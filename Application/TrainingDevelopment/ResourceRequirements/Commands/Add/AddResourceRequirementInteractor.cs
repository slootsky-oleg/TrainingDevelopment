using System;
using System.Threading.Tasks;
using Bks.TrainingDevelopment.Application.Features;

namespace Bks.TrainingDevelopment.Application.TrainingDevelopment.ResourceRequirements.Commands.Add
{
    public class AddResourceRequirementInteractor
    {
        private readonly IEntityFeatureConfig entityFeatureConfig;

        public AddResourceRequirementInteractor(IEntityFeatureConfig entityFeatureConfig)
        {
            this.entityFeatureConfig = entityFeatureConfig;
        }

        public async Task Execute<T>(
            Guid id
            /*ResourceRequirement requirement*/)
        {
            entityFeatureConfig.ValidateFeature<T>("ResourceRequirements");
            
            //var repository = repositoryResolver.Resolve<T>();
            //var entity = repository.Get(id);

            //entity.AddResourceRequirement(requirement)

            //repository.CommitAsync();
        }
    }
}