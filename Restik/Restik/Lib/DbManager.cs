using Restik.Data;
using Restik.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restik.Lib
{
    public static class DbManager
    {
        public static User GetUser(string mail, string password)
        {
            using (var db = new ApplicationContext())
            {
                return db.Users.SingleOrDefault(U => U.Mail == mail && U.Password == password);
            }
        }

        public static void AddUser(User user)
        {
            using (var db = new ApplicationContext())
            {
                db.Users.Add(user);
                db.SaveChanges();
            }
        }
    }
}
