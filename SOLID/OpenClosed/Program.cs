using System;

namespace OpenClosed
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             *  Bir sınıf, gelişime AÇIK değişime KAPALI olmalıdır.
             *  Yeni bir özellik eklemek için var olan kodlarda değişiklik yapıyorsanız, prensibi ihlal ediyorsunuz
             */

            Customer customer = new Customer { Name = "Türkay", CartType = new Premium() };
            OrderManagement orderManagement = new OrderManagement { Customer = customer };
            var discountedPrice = orderManagement.GetDiscountedPrice(1500);
            Console.WriteLine(discountedPrice.ToString());
            Console.ReadLine();


        }

    }

    public class Customer
    {
        public string Name { get; set; }
        public ICartType CartType { get; set; }
    }

    public interface ICartType
    {
        public double discountedPrice(double price);
    
    }
    public class Standart : ICartType
    {
        public double discountedPrice(double price)
        {
            return price * 0.95;
        }
    }

    public class Silver : ICartType
    {
        public  double discountedPrice(double price)
        {
            return price * 0.97;
        }
    }

    public class Gold : ICartType
    {
        public double discountedPrice(double price)
        {
            return price * 0.90;
        }
    }

    public class Premium : ICartType
    {
        public double discountedPrice(double price)
        {
            return price * 0.8;
        }
    }


    public class OrderManagement
    {
        public Customer Customer { get; set; }
        public double GetDiscountedPrice(double price)
        {
            return Customer.CartType.discountedPrice(price);
        }
    }

}
