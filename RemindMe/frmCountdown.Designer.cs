namespace RemindMe
{
    partial class frmCountdown
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCountdown));
            this.lblYouHave = new System.Windows.Forms.Label();
            this.btnStopTimer = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblTimerContent = new System.Windows.Forms.Label();
            this.tmrCountdown = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblYouHave
            // 
            this.lblYouHave.AutoSize = true;
            this.lblYouHave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYouHave.Location = new System.Drawing.Point(12, 17);
            this.lblYouHave.Name = "lblYouHave";
            this.lblYouHave.Size = new System.Drawing.Size(88, 20);
            this.lblYouHave.TabIndex = 0;
            this.lblYouHave.Text = "You have...";
            // 
            // btnStopTimer
            // 
            this.btnStopTimer.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnStopTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStopTimer.Location = new System.Drawing.Point(305, 9);
            this.btnStopTimer.Name = "btnStopTimer";
            this.btnStopTimer.Size = new System.Drawing.Size(172, 37);
            this.btnStopTimer.TabIndex = 1;
            this.btnStopTimer.Text = "Stop Countdown";
            this.btnStopTimer.UseVisualStyleBackColor = true;
            this.btnStopTimer.Click += new System.EventHandler(this.btnStopTimer_Click);
            // 
            // lblTime
            // 
            this.lblTime.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(114, 60);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(276, 55);
            this.lblTime.TabIndex = 2;
            this.lblTime.Text = "00 : 00 : 00";
            // 
            // lblTimerContent
            // 
            this.lblTimerContent.AutoSize = true;
            this.lblTimerContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimerContent.Location = new System.Drawing.Point(12, 124);
            this.lblTimerContent.Name = "lblTimerContent";
            this.lblTimerContent.Size = new System.Drawing.Size(188, 20);
            this.lblTimerContent.TabIndex = 0;
            this.lblTimerContent.Text = "until [ Reminder Content ]";
            // 
            // tmrCountdown
            // 
            this.tmrCountdown.Enabled = true;
            this.tmrCountdown.Interval = 1000;
            this.tmrCountdown.Tick += new System.EventHandler(this.tmrCountdown_Tick);
            // 
            // frmCountdown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.CancelButton = this.btnStopTimer;
            this.ClientSize = new System.Drawing.Size(489, 167);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.btnStopTimer);
            this.Controls.Add(this.lblTimerContent);
            this.Controls.Add(this.lblYouHave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmCountdown";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Countdown - RemindMe";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCountdown_FormClosing);
            this.Load += new System.EventHandler(this.frmCountdown_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblYouHave;
        private System.Windows.Forms.Button btnStopTimer;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblTimerContent;
        private System.Windows.Forms.Timer tmrCountdown;
    }
}