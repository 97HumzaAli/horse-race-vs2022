using System.Runtime.ExceptionServices;

namespace HorseRace
{
    public partial class CircularHorseRace : Form
    {
        Horse[] horses = new Horse[3];
        int xCircle = 250;
        int yCircle = 218;
        double degrees = 0;
        double degrees2 = 0;
        double degrees3 = 0;
        int seconds1 = 0;
        int seconds2 = 0;
        int seconds3 = 0;
        public CircularHorseRace()
        {
            InitializeComponent();
            lblWinner.Text = "Winner:";
            lblWinSpeed.Text = "Speed:";
            lblWinTime.Text = "Timing:";
            lblTime1.Text = "";
            lblTime2.Text = "";
            lblTime3.Text = "";
            lblSpeed1.Text = "";
            lblSpeed2.Text = "";
            lblSpeed3.Text = "";
            btnRestart.Enabled = false;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void lblHorseRacing_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {
        }

        private void lblEndPoint_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            int xStart = 50;
            int yStart = 212;

            Random r = new Random();

            for(int i = 0; i < horses.Length; i++) //Adding Buttons to Form
            {      
                horses[i] = new Horse();
                horses[i].Location = new Point(xStart, yStart);
                horses[i].BackgroundImage = HorseRace.Properties.Resources.HorseResize;
                horses[i].Size = new Size(25, 25);       
                this.Controls.Add(horses[i]);
                horses[i].BringToFront();
                horses[i].X = xStart;
                horses[i].Y = yStart;
                horses[i].Degrees = r.NextDouble();
                while(horses[i].Degrees > 0.05 || horses[i].Degrees < 0.01)
                {
                    horses[i].Degrees = r.NextDouble();
                }
                horses[i].Radius = xCircle - xStart;
                xStart += 35;
            }
            lblSpeed1.Text = (Math.Round(horses[0].Degrees, 4)*1000).ToString();
            lblSpeed2.Text = (Math.Round(horses[1].Degrees, 4)*1000).ToString();
            lblSpeed3.Text = (Math.Round(horses[2].Degrees, 4)*1000).ToString();
            timer1.Start();
            timer2.Start();
            timer3.Start();
            timer4.Start();
            timer5.Start();
            timer6.Start();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            horses[0].Y = yCircle - (horses[0].Radius * Math.Sin(degrees));
            horses[0].X = xCircle - (horses[0].Radius * Math.Cos(degrees));
            //Console.WriteLine(horses[0].Y);
            //Console.WriteLine(horses[0].X);
            horses[0].Top = (int)horses[0].Y;
            horses[0].Left = (int)horses[0].X;
            degrees += horses[0].Degrees;
            if (degrees > 4.62)
            {
                timer1.Stop();
                timer4.Stop();
                if(lblWinner.Text == "Winner:")
                {
                    lblWinner.Text += " Horse 1";
                    lblWinTime.Text += " " + seconds1;
                    lblWinSpeed.Text += " " + (Math.Round(horses[0].Degrees, 4) * 1000).ToString();
                }
                lblTime1.Text = seconds1.ToString();
            }
            if (lblTime1.Text != "" && lblTime2.Text != "" && lblTime3.Text != "")
            {
                btnRestart.Enabled = true;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            horses[1].Y = yCircle - (horses[1].Radius * Math.Sin(degrees2));
            horses[1].X = xCircle - (horses[1].Radius * Math.Cos(degrees2));
            //Console.WriteLine(horses[1].Y);
            //Console.WriteLine(horses[1].X);
            horses[1].Top = (int)horses[1].Y;
            horses[1].Left = (int)horses[1].X;
            degrees2 += horses[1].Degrees;
            if (degrees2 > 4.60)
            {
                timer2.Stop();
                timer5.Stop();
                if (lblWinner.Text == "Winner:")
                {
                    lblWinner.Text += " Horse 2";
                    lblWinTime.Text += " " + seconds2;
                    lblWinSpeed.Text += " " + (Math.Round(horses[1].Degrees, 4) * 1000).ToString();

                }
                lblTime2.Text = seconds2.ToString();
            }
            if (lblTime1.Text != "" && lblTime2.Text != "" && lblTime3.Text != "")
            {
                btnRestart.Enabled = true;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            horses[2].Y = yCircle - (horses[2].Radius * Math.Sin(degrees3));
            horses[2].X = xCircle - (horses[2].Radius * Math.Cos(degrees3));
            //Console.WriteLine(horses[2].Y);
            //Console.WriteLine(horses[2].X);
            horses[2].Top = (int)horses[2].Y;
            horses[2].Left = (int)horses[2].X;
            degrees3 += horses[2].Degrees;
            if (degrees3 > 4.57)
            {
                timer3.Stop();
                timer6.Stop();
                if (lblWinner.Text == "Winner:")
                {
                    lblWinner.Text += " Horse 3";
                    lblWinTime.Text += " " + seconds3;
                    lblWinSpeed.Text += " " + (Math.Round(horses[2].Degrees, 4) * 1000).ToString();
                }
                lblTime3.Text = seconds3.ToString();
            }
            if(lblTime1.Text != "" && lblTime2.Text != "" && lblTime3.Text != "")
            {
                btnRestart.Enabled = true;
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            seconds1++;
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            seconds2++;
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            seconds3++;
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            lblTime1.Text = "";
            lblTime2.Text = "";
            lblTime3.Text = "";
            lblSpeed1.Text = "";
            lblSpeed2.Text = "";
            lblSpeed3.Text = "";
            lblWinner.Text = "Winner:";
            lblWinSpeed.Text = "Speed:";
            lblWinTime.Text = "Timing:";
            seconds1 = 0;
            seconds2 = 0;
            seconds3 = 0;
            degrees = 0;
            degrees2 = 0;
            degrees3 = 0;
            foreach (Horse horse in horses)
            {
                horse.Dispose();
            }
            btnRestart.Enabled = false;
            btnStart.Enabled = true;
        }
    }
}