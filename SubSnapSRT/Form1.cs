using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SubSnapSRT
{
    public partial class frmMain : Form
    {

        private List<Dictionary<string, string>> loadedSubtitle;
        private List<double> loadedTimings;
        private int subCounter = 0;
        private int adjustmentsMade = 0;
        private double timePerFrame = 0;

        public frmMain()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            chkGreenZone.Checked = Properties.Settings.Default.greenzoneEnable;
            chkRedZone.Checked = Properties.Settings.Default.redzoneEnable;
            nmrFPS.Value = Properties.Settings.Default.defaultFPS;
            timePerFrame = getTimePerFrame((double)nmrFPS.Value);
            if (Properties.Settings.Default.spotCutPrioritize == true)
            {
                rdoSCF.Checked = true;
                rdoSCI.Checked = false;
            } else
            {
                rdoSCF.Checked = false;
                rdoSCI.Checked = true;
            }
        }

        private void btnSubInput_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialogSubtitle = new OpenFileDialog();
            dialogSubtitle.Filter = "Subtitle File|*.srt";
            DialogResult subInputResult = dialogSubtitle.ShowDialog();
            if (subInputResult == DialogResult.OK)
            {
                txtSubInput.Text = dialogSubtitle.FileName;
                txtOutput.Text = dialogSubtitle.FileName.Replace(".srt", "-snapped.srt");
            }
            else
            {
                MessageBox.Show("Please select a valid SRT file.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialogSCI = new OpenFileDialog();
            if (Properties.Settings.Default.spotCutPrioritize == true)
            {
                dialogSCI.Filter = "SpotCut output|*.txt|ShotChangeIndexer File|*.sci";
            } else
            {
                dialogSCI.Filter = "ShotChangeIndexer File|*.sci|SpotCut output|*.txt";
            }
            
            DialogResult sciInputResult = dialogSCI.ShowDialog();
            if (sciInputResult == DialogResult.OK)
            {
                txtTimeInput.Text = dialogSCI.FileName;
            }
            else
            {
                MessageBox.Show("Please select a valid SCI or SpotCut file.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private double getTimePerFrame(double numFrames)
        {
            double timeCalculate = ((double)1 / numFrames);
            return timeCalculate = Math.Round(timeCalculate, 3);
        }

        private void nmrFPS_ValueChanged(object sender, EventArgs e)
        {
            double timeCalculate = getTimePerFrame((double)nmrFPS.Value);
            timePerFrame = timeCalculate;
            lblTimeFPS.Text = "One frame will take " + timeCalculate.ToString() + " seconds.";
            Properties.Settings.Default.defaultFPS = nmrFPS.Value;
            Properties.Settings.Default.Save();
        }

        private void generateSRTFile()
        {

            string srtFileBuffer = "";
            string lineSeparator = Environment.NewLine;
            TimeSpan timeConverter;

            foreach (Dictionary<string,string> currentSub in loadedSubtitle)
            {

                timeConverter = TimeSpan.FromSeconds(double.Parse(currentSub["Start"]));
                string convertedTimeStart = timeConverter.ToString(@"hh\:mm\:ss\,fff");
                timeConverter = TimeSpan.FromSeconds(double.Parse(currentSub["Stop"]));
                string convertedTimeStop = timeConverter.ToString(@"hh\:mm\:ss\,fff");

                string timeString = convertedTimeStart + " --> " + convertedTimeStop;

                srtFileBuffer += currentSub["LineID"] + lineSeparator;
                srtFileBuffer += timeString + lineSeparator;
                srtFileBuffer += currentSub["Line1"] + lineSeparator;
                if (currentSub.ContainsKey("Line2"))
                {
                    srtFileBuffer += currentSub["Line2"] + lineSeparator;
                }
                srtFileBuffer += lineSeparator;

            }

            // write to file!
            System.IO.File.WriteAllText(txtOutput.Text, srtFileBuffer);
        }

        private bool loadSRTBlock(List<string> srtBlock)
        {
            for (int lineNr = 0; lineNr < srtBlock.Count; lineNr++)
            {
                switch (lineNr)
                {
                    case 0:
                        loadedSubtitle.Add(new Dictionary<string, string>());
                        loadedSubtitle[subCounter]["LineID"] = srtBlock[0];
                        break;
                    case 1:
                        string[] srtTimes = srtBlock[1].Split(new[] { " --> " }, StringSplitOptions.None);
                        loadedSubtitle[subCounter]["srtStart"] = srtTimes[0];
                        loadedSubtitle[subCounter]["srtStop"] = srtTimes[1];
                        loadedSubtitle[subCounter]["Start"] = TimeSpan.Parse(srtTimes[0]).TotalSeconds.ToString();
                        loadedSubtitle[subCounter]["Stop"] = TimeSpan.Parse(srtTimes[1]).TotalSeconds.ToString();
                        break;
                    case 2:
                        loadedSubtitle[subCounter]["Line1"] = srtBlock[2];
                        break;
                    case 3:
                        loadedSubtitle[subCounter]["Line2"] = srtBlock[3];
                        break;
                    default:
                        MessageBox.Show("Invalid SRT file, stopping processing.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                        
                }
            }
            /*
            txtDebug.AppendText("Subnummer ");
            txtDebug.AppendText(loadedSubtitle[subCounter]["LineID"] + "\n");
            txtDebug.AppendText("Van " + loadedSubtitle[subCounter]["Start"] + " tot " + loadedSubtitle[subCounter]["Stop"] + "\n");
            txtDebug.AppendText("Regel 1: " + loadedSubtitle[subCounter]["Line1"] + "\n");
            
            if (loadedSubtitle[subCounter].ContainsKey("Line2"))
            {

                txtDebug.AppendText("Regel 2: " + loadedSubtitle[subCounter]["Line2"] + "\n");

            }
            */

            subCounter++;
            return true;

        }

        private bool executeSnap()
        {
            List<string> skipSubs = new List<string>();
            
            double frameTimeGreen = Properties.Settings.Default.greenZoneWidth * timePerFrame;
            double frameTimeRed = Properties.Settings.Default.redZoneWidth * timePerFrame;
            double frameTimeStop = Properties.Settings.Default.stopBeforeShot * timePerFrame;

            string skipSubText = txtSkipSubs.Text.Replace(';', ',');
            foreach (string skipSubID in skipSubText.Split(','))
            {
                skipSubs.Add(skipSubID);
            }
            
            foreach (Dictionary<string,string> seekSub in loadedSubtitle)
            {
                foreach (double snapTime in loadedTimings)
                {
                    // This is actually not as effecient as it can be... But what the heck. It's simple addition and subtraction.
                    // Don't use on a Pentium III!
                    double currentTimingStartWidthGreen = snapTime - frameTimeGreen;
                    double currentTimingStartWidthRed = snapTime - frameTimeRed;

                    double currentTimingStopWidthGreen = snapTime + frameTimeGreen;
                    double currentTimingStopWidthRed = snapTime + frameTimeRed;

                    double currentSubStart = double.Parse(seekSub["Start"]);
                    double currentSubStop = double.Parse(seekSub["Stop"]);

                    if (skipSubs.Contains(seekSub["LineID"])) {
                        continue;
                    }

                    if (chkGreenZone.Checked == true)
                    {
                        // Dialogue starts between 8-11 frames (green zone start adjustment)
                        if (currentSubStart > currentTimingStartWidthGreen && currentSubStart < currentTimingStartWidthRed)
                        {
                            seekSub["Start"] = currentTimingStartWidthGreen.ToString(); // 12 frames before
                            txtLog.AppendText("Adjusting sub " + seekSub["LineID"] + " (Green Zone Start)\n");
                            adjustmentsMade++;
                        }
                    }

                    if (chkRedZone.Checked == true)
                    {
                        // Dialogue starts between 7-0 frames (red zone start adjustment)
                        if (currentSubStart >= currentTimingStartWidthRed && currentSubStart < snapTime)
                        {
                            seekSub["Start"] = snapTime.ToString(); // On shot change
                            txtLog.AppendText("Adjusting sub " + seekSub["LineID"] + " (Red Zone Start)\n");
                            adjustmentsMade++;
                        }

                        // Dialogue stops between 0-7 frames (red zone stop adjustment)
                        if (currentSubStop > snapTime && currentSubStop <= currentTimingStopWidthRed)
                        {
                            double stopCorrectedTime = snapTime - frameTimeStop;
                            seekSub["Stop"] = stopCorrectedTime.ToString(); // 2 frames before
                            txtLog.AppendText("Adjusting sub " + seekSub["LineID"] + " (Red Zone Stop)\n");
                            adjustmentsMade++;
                        }
                    }

                    if (chkGreenZone.Checked == true)
                    {
                        // Dialogue stops between 7-12 frames (green zone stop adjustment)
                        if (currentSubStop > currentTimingStopWidthRed && currentSubStop < currentTimingStopWidthGreen)
                        {
                            seekSub["Stop"] = currentTimingStopWidthGreen.ToString(); // 12 frames after
                            txtLog.AppendText("Adjusting sub " + seekSub["LineID"] + " (Green Zone Stop)\n");
                            adjustmentsMade++;
                        }
                    }
                    
                }

            }

            return true;

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            txtLog.AppendText("------------------------------------------------------------\n");
            txtLog.AppendText("Starting new transformation on "+ DateTime.Now.ToString("h:mm:ss")+ "\n");
                        // Check if everything is ready to go
            bool subCheck = System.IO.File.Exists(txtSubInput.Text);
            bool timeCheck = System.IO.File.Exists(txtTimeInput.Text);
            bool outputCheck = System.IO.File.Exists(txtOutput.Text);

            if (subCheck == false)
            {
                MessageBox.Show("Please make sure the subtitle file exists.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (timeCheck == false)
            {
                MessageBox.Show("Please make sure the timing file exists.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (outputCheck == true)
            {
                DialogResult overwriteResult = MessageBox.Show("The selected output file already exists. Overwrite?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (overwriteResult == DialogResult.No)
                {
                    txtLog.AppendText("File exists and no permission to overwrite. Stopping.\n");
                    MessageBox.Show("Execution stopped.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            if (chkGreenZone.Checked == true)
            {
                txtLog.AppendText("Green Zone adjustments are ON\n");
            } else
            {
                txtLog.AppendText("Green Zone adjustments are OFF\n");
            }

            if (chkRedZone.Checked == true)
            {
                txtLog.AppendText("Red Zone adjustments are ON\n");
            }
            else
            {
                txtLog.AppendText("Red Zone adjustments are OFF\n");
            }

            // Make sure we let the user know we're doing something
            UIstartProcessing();
            txtLog.AppendText("Processing "+txtSubInput.Text+"\n");

            if (loadedSubtitle != null)
            {
                loadedSubtitle.Clear();
            }
            subCounter = 0;
            adjustmentsMade = 0;

            // Load in Subtitle file
            System.IO.StreamReader openSRTFile = new System.IO.StreamReader(txtSubInput.Text);
            string srtLine;
            loadedSubtitle = new List<Dictionary<string, string>>();
            List<string> readBuffer = new List<string>();
            while((srtLine = openSRTFile.ReadLine()) != null)
            {
                if (srtLine == "")
                {
                    bool srtBlockResult = loadSRTBlock(readBuffer);
                    readBuffer.Clear();
                    if (srtBlockResult == false)
                    {
                        openSRTFile.Close();
                        UIstopProcessing();
                        return;
                    }
                }
                else
                {
                    readBuffer.Add(srtLine);
                }
            }
            openSRTFile.Close();

            readBuffer.Clear();

            txtLog.AppendText("Processing " + txtTimeInput.Text + "\n");
            // Load in timings file
            System.IO.StreamReader openSCIFile = new System.IO.StreamReader(txtTimeInput.Text);
            string sciLine;
            double checkSciLine = 0;

            loadedTimings = new List<double>();
            int sciFileType = 0;

            while ((sciLine = openSCIFile.ReadLine()) != null)
            {
                if (sciFileType == 0)
                {
                    // Determine if this a SCI file or SpotCut file
                    string[] checkTabs = sciLine.Split('\t');
                    if (checkTabs.Count() > 1)
                    {
                        sciFileType = 2; // SpotCut
                        txtLog.AppendText("Handling as SpotCut File\n");
                    } else
                    {
                        sciFileType = 1; // SCI
                        txtLog.AppendText("Handling as ShotChangeIndexer File\n");
                    }
                }
                if (sciFileType == 2)
                {
                    string[] splitTabs = sciLine.Split('\t');
                    sciLine = splitTabs[4]; // SpotCut output: <frame>tabtab<frame - 1>tabtab<time>
                }

                sciLine = sciLine.Replace(",", "."); // Always normalize
                try
                {
                    checkSciLine = double.Parse(sciLine, System.Globalization.CultureInfo.InvariantCulture);
                }
                catch (System.FormatException errorFormat)
                {
                    MessageBox.Show("This seems to be an invalid SCI or SpotCut file.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    openSCIFile.Close();
                    readBuffer.Clear();
                    UIstopProcessing();
                    return;
                }
                loadedTimings.Add(checkSciLine);
                // txtDebug.AppendText("Timing: " + checkSciLine);
            }
            openSCIFile.Close();
            readBuffer.Clear();
            
            txtLog.AppendText("Starting snap-correction\n");
            // Start!
            bool snapResult = executeSnap();
            if (snapResult == false)
            {
                MessageBox.Show("Something went wrong making adjustments.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                txtLog.AppendText("Generating SRT file:\n");

                txtLog.AppendText(txtOutput.Text + "\n");
                generateSRTFile();
                txtLog.AppendText("Done, " + adjustmentsMade.ToString() + " adjustments made.\n");
            }

            UIstopProcessing();

        }

        private void UIstartProcessing()
        {
            Cursor.Current = Cursors.WaitCursor;
            Application.UseWaitCursor = true;
            Update();
        }

        private void UIstopProcessing()
        {
            Cursor.Current = Cursors.Default;
            Application.UseWaitCursor = false;
            Update();
        }

        private void chkGreenZone_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.greenzoneEnable = chkGreenZone.Checked;
            Properties.Settings.Default.Save();
        }

        private void chkRedZone_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.redzoneEnable = chkRedZone.Checked;
            Properties.Settings.Default.Save();
        }

        private void btnSubOutput_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialogSaveSCI = new SaveFileDialog();
            dialogSaveSCI.Filter = "Subtitle File|*.srt";
            dialogSaveSCI.Title = "Save subtitle file";
            dialogSaveSCI.ShowDialog();

            if (dialogSaveSCI.FileName != "")
            {

                txtOutput.Text = dialogSaveSCI.FileName;

            }
            else
            {

                MessageBox.Show("Please select a valid save location.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private void btnClearLog_Click(object sender, EventArgs e)
        {
            txtLog.Text = "";
        }

        private void cmbSCI_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void rdoSCI_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.spotCutPrioritize = false;
            Properties.Settings.Default.Save();
        }

        private void rdoSCF_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.spotCutPrioritize = true;
            Properties.Settings.Default.Save();
        }
    }
}
