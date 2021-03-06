using System;
using Bks.Fox.Domain.Values;
using Bks.Fox.Domain.Values.Ids;
using Microsoft.AspNetCore.Mvc;

namespace Bks.WebApi.Controllers
{
    [ApiController]
    public abstract class AbstractController : ControllerBase
    {
        protected UserFootprint GetUserFootprint()
        {
            //TODO: remove when auth is implemented
            var user = 0;

            // var user = User
            //     .Identity
            //     .Name;

            var userId = UserId.Of(user);
            var now = DateTime.UtcNow;
            return new UserFootprint(userId, now);
        }
    }
}