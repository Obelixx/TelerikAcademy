namespace ArmyOfCreatures.Logic.Specialties
{
    using System;
    using System.Globalization;

    using ArmyOfCreatures.Logic.Battles;
    using ArmyOfCreatures.Extended;

    public class DoubleAttackWhenAttacking : Specialty
    {
        private int rounds;

        public DoubleAttackWhenAttacking(int rounds)
        {
            if (rounds <= 0)
            {
                throw new ArgumentOutOfRangeException("attackToAdd", "attackToAdd should be between 1 and 10, inclusive");
            }

            this.rounds = rounds;
        }

        public override void ApplyWhenAttacking(ICreaturesInBattle attackerWithSpecialty, ICreaturesInBattle defender)
        {
            CommonChecks.CheckForNull(attackerWithSpecialty, "attackerWithSpecialty");
            CommonChecks.CheckForNull(defender, "defender");

            if (this.rounds <= 0)
            {
                // Effect expires after fixed number of rounds
                return;
            }
            this.rounds--;
            attackerWithSpecialty.CurrentAttack *= 2;
        }

        public override string ToString()
        {
            return string.Format(CultureInfo.InvariantCulture, "{0}({1})", base.ToString(), this.rounds);
        }
    }
}
