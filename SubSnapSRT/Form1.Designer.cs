namespace SubSnapSRT
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.grpSubtitleInput = new System.Windows.Forms.GroupBox();
            this.btnSubOutput = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.lblOutputSelect = new System.Windows.Forms.Label();
            this.btnSubInput = new System.Windows.Forms.Button();
            this.txtSubInput = new System.Windows.Forms.TextBox();
            this.lblSubSelect = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grpSnapInput = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAdvanced = new System.Windows.Forms.Label();
            this.txtSkipSubs = new System.Windows.Forms.TextBox();
            this.btnSCIInput = new System.Windows.Forms.Button();
            this.txtTimeInput = new System.Windows.Forms.TextBox();
            this.lblTimeSelect = new System.Windows.Forms.Label();
            this.lblSCI = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.grpSettings = new System.Windows.Forms.GroupBox();
            this.rdoSCF = new System.Windows.Forms.RadioButton();
            this.rdoSCI = new System.Windows.Forms.RadioButton();
            this.lblTimeFPS = new System.Windows.Forms.Label();
            this.lblFPSBox = new System.Windows.Forms.Label();
            this.nmrFPS = new System.Windows.Forms.NumericUpDown();
            this.chkGreenZone = new System.Windows.Forms.CheckBox();
            this.chkRedZone = new System.Windows.Forms.CheckBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.btnClearLog = new System.Windows.Forms.Button();
            this.lblLog = new System.Windows.Forms.Label();
            this.lblMIT = new System.Windows.Forms.Label();
            this.grpSubtitleInput.SuspendLayout();
            this.grpSnapInput.SuspendLayout();
            this.grpSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrFPS)).BeginInit();
            this.SuspendLayout();
            // 
            // grpSubtitleInput
            // 
            this.grpSubtitleInput.Controls.Add(this.btnSubOutput);
            this.grpSubtitleInput.Controls.Add(this.txtOutput);
            this.grpSubtitleInput.Controls.Add(this.lblOutputSelect);
            this.grpSubtitleInput.Controls.Add(this.btnSubInput);
            this.grpSubtitleInput.Controls.Add(this.txtSubInput);
            this.grpSubtitleInput.Controls.Add(this.lblSubSelect);
            this.grpSubtitleInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSubtitleInput.Location = new System.Drawing.Point(19, 17);
            this.grpSubtitleInput.Name = "grpSubtitleInput";
            this.grpSubtitleInput.Size = new System.Drawing.Size(759, 105);
            this.grpSubtitleInput.TabIndex = 0;
            this.grpSubtitleInput.TabStop = false;
            this.grpSubtitleInput.Text = "Subtitles";
            // 
            // btnSubOutput
            // 
            this.btnSubOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubOutput.Location = new System.Drawing.Point(648, 69);
            this.btnSubOutput.Name = "btnSubOutput";
            this.btnSubOutput.Size = new System.Drawing.Size(94, 24);
            this.btnSubOutput.TabIndex = 5;
            this.btnSubOutput.Text = "Browse...";
            this.btnSubOutput.UseVisualStyleBackColor = true;
            this.btnSubOutput.Click += new System.EventHandler(this.btnSubOutput_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutput.Location = new System.Drawing.Point(11, 72);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(631, 20);
            this.txtOutput.TabIndex = 4;
            // 
            // lblOutputSelect
            // 
            this.lblOutputSelect.AutoSize = true;
            this.lblOutputSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutputSelect.Location = new System.Drawing.Point(10, 56);
            this.lblOutputSelect.Name = "lblOutputSelect";
            this.lblOutputSelect.Size = new System.Drawing.Size(101, 13);
            this.lblOutputSelect.TabIndex = 3;
            this.lblOutputSelect.Text = "Select an output file";
            // 
            // btnSubInput
            // 
            this.btnSubInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubInput.Location = new System.Drawing.Point(648, 30);
            this.btnSubInput.Name = "btnSubInput";
            this.btnSubInput.Size = new System.Drawing.Size(94, 24);
            this.btnSubInput.TabIndex = 2;
            this.btnSubInput.Text = "Browse...";
            this.btnSubInput.UseVisualStyleBackColor = true;
            this.btnSubInput.Click += new System.EventHandler(this.btnSubInput_Click);
            // 
            // txtSubInput
            // 
            this.txtSubInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubInput.Location = new System.Drawing.Point(11, 33);
            this.txtSubInput.Name = "txtSubInput";
            this.txtSubInput.Size = new System.Drawing.Size(631, 20);
            this.txtSubInput.TabIndex = 1;
            // 
            // lblSubSelect
            // 
            this.lblSubSelect.AutoSize = true;
            this.lblSubSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubSelect.Location = new System.Drawing.Point(8, 17);
            this.lblSubSelect.Name = "lblSubSelect";
            this.lblSubSelect.Size = new System.Drawing.Size(158, 13);
            this.lblSubSelect.TabIndex = 0;
            this.lblSubSelect.Text = "Please select a subtitle file (*.srt)";
            // 
            // grpSnapInput
            // 
            this.grpSnapInput.Controls.Add(this.label1);
            this.grpSnapInput.Controls.Add(this.lblAdvanced);
            this.grpSnapInput.Controls.Add(this.txtSkipSubs);
            this.grpSnapInput.Controls.Add(this.btnSCIInput);
            this.grpSnapInput.Controls.Add(this.txtTimeInput);
            this.grpSnapInput.Controls.Add(this.lblTimeSelect);
            this.grpSnapInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSnapInput.Location = new System.Drawing.Point(19, 128);
            this.grpSnapInput.Name = "grpSnapInput";
            this.grpSnapInput.Size = new System.Drawing.Size(759, 105);
            this.grpSnapInput.TabIndex = 1;
            this.grpSnapInput.TabStop = false;
            this.grpSnapInput.Text = "Timings Input";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "skip following subtitles (comma-seperated):";
            // 
            // lblAdvanced
            // 
            this.lblAdvanced.AutoSize = true;
            this.lblAdvanced.Location = new System.Drawing.Point(11, 69);
            this.lblAdvanced.Name = "lblAdvanced";
            this.lblAdvanced.Size = new System.Drawing.Size(68, 13);
            this.lblAdvanced.TabIndex = 5;
            this.lblAdvanced.Text = "Advanced:";
            // 
            // txtSkipSubs
            // 
            this.txtSkipSubs.Location = new System.Drawing.Point(289, 66);
            this.txtSkipSubs.Name = "txtSkipSubs";
            this.txtSkipSubs.Size = new System.Drawing.Size(453, 20);
            this.txtSkipSubs.TabIndex = 4;
            // 
            // btnSCIInput
            // 
            this.btnSCIInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSCIInput.Location = new System.Drawing.Point(648, 30);
            this.btnSCIInput.Name = "btnSCIInput";
            this.btnSCIInput.Size = new System.Drawing.Size(94, 23);
            this.btnSCIInput.TabIndex = 3;
            this.btnSCIInput.Text = "Browse...";
            this.btnSCIInput.UseVisualStyleBackColor = true;
            this.btnSCIInput.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtTimeInput
            // 
            this.txtTimeInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimeInput.Location = new System.Drawing.Point(11, 32);
            this.txtTimeInput.Name = "txtTimeInput";
            this.txtTimeInput.Size = new System.Drawing.Size(631, 20);
            this.txtTimeInput.TabIndex = 1;
            // 
            // lblTimeSelect
            // 
            this.lblTimeSelect.AutoSize = true;
            this.lblTimeSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeSelect.Location = new System.Drawing.Point(8, 16);
            this.lblTimeSelect.Name = "lblTimeSelect";
            this.lblTimeSelect.Size = new System.Drawing.Size(187, 13);
            this.lblTimeSelect.TabIndex = 0;
            this.lblTimeSelect.Text = "Please select a timing file (*.sci or *.txt)";
            // 
            // lblSCI
            // 
            this.lblSCI.AutoSize = true;
            this.lblSCI.Location = new System.Drawing.Point(16, 350);
            this.lblSCI.Name = "lblSCI";
            this.lblSCI.Size = new System.Drawing.Size(785, 13);
            this.lblSCI.TabIndex = 3;
            this.lblSCI.Text = "This program is designed to work together with Shot Change Indexer (https://www.g" +
    "ithub.com/Nexz/sci) or SpotCut by Spot Software (https://www.spotsoftware.nl/)";
            // 
            // grpSettings
            // 
            this.grpSettings.Controls.Add(this.rdoSCF);
            this.grpSettings.Controls.Add(this.rdoSCI);
            this.grpSettings.Controls.Add(this.lblTimeFPS);
            this.grpSettings.Controls.Add(this.lblFPSBox);
            this.grpSettings.Controls.Add(this.nmrFPS);
            this.grpSettings.Controls.Add(this.chkGreenZone);
            this.grpSettings.Controls.Add(this.chkRedZone);
            this.grpSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSettings.Location = new System.Drawing.Point(19, 239);
            this.grpSettings.Name = "grpSettings";
            this.grpSettings.Size = new System.Drawing.Size(532, 100);
            this.grpSettings.TabIndex = 4;
            this.grpSettings.TabStop = false;
            this.grpSettings.Text = "Settings";
            // 
            // rdoSCF
            // 
            this.rdoSCF.AutoSize = true;
            this.rdoSCF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoSCF.Location = new System.Drawing.Point(298, 65);
            this.rdoSCF.Name = "rdoSCF";
            this.rdoSCF.Size = new System.Drawing.Size(155, 17);
            this.rdoSCF.TabIndex = 6;
            this.rdoSCF.TabStop = true;
            this.rdoSCF.Text = "Prefer SpotCut files as input";
            this.rdoSCF.UseVisualStyleBackColor = true;
            this.rdoSCF.CheckedChanged += new System.EventHandler(this.rdoSCF_CheckedChanged);
            // 
            // rdoSCI
            // 
            this.rdoSCI.AutoSize = true;
            this.rdoSCI.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoSCI.Location = new System.Drawing.Point(14, 65);
            this.rdoSCI.Name = "rdoSCI";
            this.rdoSCI.Size = new System.Drawing.Size(211, 17);
            this.rdoSCI.TabIndex = 5;
            this.rdoSCI.TabStop = true;
            this.rdoSCI.Text = "Prefer ShotChangeIndexer files as input";
            this.rdoSCI.UseVisualStyleBackColor = true;
            this.rdoSCI.CheckedChanged += new System.EventHandler(this.rdoSCI_CheckedChanged);
            // 
            // lblTimeFPS
            // 
            this.lblTimeFPS.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.lblTimeFPS.AutoSize = true;
            this.lblTimeFPS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeFPS.Location = new System.Drawing.Point(295, 44);
            this.lblTimeFPS.Name = "lblTimeFPS";
            this.lblTimeFPS.Size = new System.Drawing.Size(173, 13);
            this.lblTimeFPS.TabIndex = 4;
            this.lblTimeFPS.Text = "One frame will take 0.042 seconds ";
            // 
            // lblFPSBox
            // 
            this.lblFPSBox.AutoSize = true;
            this.lblFPSBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFPSBox.Location = new System.Drawing.Point(295, 20);
            this.lblFPSBox.Name = "lblFPSBox";
            this.lblFPSBox.Size = new System.Drawing.Size(27, 13);
            this.lblFPSBox.TabIndex = 3;
            this.lblFPSBox.Text = "FPS";
            // 
            // nmrFPS
            // 
            this.nmrFPS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmrFPS.Location = new System.Drawing.Point(328, 19);
            this.nmrFPS.Name = "nmrFPS";
            this.nmrFPS.Size = new System.Drawing.Size(120, 20);
            this.nmrFPS.TabIndex = 2;
            this.nmrFPS.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.nmrFPS.ValueChanged += new System.EventHandler(this.nmrFPS_ValueChanged);
            // 
            // chkGreenZone
            // 
            this.chkGreenZone.AutoSize = true;
            this.chkGreenZone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkGreenZone.Location = new System.Drawing.Point(13, 42);
            this.chkGreenZone.Name = "chkGreenZone";
            this.chkGreenZone.Size = new System.Drawing.Size(131, 17);
            this.chkGreenZone.TabIndex = 1;
            this.chkGreenZone.Text = "Green zone correction";
            this.chkGreenZone.UseVisualStyleBackColor = true;
            this.chkGreenZone.CheckedChanged += new System.EventHandler(this.chkGreenZone_CheckedChanged);
            // 
            // chkRedZone
            // 
            this.chkRedZone.AutoSize = true;
            this.chkRedZone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRedZone.Location = new System.Drawing.Point(13, 19);
            this.chkRedZone.Name = "chkRedZone";
            this.chkRedZone.Size = new System.Drawing.Size(122, 17);
            this.chkRedZone.TabIndex = 0;
            this.chkRedZone.Text = "Red zone correction";
            this.chkRedZone.UseVisualStyleBackColor = true;
            this.chkRedZone.CheckedChanged += new System.EventHandler(this.chkRedZone_CheckedChanged);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(566, 246);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(212, 93);
            this.btnStart.TabIndex = 7;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(794, 34);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(407, 305);
            this.txtLog.TabIndex = 8;
            // 
            // btnClearLog
            // 
            this.btnClearLog.Location = new System.Drawing.Point(1099, 345);
            this.btnClearLog.Name = "btnClearLog";
            this.btnClearLog.Size = new System.Drawing.Size(102, 23);
            this.btnClearLog.TabIndex = 9;
            this.btnClearLog.Text = "Clear Log";
            this.btnClearLog.UseVisualStyleBackColor = true;
            this.btnClearLog.Click += new System.EventHandler(this.btnClearLog_Click);
            // 
            // lblLog
            // 
            this.lblLog.AutoSize = true;
            this.lblLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLog.Location = new System.Drawing.Point(791, 17);
            this.lblLog.Name = "lblLog";
            this.lblLog.Size = new System.Drawing.Size(28, 13);
            this.lblLog.TabIndex = 10;
            this.lblLog.Text = "Log";
            // 
            // lblMIT
            // 
            this.lblMIT.AutoSize = true;
            this.lblMIT.Location = new System.Drawing.Point(17, 368);
            this.lblMIT.Name = "lblMIT";
            this.lblMIT.Size = new System.Drawing.Size(499, 13);
            this.lblMIT.TabIndex = 11;
            this.lblMIT.Text = "Licensed under the MIT license - get the latest release from Github: https://gith" +
    "ub.com/Nexz/subsnapsrt";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 391);
            this.Controls.Add(this.lblMIT);
            this.Controls.Add(this.lblLog);
            this.Controls.Add(this.btnClearLog);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.grpSettings);
            this.Controls.Add(this.lblSCI);
            this.Controls.Add(this.grpSnapInput);
            this.Controls.Add(this.grpSubtitleInput);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "SubSnapSRT";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.grpSubtitleInput.ResumeLayout(false);
            this.grpSubtitleInput.PerformLayout();
            this.grpSnapInput.ResumeLayout(false);
            this.grpSnapInput.PerformLayout();
            this.grpSettings.ResumeLayout(false);
            this.grpSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrFPS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSubtitleInput;
        private System.Windows.Forms.Button btnSubInput;
        private System.Windows.Forms.TextBox txtSubInput;
        private System.Windows.Forms.Label lblSubSelect;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox grpSnapInput;
        private System.Windows.Forms.Button btnSCIInput;
        private System.Windows.Forms.TextBox txtTimeInput;
        private System.Windows.Forms.Label lblTimeSelect;
        private System.Windows.Forms.Label lblSCI;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnSubOutput;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Label lblOutputSelect;
        private System.Windows.Forms.GroupBox grpSettings;
        private System.Windows.Forms.Label lblTimeFPS;
        private System.Windows.Forms.Label lblFPSBox;
        private System.Windows.Forms.NumericUpDown nmrFPS;
        private System.Windows.Forms.CheckBox chkGreenZone;
        private System.Windows.Forms.CheckBox chkRedZone;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Button btnClearLog;
        private System.Windows.Forms.Label lblLog;
        private System.Windows.Forms.RadioButton rdoSCF;
        private System.Windows.Forms.RadioButton rdoSCI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAdvanced;
        private System.Windows.Forms.TextBox txtSkipSubs;
        private System.Windows.Forms.Label lblMIT;
    }
}

