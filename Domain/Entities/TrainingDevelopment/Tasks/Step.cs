using System.Collections.Generic;
using System.Linq;

namespace Domain.Entities.TrainingDevelopment.Tasks
{
    public class Step : TrainingDevelopmentCollectionEntity<Step>
    {
        //TODO: can be defined as a collection of leader/critical steps on the owner's level (task/step)
        //This may simplify validations (only 5 leader steps)
        public bool IsLeaderStep { get; set; }
        public bool IsCriticalStep { get; set; }
        public IReadOnlyCollection<Step> Steps { get; set; }

        public override IReadOnlyCollection<Step> GetTrainingItems()
        {
            //TODO: recursively get all steps. Handle duplicates is steps are sharable
            return Steps
                .Select(s => s.GetTrainingItems())
                .SelectMany(s => s)
                .ToList();
        }

        public override void Archive()
        {
            throw new System.NotSupportedException("Step can't be archived");
        }

        public override void Restore()
        {
            throw new System.NotSupportedException("Step can't be restored");
        }
    }
}