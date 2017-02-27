namespace RemindMe
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.grpTimerContent = new System.Windows.Forms.GroupBox();
            this.txtTimerContent = new System.Windows.Forms.TextBox();
            this.grpTimerType = new System.Windows.Forms.GroupBox();
            this.optDestTime = new System.Windows.Forms.RadioButton();
            this.optDuration = new System.Windows.Forms.RadioButton();
            this.grpTimerDuration = new System.Windows.Forms.GroupBox();
            this.lblMinSec = new System.Windows.Forms.Label();
            this.lblHrMin = new System.Windows.Forms.Label();
            this.cboAMPM = new System.Windows.Forms.ComboBox();
            this.txtSecond = new System.Windows.Forms.TextBox();
            this.txtMinute = new System.Windows.Forms.TextBox();
            this.txtHour = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.tmrCurrent = new System.Windows.Forms.Timer(this.components);
            this.stbStatusBar = new System.Windows.Forms.StatusStrip();
            this.strlblCurrentTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblCredit = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnReset = new System.Windows.Forms.Button();
            this.lblHour = new System.Windows.Forms.Label();
            this.lblMinute = new System.Windows.Forms.Label();
            this.lblSecond = new System.Windows.Forms.Label();
            this.grpTimerContent.SuspendLayout();
            this.grpTimerType.SuspendLayout();
            this.grpTimerDuration.SuspendLayout();
            this.stbStatusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpTimerContent
            // 
            this.grpTimerContent.Controls.Add(this.txtTimerContent);
            this.grpTimerContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTimerContent.Location = new System.Drawing.Point(12, 12);
            this.grpTimerContent.Name = "grpTimerContent";
            this.grpTimerContent.Size = new System.Drawing.Size(350, 100);
            this.grpTimerContent.TabIndex = 1;
            this.grpTimerContent.TabStop = false;
            this.grpTimerContent.Text = "1. Write the content of the reminder.";
            // 
            // txtTimerContent
            // 
            this.txtTimerContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimerContent.Location = new System.Drawing.Point(13, 37);
            this.txtTimerContent.Name = "txtTimerContent";
            this.txtTimerContent.Size = new System.Drawing.Size(320, 31);
            this.txtTimerContent.TabIndex = 1;
            this.txtTimerContent.TextChanged += new System.EventHandler(this.txtTimerContent_TextChanged);
            // 
            // grpTimerType
            // 
            this.grpTimerType.Controls.Add(this.optDestTime);
            this.grpTimerType.Controls.Add(this.optDuration);
            this.grpTimerType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTimerType.Location = new System.Drawing.Point(368, 12);
            this.grpTimerType.Name = "grpTimerType";
            this.grpTimerType.Size = new System.Drawing.Size(222, 100);
            this.grpTimerType.TabIndex = 2;
            this.grpTimerType.TabStop = false;
            this.grpTimerType.Text = "2. Choose the mode of timer.";
            // 
            // optDestTime
            // 
            this.optDestTime.AutoSize = true;
            this.optDestTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optDestTime.Location = new System.Drawing.Point(11, 55);
            this.optDestTime.Name = "optDestTime";
            this.optDestTime.Size = new System.Drawing.Size(170, 22);
            this.optDestTime.TabIndex = 2;
            this.optDestTime.TabStop = true;
            this.optDestTime.Text = "Countdown ends at ...";
            this.optDestTime.UseVisualStyleBackColor = true;
            this.optDestTime.CheckedChanged += new System.EventHandler(this.optDestTime_CheckedChanged);
            this.optDestTime.Click += new System.EventHandler(this.optDestTime_CheckedChanged);
            // 
            // optDuration
            // 
            this.optDuration.AutoSize = true;
            this.optDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optDuration.Location = new System.Drawing.Point(11, 27);
            this.optDuration.Name = "optDuration";
            this.optDuration.Size = new System.Drawing.Size(175, 22);
            this.optDuration.TabIndex = 1;
            this.optDuration.TabStop = true;
            this.optDuration.Text = "Countdown lasts for ...";
            this.optDuration.UseVisualStyleBackColor = true;
            this.optDuration.CheckedChanged += new System.EventHandler(this.optDuration_CheckedChanged);
            // 
            // grpTimerDuration
            // 
            this.grpTimerDuration.Controls.Add(this.lblSecond);
            this.grpTimerDuration.Controls.Add(this.lblMinute);
            this.grpTimerDuration.Controls.Add(this.lblHour);
            this.grpTimerDuration.Controls.Add(this.lblMinSec);
            this.grpTimerDuration.Controls.Add(this.lblHrMin);
            this.grpTimerDuration.Controls.Add(this.cboAMPM);
            this.grpTimerDuration.Controls.Add(this.txtSecond);
            this.grpTimerDuration.Controls.Add(this.txtMinute);
            this.grpTimerDuration.Controls.Add(this.txtHour);
            this.grpTimerDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTimerDuration.Location = new System.Drawing.Point(12, 118);
            this.grpTimerDuration.Name = "grpTimerDuration";
            this.grpTimerDuration.Size = new System.Drawing.Size(386, 100);
            this.grpTimerDuration.TabIndex = 3;
            this.grpTimerDuration.TabStop = false;
            this.grpTimerDuration.Text = "3. Set the time for the countdown.";
            // 
            // lblMinSec
            // 
            this.lblMinSec.AutoSize = true;
            this.lblMinSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinSec.Location = new System.Drawing.Point(170, 46);
            this.lblMinSec.Name = "lblMinSec";
            this.lblMinSec.Size = new System.Drawing.Size(24, 33);
            this.lblMinSec.TabIndex = 5;
            this.lblMinSec.Text = ":";
            // 
            // lblHrMin
            // 
            this.lblHrMin.AutoSize = true;
            this.lblHrMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHrMin.Location = new System.Drawing.Point(83, 45);
            this.lblHrMin.Name = "lblHrMin";
            this.lblHrMin.Size = new System.Drawing.Size(24, 33);
            this.lblHrMin.TabIndex = 5;
            this.lblHrMin.Text = ":";
            // 
            // cboAMPM
            // 
            this.cboAMPM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAMPM.Enabled = false;
            this.cboAMPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboAMPM.FormattingEnabled = true;
            this.cboAMPM.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.cboAMPM.Location = new System.Drawing.Point(279, 43);
            this.cboAMPM.Name = "cboAMPM";
            this.cboAMPM.Size = new System.Drawing.Size(80, 41);
            this.cboAMPM.TabIndex = 4;
            this.cboAMPM.SelectedIndexChanged += new System.EventHandler(this.cboAMPM_SelectedIndexChanged);
            // 
            // txtSecond
            // 
            this.txtSecond.Enabled = false;
            this.txtSecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecond.Location = new System.Drawing.Point(200, 43);
            this.txtSecond.MaxLength = 2;
            this.txtSecond.Name = "txtSecond";
            this.txtSecond.Size = new System.Drawing.Size(51, 40);
            this.txtSecond.TabIndex = 3;
            this.txtSecond.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSecond.Leave += new System.EventHandler(this.txtSecond_Leave);
            this.txtSecond.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtSecond_MouseDown);
            // 
            // txtMinute
            // 
            this.txtMinute.Enabled = false;
            this.txtMinute.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMinute.Location = new System.Drawing.Point(113, 43);
            this.txtMinute.MaxLength = 2;
            this.txtMinute.Name = "txtMinute";
            this.txtMinute.Size = new System.Drawing.Size(51, 40);
            this.txtMinute.TabIndex = 2;
            this.txtMinute.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMinute.Leave += new System.EventHandler(this.txtMinute_Leave);
            this.txtMinute.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtMinute_MouseDown);
            // 
            // txtHour
            // 
            this.txtHour.Enabled = false;
            this.txtHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHour.Location = new System.Drawing.Point(26, 43);
            this.txtHour.MaxLength = 2;
            this.txtHour.Name = "txtHour";
            this.txtHour.Size = new System.Drawing.Size(51, 40);
            this.txtHour.TabIndex = 1;
            this.txtHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtHour.Leave += new System.EventHandler(this.txtHour_Leave);
            this.txtHour.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtHour_MouseDown);
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(404, 126);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(186, 52);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(501, 184);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(90, 34);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // tmrCurrent
            // 
            this.tmrCurrent.Enabled = true;
            this.tmrCurrent.Interval = 1000;
            this.tmrCurrent.Tick += new System.EventHandler(this.tmrCurrent_Tick);
            // 
            // stbStatusBar
            // 
            this.stbStatusBar.BackColor = System.Drawing.SystemColors.Control;
            this.stbStatusBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.stbStatusBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.stbStatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.strlblCurrentTime,
            this.lblCredit});
            this.stbStatusBar.Location = new System.Drawing.Point(0, 229);
            this.stbStatusBar.MinimumSize = new System.Drawing.Size(592, 22);
            this.stbStatusBar.Name = "stbStatusBar";
            this.stbStatusBar.Size = new System.Drawing.Size(600, 22);
            this.stbStatusBar.SizingGrip = false;
            this.stbStatusBar.TabIndex = 7;
            // 
            // strlblCurrentTime
            // 
            this.strlblCurrentTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.strlblCurrentTime.Name = "strlblCurrentTime";
            this.strlblCurrentTime.Size = new System.Drawing.Size(114, 17);
            this.strlblCurrentTime.Text = "<current time here>";
            // 
            // lblCredit
            // 
            this.lblCredit.Margin = new System.Windows.Forms.Padding(50, 3, 0, 2);
            this.lblCredit.Name = "lblCredit";
            this.lblCredit.Size = new System.Drawing.Size(246, 17);
            this.lblCredit.Text = "Made by Yonjae Lee (yonjlee@indiana.edu)";
            this.lblCredit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnReset
            // 
            this.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(404, 184);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(90, 34);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblHour
            // 
            this.lblHour.AutoSize = true;
            this.lblHour.Location = new System.Drawing.Point(28, 23);
            this.lblHour.Name = "lblHour";
            this.lblHour.Size = new System.Drawing.Size(52, 16);
            this.lblHour.TabIndex = 6;
            this.lblHour.Text = "Hour(s)";
            // 
            // lblMinute
            // 
            this.lblMinute.AutoSize = true;
            this.lblMinute.Location = new System.Drawing.Point(110, 23);
            this.lblMinute.Name = "lblMinute";
            this.lblMinute.Size = new System.Drawing.Size(62, 16);
            this.lblMinute.TabIndex = 6;
            this.lblMinute.Text = "Minute(s)";
            // 
            // lblSecond
            // 
            this.lblSecond.AutoSize = true;
            this.lblSecond.Location = new System.Drawing.Point(197, 23);
            this.lblSecond.Name = "lblSecond";
            this.lblSecond.Size = new System.Drawing.Size(70, 16);
            this.lblSecond.TabIndex = 6;
            this.lblSecond.Text = "Second(s)";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(600, 251);
            this.Controls.Add(this.stbStatusBar);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.grpTimerType);
            this.Controls.Add(this.grpTimerDuration);
            this.Controls.Add(this.grpTimerContent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "RemindMe";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.grpTimerContent.ResumeLayout(false);
            this.grpTimerContent.PerformLayout();
            this.grpTimerType.ResumeLayout(false);
            this.grpTimerType.PerformLayout();
            this.grpTimerDuration.ResumeLayout(false);
            this.grpTimerDuration.PerformLayout();
            this.stbStatusBar.ResumeLayout(false);
            this.stbStatusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox grpTimerContent;
        private System.Windows.Forms.TextBox txtTimerContent;
        private System.Windows.Forms.GroupBox grpTimerType;
        private System.Windows.Forms.RadioButton optDestTime;
        private System.Windows.Forms.RadioButton optDuration;
        private System.Windows.Forms.GroupBox grpTimerDuration;
        private System.Windows.Forms.ComboBox cboAMPM;
        private System.Windows.Forms.TextBox txtSecond;
        private System.Windows.Forms.TextBox txtMinute;
        private System.Windows.Forms.TextBox txtHour;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblMinSec;
        private System.Windows.Forms.Label lblHrMin;
        private System.Windows.Forms.Timer tmrCurrent;
        private System.Windows.Forms.StatusStrip stbStatusBar;
        private System.Windows.Forms.ToolStripStatusLabel strlblCurrentTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripStatusLabel lblCredit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblSecond;
        private System.Windows.Forms.Label lblMinute;
        private System.Windows.Forms.Label lblHour;
    }
}

