namespace FussySharp
{
    partial class Form1
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
            this.secs = new System.Windows.Forms.TextBox();
            this.min = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.timer = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.hour = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.startstop = new System.Windows.Forms.Button();
            this.settings = new System.Windows.Forms.Button();
            this.pause = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // secs
            // 
            this.secs.Location = new System.Drawing.Point(233, 64);
            this.secs.Name = "secs";
            this.secs.Size = new System.Drawing.Size(100, 20);
            this.secs.TabIndex = 0;
            this.secs.Tag = "secs";
            this.secs.Text = "asdf";
            this.secs.TextChanged += new System.EventHandler(this.secs_TextChanged);
            // 
            // min
            // 
            this.min.Location = new System.Drawing.Point(233, 38);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(100, 20);
            this.min.TabIndex = 1;
            this.min.Tag = "min";
            this.min.Text = "15";
            this.min.TextChanged += new System.EventHandler(this.min_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.timer);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(160, 72);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Current Timer";
            // 
            // timer
            // 
            this.timer.AutoSize = true;
            this.timer.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.timer.Location = new System.Drawing.Point(28, 26);
            this.timer.Name = "timer";
            this.timer.Size = new System.Drawing.Size(103, 29);
            this.timer.TabIndex = 0;
            this.timer.Tag = "time";
            this.timer.Text = "00:00:00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(179, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Minutes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Seconds";
            // 
            // hour
            // 
            this.hour.Location = new System.Drawing.Point(233, 12);
            this.hour.Name = "hour";
            this.hour.Size = new System.Drawing.Size(100, 20);
            this.hour.TabIndex = 5;
            this.hour.Tag = "hours";
            this.hour.Text = "0";
            this.hour.TextChanged += new System.EventHandler(this.hour_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(179, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 6;
            this.label4.Tag = "hour";
            this.label4.Text = "Hours";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(13, 91);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(320, 23);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 7;
            this.progressBar1.Value = 67;
            // 
            // startstop
            // 
            this.startstop.Location = new System.Drawing.Point(258, 120);
            this.startstop.Name = "startstop";
            this.startstop.Size = new System.Drawing.Size(75, 23);
            this.startstop.TabIndex = 8;
            this.startstop.Text = "Start";
            this.startstop.UseVisualStyleBackColor = true;
            this.startstop.Click += new System.EventHandler(this.StartStop);
            // 
            // settings
            // 
            this.settings.Location = new System.Drawing.Point(13, 119);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(75, 23);
            this.settings.TabIndex = 9;
            this.settings.Text = "Settings";
            this.settings.UseVisualStyleBackColor = true;
            this.settings.Click += new System.EventHandler(this.settings_Click);
            // 
            // pause
            // 
            this.pause.Location = new System.Drawing.Point(177, 120);
            this.pause.Name = "pause";
            this.pause.Size = new System.Drawing.Size(75, 23);
            this.pause.TabIndex = 10;
            this.pause.Text = "Pause";
            this.pause.UseVisualStyleBackColor = true;
            this.pause.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 154);
            this.Controls.Add(this.pause);
            this.Controls.Add(this.settings);
            this.Controls.Add(this.startstop);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.hour);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.min);
            this.Controls.Add(this.secs);
            this.Name = "Form1";
            this.Text = "Fussy Sharp";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox secs;
        private System.Windows.Forms.TextBox min;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label timer;
        private System.Windows.Forms.TextBox hour;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button startstop;
        private System.Windows.Forms.Button settings;
        private System.Windows.Forms.Button pause;
    }
}

