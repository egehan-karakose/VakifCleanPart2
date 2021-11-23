using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
  public  class DataHelper
    {
        public void ExecuteCommand()
        {
            SqlConnection sqlConnection = null;
            try
            {
                sqlConnection.Open();
            }
            catch (SqlException error)
            {

                throw error;
            }
        }
    }
}
