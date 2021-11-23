using System.Collections.Generic;
using Bks.Fox.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Abstractions;
using Bks.Packages.TrainingDevelopment.Domain.Entities;

namespace Bks.Fox.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour
{
    public interface ITrainingCollection<T>
        where T : ITrainingDevelopmentEntity
    {
        public IReadOnlyCollection<T> GetTrainingItems();
    }
}