using System.Threading.Tasks;
using Bks.Domain.Values;
using Bks.Domain.Values.Ids;
using Bks.Fox.Entities.Applications.Commands.Create;
using Bks.Fox.TrainingDevelopment.Tasks.Domain.Entities;

namespace Bks.Fox.TrainingDevelopment.Tasks.Application.Commands.Create
{
    public class CreateTaskInteractor
    {
        public async Task<CreateEntityResponse> Execute(UserFootprint footprint, CreateTaskRequest request)
        {
            var name = Name.Of(request.Name);
            var externalId = ExternalId.Of(request.ExternalId);
            var description = Description.Of(request.Description);
            var typeId = TypeId.Of(request.TypeId);

            var task = new TrainingTask(footprint, name, typeId);
            task.SetExternalId(footprint, externalId);
            task.SetName(footprint, name);
            task.SetDescription(footprint, description);

            return new CreateEntityResponse(task);
        }
    }
}