using System.Collections.Generic;

namespace Bks.Training.Development.Domain.Entities.TrainingDevelopment.Tasks.Steps
{
    public class StepContainer<T>
        where T: Step
    {
        public IReadOnlyCollection<T> Steps { get; }
    }
}