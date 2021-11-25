using System;
using System.Threading.Tasks;
using Bks.Fox.TrainingDevelopment.Application.Entities.Lookups;
using Bks.Fox.TrainingDevelopment.Tasks.Domain.Entities;

namespace Bks.Fox.TrainingDevelopment.Tasks.Application.Lookups
{
    public class TaskLookup: ITrainingEntityLookup<TrainingTask>
    {
        public async Task<TrainingTask> GetRequired(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}