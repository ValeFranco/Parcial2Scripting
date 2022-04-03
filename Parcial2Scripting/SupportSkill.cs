using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2Scripting
{
    class SupportSkill :Carta 
    {
        internal enum l_effectType {ReduceAP,ReduceRP,ReduceAll,DestroyEquip,RestoreRP}
        internal l_effectType effectType;
        internal uint effectPoints;

        public SupportSkill(string name, uint costPoint, l_Rarity rarity, l_effectType effectType, uint effectPoints): base(name, costPoint,rarity) 
        {
            this.effectType = effectType;
            EffectPoints = effectPoints;
        }

        internal uint EffectPoints { get => effectPoints; set
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
        public override void afinidad()
        {

        }

        public void ReducirAttackPoints(Character carta)
        {

        }
        public void ReducirResistPoints(Character carta)
        {

        }
        public void ReducirTodo(Character carta)
        {

        }
        public void DestruirEquipos(Character carta)
        {

        }
        public void RestaurarResistPoints(Character carta)
        {

        }

    }
}
