namespace Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour
{
    public interface IArchivable
    {
        void Activate();
        void Deprecate();
        void Obsolete();
        void Archive();
    }
}