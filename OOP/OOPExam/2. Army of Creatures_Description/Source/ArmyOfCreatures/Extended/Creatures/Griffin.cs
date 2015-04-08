namespace ArmyOfCreatures.Extended.Creatures
{
    using ArmyOfCreatures.Logic.Creatures;
    using ArmyOfCreatures.Logic.Specialties;

    public class Griffin : Creature
    {
        private const int AttackPoints = 8;
        private const int DefensePoints = 8;
        private const int HP = 25;
        private const decimal DamagePoints = 4.5m;

        private const int Ddwd = 5;
        private const int Adws = 3;

        public Griffin()
            : base(AttackPoints, DefensePoints, HP, DamagePoints)
        {
            this.AddSpecialty(new DoubleDefenseWhenDefending(Ddwd));
            this.AddSpecialty(new AddDefenseWhenSkip(Adws));
            this.AddSpecialty(new Hate(typeof(WolfRaider)));
        }
    }
}
