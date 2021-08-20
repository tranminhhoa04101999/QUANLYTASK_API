using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using TaskAPI.Entities;

namespace TaskAPI.DataAccess
{
    public class UsersDA
    {
        SqlConnection conn = DBConnection.sqlConnect();
        public List<Users> getAllUsers()
        {
            string query = "SELECT * FROM USERS";
            var DSUsers = conn.Query<Users>(query).ToList();

            return DSUsers;   
        }
        public List<Users> getLogin(string username,string password)
        {
            string query = "SELECT * FROM USERS WHERE UserName = @usernamee AND Password= @passwordd";
            var user = conn.Query<Users>(query, new { usernamee = username, passwordd = password }).ToList();

            return user;
        }
    }
}
