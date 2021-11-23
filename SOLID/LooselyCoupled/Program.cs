using System;

namespace LooselyCoupled
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            //person.
        }
    }

    public class Person
    {
        public IAddress HomeAddress { get; set; }

    }

    public class Address :IAddress
    {
        public string City { get; set; }
        public string Street { get; set; }
    }

    public interface IAddress
    {

    }
}
