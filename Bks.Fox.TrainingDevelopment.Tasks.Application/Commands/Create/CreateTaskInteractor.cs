using System.Threading.Tasks;
using Bks.Fox.TrainingDevelopment.Tasks.Domain.Entities;
using Bks.Packages.Application.Entities.Commands.Create;
using Bks.Packages.Domain.Values;
using Bks.Packages.Domain.Values.Ids;

namespace Bks.Fox.TrainingDevelopment.Tasks.Application.Commands.Create
{
    public class CreateTaskInteractor
    {
        public async Task<CreateEntityResponse> Execute(UserFootprint footprint, CreateTaskRequest request)
        {
            var name = Name.Of(request.Name);
            var externalId = ExternalId.Of(request.ExternalId);
            var description = Description.Of(request.Description);

            var task = new TrainingTask(footprint, name);
            task.SetExternalId(footprint, externalId);
            task.SetName(footprint, name);
            task.SetDescription(footprint, description);

            return new CreateEntityResponse(task);
        }
    }
}