using Atis.Training.Development.Domain.Entities.TrainingDevelopment;
using Bks.Training.Development.Application.TrainingDevelopment.Common.Queries.Models;

namespace Atis.Training.Development.Application.Tasks.Queries.Get
{
    public class GetAtisTaskResponse: AbstractTrainingEntityResponse
    {
        public GetAtisTaskResponse(AtisTask entity) : base(entity)
        {

        }
    }
}