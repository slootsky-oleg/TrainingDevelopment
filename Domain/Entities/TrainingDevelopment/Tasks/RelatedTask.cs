namespace Domain.Entities.TrainingDevelopment.Tasks
{
    public class RelatedTask
    {
        public Task Task { get; set; }
        public TaskRelationCategory Category { get; set; }
    }
}