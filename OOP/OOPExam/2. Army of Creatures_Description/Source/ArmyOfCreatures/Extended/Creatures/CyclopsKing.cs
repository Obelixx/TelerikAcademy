namespace ArmyOfCreatures.Extended.Creatures
{
    using ArmyOfCreatures.Extended.Specialties;
    using ArmyOfCreatures.Logic.Creatures;
    using ArmyOfCreatures.Logic.Specialties;

    public class CyclopsKing : Creature
    {
        private const int AttackPoints = 17;
        private const int DefensePoints = 13;
        private const int HP = 70;
        private const decimal DamagePoints = 18m;

        private const int Aaws = 3;
        private const int Dawa = 4;
        private const int Dd = 1;

        public CyclopsKing()
            : base(AttackPoints, DefensePoints, HP, DamagePoints)
        {
            this.AddSpecialty(new AddAttackWhenSkip(Aaws));
            this.AddSpecialty(new DoubleAttackWhenAttacking(Dawa));
            this.AddSpecialty(new DoubleDamage(Dd));
        }
    }
}
