using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2Scripting
{
    
     abstract class Carta
    {
        internal string name;
        internal uint costPoint;
        internal enum l_Rarity { Common, Rare, SuperRare, UltraRare };
        internal l_Rarity rarity;

        public Carta(string name, uint costPoint, l_Rarity rarity)
        {
            this.rarity = rarity;
            Name = name;
            CostPoint = costPoint;
        }

        protected string Name
        {
            get => name;

            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value) || value.Length < 5)
                {
                    throw new Exception("el nombre no puede tener espacios en blanco  ");
                }
                else
                {
                    Name = value;
                }

            }
        }
        internal uint CostPoint { get => costPoint; set
            {
                if (value > 0) costPoint = value;
                else throw new Exception("no puede ser el CostPoint 0 o inferior   ");
            }
                
                
                
         }
    }
}
