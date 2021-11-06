using System.Threading;
using System.Threading.Tasks;
using Bks.TrainingDevelopment.Application.Tasks.ResourceRequirements.Commands.Add;
using Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour.ResourceRequirements;
using Bks.TrainingDevelopment.Domain.Values.Ids;
using MediatR;
using ReflectionMagic;

namespace Bks.TrainingDevelopment.Application.Tasks.ResourceRequirements.Queries.Get
{
    public class GetTaskResourceRequirementHandler : IRequestHandler<GetTaskResourceRequirementRequest, GetTaskResourceRequirementResponse>
    {
        public async Task<GetTaskResourceRequirementResponse> Handle(GetTaskResourceRequirementRequest request, CancellationToken cancellationToken)
        {
            var requirement = new ResourceRequirement();
            var hack = requirement.AsDynamic();
            hack.Id = GuidId.New();

            return new GetTaskResourceRequirementResponse(requirement);
        }
    }
}