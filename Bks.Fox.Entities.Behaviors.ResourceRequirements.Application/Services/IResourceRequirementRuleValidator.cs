using System.Threading.Tasks;
using Bks.Fox.Domain.Values.Ids;

namespace Bks.Fox.Behaviors.ResourceRequirements.Application.Services
{
    public interface IResourceRequirementRuleValidator<T>
    {
        Task ValidateEnabled(TypeId typeId);
    }
}