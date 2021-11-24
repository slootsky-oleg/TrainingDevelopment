using System.Threading.Tasks;
using Bks.Packages.Domain.Values.Ids;

namespace Bks.Packages.Core.Application.Entities.Behaviors.ResourceRequirements.Services
{
    public interface IResourceRequirementRuleValidator<T>
    {
        Task ValidateEnabled(TypeId typeId);
    }
}