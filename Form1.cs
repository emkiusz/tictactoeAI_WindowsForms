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
        int randomNum;
        int[] plansza = new int[] {0,0,0,0,0,0,0,0,0};
        PictureBox[] poleGracza;
        String planszaZapis = "";
        int czyjaTura = 1;

        public Form1()
        {
            InitializeComponent();
            poleGracza = new PictureBox[] { pole1, pole2, pole3, pole4, pole5, pole6, pole7, pole8, pole9 };
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            planszaZapis = "";
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

        #region klikanie gracza
        private void pole1_Click(object sender, EventArgs e)
        {
            turaGracza(0);
        }

        private void pole2_Click(object sender, EventArgs e)
        {
            turaGracza(1);
        }

        private void pole3_Click(object sender, EventArgs e)
        {
            turaGracza(2);
        }

        private void pole4_Click(object sender, EventArgs e)
        {
            turaGracza(3);
        }

        private void pole5_Click(object sender, EventArgs e)
        {
            turaGracza(4);
        }

        private void pole6_Click(object sender, EventArgs e)
        {
            turaGracza(5);
        }

        private void pole7_Click(object sender, EventArgs e)
        {
            turaGracza(6);
        }

        private void pole8_Click(object sender, EventArgs e)
        {
            turaGracza(7);
        }

        private void pole9_Click(object sender, EventArgs e)
        {
            turaGracza(8);
        }
        #endregion

        #region tura komputera
        public void turaKomputera()
        {
            String tempLine = "";
            int kolejnyRuch=-1;
            int wygrana = -1;

            label3.Text = "Tura komputera.";

            if (czyjaTura < 3)
            {
                czyjaTura = 0;

                foreach (var line in File.ReadLines("przegrana.txt"))
                {
                    if (line != "")
                    {
                        //MessageBox.Show("Koniec gry: "+line.Substring(planszaZapis.Length, 1));
                        tempLine = line.Substring(0, planszaZapis.Length);
                        if (tempLine.Contains(planszaZapis.Substring(0, planszaZapis.Length)))
                        {
                            //MessageBox.Show("Mój następny ruch, aby nie przegrać: " + line.Substring(planszaZapis.Length+1, 1));
                            kolejnyRuch = int.Parse(line.Substring(planszaZapis.Length+1, 1));
                            wygrana = 0;
                            break;
                        }
                    }
                }

                if (wygrana != 0)
                {
                    foreach (var line in File.ReadLines("wygrana.txt"))
                    {
                        if (line != "")
                        {
                            tempLine = line.Substring(0, planszaZapis.Length);
                            if (tempLine.Contains(planszaZapis.Substring(0, planszaZapis.Length)))
                            {
                                //MessageBox.Show("Mój następny ruch, aby wygrać: " + line.Substring(planszaZapis.Length, 1));
                                kolejnyRuch = int.Parse(line.Substring(planszaZapis.Length, 1));
                                wygrana = 1;
                                break;
                            }
                        }
                    }
                }
                                
                if (wygrana == -1)
                {
                    do
                    {
                        randomNum = rand.Next(9);
                    }
                    while (plansza[randomNum] != 0);           
                }
                else
                {
                    randomNum = kolejnyRuch;
                }
                planszaZapis += randomNum;
                plansza[randomNum] = 2;
                switch (randomNum)
                {
                    case 0:
                        pole1.Image = Properties.Resources.x;
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
                if (czyjaTura < 3)
                {
                    label3.Text = "Tura gracza.";
                    czyjaTura = 1;
                }
            }
        }
        #endregion

        #region tura gracza
        public void turaGracza(int pole)
        {
            if (czyjaTura == 1)
            {
                if (plansza[pole] == 0)
                {
                    planszaZapis += pole;
                    poleGracza[pole].Image = Properties.Resources.o;
                    plansza[pole] = 1;
                    sprawdzWygrana();
                    if (czyjaTura < 3)
                    {
                        turaKomputera();
                    }
                }
            }
        }
        #endregion
        public void sprawdzWygrana()
        {
            String temp = "";
            foreach(int z in plansza)
            {
                temp += z.ToString();
            }
            if (!temp.Contains("0"))
            {
                if
                (
                    (plansza[0] == 1 && plansza[1] == 1 && plansza[2] == 1) ||
                    (plansza[0] == 1 && plansza[4] == 1 && plansza[8] == 1) ||
                    (plansza[1] == 1 && plansza[4] == 1 && plansza[7] == 1) ||
                    (plansza[2] == 1 && plansza[4] == 1 && plansza[6] == 1) ||
                    (plansza[3] == 1 && plansza[4] == 1 && plansza[5] == 1) ||
                    (plansza[0] == 1 && plansza[3] == 1 && plansza[6] == 1) ||
                    (plansza[2] == 1 && plansza[5] == 1 && plansza[8] == 1) ||
                    (plansza[6] == 1 && plansza[7] == 1 && plansza[8] == 1)
                )
                {
                    label3.Text = "Wygrał gracz.";
                    button1.Visible = true;
                    czyjaTura = 3;
                }
                else if
                (
                     (plansza[0] == 2 && plansza[1] == 2 && plansza[2] == 2) ||
                     (plansza[0] == 2 && plansza[4] == 2 && plansza[8] == 2) ||
                     (plansza[1] == 2 && plansza[4] == 2 && plansza[7] == 2) ||
                     (plansza[2] == 2 && plansza[4] == 2 && plansza[6] == 2) ||
                     (plansza[3] == 2 && plansza[4] == 2 && plansza[5] == 2) ||
                     (plansza[0] == 2 && plansza[3] == 2 && plansza[6] == 2) ||
                     (plansza[2] == 2 && plansza[5] == 2 && plansza[8] == 2) ||
                     (plansza[6] == 2 && plansza[7] == 2 && plansza[8] == 2)
                )
                {
                    label3.Text = "Wygrał komputer.";
                    button1.Visible = true;
                    czyjaTura = 4;
                }
                else
                {
                    label3.Text = "Remis";
                    button1.Visible = true;
                    czyjaTura = 5;
                }                    
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
                (plansza[2] == 1 && plansza[5] == 1 && plansza[8] == 1) ||
                (plansza[6] == 1 && plansza[7] == 1 && plansza[8] == 1)
              )
                {
                    if (planszaZapis.Length != 9)
                    {
                        int z = 0;
                        int temp2 = 9 - planszaZapis.Length;
                        while (z < temp2)
                        {
                            planszaZapis += "#";
                            z++;
                        }
                    }
                    File.AppendAllText("przegrana.txt", planszaZapis + Environment.NewLine);              
                    label3.Text = "Wygrał gracz.";
                    button1.Visible = true;
                    czyjaTura=3;
                }

                if (
                    (plansza[0] == 2 && plansza[1] == 2 && plansza[2] == 2) ||
                    (plansza[0] == 2 && plansza[4] == 2 && plansza[8] == 2) ||
                    (plansza[1] == 2 && plansza[4] == 2 && plansza[7] == 2) ||
                    (plansza[2] == 2 && plansza[4] == 2 && plansza[6] == 2) ||
                    (plansza[3] == 2 && plansza[4] == 2 && plansza[5] == 2) ||
                    (plansza[0] == 2 && plansza[3] == 2 && plansza[6] == 2) ||
                    (plansza[2] == 2 && plansza[5] == 2 && plansza[8] == 2) ||
                    (plansza[6] == 2 && plansza[7] == 2 && plansza[8] == 2)
                  )
                {                    
                    if(planszaZapis.Length!=9)
                    {
                        int z = 0;
                        int temp2 = 9 - planszaZapis.Length;
                        while(z<temp2)
                        {
                            planszaZapis += "#";
                            z++;
                        }
                    }
                    File.AppendAllText("wygrana.txt", planszaZapis + Environment.NewLine);
                    label3.Text = "Wygrał komputer.";
                    button1.Visible = true;
                    czyjaTura =4;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
