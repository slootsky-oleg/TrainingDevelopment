using System;
using System.Threading.Tasks;
using Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour;

namespace Bks.TrainingDevelopment.Application.TrainingDevelopment.Common.Queries.Get
{
    public interface IGetTrainingEntityInteractor<T, TResponse>
        where T: ITrainingEntity
    {
        Task<TResponse> Execute(Guid id);
    }
}