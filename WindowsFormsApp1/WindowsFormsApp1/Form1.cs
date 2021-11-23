using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Product product = new Product();
            //product.v
        }
        List<ExceptionMessage> messages = new List<ExceptionMessage>();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int sayi1 = Convert.ToInt32(textBox1.Text);
                int sayi2 = Convert.ToInt32(textBox2.Text);
                int sonuc = sayi1 / sayi2;
                MessageBox.Show(sonuc.ToString()); //burada bazen hata dönüyor. Neden bilmiyorum!
                                                   //Biliyorum kod biraz kötü ama sonuçta çalışıyor! 
            }
            catch (FormatException x)
            {
                //TODO 1: Uygulamayı test et
                messages.Add(new ExceptionMessage { Detail = nameof(button1_Click), Message = x.Message });
            }
            catch (DivideByZeroException y)
            {
                //TODO 2: 0'a bölmeyi test et:
                //MessageBox.Show("Tam sayılar 0'a bölünemez");
                messages.Add(new ExceptionMessage { Detail = nameof(button1_Click), Message = y.Message });
            }
        }
    }
}
