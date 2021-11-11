using Bks.Packages.Domain.Values;
using Microsoft.AspNetCore.Mvc;

namespace Bks.Fox.TrainingDevelopment.Tasks.Presentation.Web.Controllers.Abstractions
{
    [ApiController]
    public abstract class AbstractController : ControllerBase
    {
        protected AuditRecord GetAuditRecord()
        {
            var user = User
                .Identity
                .Name;

            var userId = ToInt(user);

            return new AuditRecord(userId);
        }

        private static int ToInt(string stringValue)
        {
            return int.Parse(stringValue);
        }
    }
}