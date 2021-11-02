using Atis.Training.Development.Domain.Entities.TrainingDevelopment;
using Bks.TrainingDevelopment.Application.TrainingDevelopment.Common.Queries.Models;

namespace Atis.TrainingDevelopment.Application.Tasks.Queries.Get
{
    public class GetAtisTaskResponse: AbstractTrainingEntityResponse
    {
        public GetAtisTaskResponse(AtisTask entity) : base(entity)
        {

        }
    }
}