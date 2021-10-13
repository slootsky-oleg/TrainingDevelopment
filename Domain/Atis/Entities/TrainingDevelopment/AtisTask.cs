using System.Collections.Generic;
using Domain.Atis.Entities.TrainingDevelopment.Behaviour;
using Domain.Entities.TrainingDevelopment.Tasks;
using Domain.Entities.TrainingDevelopment.Tasks.Steps;

namespace Domain.Atis.Entities.TrainingDevelopment
{
    public class AtisTask: AbstractTask<AtisStep, AtisResourceRequirement>
    {
    }
}