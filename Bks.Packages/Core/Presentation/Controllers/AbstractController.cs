using System;
using Bks.Packages.Domain.Values;
using Bks.Packages.Domain.Values.Ids;
using Microsoft.AspNetCore.Mvc;

namespace Bks.Packages.Core.Presentation.Controllers
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