using System.Collections.Generic;
using Bks.TrainingDevelopment.Domain.Values;

namespace Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour.ResourceRequirements
{
    public interface IResourceRequirementContainer<T> where T : ResourceRequirement
    {
        IReadOnlyCollection<T> GetAll();
        void Add(AuditRecord audit, T requirement);
        void Remove(AuditRecord audit, T requirement);
    }
}