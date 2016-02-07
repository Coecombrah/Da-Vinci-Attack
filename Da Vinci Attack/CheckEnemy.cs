using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Da_Vinci_Attack
{
    public partial class CheckEnemy : Form1
    {
        public void kraanvis(string[] args)
        {
            if (MyPictureBox.Image == SlijmMonster)
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
                    MonsterTimerPublic.Value = 0;
                }
                else
                {
                    Levens -= SPK;
                }
                if (Levens <= 0)
                {
                    Levens = 0;
                }
            }
            else if (MyPictureBox.Image == ZombieMonster)
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
                    MonsterTimerPublic.Value = 0;
                }
                else
                    Levens -= SPK;
                if (Levens <= 0)
                {
                    Levens = 0;
                }
            }
            else if (MyPictureBox.Image == BalRogMonster)
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
                    MonsterTimerPublic.Value = 0;
                    MyLabel.Text = string.Format("{0}", Levens);
                }
                else
                    Levens -= SPK;
                if (Levens <= 0)
                {
                    Levens = 0;
                }
            }
        }
    }
}
