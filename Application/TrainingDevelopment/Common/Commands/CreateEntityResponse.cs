namespace Bks.TrainingDevelopment.Application.TrainingDevelopment.Common.Commands
{
    public class CreateEntityResponse
    {
        public int Id { get; }

        public CreateEntityResponse(int id)
        {
            Id = id;
        }
    }
}