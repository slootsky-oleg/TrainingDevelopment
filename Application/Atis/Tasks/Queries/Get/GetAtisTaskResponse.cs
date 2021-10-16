using Application.TrainingDevelopment.Common.Queries.Models;
using Domain.Atis.Entities.TrainingDevelopment;
using Domain.Entities.TrainingDevelopment.Behaviour;

namespace Application.Atis.Tasks.Queries.Get
{
    public class GetAtisTaskResponse: AbstractTrainingEntityResponse
    {
        public GetAtisTaskResponse(AtisTask entity) : base(entity)
        {

        }
    }
}