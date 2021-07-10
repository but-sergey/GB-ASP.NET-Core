using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using WebStore.DAL.Context;
using WebStore.Domain.Entities.Identity;
using WebStore.Interfaces;

namespace WebStore.WebAPI.Controllers.Identity
{
    [Route(WebAPIAddress.Identity.Roles)]
    [ApiController]
    public class RolessApiController : ControllerBase
    {
        private readonly RoleStore<Role> _RoleStore;

        public RolessApiController(WebStoreDB db)
        {
            _RoleStore = new RoleStore<Role>(db);
        }
    }
}
