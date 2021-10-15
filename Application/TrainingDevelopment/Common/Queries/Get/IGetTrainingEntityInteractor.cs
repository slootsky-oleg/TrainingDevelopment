using System;
using System.Threading.Tasks;
using Domain.Entities.TrainingDevelopment.Behaviour;

namespace Application.TrainingDevelopment.Common.Queries.Get
{
    public interface IGetTrainingEntityInteractor<T>
        where T: ITrainingDevelopmentEntity
    {
        Task<T> Execute(Guid id);
    }
}