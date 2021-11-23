using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanFunctions
{
   public class UserService
    {

        public void AuthorizeUser()
        {
            var users = new FakeUsers().GetUsers();
            foreach (var user in users)
            {
                AdminProcess(user);
            }
        }

        private static void AdminProcess(User user)
        {
            if (user.IsInRole("Admin"))
            {

            }
        }
    }
}
