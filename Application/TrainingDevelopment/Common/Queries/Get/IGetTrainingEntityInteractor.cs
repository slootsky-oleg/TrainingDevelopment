using System;
using System.Threading.Tasks;
using Domain.Entities.TrainingDevelopment.Behaviour;

namespace Application.TrainingDevelopment.Common.Queries.Get
{
    public interface IGetTrainingEntityInteractor<T, TResponse>
        where T: ITrainingEntity
    {
        Task<TResponse> Execute(Guid id);
    }
}