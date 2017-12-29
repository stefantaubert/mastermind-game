namespace Mastermind
{
    using Mastermind.Properties;
    using System;
    using System.Diagnostics;
    using System.Drawing;
    using System.Windows.Forms;

    public partial class MainForm : Form
    {
        Random rnd = new Random();
        Image[] Button = new Image[10];
        Image[] GegnerFarbreihe = new Image[7];
        Colorrow[] reihe = new Colorrow[8];
        public int aktuelleReihe = new int();

        public MainForm()
        {
            InitializeComponent();
            Abstand = 20;
            Abstand2 = 38;
            for (int aktuelleReihe = 0; aktuelleReihe < 8; aktuelleReihe++)
            {
                reihe[aktuelleReihe] = new Colorrow();
                reihe[aktuelleReihe].Location = new Point(10, Abstand + Abstand2 * aktuelleReihe);
                this.Controls.Add(reihe[aktuelleReihe]);
            }
        }

        private void SetGegnerReihe()
        {
            int RndZahl = new int();
            for (int i = 0; i < 4; i++)
            {
                RndZahl = rnd.Next(1, 6);
                GegnerFarbreihe[i] = Button[RndZahl];
                //MessageBox.Show(RndZahl.ToString());
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            aktuelleReihe = -1;

            Button[0] = Resources.Blue;
            Button[1] = Resources.Green;
            Button[2] = Resources.Grey;
            Button[3] = Resources.Orange;
            Button[4] = Resources.Red;
            Button[5] = Resources.Yellow;
            Button[6] = Resources.Question;
            Button[7] = Resources.White;
            Button[8] = Resources.Black;
            // Gegener Farbreihe füllen
            SetGegnerReihe();
            stecker1.Image = Button[0];
            stecker2.Image = Button[1];
            stecker3.Image = Button[2];
            stecker4.Image = Button[3];
            stecker5.Image = Button[4];
            stecker6.Image = Button[5];
            NeueReihe();
        }

        int Abstand = 0, Abstand2 = 10;

        void NeueReihe()
        {
            aktuelleReihe++;
            reihe[aktuelleReihe].stecker1.Image = Button[6];
            reihe[aktuelleReihe].stecker2.Image = Button[6];
            reihe[aktuelleReihe].stecker3.Image = Button[6];
            reihe[aktuelleReihe].stecker4.Image = Button[6];
            string Reihe = Convert.ToString(aktuelleReihe + 1);
            if (Reihe == "7")
            {
                Text = "Mastermind - Row: " + Reihe + " (last try!)";
            }
            else if (Reihe == "8")
            {
                Text = "Mastermind";
            }
            else
            {
                Text = "Mastermind - Row: " + Reihe;
            }
        }
        void ÜberprüfeVorkommen()
        {
            Image[] MeinBild = new Image[4];
            MeinBild[0] = reihe[aktuelleReihe].stecker1.Image;
            MeinBild[1] = reihe[aktuelleReihe].stecker2.Image;
            MeinBild[2] = reihe[aktuelleReihe].stecker3.Image;
            MeinBild[3] = reihe[aktuelleReihe].stecker4.Image;

            int[] MeineFarbe = new int[4];
            int[] GegnerFarbe = new int[4];
            bool[] MeineFarbeVerwendet = new bool[4] { false, false, false, false };

            int[] anzahlFarbe = new int[6];
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (Button[i] == GegnerFarbreihe[j])
                    {
                        GegnerFarbe[j] = i;
                        anzahlFarbe[i]++;
                    }
                    if (Button[i] == MeinBild[j])
                    {
                        MeineFarbe[j] = i;
                    }
                }
            }

            int anzahlSchwarz = 0;
            int anzahlWeiß = 0;

            for (int i = 0; i < 4; i++)
            {
                if (MeineFarbe[i] == GegnerFarbe[i])
                {
                    anzahlSchwarz++;
                    MeineFarbeVerwendet[i] = true;
                    anzahlFarbe[MeineFarbe[i]]--;
                }
            }

            for (int i = 0; i < 4; i++)
            {
                if ((anzahlFarbe[MeineFarbe[i]] > 0) && (MeineFarbeVerwendet[i] == false))
                {
                    anzahlWeiß++;
                    anzahlFarbe[MeineFarbe[i]]--;
                }
            }

            if (anzahlSchwarz > 0)
            {
                reihe[aktuelleReihe].stift1.Image = Button[8];
                anzahlSchwarz--;
            }
            else if (anzahlWeiß > 0)
            {
                reihe[aktuelleReihe].stift1.Image = Button[7];
                anzahlWeiß--;
            }

            if (anzahlSchwarz > 0)
            {
                reihe[aktuelleReihe].stift2.Image = Button[8];
                anzahlSchwarz--;
            }
            else if (anzahlWeiß > 0)
            {
                reihe[aktuelleReihe].stift2.Image = Button[7];
                anzahlWeiß--;
            }

            if (anzahlSchwarz > 0)
            {
                reihe[aktuelleReihe].stift3.Image = Button[8];
                anzahlSchwarz--;
            }
            else if (anzahlWeiß > 0)
            {
                reihe[aktuelleReihe].stift3.Image = Button[7];
                anzahlWeiß--;
            }

            if (anzahlSchwarz > 0)
            {
                reihe[aktuelleReihe].stift4.Image = Button[8];
                anzahlSchwarz--;
            }
            else if (anzahlWeiß > 0)
            {
                reihe[aktuelleReihe].stift4.Image = Button[7];
                anzahlWeiß--;
            }

        }
        void restart()
        {
            Process MeinProcess = new Process();
            MeinProcess.StartInfo.FileName = Application.ExecutablePath;
            MeinProcess.Start();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
            if (reihe[aktuelleReihe].stecker1.Image != Button[6] && reihe[aktuelleReihe].stecker2.Image != Button[6] && reihe[aktuelleReihe].stecker3.Image != Button[6] && reihe[aktuelleReihe].stecker4.Image != Button[6])
            {
                if (aktuelleReihe < 6)
                {
                    ÜberprüfeVorkommen();
                    if (reihe[aktuelleReihe].stift1.Image == Button[8] && reihe[aktuelleReihe].stift2.Image == Button[8] && reihe[aktuelleReihe].stift3.Image == Button[8] && reihe[aktuelleReihe].stift4.Image == Button[8])
                    {
                        if (MessageBox.Show("You have won! Would you try again?", "Win!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            this.button1_Click_1(this, new EventArgs());
                        }
                    }
                    else
                    {
                        NeueReihe();
                    }
                }
                else
                {
                    ÜberprüfeVorkommen();
                    MessageBox.Show("You have lost!");

                    NeueReihe();
                    reihe[aktuelleReihe].label1.Show();
                    reihe[aktuelleReihe].stecker1.Image = GegnerFarbreihe[0];
                    reihe[aktuelleReihe].stecker2.Image = GegnerFarbreihe[1];
                    reihe[aktuelleReihe].stecker3.Image = GegnerFarbreihe[2];
                    reihe[aktuelleReihe].stecker4.Image = GegnerFarbreihe[3];
                    StartButton.Hide();
                    panel1.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Please set up all plugs first!");
            }

        }
        void FarbeZuordnen(int ButtonWert)
        {
            if (radioButton4.Checked)
            {
                reihe[aktuelleReihe].stecker4.Image = Button[ButtonWert];
                radioButton1.Checked = true;
            }
            else if (radioButton3.Checked)
            {
                reihe[aktuelleReihe].stecker3.Image = Button[ButtonWert];
                radioButton4.Checked = true;
            }
            else if (radioButton2.Checked)
            {
                reihe[aktuelleReihe].stecker2.Image = Button[ButtonWert];
                radioButton3.Checked = true;
            }
            else if (radioButton1.Checked)
            {
                reihe[aktuelleReihe].stecker1.Image = Button[ButtonWert];
                radioButton2.Checked = true;
            }
        }
        private void stecker1_Click(object sender, EventArgs e)
        {
            FarbeZuordnen(0);
        }
        private void stecker2_Click(object sender, EventArgs e)
        {
            FarbeZuordnen(1);
        }
        private void stecker3_Click(object sender, EventArgs e)
        {
            FarbeZuordnen(2);
        }
        private void stecker4_Click(object sender, EventArgs e)
        {
            FarbeZuordnen(3);
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FarbeZuordnen(4);
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FarbeZuordnen(5);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            StartButton.Show();
            panel1.Enabled = true;

            for (int i = 0; i < 8; i++)
            {
                if (reihe[i] == null)
                {
                    break;
                }

                reihe[i].stecker1.Image = null;
                reihe[i].stecker2.Image = null;
                reihe[i].stecker3.Image = null;
                reihe[i].stecker4.Image = null;
                reihe[i].stift1.Image = null;
                reihe[i].stift2.Image = null;
                reihe[i].stift3.Image = null;
                reihe[i].stift4.Image = null;
            }
            reihe[7].label1.Hide();
            SetGegnerReihe();
            aktuelleReihe = -1;
            NeueReihe();
        }
    }
}