using System.Collections.Generic;
using System.Reflection.Metadata;
using Domain.Entities.Operational.Scheduling;
using Domain.Entities.TrainingDevelopment.BuilingBlocks.ResourceRequirements;

namespace Domain.Entities.Operational.Events
{
    //var event = repo.get(id);
    
    //event.resources.AddMany(request.resource)
    //event.resources.AddMany(request.allocations)


    //POST resources/id/allocate {event, daterange}
    //resources/id/avalibility

    public class Event : SchedulableEntity
    {
        //public IReadOnlyCollection<ResourceRequirement> ResourceRequirements { get; }

        //public IReadOnlyCollection<Resource> Resources { get; }

        public override void Archive_Q()
        {
            throw new System.NotSupportedException("Step can't be archived.");  //Applies to all availability methods
        }
    }
}