using System.Threading.Tasks;
using Bks.Practices.Ddd.Domain.Values.Ids;

namespace Bks.Packages.Core.Application.Entities.Behaviors.ResourceRequirements.Services
{
    public interface IResourceRequirementRuleValidator<T>
    {
        Task ValidateEnabled(TypeId typeId);
    }
}