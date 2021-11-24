using System;
using Bks.Fox.Entities.Domain.Values;
using Bks.Fox.Entities.Domain.Values.Ids;
using Microsoft.AspNetCore.Mvc;

namespace Bks.AspNetCore.WebApi.Controllers
{
    [ApiController]
    public abstract class AbstractController : ControllerBase
    {
        protected UserFootprint GetUserFootprint()
        {
            var user = User
                .Identity
                .Name;

            var userId = UserId.Of(user);
            var now = DateTime.UtcNow;
            return new UserFootprint(userId, now);
        }
    }
}