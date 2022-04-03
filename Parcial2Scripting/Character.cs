using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2Scripting
{
    class Character : Carta
    {
        private uint attackPoints;
        private uint resistPoints;
        internal List<Equip> equip;
        internal enum l_Afinity
        {
            Knight,
            Mage,
            Undead
        };
        internal l_Afinity afinity;

        public Character(string name, uint costPoint,l_Rarity rarity, uint attackPoints, uint resistPoints,  l_Afinity afinity): base(name, costPoint, rarity)
        {
            AttackPoints = attackPoints;
            ResistPoints = resistPoints;
            this.afinity = afinity;
            equip = new List<Equip>();
        }

        internal uint AttackPoints
        {
            get => attackPoints; set
            {
                if (value > 0) attackPoints = value;
                else throw new Exception("Los attackPoints no pueden ser menor a cero");
            }
        }
        internal uint ResistPoints
        {
            get => resistPoints; set
            {
                if (value > 0) resistPoints = value;
                else throw new Exception("Los resistPoints no pueden ser menor a cero");
            }
        }
        public override void afinidad() { }

        public void AnadirEquip(Equip equipo)
        {
            //evalua si tiene la misma afinidad y se añade
        }
    }
}
