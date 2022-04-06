using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2Scripting
{
    public class Equip : Carta
    {
        public string CartaDueno = "";
        public enum l_targetAttribute {AP, RP, ALL};
        public enum l_affinity {Knight, Mage, Undead, ALL};
        internal l_affinity affinity;
        internal l_targetAttribute targetAttribute;
        internal int effectPoints;
        public bool aplicada=false;

        public Equip(string name, int costPoint, l_Rarity rarity, l_affinity affinity, l_targetAttribute targetAttribute, int effectPoints) : base(name, costPoint, rarity)
        {
            this.affinity = affinity;
            this.targetAttribute = targetAttribute;
            this.effectPoints = effectPoints;
        }

        
    }
}
