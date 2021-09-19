using System.Collections.Generic;
using System.Linq;
using Domain.Entities.TrainingDevelopment;

namespace Domain.Atis.Entities.TrainingDevelopment
{
    public class AtisStep : TrainingDevelopmentCollectionEntity<AtisStep>
    {
        //TODO: can be defined as a collection of leader/critical steps on the owner's level (task/step)
        //This may simplify validations (only 5 leader steps)
        public bool IsLeader_Q { get; set; }
        public bool IsCritical_Q { get; set; }
        public IReadOnlyCollection<AtisStep> Steps { get; set; }

        public override IReadOnlyCollection<AtisStep> GetTrainingItems()
        {
            //recursively get all steps. Handle duplicates is steps are sharable
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