using Domain.Values;
using Domain.Values.Ids;

namespace Domain.Entities.TrainingDevelopment.Tasks
{
    public class TaskRelationCategory
    {
        public GuidId Id { get; set; }
        public Name Name { get; set; }
        public Description Description { get; set; }
    }
}