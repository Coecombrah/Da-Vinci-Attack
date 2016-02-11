using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Da_Vinci_Attack
{
    public class CheckEnemy
    {
        public void kraanvis()
        {
            if (VariableStorage.MonsterToBattle == 1)
            {
                if (VariableStorage.Levens == 999999999)
                {
                    VariableStorage.Levens = 10;
                    VariableStorage.Levens -= VariableStorage.SPK;
                }
                else if (VariableStorage.Levens <= 1)
                {
                    VariableStorage.Geld += 1;
                    VariableStorage.Levens = 10;

                    //Form1.MonsterTimerPublic.Value = 0;
                }
                else
                {
                    VariableStorage.Levens -= VariableStorage.SPK;
                }
                if (VariableStorage.Levens <= 0)
                {
                    VariableStorage.Levens = 0;
                }
            }
            else if (VariableStorage.MonsterToBattle == 2)
            {
                if (VariableStorage.Levens == 999999999)
                {
                    VariableStorage.Levens = 300;
                    VariableStorage.Levens -= VariableStorage.SPK;
                }
                else if (VariableStorage.Levens <= 1)
                {
                    VariableStorage.Geld += 50;
                    VariableStorage.Levens = 300;

                    //Form1.MonsterTimerPublic.Value = 0;
                }
                else
                    VariableStorage.Levens -= VariableStorage.SPK;
                if (VariableStorage.Levens <= 0)
                {
                    VariableStorage.Levens = 0;
                }
            }
            else if (VariableStorage.MonsterToBattle == 3)
            {
                if (VariableStorage.Levens == 999999999)
                {
                    VariableStorage.Levens = 7500;
                    VariableStorage.Levens -= VariableStorage.SPK;
                }
                else if (VariableStorage.Levens <= 1)
                {
                    VariableStorage.Geld += 2000;
                    VariableStorage.Levens = 7500;
                   
                    //Form1.MonsterTimerPublic.Value = 0;
                }
                else
                    VariableStorage.Levens -= VariableStorage.SPK;
                if (VariableStorage.Levens <= 0)
                {
                    VariableStorage.Levens = 0;
                }
            }
        }
    }
}
