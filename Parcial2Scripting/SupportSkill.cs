using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2Scripting
{
    public class SupportSkill :Carta 
    {
        public enum l_effectType {ReduceAP,ReduceRP,ReduceAll,DestroyEquip,RestoreRP}
        internal l_effectType effectType;
        internal int effectPoints;

        public SupportSkill(string name, int costPoint, l_Rarity rarity, l_effectType effectType, int effectPoints): base(name, costPoint,rarity) 
        {
            this.effectType = effectType;
            EffectPoints = effectPoints;
        }
        internal int EffectPoints { get => effectPoints; set
            {
                if (value > 0)
                {
                    effectPoints = value;
                }                   
                else
                {
                    throw new Exception("no puede ser el CostPoint 0 o inferior");
                }                   
            }
        }
    }
}
