using Bks.Packages.Core.Domain.Values;
using Bks.Packages.Core.Domain.Values.Ids;
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

            return new UserFootprint(userId);
        }
    }
}