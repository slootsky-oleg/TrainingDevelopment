using Bks.Fox.Behaviors.ResourceRequirements.Domain;
using System;

namespace Bks.Fox.Behaviors.ResourceRequirements.Application.Commands.Add
{
    public class AddResourceRequirementResponse
    {
        public Guid Id { get; }

        public AddResourceRequirementResponse(ResourceRequirement behaviour)
        {
            Id = behaviour.Id;
        }
    }
}