using System;
using Bks.Domain.Values;
using Bks.Domain.Values.Ids;
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