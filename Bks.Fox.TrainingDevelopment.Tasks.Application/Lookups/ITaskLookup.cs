using Bks.Fox.TrainingDevelopment.Tasks.Domain.Entities;
using Bks.Practices.Ddd.Domain.Lookups;

namespace Bks.Fox.TrainingDevelopment.Tasks.Application.Lookups
{
    public interface ITaskLookup: IEntityLookup<TrainingTask>
    {
    }
}