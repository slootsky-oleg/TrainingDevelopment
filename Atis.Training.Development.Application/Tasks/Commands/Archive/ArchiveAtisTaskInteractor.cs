using System;
using System.Threading.Tasks;
using Atis.Training.Development.Domain.Entities.TrainingDevelopment;
using Bks.Training.Development.Application.TrainingDevelopment.Common.Commands.Archive;

namespace Atis.Training.Development.Application.Tasks.Commands.Archive
{
    public class ArchiveAtisTaskInteractor: IArchiveTrainingEntityInteractor<AtisTask>
    {
        public async Task Execute(Guid id)
        {
        }
    }
}