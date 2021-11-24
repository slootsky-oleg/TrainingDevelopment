using System.Threading.Tasks;
using Bks.Packages.Core.Domain.Values.Ids;

namespace Bks.Packages.Core.Application.Entities.Behaviors.ResourceRequirements.Services
{
    public interface IResourceRequirementRuleValidator<T>
    {
        Task ValidateEnabled(TypeId typeId);
    }
}