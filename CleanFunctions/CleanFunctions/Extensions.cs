using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanFunctions
{
   public static class Extensions
    {
        public static bool IsInRole(this User user, string role)
        {
            return user.Role.ToLower() == role.ToLower();

        }
    }
}
