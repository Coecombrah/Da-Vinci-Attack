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
    public static class VariableStorage
    {
        public static int MonsterToBattle = 0;
        public static float Levens = 999999999;
        public static float Geld = 0;
        public static float SPK = 1;
        public static float AantalKeerGeklikt = 0;
        public static float AantalWapen1 = 0;
        public static float AantalWapen2 = 0;
        public static float AantalWapen3 = 0;
        public static float Wapen1Prijs = Wapen1BasePrijs + AantalWapen1 * 1f;
        public static float Wapen2Prijs = Wapen2BasePrijs + AantalWapen2 * 1f;
        public static float Wapen3Prijs = Wapen3BasePrijs + AantalWapen3 * 1f;
        public static float Wapen1BasePrijs = 10;
        public static float Wapen2BasePrijs = 250;
        public static float Wapen3BasePrijs = 4000;
        public static Bitmap SlijmMonster = Properties.Resources.SlijmMonster;
        public static Bitmap ZombieMonster = Properties.Resources.ZombieMonster;
        public static Bitmap BalRogMonster = Properties.Resources.BalrogMonster;

    }
}
