using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tictactoeAI
{
    public partial class Form1 : Form
    {
        Random rand = new Random();
        String testZapis = "";
        int randomNum;
        int[] plansza = new int[] {0,0,0,0,0,0,0,0,0};
        String planszaZapis = "";
        int tura = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void pole1_Click(object sender, EventArgs e)
        {
            if (tura == 1)
            {
                if (plansza[0] == 0)
                {
                    pole1.Image = Properties.Resources.o;
                }
                plansza[0] = 1;
                if (tura < 3)
                {
                    turaKomputera();
                }
                else
                {
                    button1.Visible = true;
                }
            }
        }

        private void pole2_Click(object sender, EventArgs e)
        {
            if (tura == 1)
            {
                if (plansza[1] == 0)
                {
                    pole2.Image = Properties.Resources.o;
                }
                plansza[1] = 1;
                if (tura < 3)
                {
                    turaKomputera();
                }
                else
                {                    
                    button1.Visible = true;
                }
            }
        }

        private void pole3_Click(object sender, EventArgs e)
        {
            if (tura == 1)
            {
                if (plansza[2] == 0)
                {
                    pole3.Image = Properties.Resources.o;
                }
                plansza[2] = 1;
                if (tura < 3)
                {
                    turaKomputera();
                }
                else
                {
                    button1.Visible = true;
                }
            }
        }

        private void pole4_Click(object sender, EventArgs e)
        {
            if (tura == 1)
            {
                if (plansza[3] == 0)
                {
                    pole4.Image = Properties.Resources.o;
                }
                plansza[3] = 1;
                if (tura < 3)
                {
                    turaKomputera();
                }
                else
                {
                    button1.Visible = true;
                }
            }
        }

        private void pole5_Click(object sender, EventArgs e)
        {
            if (tura == 1)
            {
                if (plansza[4] == 0)
                {
                    pole5.Image = Properties.Resources.o;
                }
                plansza[4] = 1;
                if (tura < 3)
                {
                    turaKomputera();
                }
                else
                {
                    button1.Visible = true;
                }
            }
        }

        private void pole6_Click(object sender, EventArgs e)
        {
            if (tura == 1)
            {
                if (plansza[5] == 0)
                {
                    pole6.Image = Properties.Resources.o;
                }
                plansza[5] = 1;
                if (tura < 3)
                {
                    turaKomputera();
                }
                else
                {
                    button1.Visible = true;
                }
            }
        }

        private void pole7_Click(object sender, EventArgs e)
        {
            if (tura == 1)
            {
                if (plansza[6] == 0)
                {
                    pole7.Image = Properties.Resources.o;
                }
                plansza[6] = 1;
                if (tura < 3)
                {
                    turaKomputera();
                }
                else
                {
                    button1.Visible = true;
                }
            }
        }

        private void pole8_Click(object sender, EventArgs e)
        {
            if (tura == 1)
            {
                if (plansza[7] == 0)
                {
                    pole8.Image = Properties.Resources.o;
                }
                plansza[7] = 1;
                if (tura < 3)
                {
                    turaKomputera();
                }
                else
                {
                    button1.Visible = true;
                }
            }
        }

        private void pole9_Click(object sender, EventArgs e)
        {
            if (tura == 1)
            {
                if (plansza[8] == 0)
                {
                    pole9.Image = Properties.Resources.o;
                }
                plansza[8] = 1;                
                if (tura < 3)
                {
                    turaKomputera();
                }
            }
        }        

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!File.Exists("przegrana.txt"))
            {
                using (StreamWriter sw = File.CreateText("przegrana.txt"))
                {
                    sw.WriteLine("");
                }
            }
            if (!File.Exists("wygrana.txt"))
            {
                using (StreamWriter sw = File.CreateText("wygrana.txt"))
                {
                    sw.WriteLine("");
                }
            }
        }

        public void turaKomputera()
        {
            tura = 0;
            label3.Text = "Tura komputera.";
            do
            {
                randomNum = rand.Next(9);
            }
            while (plansza[randomNum] != 0);
            plansza[randomNum] = 2;
            switch (randomNum)
            {
                case 0:
                    pole1.Image= Properties.Resources.x;
                    break;
                case 1:
                    pole2.Image = Properties.Resources.x;
                    break;
                case 2:
                    pole3.Image = Properties.Resources.x;
                    break;
                case 3:
                    pole4.Image = Properties.Resources.x;
                    break;
                case 4:
                    pole5.Image = Properties.Resources.x;
                    break;
                case 5:
                    pole6.Image = Properties.Resources.x;
                    break;
                case 6:
                    pole7.Image = Properties.Resources.x;
                    break;
                case 7:
                    pole8.Image = Properties.Resources.x;
                    break;
                case 8:
                    pole9.Image = Properties.Resources.x;
                    break;
            }
            sprawdzWygrana();
            if (tura < 3)
            {
                label3.Text = "Tura gracza.";
                tura = 1;
            }
        }

        public void sprawdzWygrana()
        {
            testZapis = "";
            foreach (int x in plansza)
            {
                testZapis += x.ToString();
            }

            if(!testZapis.Contains("0"))
            {                
                label3.Text = "Remis";
                button1.Visible = true;
                tura = 5;
            }
            else
            {
                if (
                (plansza[0] == 1 && plansza[1] == 1 && plansza[2] == 1) ||
                (plansza[0] == 1 && plansza[4] == 1 && plansza[8] == 1) ||
                (plansza[1] == 1 && plansza[4] == 1 && plansza[7] == 1) ||
                (plansza[2] == 1 && plansza[4] == 1 && plansza[6] == 1) ||
                (plansza[3] == 1 && plansza[4] == 1 && plansza[5] == 1) ||
                (plansza[0] == 1 && plansza[3] == 1 && plansza[6] == 1) ||
                (plansza[2] == 1 && plansza[5] == 1 && plansza[8] == 1)
              )
                {
                    foreach (int x in plansza)
                    {
                        planszaZapis += x.ToString();
                    }
                    File.AppendAllText("przegrana.txt", planszaZapis + Environment.NewLine);              
                    label3.Text = "Wygrał gracz.";
                    button1.Visible = true;
                    tura=3;
                }

                if (
                    (plansza[0] == 2 && plansza[1] == 2 && plansza[2] == 2) ||
                    (plansza[0] == 2 && plansza[4] == 2 && plansza[8] == 2) ||
                    (plansza[1] == 2 && plansza[4] == 2 && plansza[7] == 2) ||
                    (plansza[2] == 2 && plansza[4] == 2 && plansza[6] == 2) ||
                    (plansza[3] == 2 && plansza[4] == 2 && plansza[5] == 2) ||
                    (plansza[0] == 2 && plansza[3] == 2 && plansza[6] == 2) ||
                    (plansza[2] == 2 && plansza[5] == 2 && plansza[8] == 2)
                  )
                {
                    foreach (int x in plansza)
                    {
                        planszaZapis += x.ToString();
                    }
                    File.AppendAllText("wygrana.txt", planszaZapis + Environment.NewLine);
                    label3.Text = "Wygrał komputer.";
                    button1.Visible = true;
                    tura =4;
                }
            }            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
