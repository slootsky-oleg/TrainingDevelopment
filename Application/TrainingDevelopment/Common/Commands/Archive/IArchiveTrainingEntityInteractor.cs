using System;
using System.Threading.Tasks;
using Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour;

namespace Bks.TrainingDevelopment.Application.TrainingDevelopment.Common.Commands.Archive
{
    public interface IArchiveTrainingEntityInteractor<T>
        where T: ITrainingEntity
    {
        Task Execute(Guid id);
    }
}