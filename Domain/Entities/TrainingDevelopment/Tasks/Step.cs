using System.Collections.Generic;
using System.Linq;

namespace Domain.Entities.TrainingDevelopment.Tasks
{
    public class Step : TrainingDevelopmentCollectionEntity<Step>
    {
        public IReadOnlyCollection<Step> Steps { get; set; }

        public override IReadOnlyCollection<Step> GetTrainingItems()
        {
            //TODO: recursively get all steps. Handle duplicates is steps are sharable
            return Steps
                .Select(s => s.GetTrainingItems())
                .SelectMany(s => s)
                .ToList();
        }
    }
}