namespace Domain.Entities.TrainingDevelopment.Abstractions.CheckList
{
    public interface IHasCheckList
    {
        CheckListContainer CheckList { get; }
    }
}