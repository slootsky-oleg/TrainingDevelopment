using System.Threading.Tasks;
using Bks.Fox.TrainingDevelopment.Tasks.Domain.Entities;
using Bks.Packages.Core.Application.Entities.Commands.Create;
using Bks.Packages.Core.Domain.Values;
using Bks.Packages.Core.Domain.Values.Ids;

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

            //Get from type or somewhere
            var settings = new TaskSettings();

            var task = new TrainingTask(footprint, name, typeId, settings);
            task.SetExternalId(footprint, externalId);
            task.SetName(footprint, name);
            task.SetDescription(footprint, description);

            return new CreateEntityResponse(task);
        }
    }
}