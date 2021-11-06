using Atis.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour;
using Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour;
using Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour.RelatedEntities;
using Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Tasks;
using Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Tasks.Steps;

namespace Atis.TrainingDevelopment.Domain.Entities.TrainingDevelopment
{
    public class AtisTask :
        TrainingEntity<AtisResourceRequirement>,
        IHasRelatedEntities<AtisTask>
    {
        public StepContainer<AtisStep> Steps { get; }

        public RelatedEntityContainer<AtisTask> RelatedEntities { get; }

        public void Archive()
        {
            throw new System.NotImplementedException();
        }

    }
}