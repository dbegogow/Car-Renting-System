using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

using static CarRentingSystem.Areas.Admin.AdminConstants;

namespace CarRentingSystem.Areas.Admin.Controllers
{
    [Area(AreaName)]
    [Authorize(Roles = AdministratorRoleName)]
    public abstract class AdminController : Controller
    {
    }
}
