
using LibraryDBManagement.Core;
using LibraryDBManagement.Model;
using System.Collections.Generic;


namespace LibraryDBManagement.EFTransactionsLinQTSQL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SPManager SPMngr = new SPManager();
            List<User> Usrs = SPMngr.GetAllUsers();
            SPMngr.DeleteAllUserRole("test");
        }
    }
}
