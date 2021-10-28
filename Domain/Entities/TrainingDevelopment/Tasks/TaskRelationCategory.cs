using Bks.Training.Development.Domain.Values;
using Bks.Training.Development.Domain.Values.Ids;

namespace Bks.Training.Development.Domain.Entities.TrainingDevelopment.Tasks
{
    public class TaskRelationCategory
    {
        public GuidId Id { get; set; }
        public Name Name { get; set; }
        public Description Description { get; set; }
    }
}