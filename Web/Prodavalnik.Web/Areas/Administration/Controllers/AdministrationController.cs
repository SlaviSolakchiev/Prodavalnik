namespace Prodavalnik.Web.Areas.Administration.Controllers
{
    using Prodavalnik.Common;
    using Prodavalnik.Web.Controllers;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
    [Area("Administration")]
    public class AdministrationController : BaseController
    {
    }
}
