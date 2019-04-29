using System;

namespace oop
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer();
            var cx = new Customer("André", "andre@balta.io");
            customer.Edit("André");
            customer.Edit("André", "andre@balta.io");

            Console.WriteLine(customer);
            Console.WriteLine(customer.ToString());
        }
    }


    // Virtual
    public class Person
    {
        public int Id { get; private set; }

        public virtual void ChangeId(int id)
        {
            Id = id;
        }
    }

    public class Customer : Person
    {
        public Customer() { }

        public Customer(string name, string email)
        {
            Name = name;
            Email = email;
        }

        public string Name { get; private set; }
        public string Email { get; private set; }

        public void Edit(string name)
        {
            Name = name;
        }

        public void Edit(string name, string email)
        {
            Name = name;
            Email = email;
        }

        public override string ToString()
        {
            return Name;
        }

        public override void ChangeId(int id)
        {
            // Do some stuff
        }
    }
}
