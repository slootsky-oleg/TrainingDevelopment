﻿using System;
using System.Threading.Tasks;
using Bks.Fox.TrainingDevelopment.Tasks.Domain.Repositories;
using Bks.Packages.Core.Domain.Values.Ids;

namespace Bks.Fox.TrainingDevelopment.Tasks.Application.ResourceRequirements.Services
{
    //TODO: choose a better name
    public class ResourceRequirementRuleValidator : IResourceRequirementRuleValidator
    {
        private readonly ITaskTypeRepository typeRepository;

        public ResourceRequirementRuleValidator(ITaskTypeRepository typeRepository)
        {
            this.typeRepository = typeRepository;
        }

        public async Task ValidateEnabled(TypeId taskTypeId)
        {
            var type = await  typeRepository.GetAsync(taskTypeId);
            // //Get from type or somewhere
            var settings = type.Settings;
            var requirementSettings = settings.ResourceRequirement; 

            if (!requirementSettings.IsEnabled)
            {
                //TODO: replace with a custom exception
                throw new NotSupportedException($"Resource requirements are not supported for the Type [{taskTypeId}].");
            }
        }
    }
}