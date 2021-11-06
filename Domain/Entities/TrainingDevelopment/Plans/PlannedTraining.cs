using Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour;

namespace Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Plans
{
    public class PlannedTraining<T> where T : TrainingEntity
    {
        public T Training { get; set; }
        public Offset Offset { get; set; }

        //TODO: define other PlannedTraining settings: first day of... etc.
    }
}