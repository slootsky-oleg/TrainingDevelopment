using System;
using System.Threading.Tasks;
using Bks.Fox.Behaviors.ResourceRequirements.Application.Services;
using Bks.Fox.Domain.Values.Ids;
using Bks.Fox.TrainingDevelopment.Tasks.Domain.Entities;
using Bks.Fox.TrainingDevelopment.Tasks.Domain.Repositories;

namespace Bks.Fox.TrainingDevelopment.Tasks.Application.ResourceRequirements.Services
{
    //TODO: choose a better name
    public class TaskResourceRequirementRuleValidator : IResourceRequirementRuleValidator<TrainingTask>
    {
        // private readonly ITaskTypeRepository typeRepository;
        //
        // public TaskResourceRequirementRuleValidator(ITaskTypeRepository typeRepository)
        // {
        //     this.typeRepository = typeRepository;
        // }
        //
        // public async Task ValidateEnabled(TypeId taskTypeId)
        // {
        //     var type = await  typeRepository.GetAsync(taskTypeId);
        //     // //Get from type or somewhere
        //     var settings = type.Settings;
        //     var requirementSettings = settings.ResourceRequirement; 
        //
        //     if (!requirementSettings.IsEnabled)
        //     {
        //         //TODO: replace with a custom exception
        //         throw new NotSupportedException($"Resource requirements are not supported for the Type [{taskTypeId}].");
        //     }
        // }
        public async Task ValidateEnabled(TypeId typeId)
        {
            throw new NotImplementedException();
        }
    }
}