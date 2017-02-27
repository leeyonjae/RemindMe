/* RemindMe timed reminder generator
 * frmMain.cs - Part of A590 final project / RemindMe timed reminder generator
 * Created by: Yonjae Lee
 * Created on: 11/28/2016
 * Modified by: Yonjae Lee
 * Modified on: 12/09/2016
 * 
 * This is the main form of this application. This accepts user inputs for
 * the content of the reminder, the mode of the countdown timer, and the
 * length of the countdown or the endtime of the countdown.
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
    public partial class frmMain : Form
    {
        string strTimerContent = "";
        int timerMode = -1;
        int timerHour = 0;
        int timerMin = 0;
        int timerSec = 0;
        int timerHourAdjusted = 0; // This is for adjusting timerHour value according to AM/PM value

        string strHour = "00";
        string strMin = "00";
        string strSec = "00";
        int indexAMPM = -1; // Will be changed to 0 ("AM") or 1 ("PM") if second mode is chosen
        string strTest = "";

        bool isNum = false;

        DateTime current = DateTime.Now;

        public frmMain()
        {
            InitializeComponent();
        }
        
        private void frmMain_Load(object sender, EventArgs e)
        {
            /* Initialize Minutes, Hours, and Seconds textboxes*/
            txtHour.Text = "00";
            txtMinute.Text = "00";
            txtSecond.Text = "00";

            // Display current time at the bottom of application
            strlblCurrentTime.Text = "Current time: " + current.ToString();
            
        }
        
        private void txtTimerContent_TextChanged(object sender, EventArgs e)
        {
            // Store the reminder content in a string variable
            strTimerContent = txtTimerContent.Text;
        }
        
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            /* Ask if the user really wants to close the application */
            if (MessageBox.Show("Do you want to close RemindMe?", "Close RemindMe", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void optDuration_CheckedChanged(object sender, EventArgs e)
        {
            
            if (optDuration.Checked == true)
            {
                /* Enable controls */
                txtHour.Enabled = true;
                txtMinute.Enabled = true;
                txtSecond.Enabled = true;

                /* Set timerMode to 1 */
                timerMode = 1;

                /* Bolden the text */
                optDuration.Font = new Font(optDuration.Font.Name, optDuration.Font.Size, FontStyle.Bold);
                optDestTime.Font = new Font(optDestTime.Font.Name, optDestTime.Font.Size, FontStyle.Regular);
                

                /* Disable AM/PM combo box if this option is selected */
                cboAMPM.Enabled = false;
                cboAMPM.Text = "";

                /* Reset the timer length and corresponding text boxes */
                timerHour = 0;
                txtHour.Text = "00";
                strHour = "00";

                timerMin = 0;
                txtMinute.Text = "00";
                strMin = "00";

                timerSec = 0;
                txtSecond.Text = "00";
                strMin = "00";

            }
            else
            {
                optDuration.Font = new Font(optDuration.Font.Name, optDuration.Font.Size, FontStyle.Regular);
            }
        }

        private void optDestTime_CheckedChanged(object sender, EventArgs e)
        {
            
            if (optDestTime.Checked == true)
            {
                /* Enable controls */
                txtHour.Enabled = true;
                txtMinute.Enabled = true;
                txtSecond.Enabled = true;
                cboAMPM.Enabled = true;

                /* Set timerMode to 2 */
                timerMode = 2;

                /* Bolden the text */
                optDestTime.Font = new Font(optDestTime.Font.Name, optDestTime.Font.Size, FontStyle.Bold);
                optDuration.Font = new Font(optDuration.Font.Name, optDuration.Font.Size, FontStyle.Regular);

                /* Fill out the hour, minute, second, AM/PM information with current time + 20 minutes */
                enterCurrentTime();
                
            }
            else
            {
                optDestTime.Font = new Font(optDestTime.Font.Name, optDestTime.Font.Size, FontStyle.Regular);
            }
        }

        private void enterCurrentTime()
        {
            /* Calculate current time, add 20 minutes, and enter it into the time textboxes and AM/PM combo 
             * boxes. Also, save the result as integer variables */

            DateTime d = DateTime.Now;
            d = d.AddMinutes(20); // 20 extra minutes given for convenience of user

            /* Store time information in int. 
             * We give five extra minutes in default. It would be weird if the timer is 
             * set to end before the current time.
             */



            /* Convert hours from 24-hour system to 12-hour system with AM/PM information */
            if (d.Hour < 12)
            {
                if (d.Hour == 0)
                {
                    timerHour = 12;
                }
                else
                {
                    timerHour = d.Hour;
                }
                
                cboAMPM.SelectedIndex = cboAMPM.FindStringExact("AM");
                
            }
            else if (d.Hour > 12)
            {
                timerHour = d.Hour - 12;
                cboAMPM.SelectedIndex = cboAMPM.FindStringExact("PM");

            }
            else
            {
                timerHour = d.Hour;
                cboAMPM.SelectedIndex = cboAMPM.FindStringExact("PM");
            }
            indexAMPM = cboAMPM.SelectedIndex;

            /* Minutes, Seconds are entered */
            timerMin = d.Minute;
            timerSec = d.Second;

            /* Hours, Minutes, Seconds displayed */
            txtHour.Text = timerHour.ToString();
            txtMinute.Text = timerMin.ToString();
            txtSecond.Text = timerSec.ToString();

            // Keep textbox double-digit
            twoDigits();
        }

        private void txtHour_MouseDown(object sender, MouseEventArgs e)
        {
            // Select all text in the textbox so the user do not have to manually press backspaces
            txtHour.SelectAll();
        }

        private void txtHour_Leave(object sender, EventArgs e)
        {
            /* Convert the input to string */
            strHour = txtHour.Text.ToString();
            strTest = strHour;
            /* Make sure the input is a number */

            isNum = int.TryParse(strHour, out timerHour);

            if (!isNum)
            {
                // Show error message if input is not a number
                MessageBox.Show("The hours should be a whole number.", "Wrong Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHour.Text = "00";
                strHour = "00";
                txtHour.SelectAll();
            }
            else
            {
                timerHour = int.Parse(strHour);
                /* Make sure the input number is valid 
                 * if mode is 'ends at...' it should be within 1 - 12
                 * if mode is 'lasts for...' it should be within 0 - 23
                 */
                if (timerMode == 2)
                {
                    // If timerMode is 'ends at...' hour should be within 1 ~ 12
                    if (timerHour < 1 || timerHour > 12)
                    {
                        MessageBox.Show("Please enter the number between 1 and 12.", "RemindMe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtHour.Text = "00";
                        strHour = "00";
                        txtHour.SelectAll();
                    }
                }
                else if (timerMode == 1)
                {// if mode is 'lasts for...' it should be within 0 ~ 23
                    if (timerHour < 0 || timerHour > 23)
                    {
                        MessageBox.Show("Please enter the number between 0 and 23.", "RemindMe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtHour.Text = "00";
                        strHour = "00";
                        txtHour.SelectAll();
                    }
                }
                // Keep textbox double-digit
                twoDigits();                
            }
        }
        
        private void txtMinute_MouseDown(object sender, MouseEventArgs e)
        {
            // Select all text in the textbox so the user do not have to manually press backspaces
            txtMinute.SelectAll();
        }


        private void txtMinute_Leave(object sender, EventArgs e)
        {
            /* Convert the input to string */
            strMin = txtMinute.Text.ToString();
            strTest = strMin;

            /* Make sure the input is a number */
            isNum = int.TryParse(strMin, out timerMin);

            if(!isNum)
            {
                // Show error message if input is not a number
                MessageBox.Show("The minutes should be a whole number.", "Wrong Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMinute.Text = "00";
                strMin = "00";
                txtMinute.SelectAll();
            }
            else
            {
                timerMin = int.Parse(strMin);
                // Make sure the input number is valid (i.e. between 00 and 59) 
                if (timerMin < 0 || timerMin > 59)
                {
                    MessageBox.Show("The minutes should be between 0 and 59.", "Wrong Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMinute.Text = "00";
                    strMin = "00";
                    txtMinute.SelectAll();
                }
                // Keep textbox double-digit
                twoDigits();
            }

        }

        private void txtSecond_MouseDown(object sender, MouseEventArgs e)
        {
            // Select all text in the textbox so the user do not have to manually press backspaces
            txtSecond.SelectAll();
        }

        private void txtSecond_Leave(object sender, EventArgs e)
        {
            /* Convert the input to string */
            strSec = txtSecond.Text.ToString();
            strTest = strSec;

            /* Make sure the input is a number */
            isNum = int.TryParse(strSec, out timerSec);

            if (!isNum)
            { // Show error message if input is not a number 
                MessageBox.Show("The seconds should be a whole number.", "Wrong Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSecond.Text = "00";
                strSec = "00";
                txtSecond.SelectAll();
            }
            else
            {
                timerSec = int.Parse(strSec);
                if (timerSec < 0 || timerSec > 59)
                { // Make sure the input number is valid (i.e. between 00 and 59) 
                    MessageBox.Show("The seconds should be between 0 and 59.", "Wrong Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSecond.Text = "00";
                    strSec = "00";
                    txtSecond.SelectAll();
                }
                else
                { // Keep textbox double-digit
                    twoDigits();
                }
            }
        }

        private void cboAMPM_SelectedIndexChanged(object sender, EventArgs e)
        {
            // store the chosen AM/PM value
            indexAMPM = cboAMPM.SelectedIndex;
        }


        private void tmrCurrent_Tick(object sender, EventArgs e)
        { // Display current time at the bottom of the form; update in every second
            current = DateTime.Now;
            strlblCurrentTime.Text = "Current time: " + current.ToString();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            /* Launch the timer */

            /* Error Check
             * Make sure all the required inputs are submitted!!
             */
             
            if (txtTimerContent.Text == "")
            { // Don't let the user start the timer without writing reminder content 
                MessageBox.Show("Please write the content of the reminder.", "RemindMe");
            }
            else if (!optDestTime.Checked && !optDuration.Checked)
            { // Error if the timer mode is not set
                MessageBox.Show("Please select the timer mode.", "RemindMe");
            }
            else if (txtHour.Text == "" || txtMinute.Text == "" || txtSecond.Text == "" || (optDestTime.Checked && cboAMPM.Text == ""))
            { // Error if the time is not entered properly (highly unlikely occurrence)
                MessageBox.Show("Please set the timer appropriately.", "RemindMe");
            }
            else if (timerMode == 1 && timerHour == 0 && timerMin == 0 && timerSec == 0)
            { // Error if countdown length is zero
                MessageBox.Show("The duration of the countdown should be longer than ZERO seconds.", "RemindMe");
            }
            else
            { // Now that the errors are checked, start the timer
                timerHourAdjusted = timerHour;
                if (timerMode == 2)
                { /* convert hours to 12-hour format if ends-at option is chosen */
                    timerHourAdjusted = h12to24(timerHour, indexAMPM);
                }

                /* Calculate the length of the countdown in seconds */
                int totalTime = timecalc(timerHourAdjusted, timerMin, timerSec, timerMode);

                // Create countdown form as an instance with length and reminder content
                frmCountdown countdown = new frmCountdown(totalTime, strTimerContent);

                /* Reset this form */
                timerReset();
                
                // Load countdown form
                countdown.Show();
            }

        }

        private void twoDigits()
        {
            /* Keep hour, minute, and second textboxes in double-digit */
        
            if (timerSec < 10 && timerSec >= 0) // If second is single-digit, add 0 before it
            {
                txtSecond.Text = "0" + timerSec.ToString(); 
            }
            if (timerMin < 10 && timerMin >= 0) // If minute is single-digit, add 0 before it
            {
                txtMinute.Text = "0" + timerMin.ToString();
            }
            if(timerHour < 10 && timerHour >= 0) // If minute is single-digit, add 0 before it
            {
                txtHour.Text = "0" + timerHour.ToString();
            }
        }

        private int timecalc(int h, int m, int s, int mode)
        {
            // return countdown length in seconds
            int cntdwn = 0;
            
            /* Convert the length of the countdown to seconds */
            switch (mode)
            {
                case 1:
                    cntdwn = (h * 3600) + (m * 60) + s;
                    break;
                case 2:
                    
                    DateTime d = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, h, m, s, DateTimeKind.Local);
                    d = d.AddDays(1); 
                    /* 1 day is added to DateTime. If the given time precedes current time, the countdown
                     * is considered to last until that time of the next day.
                     */
                    TimeSpan t = d.Subtract(DateTime.Now);

                    cntdwn = (t.Hours * 3600) + (t.Minutes * 60) + t.Seconds;
                                        
                    break;
                default:
                    MessageBox.Show("Error: Invalid Operation");
                    cntdwn = 0;
                    break;
            }
            
            return cntdwn;
        }

        private int h12to24 (int hour, int ampm)
        { // Convert 12-hr format hour to 24-hr format hr
            int hour24 = 0;

            switch (ampm) // depending on AM/PM information
            {
                case 0:
                    if (hour == 12)
                    { // 12 AM = 0th hour
                        hour24 = 0;
                    }
                    else
                    { // Otherwise, leave hour as it is
                        hour24 = hour;
                    }
                    break;
                case 1:
                    if (hour == 12)
                    { // 12 PM = 12th hour
                        hour24 = 12; 
                    }
                    else
                    { // Otherwise, add 12 to the hour
                        hour24 = hour + 12;
                    }
                    break;
            }

            return hour24; // return 24-hour format hours
        }

        public void timerReset()
        {
            /* Reset the timer; clean up all the data, empty all the inputs
             * and set the focus on the reminder content textbox */
            
            timerHour = 0;
            timerHourAdjusted = 0;
            timerMin = 0;
            timerSec = 0;
            strHour = "00";
            strMin = "00";
            strSec = "00";
            strTest = "";
            strTimerContent = "";
            indexAMPM = -1;
            timerMode = 0;
            /* Reset reminder content textBox */
            txtTimerContent.Text = "";

            /* Reset radio buttons */
            optDestTime.Checked = false;
            optDuration.Checked = false;

            /* Reset time controls; disable them until radiobuttons are clicked again */
            txtHour.Text = "00";
            txtMinute.Text = "00";
            txtSecond.Text = "00";
            cboAMPM.Text = "";
            txtHour.Enabled = false;
            txtMinute.Enabled = false;
            txtSecond.Enabled = false;
            cboAMPM.Enabled = false;

            /* Place cursor to the reminder textbox */
            txtTimerContent.Focus();

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // Reset the inputs
            timerReset();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Exit the application gracefully
            Close();
        }

    }
}
