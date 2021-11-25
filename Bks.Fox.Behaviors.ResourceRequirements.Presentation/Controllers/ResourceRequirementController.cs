using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Bks.Fox.Behaviors.ResourceRequirements.Application.Commands.Add;
using Bks.Fox.Behaviors.ResourceRequirements.Application.Queries.Common;
using Bks.Fox.Behaviors.ResourceRequirements.Application.Queries.Get;
using Bks.Fox.Behaviors.ResourceRequirements.Application.Queries.GetAll;
using Bks.Fox.TrainingDevelopment.Domain.Entities;
using Bks.WebApi.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace Bks.Fox.Behaviors.ResourceRequirements.Presentation.Controllers
{
    public abstract class ResourceRequirementController<T> : AbstractController
    where T: TrainingEntity
    {
        [HttpPost]
        public async Task<AddResourceRequirementResponse> Add(
            [FromServices] AddResourceRequirementInteractor<T> interactor,
            [FromRoute] [Required] Guid id,
            AddResourceRequirementRequest request)
        {
            var footprint = GetUserFootprint();
            return await interactor.Execute(footprint, id, request);
        }

        [HttpGet]
        public async Task<IList<GetResourceRequirementResponse>> GetAll(
            [FromServices] GetAllResourceRequirementsInteractor<T> interactor,
            [FromRoute] [Required] Guid id)
        {
            return await interactor.Execute(id);
        }

        [HttpGet("{requirementId:guid}")]
        public async Task<GetResourceRequirementResponse> Get(
            [FromServices] GetResourceRequirementInteractor<T> interactor,
            [FromRoute] Guid id,
            [FromRoute] Guid requirementId)
        {
            return await interactor.Execute(id, requirementId);
        }
    }
}