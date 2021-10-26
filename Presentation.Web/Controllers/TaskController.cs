using System;
using System.Threading.Tasks;
using Application.Features;
using Domain.Atis.Entities.TrainingDevelopment;
using Domain.Entities.TrainingDevelopment.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.FeatureManagement;
using Microsoft.FeatureManagement.Mvc;

namespace Presentation.Web.Controllers
{
    [Route("tasks")]
    [FeatureGate(FeatureFlag.Task)] 
    public class TaskController: AbstractTrainingEntityController<TrainingTask>
    {
        private readonly IFeatureManager featureManager;

        public TaskController(IFeatureManager featureManager)
        {
            this.featureManager = featureManager;
        }

        public override void Home()
        {
            var isEnabled = featureManager.IsEnabledAsync(FeatureFlag.Task).Result;
            base.Home();
        }
    }
}