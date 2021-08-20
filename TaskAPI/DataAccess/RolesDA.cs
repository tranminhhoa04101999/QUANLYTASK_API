using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using TaskAPI.Entities;

namespace TaskAPI.DataAccess
{
    public class RolesDA
    {
        SqlConnection conn = DBConnection.sqlConnect();
        public List<Roles> getAllRoles()
        {
            string query = "SELECT * FROM ROLES";
            var list = conn.Query<Roles>(query).ToList();

            return list;
        }
    }
}
