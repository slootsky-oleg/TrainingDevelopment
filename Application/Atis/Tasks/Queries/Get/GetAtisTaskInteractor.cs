using System;
using System.Threading.Tasks;
using Application.TrainingDevelopment.Common.Commands.Archive;
using Application.TrainingDevelopment.Common.Queries.Get;
using Domain.Atis.Entities.TrainingDevelopment;

namespace Application.Atis.Tasks.Queries.Get
{
    public class GetAtisTaskInteractor : IGetTrainingEntityInteractor<AtisTask, GetAtisTaskResponse>
    {
        public async Task<GetAtisTaskResponse> Execute(Guid id)
        {
            var entity = new AtisTask();
            return new GetAtisTaskResponse(entity);
        }
    }
}