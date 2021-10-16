using System;
using System.Threading.Tasks;
using Domain.Entities.TrainingDevelopment.Behaviour;
using Domain.Repositories;

namespace Application.TrainingDevelopment.Common.Queries.Get
{
    // public class GetTrainingEntityInteractor<T, TResult> : IGetTrainingEntityInteractor<T, TResult>
    //     where T: ITrainingEntity
    // {
    //     //private readonly ITrainingEntityRepository<T> repository;
    //
    //     // public GetTrainingEntityInteractor(ITrainingEntityRepository<T> repository)
    //     // {
    //     //     this.repository = repository;
    //     // }
    //
    //     public async Task<TResult> Execute(Guid id)
    //     {
    //         //return default;
    //         // var entity = await repository.GetAsync(id);
    //         // if (entity == null) throw new ArgumentNullException(nameof(entity));
    //         //
    //         // return entity;
    //     }
    // }
}