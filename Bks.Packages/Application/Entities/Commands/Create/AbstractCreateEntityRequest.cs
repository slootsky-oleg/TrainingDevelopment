namespace Bks.Packages.Application.Entities.Commands.Create
{
    public abstract class AbstractCreateEntityRequest
    {
        public string ExternalId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}