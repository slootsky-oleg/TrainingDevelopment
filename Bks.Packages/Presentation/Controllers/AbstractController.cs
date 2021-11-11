using Bks.Packages.Domain.Values;
using Bks.Packages.Domain.Values.Ids;
using Microsoft.AspNetCore.Mvc;

namespace Bks.Packages.Presentation.Controllers
{
    [ApiController]
    public abstract class AbstractController : ControllerBase
    {
        protected AuditRecord GetAuditRecord()
        {
            var user = User
                .Identity
                .Name;

            var userId = UserId.Of(user);

            return new AuditRecord(userId);
        }
    }
}