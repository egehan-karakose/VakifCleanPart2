using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanFunctions
{
   public class FakeUsers
    {
        public List<User> GetUsers()
        {
            return new List<User>
            {
                 new User { Name="Batuhan", Role="User"},
                 new User { Name="Pınar", Role="Admin"},
                 new User { Name="Salih", Role="Editor"},
                 new User { Name="Samet", Role="Admin"}
            };
        }
    }
}
