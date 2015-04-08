namespace ArmyOfCreatures.Extended
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using ArmyOfCreatures.Logic.Battles;
    using ArmyOfCreatures.Extended;
    

    public class BattleManagerExt : BattleManager , IBattleManager
    {
        private Logic.ICreaturesFactory creaturesFactory;
        private Logic.ILogger logger;

        private readonly ICollection<ICreaturesInBattle> thirdArmyCreatures;

        public BattleManagerExt(Logic.ICreaturesFactory creaturesFactory, Logic.ILogger logger)
            :base(creaturesFactory,logger)
        {
            // TODO: Complete member initialization
            this.creaturesFactory = creaturesFactory;
            this.logger = logger;

            this.thirdArmyCreatures = new List<ICreaturesInBattle>();
            
        }

        protected override void AddCreaturesByIdentifier(CreatureIdentifier creatureIdentifier, ICreaturesInBattle creaturesInBattle)
        {
            CommonChecks.CheckForNull(creatureIdentifier, "creatureIdentifier");
            CommonChecks.CheckForNull(creaturesInBattle, "creaturesInBattle");
            
            if (creatureIdentifier.ArmyNumber == 3)
            {
                this.thirdArmyCreatures.Add(creaturesInBattle);
            }
            else
                base.AddCreaturesByIdentifier(creatureIdentifier, creaturesInBattle);
        }

        protected override ICreaturesInBattle GetByIdentifier(CreatureIdentifier identifier)
        {
            if (identifier.ArmyNumber == 3)
            {
                return this.thirdArmyCreatures.FirstOrDefault(x => x.Creature.GetType().Name == identifier.CreatureType);
            }
            else
            {
                return base.GetByIdentifier(identifier);
            }
        }
    }
}
