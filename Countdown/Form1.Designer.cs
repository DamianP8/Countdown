
namespace Countdown
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnStart = new Button();
            btnStop = new Button();
            groupBox1 = new GroupBox();
            lblTimer = new Label();
            groupBox2 = new GroupBox();
            txtSeconds = new TextBox();
            txtMinutes = new TextBox();
            txtHours = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox3 = new GroupBox();
            rbSavePower = new RadioButton();
            rbRestart = new RadioButton();
            rbShutdown = new RadioButton();
            timer = new System.Windows.Forms.Timer(components);
            groupBox4 = new GroupBox();
            lblTimeNow = new Label();
            button1 = new Button();
            btnIncreaseOpacity = new Button();
            btnDecreaseOpacity = new Button();
            button4 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // btnStart
            // 
            resources.ApplyResources(btnStart, "btnStart");
            btnStart.ForeColor = Color.DimGray;
            btnStart.Name = "btnStart";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnStop
            // 
            resources.ApplyResources(btnStop, "btnStop");
            btnStop.BackColor = Color.Transparent;
            btnStop.ForeColor = Color.DimGray;
            btnStop.Name = "btnStop";
            btnStop.UseVisualStyleBackColor = false;
            btnStop.Click += btnStop_Click;
            // 
            // groupBox1
            // 
            resources.ApplyResources(groupBox1, "groupBox1");
            groupBox1.Controls.Add(lblTimer);
            groupBox1.ForeColor = Color.DarkOrange;
            groupBox1.Name = "groupBox1";
            groupBox1.TabStop = false;
            // 
            // lblTimer
            // 
            resources.ApplyResources(lblTimer, "lblTimer");
            lblTimer.BackColor = Color.Transparent;
            lblTimer.ForeColor = Color.DarkOrange;
            lblTimer.Name = "lblTimer";
            // 
            // groupBox2
            // 
            resources.ApplyResources(groupBox2, "groupBox2");
            groupBox2.Controls.Add(txtSeconds);
            groupBox2.Controls.Add(txtMinutes);
            groupBox2.Controls.Add(txtHours);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.ForeColor = Color.DarkOrange;
            groupBox2.Name = "groupBox2";
            groupBox2.TabStop = false;
            // 
            // txtSeconds
            // 
            resources.ApplyResources(txtSeconds, "txtSeconds");
            txtSeconds.BackColor = Color.Silver;
            txtSeconds.Name = "txtSeconds";
            // 
            // txtMinutes
            // 
            resources.ApplyResources(txtMinutes, "txtMinutes");
            txtMinutes.BackColor = Color.Silver;
            txtMinutes.Name = "txtMinutes";
            // 
            // txtHours
            // 
            resources.ApplyResources(txtHours, "txtHours");
            txtHours.BackColor = Color.Silver;
            txtHours.Name = "txtHours";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // groupBox3
            // 
            resources.ApplyResources(groupBox3, "groupBox3");
            groupBox3.Controls.Add(rbSavePower);
            groupBox3.Controls.Add(rbRestart);
            groupBox3.Controls.Add(rbShutdown);
            groupBox3.ForeColor = Color.DarkOrange;
            groupBox3.Name = "groupBox3";
            groupBox3.TabStop = false;
            // 
            // rbSavePower
            // 
            resources.ApplyResources(rbSavePower, "rbSavePower");
            rbSavePower.Name = "rbSavePower";
            rbSavePower.TabStop = true;
            rbSavePower.UseVisualStyleBackColor = true;
            // 
            // rbRestart
            // 
            resources.ApplyResources(rbRestart, "rbRestart");
            rbRestart.Name = "rbRestart";
            rbRestart.TabStop = true;
            rbRestart.UseVisualStyleBackColor = true;
            // 
            // rbShutdown
            // 
            resources.ApplyResources(rbShutdown, "rbShutdown");
            rbShutdown.Name = "rbShutdown";
            rbShutdown.TabStop = true;
            rbShutdown.UseVisualStyleBackColor = true;
            // 
            // timer
            // 
            timer.Interval = 1000;
            timer.Tick += timer_Tick;
            // 
            // groupBox4
            // 
            resources.ApplyResources(groupBox4, "groupBox4");
            groupBox4.Controls.Add(lblTimeNow);
            groupBox4.ForeColor = Color.DarkOrange;
            groupBox4.Name = "groupBox4";
            groupBox4.TabStop = false;
            // 
            // lblTimeNow
            // 
            resources.ApplyResources(lblTimeNow, "lblTimeNow");
            lblTimeNow.Name = "lblTimeNow";
            // 
            // button1
            // 
            resources.ApplyResources(button1, "button1");
            button1.ForeColor = Color.DimGray;
            button1.Name = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnClose_Click;
            // 
            // btnIncreaseOpacity
            // 
            resources.ApplyResources(btnIncreaseOpacity, "btnIncreaseOpacity");
            btnIncreaseOpacity.ForeColor = Color.DimGray;
            btnIncreaseOpacity.Name = "btnIncreaseOpacity";
            btnIncreaseOpacity.UseVisualStyleBackColor = true;
            btnIncreaseOpacity.Click += btnIncreaseOpacity_Click;
            // 
            // btnDecreaseOpacity
            // 
            resources.ApplyResources(btnDecreaseOpacity, "btnDecreaseOpacity");
            btnDecreaseOpacity.ForeColor = Color.DimGray;
            btnDecreaseOpacity.Name = "btnDecreaseOpacity";
            btnDecreaseOpacity.UseVisualStyleBackColor = true;
            btnDecreaseOpacity.Click += btnDecreaseOpacity_Click;
            // 
            // button4
            // 
            resources.ApplyResources(button4, "button4");
            button4.ForeColor = Color.DimGray;
            button4.Name = "button4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += btnMinimize_Click;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            Controls.Add(button4);
            Controls.Add(btnDecreaseOpacity);
            Controls.Add(btnIncreaseOpacity);
            Controls.Add(button1);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnStop);
            Controls.Add(btnStart);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        #endregion

        private Button btnStart;
        private Button btnStop;
        private GroupBox groupBox1;
        private Label lblTimer;
        private GroupBox groupBox2;
        private TextBox txtSeconds;
        private TextBox txtMinutes;
        private TextBox txtHours;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox3;
        private RadioButton rbSavePower;
        private RadioButton rbRestart;
        private RadioButton rbShutdown;
        private System.Windows.Forms.Timer timer;
        private GroupBox groupBox4;
        private Label lblTimeNow;
        private Button button1;
        private Button btnIncreaseOpacity;
        private Button btnDecreaseOpacity;
        private Button button4;
    }
}
