﻿namespace Domain.Entities.TrainingDevelopment.BuilingBlocks.CustomFields
{
    public interface IHasCustomFields
    {
        CustomFieldContainer CustomFields_Q { get; }
    }
}