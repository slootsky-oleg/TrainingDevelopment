using System;
using System.Threading.Tasks;
using Application.TrainingDevelopment.Common.Commands.Archive;
using Application.TrainingDevelopment.Common.Queries.Get;
using Domain.Atis.Entities.TrainingDevelopment;

namespace Application.Atis.Tasks.Queries.Get
{
    public class GetAtisTaskInteractor : IGetTrainingDevelopmentEntityInteractor<AtisTask>
    {
        public async Task<AtisTask> Execute(Guid id)
        {
            return new AtisTask();
        }
    }
}