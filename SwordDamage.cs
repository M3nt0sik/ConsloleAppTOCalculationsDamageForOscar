using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsloleAppTOCalculationsDamageForOscar
{
    internal class SwordDamage
    {
        public const int BaseDamage = 3;
        public const int FlameDamage = 2;
        private int roll;

        public int Roll
        {
            get { return roll; }
            set 
            { 
                roll = value;
                CalculateDamage();                
            }
        }
        public decimal MagicMultipler = 1M;
        public int FlamingDamage = 0;
        public int Damage;

        public void CalculateDamage()
        {
            Damage = (int)(Roll * MagicMultipler) + BaseDamage + FlamingDamage;
        }
        public void SetMagic(bool isMagic)
        {
            if (isMagic)
            {
                MagicMultipler = 1.75M;
            }
            else
            {
                MagicMultipler = 1M;

            }
            CalculateDamage();
        }
        public void SetFlamingDamage(bool isFlaming)
        {
            CalculateDamage();
            if (isFlaming)
            {
                Damage += FlameDamage;
            }
        }
    }

}
