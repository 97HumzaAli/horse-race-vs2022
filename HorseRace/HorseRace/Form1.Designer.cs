namespace HorseRace
{
    partial class CircularHorseRace
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CircularHorseRace));
            this.lblWinner = new System.Windows.Forms.Label();
            this.lblWinTime = new System.Windows.Forms.Label();
            this.lblWinSpeed = new System.Windows.Forms.Label();
            this.tblLayout = new System.Windows.Forms.TableLayoutPanel();
            this.lblHorse = new System.Windows.Forms.Label();
            this.lblTiming = new System.Windows.Forms.Label();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.lblH1 = new System.Windows.Forms.Label();
            this.lblH2 = new System.Windows.Forms.Label();
            this.lblH3 = new System.Windows.Forms.Label();
            this.lblTime1 = new System.Windows.Forms.Label();
            this.lblTime2 = new System.Windows.Forms.Label();
            this.lblTime3 = new System.Windows.Forms.Label();
            this.lblSpeed1 = new System.Windows.Forms.Label();
            this.lblSpeed2 = new System.Windows.Forms.Label();
            this.lblSpeed3 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.pBoxTrack = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.startPanel = new System.Windows.Forms.Panel();
            this.lblStart = new System.Windows.Forms.Label();
            this.endPanel = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.timer5 = new System.Windows.Forms.Timer(this.components);
            this.timer6 = new System.Windows.Forms.Timer(this.components);
            this.tblLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxTrack)).BeginInit();
            this.startPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWinner
            // 
            this.lblWinner.AutoSize = true;
            this.lblWinner.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblWinner.ForeColor = System.Drawing.Color.White;
            this.lblWinner.Location = new System.Drawing.Point(559, 44);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(59, 20);
            this.lblWinner.TabIndex = 0;
            this.lblWinner.Text = "Winner:";
            this.lblWinner.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblWinTime
            // 
            this.lblWinTime.AutoSize = true;
            this.lblWinTime.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblWinTime.ForeColor = System.Drawing.Color.White;
            this.lblWinTime.Location = new System.Drawing.Point(559, 74);
            this.lblWinTime.Name = "lblWinTime";
            this.lblWinTime.Size = new System.Drawing.Size(62, 20);
            this.lblWinTime.TabIndex = 1;
            this.lblWinTime.Text = "Timing: ";
            this.lblWinTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblWinSpeed
            // 
            this.lblWinSpeed.AutoSize = true;
            this.lblWinSpeed.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblWinSpeed.ForeColor = System.Drawing.Color.White;
            this.lblWinSpeed.Location = new System.Drawing.Point(559, 105);
            this.lblWinSpeed.Name = "lblWinSpeed";
            this.lblWinSpeed.Size = new System.Drawing.Size(54, 20);
            this.lblWinSpeed.TabIndex = 2;
            this.lblWinSpeed.Text = "Speed:";
            this.lblWinSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tblLayout
            // 
            this.tblLayout.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.tblLayout.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tblLayout.ColumnCount = 3;
            this.tblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tblLayout.Controls.Add(this.lblHorse, 0, 0);
            this.tblLayout.Controls.Add(this.lblTiming, 1, 0);
            this.tblLayout.Controls.Add(this.lblSpeed, 2, 0);
            this.tblLayout.Controls.Add(this.lblH1, 0, 1);
            this.tblLayout.Controls.Add(this.lblH2, 0, 2);
            this.tblLayout.Controls.Add(this.lblH3, 0, 3);
            this.tblLayout.Controls.Add(this.lblTime1, 1, 1);
            this.tblLayout.Controls.Add(this.lblTime2, 1, 2);
            this.tblLayout.Controls.Add(this.lblTime3, 1, 3);
            this.tblLayout.Controls.Add(this.lblSpeed1, 2, 1);
            this.tblLayout.Controls.Add(this.lblSpeed2, 2, 2);
            this.tblLayout.Controls.Add(this.lblSpeed3, 2, 3);
            this.tblLayout.Location = new System.Drawing.Point(516, 141);
            this.tblLayout.Name = "tblLayout";
            this.tblLayout.RowCount = 4;
            this.tblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblLayout.Size = new System.Drawing.Size(250, 92);
            this.tblLayout.TabIndex = 3;
            this.tblLayout.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // lblHorse
            // 
            this.lblHorse.AutoSize = true;
            this.lblHorse.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHorse.Location = new System.Drawing.Point(5, 2);
            this.lblHorse.Name = "lblHorse";
            this.lblHorse.Size = new System.Drawing.Size(63, 20);
            this.lblHorse.TabIndex = 4;
            this.lblHorse.Text = "Horse #";
            // 
            // lblTiming
            // 
            this.lblTiming.AutoSize = true;
            this.lblTiming.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTiming.Location = new System.Drawing.Point(87, 2);
            this.lblTiming.Name = "lblTiming";
            this.lblTiming.Size = new System.Drawing.Size(58, 20);
            this.lblTiming.TabIndex = 5;
            this.lblTiming.Text = "Timing";
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSpeed.Location = new System.Drawing.Point(169, 2);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(51, 20);
            this.lblSpeed.TabIndex = 6;
            this.lblSpeed.Text = "Speed";
            // 
            // lblH1
            // 
            this.lblH1.AutoSize = true;
            this.lblH1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblH1.Location = new System.Drawing.Point(5, 24);
            this.lblH1.Name = "lblH1";
            this.lblH1.Size = new System.Drawing.Size(18, 20);
            this.lblH1.TabIndex = 4;
            this.lblH1.Text = "1";
            this.lblH1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblH2
            // 
            this.lblH2.AutoSize = true;
            this.lblH2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblH2.Location = new System.Drawing.Point(5, 46);
            this.lblH2.Name = "lblH2";
            this.lblH2.Size = new System.Drawing.Size(18, 20);
            this.lblH2.TabIndex = 7;
            this.lblH2.Text = "2";
            // 
            // lblH3
            // 
            this.lblH3.AutoSize = true;
            this.lblH3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblH3.Location = new System.Drawing.Point(5, 68);
            this.lblH3.Name = "lblH3";
            this.lblH3.Size = new System.Drawing.Size(18, 20);
            this.lblH3.TabIndex = 8;
            this.lblH3.Text = "3";
            this.lblH3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTime1
            // 
            this.lblTime1.AutoSize = true;
            this.lblTime1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTime1.Location = new System.Drawing.Point(87, 24);
            this.lblTime1.Name = "lblTime1";
            this.lblTime1.Size = new System.Drawing.Size(53, 20);
            this.lblTime1.TabIndex = 9;
            this.lblTime1.Text = "Time1";
            // 
            // lblTime2
            // 
            this.lblTime2.AutoSize = true;
            this.lblTime2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTime2.Location = new System.Drawing.Point(87, 46);
            this.lblTime2.Name = "lblTime2";
            this.lblTime2.Size = new System.Drawing.Size(53, 20);
            this.lblTime2.TabIndex = 10;
            this.lblTime2.Text = "Time2";
            // 
            // lblTime3
            // 
            this.lblTime3.AutoSize = true;
            this.lblTime3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTime3.Location = new System.Drawing.Point(87, 68);
            this.lblTime3.Name = "lblTime3";
            this.lblTime3.Size = new System.Drawing.Size(53, 20);
            this.lblTime3.TabIndex = 11;
            this.lblTime3.Text = "Time3";
            // 
            // lblSpeed1
            // 
            this.lblSpeed1.AutoSize = true;
            this.lblSpeed1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSpeed1.Location = new System.Drawing.Point(169, 24);
            this.lblSpeed1.Name = "lblSpeed1";
            this.lblSpeed1.Size = new System.Drawing.Size(60, 20);
            this.lblSpeed1.TabIndex = 12;
            this.lblSpeed1.Text = "Speed1";
            // 
            // lblSpeed2
            // 
            this.lblSpeed2.AutoSize = true;
            this.lblSpeed2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSpeed2.Location = new System.Drawing.Point(169, 46);
            this.lblSpeed2.Name = "lblSpeed2";
            this.lblSpeed2.Size = new System.Drawing.Size(60, 20);
            this.lblSpeed2.TabIndex = 13;
            this.lblSpeed2.Text = "Speed2";
            // 
            // lblSpeed3
            // 
            this.lblSpeed3.AutoSize = true;
            this.lblSpeed3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSpeed3.Location = new System.Drawing.Point(169, 68);
            this.lblSpeed3.Name = "lblSpeed3";
            this.lblSpeed3.Size = new System.Drawing.Size(60, 20);
            this.lblSpeed3.TabIndex = 14;
            this.lblSpeed3.Text = "Speed3";
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(516, 239);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(114, 29);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnRestart.ForeColor = System.Drawing.Color.White;
            this.btnRestart.Location = new System.Drawing.Point(653, 239);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(113, 29);
            this.btnRestart.TabIndex = 5;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // pBoxTrack
            // 
            this.pBoxTrack.Image = ((System.Drawing.Image)(resources.GetObject("pBoxTrack.Image")));
            this.pBoxTrack.Location = new System.Drawing.Point(7, 12);
            this.pBoxTrack.Name = "pBoxTrack";
            this.pBoxTrack.Size = new System.Drawing.Size(503, 426);
            this.pBoxTrack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBoxTrack.TabIndex = 6;
            this.pBoxTrack.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(209, 213);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(97, 20);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "Horse Racing";
            // 
            // startPanel
            // 
            this.startPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.startPanel.Controls.Add(this.lblStart);
            this.startPanel.Location = new System.Drawing.Point(46, 187);
            this.startPanel.Name = "startPanel";
            this.startPanel.Size = new System.Drawing.Size(109, 24);
            this.startPanel.TabIndex = 8;
            // 
            // lblStart
            // 
            this.lblStart.ForeColor = System.Drawing.Color.White;
            this.lblStart.Location = new System.Drawing.Point(6, 0);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(100, 20);
            this.lblStart.TabIndex = 0;
            this.lblStart.Text = "START POINT";
            // 
            // endPanel
            // 
            this.endPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.endPanel.Location = new System.Drawing.Point(248, 331);
            this.endPanel.Name = "endPanel";
            this.endPanel.Size = new System.Drawing.Size(28, 107);
            this.endPanel.TabIndex = 9;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // timer2
            // 
            this.timer2.Interval = 1;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 1;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timer4
            // 
            this.timer4.Interval = 1000;
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // timer5
            // 
            this.timer5.Interval = 1000;
            this.timer5.Tick += new System.EventHandler(this.timer5_Tick);
            // 
            // timer6
            // 
            this.timer6.Interval = 1000;
            this.timer6.Tick += new System.EventHandler(this.timer6_Tick);
            // 
            // CircularHorseRace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.endPanel);
            this.Controls.Add(this.startPanel);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.tblLayout);
            this.Controls.Add(this.lblWinSpeed);
            this.Controls.Add(this.lblWinTime);
            this.Controls.Add(this.lblWinner);
            this.Controls.Add(this.pBoxTrack);
            this.Name = "CircularHorseRace";
            this.Text = "Circular Horse Race";
            this.tblLayout.ResumeLayout(false);
            this.tblLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxTrack)).EndInit();
            this.startPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblWinner;
        private Label lblWinTime;
        private Label lblWinSpeed;
        private TableLayoutPanel tblLayout;
        private Label lblHorse;
        private Label lblTiming;
        private Label lblSpeed;
        private Label lblH1;
        private Label lblH2;
        private Label lblH3;
        private Button btnStart;
        private Button btnRestart;
        private PictureBox pBoxTrack;
        private Label lblTitle;
        private Panel startPanel;
        private Label lblStart;
        private Panel endPanel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private Label lblTime1;
        private Label lblTime2;
        private Label lblTime3;
        private Label lblSpeed1;
        private Label lblSpeed2;
        private Label lblSpeed3;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Timer timer5;
        private System.Windows.Forms.Timer timer6;
    }
}