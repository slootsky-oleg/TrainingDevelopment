using System.Collections.Generic;

namespace Domain.Entities.TrainingDevelopment.Plans
{
    public class TrainingPlan : TrainingDevelopmentCollectionEntity<TrainingDevelopmentEntity>
    {
        public override IReadOnlyCollection<TrainingDevelopmentEntity> GetItems()
        {
            throw new System.NotImplementedException();
        }
    }
}