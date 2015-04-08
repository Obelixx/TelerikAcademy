namespace ArmyOfCreatures.Extended.Creatures
{
    using ArmyOfCreatures.Extended.Specialties;
    using ArmyOfCreatures.Logic.Creatures;

    public class WolfRaider : Creature
    {
        private const int AttackPoints = 8;
        private const int DefensePoints = 5;
        private const int HP = 10;
        private const decimal DamagePoints = (decimal)3.5;

        private const int DDRounds = 7;

        public WolfRaider()
            : base(AttackPoints, DefensePoints, HP, DamagePoints)
        {
            this.AddSpecialty(new DoubleDamage(DDRounds));
        }
    }
}

