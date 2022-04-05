using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2Scripting
{
    public class Character : Carta
    {
        internal uint attackPoints;
        internal uint resistPoints;
        public  uint Heald;
        internal List<Equip> equip;
        public enum l_Afinity
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
            Heald = resistPoints;
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
      

        public bool AnadirEquip(Equip equipo)
        {
            if (equip.Count()<=2 && equip.Count() >=0)
            {
              
                if (equipo.affinity.ToString()== afinity.ToString() || equipo.affinity.ToString()== "ALL")
                {
                    equip.Add(equipo);
                    AplicarEquip(equipo);
                    return true;
                }
                return false;
            }
            else
                throw new Exception("No se pueden equipar mas de tres cartas tipo equip");
        }
        public void AplicarEquip(Equip equipo)
        {

            if (!equipo.aplicada)
            {
                equipo.aplicada = true;
                if (equipo.targetAttribute.ToString() == "AP")
                {
                   AttackPoints += equipo.effectPoints;


                }
                else if (equipo.targetAttribute.ToString() == "RP")
                {
                  ResistPoints += equipo.effectPoints;

                }
                else if (equipo.targetAttribute.ToString() == "ALL")
                {

                   AttackPoints += equipo.effectPoints;
                   ResistPoints += equipo.effectPoints;

                }


            }
            else
            {
                throw new Exception("la carta fue aplicada con anterioridad");
            }




            //Aumentar el AP segun desea la carta
            //Aumentar RP segun desea la carta
            //Que ambas se aumenten
        }

    }
}
