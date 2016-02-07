using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Da_Vinci_Attack
{
    
    public partial class Form1 : Form
    {

        //monster zooi
        public PictureBox MyPictureBox
        {
            get
            {
                return Picbox_enemy;
            }
        }
        public Bitmap SlijmMonster = Properties.Resources.SlijmMonster;
        public Bitmap ZombieMonster = Properties.Resources.ZombieMonster;
        public Bitmap BalRogMonster = Properties.Resources.BalrogMonster;
        public float Levens = 999999999;

        public ProgressBar MonsterTimerPublic
        {
            get
            {
                return TimeBar;
            }
        }
        

        //klik en geld variabelen
        public float Geld = 0;
        public float SPK = 1;
        public float AantalKeerGeklikt = 0;


        //wapens variabelen
        public float AantalWapen1 = 0;
        public float AantalWapen2 = 0;
        public float AantalWapen3 = 0;
        public float Wapen1BasePrijs = 10;
        public float Wapen2BasePrijs = 250;
        public float Wapen3BasePrijs = 4000;

        
        
        
        //label
        public Label MyLabel
        {
            get
            {
                return Lbl_Levens;
            }
        }



        public Form1()
        {
            InitializeComponent();
            Lbl_Geld.BackColor = Color.Transparent;
            Lbl_SPK.BackColor = Color.Transparent;
            Lbl_Levens.Text = string.Format("{0}", Levens);
            Lbl_Kliks.Text = string.Format("{0}", AantalKeerGeklikt);
            richTextBox1.Hide();
            Btn_StartGame2.Hide();
            Picbox_ValAan.Hide();
            Picbox_Kluisjes.Hide();
            Picbox_ValAan.BringToFront();
            Picbox_Kluisjes.BringToFront();
            label1.Hide();
            label2.Hide();
            Lbl_Geld.Hide();
            Lbl_SPK.Hide();
            Picbox_Terug.Hide();
            Picbox_zombie.Hide();
            Picbox_Slijm.Hide();
            Text_Kluisjes.Hide();
            Picbox_enemy.Hide();
            TimeBar.Hide();
            Lbl_tijd.Hide();
            label3.Hide();
            Lbl_Kliks.Hide();
            Lbl_Levens.Hide();
            Picbox_Wapen1.Hide();
            Picbox_Wapen2.Hide();
            Picbox_Wapen3.Hide();
            Picbox_Wapen4.Hide();
            label4.Hide();
            label5.Hide();
            Text_Wapen2.Hide();
            Text_Wapen3.Hide();
            Text_Wapen4.Hide();
            Picbox_balrog.Hide();
            Lbl_Wapen1Prijs.Hide();
            Lbl_Wapen2Prijs.Hide();
            Lbl_Wapen3Prijs.Hide();
            Lbl_Wapen4Prijs.Hide();
        }

       

        public void Btn_StartGame_Click(object sender, EventArgs e)
        {
            //Picbox_StartScreen.BackgroundImage = null;
            Btn_StartGame.Hide();
            richTextBox1.Show();
            Btn_StartGame2.Show();
            BackgroundImage = Properties.Resources.StartMenuScreen;

        }

        public void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBox1.Hide();
        }

        public void Btn_StartGame2_Click(object sender, EventArgs e)
        {
            Btn_StartGame2.Hide();
            richTextBox1.Hide();
            Picbox_StartScreen.BackgroundImage = Properties.Resources.StartMenuScreen;
            BackgroundImage = Properties.Resources.StartMenuScreen;
            Picbox_ValAan.Show();
            Picbox_Kluisjes.Show();
            label1.Show();
            label2.Show();
            Lbl_Geld.Show();
            Lbl_SPK.Show();
            Lbl_Geld.Text = string.Format("{0}$", Geld);
            Lbl_SPK.Text = string.Format("{0} Schade", SPK);
            //Picbox_PlayScreen.Show();
        }

        public void Picbox_Kluisjes_Click(object sender, EventArgs e)
        {
            ///????????????????????
            /// waarom kan dit niet hierboven?
            ///????????????????????
            float Wapen1Prijs = Wapen1BasePrijs + AantalWapen1 * 1f;
            float Wapen2Prijs = Wapen2BasePrijs + AantalWapen2 * 20f;
            float Wapen3Prijs = Wapen3BasePrijs + AantalWapen3 * 350f;


            BackgroundImage = Properties.Resources.KluisjesScreen;
            Picbox_StartScreen.BackgroundImage = Properties.Resources.KluisjesScreen;
            Picbox_ValAan.Hide();
            Picbox_Kluisjes.Hide();
            Picbox_Terug.Show();
            Text_Kluisjes.Show();
            Picbox_Wapen1.Show();
            Picbox_Wapen2.Show();
            Picbox_Wapen3.Show();
            Picbox_Wapen4.Show();
            label5.Show();
            Text_Wapen2.Show();
            Text_Wapen3.Show();
            Text_Wapen4.Show();
            Lbl_Wapen1Prijs.Show();
            Lbl_Wapen2Prijs.Show();
            Lbl_Wapen3Prijs.Show();
            Lbl_Wapen4Prijs.Show();
            Lbl_Wapen1Prijs.Text = string.Format("{0}$", Wapen1Prijs);
            Lbl_Wapen2Prijs.Text = string.Format("{0}$", Wapen2Prijs);
            Lbl_Wapen3Prijs.Text = string.Format("{0}$", Wapen3Prijs);
        }

        public void Picbox_Terug_Click(object sender, EventArgs e)
        {
            if (Picbox_Slijm.Visible || Text_Kluisjes.Visible)
            {
                BackgroundImage = Properties.Resources.StartMenuScreen;
                label5.Hide();
                Text_Wapen2.Hide();
                Text_Wapen3.Hide();
                Text_Wapen4.Hide();
                Picbox_ValAan.Show();
                Picbox_Kluisjes.Show();
                Picbox_Terug.Hide();
                Picbox_zombie.Hide();
                Picbox_Slijm.Hide();
                Text_Kluisjes.Hide();
                Picbox_enemy.Hide();
                Lbl_tijd.Hide();
                Lbl_Wapen1Prijs.Hide();
                Lbl_Wapen2Prijs.Hide();
                Lbl_Wapen3Prijs.Hide();
                Lbl_Wapen4Prijs.Hide();
                Picbox_balrog.Hide();
            } else {
                BackgroundImage = Properties.Resources.StartMenuScreen;
                Lbl_Kliks.Hide();
                Picbox_balrog.Show();
                label3.Hide();
                label4.Hide();
                Lbl_Levens.Hide();
                Lbl_tijd.Hide();
                Picbox_StartScreen.BackgroundImage = Properties.Resources.StartMenuScreen;
                Picbox_ValAan.Hide();
                Picbox_Kluisjes.Hide();
                Picbox_Terug.Show();
                Picbox_Slijm.Show();
                Picbox_zombie.Show();
                Picbox_enemy.Hide();
                Levens = 999999999;
             }
            TimeBar.Hide();
            TimeBar.Value = 0;
            TimeBar.Enabled = false;
            Picbox_StartScreen.BackgroundImage = Properties.Resources.StartMenuScreen;
            Picbox_Wapen1.Hide();
            Picbox_Wapen2.Hide();
            Picbox_Wapen3.Hide();
            Picbox_Wapen4.Hide();
        }

        public void Picbox_ValAan_Click(object sender, EventArgs e)
        {
            Picbox_StartScreen.BackgroundImage = Properties.Resources.StartMenuScreen;
            Picbox_ValAan.Hide();
            Picbox_Kluisjes.Hide();
            Picbox_Terug.Show();
            Picbox_Slijm.Show();
            Picbox_zombie.Show();
            Picbox_balrog.Show();
        }



        public void Picbox_Slijm_Click(object sender, EventArgs e)
        {
            if (MonsterTimer.Enabled == false)
            {
                MonsterTimer.Enabled = true;
                MonsterTimer.Start();
                MonsterTimer.Interval = 1000;
                TimeBar.Maximum = 50;
                MonsterTimer.Tick += new EventHandler(timer1_Tick);
            }
            else
            {

            }

            Levens = 10;
            Lbl_Levens.Text = string.Format("{0}", Levens);

            Picbox_StartScreen.BackgroundImage = Properties.Resources.SlijmVeld;
            BackgroundImage = Properties.Resources.SlijmVeld;
            Picbox_enemy.Image = SlijmMonster;
           // Picbox_enemy = Levens(10);
            Picbox_Slijm.Hide();
            Picbox_zombie.Hide();
            Picbox_balrog.Hide();
            Picbox_enemy.Show();
            Lbl_tijd.Show();
            TimeBar.Show();
            Lbl_Levens.Show();
            label4.Show();
        }

        public void Picbox_zombie_Click(object sender, EventArgs e)
        {
            if (MonsterTimer.Enabled == false)
            {
                MonsterTimer.Enabled = true;
                MonsterTimer.Start();
                MonsterTimer.Interval = 1000;
                TimeBar.Maximum = 50;
                MonsterTimer.Tick += new EventHandler(timer1_Tick);
            } else {

            }


            Levens = 300;
            Lbl_Levens.Text = string.Format("{0}", Levens);

            Picbox_StartScreen.BackgroundImage = Properties.Resources.ZombieVeld;
            BackgroundImage = Properties.Resources.ZombieVeld;
            Picbox_enemy.Image = ZombieMonster;
            Picbox_zombie.Hide();
            Picbox_Slijm.Hide();
            Picbox_balrog.Hide();
            Picbox_enemy.Show();
            Lbl_tijd.Show();
            TimeBar.Show();
            Lbl_Levens.Show();
            label4.Show();
        }

        public void Picbox_enemy_Click(object sender, EventArgs e)
        {

            Lbl_Levens.Show();
            label4.Show();
            AantalKeerGeklikt++;
            label3.Show();
            Lbl_Kliks.Show();
            if (Picbox_enemy.Image == SlijmMonster)
            {
                if (Levens == 999999999)
                {
                    Levens = 10;
                    Levens -= SPK;
                }
                else if (Levens <= 1)
                {
                    Geld += 1;
                    Levens = 10;
                    TimeBar.Value = 0;
                }
                else
                {
                    Levens -= SPK;
                }
                     if (Levens <= 0)
                     {
                         Levens = 0;
                      }
            } else if (Picbox_enemy.Image == ZombieMonster)
            {
                if (Levens == 999999999)
                {
                    Levens = 300;
                    Levens -= SPK;
                }
                else if (Levens <= 1)
                {
                    Geld += 50;
                    Levens = 300;
                    TimeBar.Value = 0;
                }
                else
                    Levens -= SPK;
                     if (Levens <= 0)
                      {
                         Levens = 0;
                     }
            } else if (Picbox_enemy.Image == BalRogMonster)
            {
                if (Levens == 999999999)
                {
                    Levens = 7500;
                    Levens -= SPK;
                }
                else if (Levens <= 1)
                {
                    Geld += 2000;
                    Levens = 7500;
                    TimeBar.Value = 0;
                    Lbl_Levens.Text = string.Format("{0}", Levens);
                }
                else
                    Levens -= SPK;
                    if(Levens <= 0)
                     {
                         Levens = 0;
                     }
            }

            Picbox_enemy.Refresh();
            Lbl_Kliks.Text = string.Format("{0}", AantalKeerGeklikt);
            Lbl_Levens.Text = string.Format("{0}", Levens);
            Lbl_Geld.Text = string.Format("{0}$", Geld);
        }

        public void Picbox_StartScreen_Click(object sender, EventArgs e)
        {

        }

        public void Picbox_wapen1_Click(object sender, EventArgs e)
        {

            float Wapen1Prijs = Wapen1BasePrijs + AantalWapen1 * 1f;

            if (Geld >= Wapen1Prijs)
            {
                SPK += 1;
                AantalWapen1 += 1;
                Lbl_Geld.Text = string.Format("{0}$", Geld);
                Lbl_SPK.Text = string.Format("{0} Schade", SPK);
                Geld -= Wapen1Prijs;
            } else
            {
                MessageBox.Show("Je hebt $" + Wapen1Prijs + " nodig voor deze potloden! :c");
            }
            Lbl_Wapen1Prijs.Text = string.Format("{0}$", Wapen1Prijs);
        }

        public void Btn_GratisGeld_Click(object sender, EventArgs e)
        {
            Geld += 100000;
            Lbl_Geld.Text = string.Format("{0}$", Geld);
        }

        public void Picbox_balrog_Click(object sender, EventArgs e)
        {
            if (MonsterTimer.Enabled == false)
            {
                MonsterTimer.Enabled = true;
                MonsterTimer.Start();
                MonsterTimer.Interval = 1000;
                TimeBar.Maximum = 50;
                MonsterTimer.Tick += new EventHandler(timer1_Tick);
            }
            else
            {

            }

            Levens = 7500;
            Lbl_Levens.Text = string.Format("{0}", Levens);

            Picbox_StartScreen.BackgroundImage = Properties.Resources.BalrogVeld;
            BackgroundImage = Properties.Resources.BalrogVeld;
            Picbox_enemy.Image = BalRogMonster;
            Picbox_zombie.Hide();
            Picbox_Slijm.Hide();
            Picbox_balrog.Hide();
            Picbox_enemy.Show();
            Lbl_tijd.Show();
            TimeBar.Show();
            Lbl_Levens.Show();
            label4.Show();
        }

        public void Picbox_Wapen2_Click(object sender, EventArgs e)
        {
            float Wapen2Prijs = Wapen2BasePrijs + AantalWapen2 * 20f;

            if (Geld >= Wapen2Prijs)
            {
                Geld -= Wapen2Prijs;
                SPK += 20;
                AantalWapen2 += 1;
                Lbl_Geld.Text = string.Format("{0}$", Geld);
                Lbl_SPK.Text = string.Format("{0} Schade", SPK);
                Lbl_Wapen2Prijs.Text = string.Format("{0}$", Wapen2Prijs);
            }
            else
            {
                MessageBox.Show("Je hebt $" + Wapen2Prijs + " nodig voor dit houten zwaard! :c");
            }
            Lbl_Wapen2Prijs.Text = string.Format("{0}$", Wapen2Prijs);
        }

        public void timer1_Tick(object sender, EventArgs e)
        {
            if (TimeBar.Value != 50)
            {
                TimeBar.Value++;
            }
            else
            {
                TimeBar.Value = 0;
                if (Picbox_enemy.Image == SlijmMonster)
                {
                    Levens = 10;
                }
                else if (Picbox_enemy.Image == ZombieMonster)
                {
                    Levens = 300;
                }
                else if (Picbox_enemy.Image == BalRogMonster)
                {
                    Levens = 7500;
                }
            }
        }

        public void Picbox_Wapen3_Click(object sender, EventArgs e)
        {
            float Wapen3Prijs = Wapen3BasePrijs + AantalWapen3 * 350f;

            if (Geld >= Wapen3Prijs)
            {
                Geld -= Wapen3Prijs;
                SPK += 250;
                AantalWapen3 += 1;
                Lbl_Geld.Text = string.Format("{0}$", Geld);
                Lbl_SPK.Text = string.Format("{0} Schade", SPK);
                Lbl_Wapen3Prijs.Text = string.Format("{0}$", Wapen3Prijs);
            }
            else
            {
                MessageBox.Show("Je hebt $" + Wapen3Prijs + " nodig voor deze snijert.");
            }
            Lbl_Wapen3Prijs.Text = string.Format("{0}$", Wapen3Prijs);
        }

        public void button1_Click(object sender, EventArgs e)
        {
        }
    }
}
