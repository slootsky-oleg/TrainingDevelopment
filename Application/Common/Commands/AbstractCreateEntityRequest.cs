namespace Bks.TrainingDevelopment.Application.Common.Commands
{
    public abstract class AbstractCreateEntityRequest
    {
        public string ExternalId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}