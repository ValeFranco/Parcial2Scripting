using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2Scripting
{
    class Equip : Carta
    {
        public string CartaDueno = "";
        public enum l_targetAttribute {AP, RP, ALL};
        public enum l_affinity {Knight, Mage, Undead, ALL};
        public l_affinity Affinity;
        public l_targetAttribute targetAttribute;
        internal uint effectPoints;

        public Equip(string name, uint costPoint, l_Rarity rarity, l_affinity affinity, l_targetAttribute targetAttribute, uint effectPoints) : base(name, costPoint, rarity)
        {
            Affinity = affinity;
            this.targetAttribute = targetAttribute;
            this.effectPoints = effectPoints;
        }
        public override void afinidad()
        {

        }
    }
}
