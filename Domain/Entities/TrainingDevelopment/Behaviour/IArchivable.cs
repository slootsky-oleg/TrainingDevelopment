namespace Bks.Training.Development.Domain.Entities.TrainingDevelopment.Behaviour
{
    public interface IArchivable
    {
        void Activate_Q();
        void Deprecate_Q();
        void Obsolete_Q();
        void Archive_Q();
    }
}