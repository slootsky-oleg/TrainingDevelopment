using Bks.Fox.TrainingDevelopment.Tasks.Domain.Entities;
using Bks.Packages.Application.Entities.Queries.Get;
using Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Tasks;

namespace Bks.Fox.TrainingDevelopment.Tasks.Application.Queries.Get
{
    public class GetTaskResponse : AbstractGetEntityResponse
    {
        public GetTaskResponse(TrainingTask entity) : base(entity)
        {
        }
    }
}