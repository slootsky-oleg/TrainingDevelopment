using System.Threading.Tasks;
using Bks.Fox.Domain.Values.Ids;

namespace Bks.Fox.Application.Behaviors.ResourceRequirements.Services
{
    public interface IResourceRequirementRuleValidator<T>
    {
        Task ValidateEnabled(TypeId typeId);
    }
}