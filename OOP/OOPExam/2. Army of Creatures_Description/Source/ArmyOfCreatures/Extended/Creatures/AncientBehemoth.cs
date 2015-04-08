namespace ArmyOfCreatures.Extended.Creatures
{
    using ArmyOfCreatures.Logic.Creatures;
    using ArmyOfCreatures.Logic.Specialties;

    public class AncientBehemoth : Creature
    {
        private const int AttackPoints = 19;
        private const int DefensePoints = 19;
        private const int HP = 300;
        private const decimal DamagePoints = 40m;

        private const decimal Redbp = 80m;
        private const int Ddwd = 5;

        public AncientBehemoth()
            : base(AttackPoints, DefensePoints, HP, DamagePoints)
        {
            this.AddSpecialty(new ReduceEnemyDefenseByPercentage(Redbp));
            this.AddSpecialty(new DoubleDefenseWhenDefending(Ddwd));
        }
    }


}
