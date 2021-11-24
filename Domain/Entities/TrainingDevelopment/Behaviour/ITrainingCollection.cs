using System.Collections.Generic;
using Bks.Fox.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Abstractions;
using Bks.Packages.Domain.Entities;

namespace Bks.Fox.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour
{
    public interface ITrainingCollection<T>
        where T : TrainingEntity
    {
        public IReadOnlyCollection<T> GetTrainingItems();
    }
}