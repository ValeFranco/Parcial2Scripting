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
        private List<Carta> equip;
        internal enum l_Afinity
        {
            Knight,
            Mage,
            Undead
        };
        internal l_Afinity afinity;

        public Character(string name, uint costPoint,l_Rarity rarity, uint attackPoints, uint resistPoints, List<Carta> equip, l_Afinity afinity): base(name, costPoint, rarity)
        {
            AttackPoints = attackPoints;
            ResistPoints = resistPoints;
            Equip = equip;
            this.afinity = afinity;
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

        internal List<Carta> Equip { get => equip; set {
                if (value.Count() > -1 && value.Count() < 4) equip = value;
                else throw new Exception("los equip  no pueden ser  mayores de 3 ");
            } }
    }
}
