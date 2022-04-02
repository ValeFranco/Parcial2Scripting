namespace Parcial2Scripting
{
    public class SupportSkillBase
    {
        protected l_effectType effectType;

        internal uint EddectPoints
        {
            get => eddectPoints; set
            {
                if (value > 0) eddectPoints = value;
                else throw new Exception("no puede ser el CostPoint 0 o inferior   ");
            }



        }
    }
}