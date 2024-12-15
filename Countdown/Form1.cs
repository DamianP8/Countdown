using System.Diagnostics;

namespace Countdown
{
    public partial class Form1 : Form
    {
        TimeSpan timeLeft;
        System.Windows.Forms.Timer clockTimer;

        public Form1()
        {
            InitializeComponent();
            ShowTimeNow();
            ClockTimerSetUp();
            PositionInBottomRight();
            this.Opacity = 1.0;
        }

        private void ClockTimerSetUp()
        {
            clockTimer = new System.Windows.Forms.Timer();
            clockTimer.Interval = 1000;
            clockTimer.Tick += ClockTimer_Tick;
            clockTimer.Start();
        }

        private void PositionInBottomRight()
        {
            int screenWidth = Screen.PrimaryScreen.WorkingArea.Width;
            int screenHeight = Screen.PrimaryScreen.WorkingArea.Height;

            int formWidth = this.Width;
            int formHeight = this.Height;

            int xPosition = screenWidth - formWidth;
            int yPosition = screenHeight - formHeight;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(xPosition, yPosition);
        }

        private void ClockTimer_Tick(object sender, EventArgs e)
        {
            ShowTimeNow();
        }

        private void ShowTimeNow()
        {
            lblTimeNow.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            CheckTextBoxValue();
            bool isStartable = true;
            try
            {
                timeLeft = new TimeSpan(Convert.ToInt32(txtHours.Text), Convert.ToInt32(txtMinutes.Text), Convert.ToInt32(txtSeconds.Text));
            }
            catch (FormatException ex)
            {
                isStartable = false;
                MessageBox.Show("Die Eingabe für den Timer war nicht richtig, Fehler: " + ex.Message);
            }

            if (isStartable)
            {
                timer.Start();
                lblTimer.Text = timeLeft.ToString(@"hh\:mm\:ss");
            }
        }

        private void CheckTextBoxValue()
        {
            if (txtHours.Text.Count() == 0)
            {
                txtHours.Text = "0";
            }
            if (txtMinutes.Text.Count() == 0)
            {
                txtMinutes.Text = "0";
            }
            if (txtSeconds.Text.Count() == 0)
            {
                txtSeconds.Text = "0";
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timeLeft = timeLeft.Subtract(TimeSpan.FromSeconds(1));
            lblTimer.Text = timeLeft.ToString(@"hh\:mm\:ss");

            if (timeLeft.TotalSeconds <= 0)
            {
                timer.Stop();
                PerformAction();
            }
        }

        private void PerformAction()
        {
            if (rbShutdown.Checked)
            {
                Process.Start("shutdown", "/s");
            }
            else if (rbRestart.Checked)
            {
                Process.Start("shutdown", "/r");
            }
            else if (rbSavePower.Checked)
            {
                Process.Start("rundll32.exe", "powrprof.dll,SetSuspendState");
            }
            else
            {
                MessageBox.Show("Keine Aktion gewählt, Snickers -> und weiter geht's");
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer.Stop();
            lblTimer.Text = "00:00:00";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnDecreaseOpacity_Click(object sender, EventArgs e)
        {
            if (Opacity >= 0.1)
                 this.Opacity = Opacity - 0.05;
        }

        private void btnIncreaseOpacity_Click(object sender, EventArgs e)
        {
            if (Opacity >= 0.01)
                this.Opacity = Opacity + 0.05;
        }
    }
}
