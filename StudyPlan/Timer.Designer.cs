namespace StudyPlan
{
    partial class Timer
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Timer));
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnRest = new System.Windows.Forms.Button();
            this.txtPomadoro = new System.Windows.Forms.TextBox();
            this.btnPomadoro = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pomadoaCounterLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(248, 283);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 91);
            this.label1.TabIndex = 0;
            this.label1.Text = "00:00:00";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.LimeGreen;
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnStart.Location = new System.Drawing.Point(171, 414);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(144, 62);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.Crimson;
            this.btnStop.FlatAppearance.BorderSize = 0;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnStop.Location = new System.Drawing.Point(352, 414);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(144, 62);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnRest
            // 
            this.btnRest.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnRest.FlatAppearance.BorderSize = 0;
            this.btnRest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRest.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRest.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRest.Location = new System.Drawing.Point(526, 414);
            this.btnRest.Name = "btnRest";
            this.btnRest.Size = new System.Drawing.Size(144, 62);
            this.btnRest.TabIndex = 1;
            this.btnRest.Text = "Rest";
            this.btnRest.UseVisualStyleBackColor = false;
            this.btnRest.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtPomadoro
            // 
            this.txtPomadoro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPomadoro.Location = new System.Drawing.Point(461, 131);
            this.txtPomadoro.Name = "txtPomadoro";
            this.txtPomadoro.Size = new System.Drawing.Size(157, 30);
            this.txtPomadoro.TabIndex = 3;
            // 
            // btnPomadoro
            // 
            this.btnPomadoro.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnPomadoro.FlatAppearance.BorderSize = 0;
            this.btnPomadoro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPomadoro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPomadoro.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPomadoro.Location = new System.Drawing.Point(461, 187);
            this.btnPomadoro.Name = "btnPomadoro";
            this.btnPomadoro.Size = new System.Drawing.Size(157, 52);
            this.btnPomadoro.TabIndex = 4;
            this.btnPomadoro.Text = "Pomadoro";
            this.btnPomadoro.UseVisualStyleBackColor = false;
            this.btnPomadoro.Click += new System.EventHandler(this.btnPomadoro_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(461, 83);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(157, 33);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(238, 83);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(170, 156);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pomadoaCounterLabel
            // 
            this.pomadoaCounterLabel.AutoSize = true;
            this.pomadoaCounterLabel.BackColor = System.Drawing.Color.Transparent;
            this.pomadoaCounterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 100F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pomadoaCounterLabel.Location = new System.Drawing.Point(134, 86);
            this.pomadoaCounterLabel.Name = "pomadoaCounterLabel";
            this.pomadoaCounterLabel.Size = new System.Drawing.Size(140, 153);
            this.pomadoaCounterLabel.TabIndex = 6;
            this.pomadoaCounterLabel.Text = "0";
            // 
            // Timer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pomadoaCounterLabel);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnPomadoro);
            this.Controls.Add(this.txtPomadoro);
            this.Controls.Add(this.btnRest);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label1);
            this.Name = "Timer";
            this.Size = new System.Drawing.Size(847, 585);
            this.Load += new System.EventHandler(this.Timer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnRest;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtPomadoro;
        private System.Windows.Forms.Button btnPomadoro;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label pomadoaCounterLabel;
    }
}
