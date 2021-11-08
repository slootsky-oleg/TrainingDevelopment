using Bks.TrainingDevelopment.Domain.Values;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

namespace Bks.TrainingDevelopment.Presentation.Web.Controllers.Abstractions
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