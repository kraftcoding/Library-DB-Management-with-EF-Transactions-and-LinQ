using LibraryDBManagement.Model;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace LibraryDBManagement.Core
{
    public class SPManager
    {
        public List<User> GetAllUsers()
        {
            using (var db = new LibraryDBContext())
            {
                var result = db.Database.SqlQuery<User>("sp_getAllLibraryUsers").ToList();
                return result;
            }
        }

        public void DeleteAllUserRole(string role)
        {
            using (var db = new LibraryDBContext())
            {
                var roleParameter = new SqlParameter("@role", role);
                db.Database.ExecuteSqlCommand("exec sp_deleteAllLibraryUsers @role", roleParameter);                
            }
        }
    }
}
