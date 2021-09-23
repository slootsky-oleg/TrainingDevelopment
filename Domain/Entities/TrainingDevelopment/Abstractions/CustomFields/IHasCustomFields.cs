namespace Domain.Entities.TrainingDevelopment.Abstractions.CustomFields
{
    public interface IHasCustomFields
    {
        CustomFieldContainer CustomFields { get; }
    }
}