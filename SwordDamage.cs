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
        private int flaming;
        private int magic;

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
        
        public int Magic
        {
            get { return magic; }
            set
            {
                magic = value;
                CalculateDamage();

            }
        }
        public int Flaming 
        {
            get { return flaming; }
            set
            {
                flaming = value;
                CalculateDamage();
            } 
        }
    }

}
