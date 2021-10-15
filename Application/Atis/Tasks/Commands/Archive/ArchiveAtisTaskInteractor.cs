using System;
using System.Threading.Tasks;
using Application.TrainingDevelopment.Common.Commands.Archive;
using Domain.Atis.Entities.TrainingDevelopment;

namespace Application.Atis.Tasks.Commands.Archive
{
    public class ArchiveAtisTaskInteractor: IArchiveTrainingDevelopmentEntityInteractor<AtisTask>
    {
        public async Task Execute(Guid id)
        {
        }
    }
}