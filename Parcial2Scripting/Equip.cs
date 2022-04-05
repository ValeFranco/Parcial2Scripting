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
        public l_affinity affinity;
        public l_targetAttribute targetAttribute;
        internal uint effectPoints;
        bool aplicada=false;

        public Equip(string name, uint costPoint, l_Rarity rarity, l_affinity affinity, l_targetAttribute targetAttribute, uint effectPoints) : base(name, costPoint, rarity)
        {
            this.affinity = affinity;
            this.targetAttribute = targetAttribute;
            this.effectPoints = effectPoints;
        }

        public void AplicarEquip(Character carta)
        {
            if (!aplicada)
            {
                aplicada = true;
                if (targetAttribute.ToString() == "AP")
                {
                    carta.AttackPoints += effectPoints;


                }
                else if (targetAttribute.ToString() == "RP")
                {
                    carta.ResistPoints += effectPoints;

                }
                else if (targetAttribute.ToString() == "ALL")
                {

                    carta.AttackPoints += effectPoints;
                    carta.ResistPoints += effectPoints;

                }


            }
          
            //Aumentar el AP segun desea la carta
            //Aumentar RP segun desea la carta
            //Que ambas se aumenten
        }
  
    }
}
