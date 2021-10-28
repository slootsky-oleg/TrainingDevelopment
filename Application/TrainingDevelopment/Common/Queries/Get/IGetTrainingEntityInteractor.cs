using System;
using System.Threading.Tasks;
using Bks.Training.Development.Domain.Entities.TrainingDevelopment.Behaviour;

namespace Bks.Training.Development.Application.TrainingDevelopment.Common.Queries.Get
{
    public interface IGetTrainingEntityInteractor<T, TResponse>
        where T: ITrainingEntity
    {
        Task<TResponse> Execute(Guid id);
    }
}