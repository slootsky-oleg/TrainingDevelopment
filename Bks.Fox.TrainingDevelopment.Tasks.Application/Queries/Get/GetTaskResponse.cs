using Bks.Fox.Application.Entities.Queries.Get;
using Bks.Fox.TrainingDevelopment.Tasks.Domain.Entities;

namespace Bks.Fox.TrainingDevelopment.Tasks.Application.Queries.Get
{
    public class GetTaskResponse : GetEntityResponse
    {
        public GetTaskResponse(TrainingTask entity) : base(entity)
        {
        }
    }
}