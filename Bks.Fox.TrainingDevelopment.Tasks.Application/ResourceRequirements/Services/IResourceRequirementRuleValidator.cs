using System.Threading.Tasks;
using Bks.Packages.Core.Domain.Values.Ids;

namespace Bks.Fox.TrainingDevelopment.Tasks.Application.ResourceRequirements.Services
{
    public interface IResourceRequirementRuleValidator
    {
        Task ValidateEnabled(TypeId taskTypeId);
    }
}