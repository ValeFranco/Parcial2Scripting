using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2Scripting
{
    public class SupportSkill :Carta 
    {
        internal enum l_effectType {ReduceAP,ReduceRP,ReduceAll,DestroyEquip,RestoreRP}
        internal l_effectType effectType;
        internal uint eddectPoints;

         SupportSkill(string name, uint costPoint, l_Rarity rarity, l_effectType effectType, uint eddectPoints): base(name, costPoint,rarity) 
        {
            this.effectType = effectType;
            EddectPoints = eddectPoints;
        }

        internal uint EddectPoints { get => eddectPoints; set
            {
                if (value > 0) eddectPoints = value;
                else throw new Exception("no puede ser el CostPoint 0 o inferior   ");
            }



        }
    }
}
