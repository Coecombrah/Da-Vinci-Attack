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
        Bitmap SlijmMonster = Properties.Resources.SlijmMonster;
        Bitmap ZombieMonster = Properties.Resources.ZombieMonster;
        Bitmap BalRogMonster = Properties.Resources.BalrogMonster;
        public float Levens = 999999999;


        //klik en geld variabelen
        public float Geld = 0;
        public float SPK = 1;
        float AantalKeerGeklikt = 0;


        //wapens variabelen
        float AantalWapen1 = 0;
        float AantalWapen2 = 0;
        float Wapen1Prijss = 10;
        float Wapen2Prijss = 250;

        public Form1()
        {
            ///???????????????
            ///Waarom kan dit wel hier maar niet hier boven?????
            ///???????????????
            float Wapen1Prijs = Wapen1Prijss + AantalWapen1 * 1.20f;
            float Wapen2Prijs = Wapen2Prijss + AantalWapen2 * 1.20f;


            InitializeComponent();

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
            Text_Wapen1.Hide();
            Text_Wapen2.Hide();
            Text_Wapen3.Hide();
            Text_Wapen4.Hide();
            Picbox_balrog.Hide();
            Lbl_Wapen1Prijs.Hide();
            Lbl_Wapen2Prijs.Hide();
            Lbl_Wapen3Prijs.Hide();
            Lbl_Wapen4Prijs.Hide();
        }

       

        private void Btn_StartGame_Click(object sender, EventArgs e)
        {
            //Picbox_StartScreen.BackgroundImage = null;
            Btn_StartGame.Hide();
            richTextBox1.Show();
            Btn_StartGame2.Show();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBox1.Hide();
        }

        private void Btn_StartGame2_Click(object sender, EventArgs e)
        {
            Btn_StartGame2.Hide();
            richTextBox1.Hide();
            Picbox_StartScreen.BackgroundImage = Properties.Resources.StartMenuScreen;
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

        private void Picbox_Kluisjes_Click(object sender, EventArgs e)
        {
            ///????????????????????
            /// Hoe krijg ik de Picbox_terug en de Text_Kluisjes transparant met het achtergrond plaatje?
            ///????????????????????
            float Wapen1Prijs = Wapen1Prijss + AantalWapen1 * 1.20f;
            float Wapen2Prijs = Wapen2Prijss + AantalWapen2 * 1.20f;


            Picbox_StartScreen.BackgroundImage = Properties.Resources.KluisjesScreen;
            Picbox_ValAan.Hide();
            Picbox_Kluisjes.Hide();
            Picbox_Terug.Show();
            Text_Kluisjes.Show();
            Picbox_Wapen1.Show();
            Picbox_Wapen2.Show();
            Picbox_Wapen3.Show();
            Picbox_Wapen4.Show();
            Text_Wapen1.Show();
            Text_Wapen2.Show();
            Text_Wapen3.Show();
            Text_Wapen4.Show();
            Lbl_Wapen1Prijs.Show();
            Lbl_Wapen2Prijs.Show();
            Lbl_Wapen3Prijs.Show();
            Lbl_Wapen4Prijs.Show();
            Lbl_Wapen1Prijs.Text = string.Format("{0}$", Wapen1Prijs);
            Lbl_Wapen2Prijs.Text = string.Format("{0}$", Wapen2Prijs);
        }

        private void Picbox_Terug_Click(object sender, EventArgs e)
        {
            if (Picbox_Slijm.Visible || Text_Kluisjes.Visible)
            {
                Text_Wapen1.Hide();
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
                TimeBar.Hide();
                Lbl_Wapen1Prijs.Hide();
                Lbl_Wapen2Prijs.Hide();
                Lbl_Wapen3Prijs.Hide();
                Lbl_Wapen4Prijs.Hide();
                Picbox_balrog.Hide();
            } else {
                Lbl_Kliks.Hide();
                TimeBar.Value = 0;
                Picbox_balrog.Show();
                label3.Hide();
                label4.Hide();
                Lbl_Levens.Hide();
                Lbl_tijd.Hide();
                TimeBar.Hide();
                Picbox_StartScreen.BackgroundImage = Properties.Resources.StartMenuScreen;
                Picbox_ValAan.Hide();
                Picbox_Kluisjes.Hide();
                Picbox_Terug.Show();
                Picbox_Slijm.Show();
                Picbox_zombie.Show();
                Picbox_enemy.Hide();
                Levens = 999999999;
    }
            Picbox_StartScreen.BackgroundImage = Properties.Resources.StartMenuScreen;
            Picbox_Wapen1.Hide();
            Picbox_Wapen2.Hide();
            Picbox_Wapen3.Hide();
            Picbox_Wapen4.Hide();
        }

        private void Picbox_ValAan_Click(object sender, EventArgs e)
        {
            Picbox_StartScreen.BackgroundImage = Properties.Resources.StartMenuScreen;
            Picbox_ValAan.Hide();
            Picbox_Kluisjes.Hide();
            Picbox_Terug.Show();
            Picbox_Slijm.Show();
            Picbox_zombie.Show();
            Picbox_balrog.Show();
        }



        private void Picbox_Slijm_Click(object sender, EventArgs e)
        {
            Picbox_StartScreen.BackgroundImage = Properties.Resources.SlijmVeld;
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

        private void Picbox_zombie_Click(object sender, EventArgs e)
        {
            Picbox_StartScreen.BackgroundImage = Properties.Resources.ZombieVeld;
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

        private void Picbox_enemy_Click(object sender, EventArgs e)
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
                    Levens -= SPK;
                    TimeBar.Value = 0;
                }
                else
                {
                    Levens -= SPK;
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
                    Levens -= SPK;
                    TimeBar.Value = 0;
                }
                else
                    Levens -= SPK;
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
                    Levens -= SPK;
                    TimeBar.Value = 0;
                }
                else
                    Levens -= SPK;
            }


            Lbl_Kliks.Text = string.Format("{0}", AantalKeerGeklikt);
            Lbl_Levens.Text = string.Format("{0}", Levens);
            Lbl_Geld.Text = string.Format("{0}$", Geld);
        }

        private void Picbox_StartScreen_Click(object sender, EventArgs e)
        {

        }

        private void Picbox_wapen1_Click(object sender, EventArgs e)
        {
            float Wapen1Prijs = Wapen1Prijss + AantalWapen1 * 1.20f;

            if (Geld >= Wapen1Prijs)
            {
                Geld -= Wapen1Prijs;
                SPK += 1;
                AantalWapen1 += 1;
                Lbl_Geld.Text = string.Format("{0}$", Geld);
                Lbl_SPK.Text = string.Format("{0} Schade", SPK);
                Lbl_Wapen1Prijs.Text = string.Format("{0}$", Wapen1Prijs);
            } else
            {
                MessageBox.Show("Je hebt $" + Wapen1Prijs + " nodig voor deze potloden! :c");
            }
        }

        private void Btn_GratisGeld_Click(object sender, EventArgs e)
        {
            Geld += 1000;
            Lbl_Geld.Text = string.Format("{0}$", Geld);
        }

        private void Picbox_balrog_Click(object sender, EventArgs e)
        {
            Picbox_StartScreen.BackgroundImage = Properties.Resources.BalrogVeld;
            Picbox_enemy.Image = BalRogMonster;
            Picbox_zombie.Hide();
            Picbox_Slijm.Hide();
            Picbox_balrog.Hide();
            Picbox_enemy.Show();
            Lbl_tijd.Show();
            TimeBar.Show();
            Lbl_Levens.Show();
            label4.Show();

            MonsterTimer.Enabled = true;
            MonsterTimer.Start();
            MonsterTimer.Interval = 1000;
            TimeBar.Maximum = 100;
            MonsterTimer.Tick += new EventHandler(timer1_Tick);
        }

        private void Picbox_Wapen2_Click(object sender, EventArgs e)
        {
            float Wapen2Prijs = Wapen2Prijss + AantalWapen2 * Wapen2Prijss / 100 * 20;

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
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (TimeBar.Value != 100)
            {
                TimeBar.Value++;
            }
            else
            {
                TimeBar.Value = 0;
                Levens = 7500;
            }
        }
    }
}
