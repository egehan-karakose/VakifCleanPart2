using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility
{
    public class ProductsService
    {
        public int AddProduct(Product product)
        {
            string connectionString = @"Data Source=(localdb)\MssqlLocaldb;Initial Catalog=innovaDb;Integrated Security=True";
            string commandText = "INSERT into Products (Name,Price,CategoryId) values (@name,@price,1) ";

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@name", product.Name);
            parameters.Add("@price", product.Price);

            SqlDataHelper sqlDataHelper = new SqlDataHelper(connectionString);
            var affectedRowCount = sqlDataHelper.ExecuteCommand(commandText, parameters);
            return affectedRowCount;


        }
    }
}
