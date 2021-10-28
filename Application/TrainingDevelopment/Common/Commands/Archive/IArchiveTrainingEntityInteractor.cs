using System;
using System.Threading.Tasks;
using Bks.Training.Development.Domain.Entities.TrainingDevelopment.Behaviour;

namespace Bks.Training.Development.Application.TrainingDevelopment.Common.Commands.Archive
{
    public interface IArchiveTrainingEntityInteractor<T>
        where T: ITrainingEntity
    {
        Task Execute(Guid id);
    }
}