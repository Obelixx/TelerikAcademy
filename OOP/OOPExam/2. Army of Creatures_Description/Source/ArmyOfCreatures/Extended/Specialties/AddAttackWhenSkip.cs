namespace ArmyOfCreatures.Logic.Specialties
{
    using System;
    using System.Globalization;

    using ArmyOfCreatures.Logic.Battles;
    using ArmyOfCreatures.Extended;

    public class AddAttackWhenSkip : Specialty
    {
        private int attackToAdd;

        public AddAttackWhenSkip(int attackToAdd)
        {
            if (attackToAdd <= 0 || attackToAdd > 10)
            {
                throw new ArgumentOutOfRangeException("attackToAdd", "attackToAdd should be between 1 and 10, inclusive");
            }

            this.attackToAdd = attackToAdd;
        }

        public override void ApplyOnSkip(ICreaturesInBattle skipCreature)
        {
            CommonChecks.CheckForNull(skipCreature, "skipCreature");
            
            skipCreature.PermanentAttack += this.attackToAdd;
        }


        public override string ToString()
        {
            return string.Format(CultureInfo.InvariantCulture, "{0}({1})", base.ToString(), this.attackToAdd);
        }
    }
}
