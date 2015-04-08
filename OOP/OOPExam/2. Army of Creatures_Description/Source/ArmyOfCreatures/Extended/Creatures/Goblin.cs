namespace ArmyOfCreatures.Extended.Creatures
{
    using ArmyOfCreatures.Logic.Creatures;
    using ArmyOfCreatures.Logic.Specialties;

    public class Goblin : Creature
    {
        private const int AttackPoints = 4;
        private const int DefensePoints = 2;
        private const int HP = 5;
        private const decimal DamagePoints = 1.5m;

        public Goblin()
            : base(AttackPoints, DefensePoints, HP, DamagePoints)
        {
        }
    }
}
