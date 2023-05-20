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
        /// <summary>
        /// Wczytuje do zmiennej roll wartosc rzutu kostką
        /// </summary>
        /// <param name="Roll">Liczba wyrzuconych oczek np 16</param>
        public SwordDamage(int Roll)
        {
            roll = Roll;
        }

        //public decimal MagicMultipler = 1M;
        //public int FlamingDamage = 0;
        //public int Damage;

        private void CalculateDamage()
        {
            Damage = (int)(this.Roll * this.Magic) + BaseDamage + this.Flaming;
        }
        /// <summary>
        /// Propertis to magic damage
        /// </summary>
        /// <remarks>
        /// Getter returns value value of multiply by magic damage
        /// 
        /// Setter assigns new value to magic multipler and calculate damage 
        /// </remarks>
        public int Magic
        {
            get { return magic; }
            set
            {
                magic = value;
                CalculateDamage();

            }
        }
        /// <summary>
        /// Propertis for flaming damage
        /// </summary>
        /// <remarks>
        /// Getter renturns value fire damage 
        /// 
        /// Setter assign new value to fire damage and calclate damage
        /// </remarks>
        public int Flaming 
        {
            get { return flaming; }
            set
            {
                flaming = value;
                CalculateDamage();
            } 
        }
        /// <summary>
        /// Propertis returns damage
        /// </summary>
        /// <remarks>
        /// Getter renturns value fire damage 
        /// </remarks>
        public int Damage { get; private set; }
        /// <summary>
        /// Propertis for sets new value of roll
        /// </summary>
        /// <remarks>
        /// Getter renturns value roll
        /// 
        /// Setter assign new value to roll and calclate damage
        /// </remarks>
        public int Roll
        {
            get { return roll; }
            set
            {
                roll = value;
                CalculateDamage();
            }
        }
    }

}
