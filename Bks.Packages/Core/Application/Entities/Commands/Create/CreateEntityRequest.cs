namespace Bks.Packages.Core.Application.Entities.Commands.Create
{
    public abstract class CreateEntityRequest
    {
        public string ExternalId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}