using System.Threading.Tasks;
using Bks.Domain.Values.Ids;

namespace Bks.Fox.Entities.Behaviors.ResourceRequirements.Application.Services
{
    public interface IResourceRequirementRuleValidator<T>
    {
        Task ValidateEnabled(TypeId typeId);
    }
}