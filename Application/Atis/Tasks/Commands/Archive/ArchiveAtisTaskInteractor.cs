using System;
using System.Threading.Tasks;
using Bks.Training.Development.Application.TrainingDevelopment.Common.Commands.Archive;
using Bks.Training.Development.Domain.Atis.Entities.TrainingDevelopment;

namespace Bks.Training.Development.Application.Atis.Tasks.Commands.Archive
{
    public class ArchiveAtisTaskInteractor: IArchiveTrainingEntityInteractor<AtisTask>
    {
        public async Task Execute(Guid id)
        {
        }
    }
}