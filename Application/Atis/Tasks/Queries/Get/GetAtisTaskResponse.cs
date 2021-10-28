using Bks.Training.Development.Application.TrainingDevelopment.Common.Queries.Models;
using Bks.Training.Development.Domain.Atis.Entities.TrainingDevelopment;

namespace Bks.Training.Development.Application.Atis.Tasks.Queries.Get
{
    public class GetAtisTaskResponse: AbstractTrainingEntityResponse
    {
        public GetAtisTaskResponse(AtisTask entity) : base(entity)
        {

        }
    }
}