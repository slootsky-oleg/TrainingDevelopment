using System;
using System.Threading.Tasks;
using Domain.Entities.TrainingDevelopment.Behaviour;
using Domain.Repositories;

namespace Application.TrainingDevelopment.Common.Queries.Get
{
    public class GetTrainingEntityInteractor<T> : IGetTrainingEntityInteractor<T>
        where T: ITrainingDevelopmentEntity
    {
        //private readonly ITrainingEntityRepository<T> repository;

        // public GetTrainingEntityInteractor(ITrainingEntityRepository<T> repository)
        // {
        //     this.repository = repository;
        // }

        public async Task<T> Execute(Guid id)
        {
            return default;
            // var entity = await repository.GetAsync(id);
            // if (entity == null) throw new ArgumentNullException(nameof(entity));
            //
            // return entity;
        }
    }
}