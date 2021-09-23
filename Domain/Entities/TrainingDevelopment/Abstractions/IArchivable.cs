namespace Domain.Entities.TrainingDevelopment.Abstractions
{
    public interface IArchivable
    {
        void Activate_Q();
        void Deprecate_Q();
        void Obsolete_Q();
        void Archive_Q();
    }
}