using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using TaskAPI.DataAccess;
using TaskAPI.Entities;

namespace TaskAPI.Controllers
{
    [ApiController]
    [Route("Users/[action]")]
    public class UsersController :ControllerBase
    {
        // ket noi voi database
        SqlConnection conn = DBConnection.sqlConnect();
        UsersDA usersDA = new UsersDA();

        
        [HttpGet]
        [ActionName("getAllUsers")]
        public IActionResult getAllUsers()
        {
            var result = usersDA.getAllUsers();
            return Ok(result);
        }
        [HttpPost]
        [ActionName("login")]
        public IActionResult login([FromQuery] string username, [FromQuery] string password)
        {
            var result = usersDA.getLogin(username, password);
            return Ok(result);
        }
    }
}
