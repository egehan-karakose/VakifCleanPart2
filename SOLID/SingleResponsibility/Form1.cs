using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SingleResponsibility
{
    public partial class Form1 : Form
    {
        //Formun görevi, kullanıcıya arayüz oluşturmaktır!!!!
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
             * Her sınıf, tek bir işten sorumlu olmalıdır!!!!!1!1!!!!
             * 
             * Eğer bir sınıfta değişiklik yapmak için birden fazla sebebiniz varsa, bu prensibi ihlal ediyorsunuz demektir.
             */
        }

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            ProductsService productsService = new ProductsService();
            string name = textBoxProductName.Text;
            double price = Convert.ToDouble(textBoxPrice.Text);
            var product = new Product { Name = name, Price = price };
            var affectedRowCount = productsService.AddProduct(product);       

            string message = affectedRowCount > 0 ? "Başarılı" : "Başarısız";

            MessageBox.Show(message);
        }
    }
}
