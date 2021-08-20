using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskAPI.DataAccess;

namespace TaskAPI.Controllers
{
    [ApiController]
    [Route("Roles/[action]")]
    public class RolesController : ControllerBase
    {
        RolesDA rolesDA = new RolesDA();

        
        [HttpGet]
        [ActionName("getAllRoles")]
        public IActionResult getAllUsers()
        {
            var result = rolesDA.getAllRoles();
            return Ok(result);
        }
    }
}
