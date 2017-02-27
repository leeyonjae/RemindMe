/* RemindMe timed reminder generator
 * frmCountdown.cs - Part of A590 final project / RemindMe timed reminder generator
 * Created by: Yonjae Lee
 * Created on: 12/07/2016
 * Modified by: Yonjae Lee
 * Modified on: 12/09/2016 
 * 
 * This is the countdown form.
 * 
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RemindMe
{
    public partial class frmCountdown : Form
    {
        /* Variables */
        int timerlength;
        string reminder;
        int h, m, s; // Countdown display variables
        string strH, strM, strS;

        public frmCountdown(int countdownLength, string timerContent)
        {
            InitializeComponent();

            // Set the local variables with the values passed from the main form
            timerlength = countdownLength;
            reminder = timerContent;
        }

        private void frmCountdown_Load(object sender, EventArgs e)
        {
            lblTimerContent.Text = "Reminder: " + reminder; // Display content of the reminder
            timerUpdate(); // Update the screen for the first time to display remaining time
        }

        private void btnStopTimer_Click(object sender, EventArgs e)
        {
            // Stop countdown by attempting to close the form; closing ends countdown
            Close();
        }


        private void frmCountdown_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (timerlength != 0)
            { // when countdown is not over
                /* Ask if the user really wants to stop the countdown */
                if (MessageBox.Show("Do you want to stop the countdown?", "Stop Countdown", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                { // Notify that the countdown is stopped
                    MessageBox.Show("Countdown has been stopped.", "Stop Countdown", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private void timerUpdate()
        { /* Update the display as the timer runs */
            
            // Every 3600 seconds = 1 hour
            h = timerlength / 3600;
            if (h < 10)
            { // Keep the double-digit format
                strH = "0" + h.ToString();
            }
            else
            {
                strH = h.ToString();
            }

            // Minutes are calculated from the remainder of hour calculation
            // Every 60 second = 1 minute
            m = (timerlength % 3600) / 60;
            if (m < 10)
            { // Keep the double-digit format
                strM = "0" + m.ToString();
            }
            else
            { 
                strM = m.ToString();
            }

            // Seconds are the remainder of minute calculation
            s = (timerlength % 3600) % 60;
            if (s < 10)
            { // Keep the double-digit format
                strS = "0" + s.ToString();
            }
            else
            {
                strS = s.ToString();
            }


            // Display the remaining time in HH:MM:SS format
            lblTime.Text = strH + " : " + strM + " : " + strS;
        }

        private void tmrCountdown_Tick(object sender, EventArgs e)
        { /* This timer ticks in every second ( = 1000 milliseconds ) */

            /* Count down until remaining time reaches zero */
            timerlength--;
            timerUpdate(); // Update countdown


            /* Timer stops when the countdown is over */
            if (timerlength == 0)
            {
                // Stop the timer
                tmrCountdown.Stop();
                // Let the user know the time is up
                MessageBox.Show("Time is up! Here's your reminder: " + reminder + ".", "Countdown - RemindMe", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
                Close(); // Close the form
            }
        }
    }
}
