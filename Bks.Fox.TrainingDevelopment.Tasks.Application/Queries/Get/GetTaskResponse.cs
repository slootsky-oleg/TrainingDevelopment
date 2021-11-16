using Bks.Fox.TrainingDevelopment.Tasks.Domain.Entities;
using Bks.Packages.Core.Application.Entities.Queries.Get;

namespace Bks.Fox.TrainingDevelopment.Tasks.Application.Queries.Get
{
    public class GetTaskResponse : GetEntityResponse
    {
        public GetTaskResponse(TrainingTask entity) : base(entity)
        {
        }
    }
}