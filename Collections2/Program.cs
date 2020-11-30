using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections2
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> cities = new List<string>();
            cities.Add("Ankara");
            cities.Add("İstanbul");

            Console.WriteLine(cities.Contains("Ankara"));

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }

            //List<Customer> customers = new List<Customer>();
            //customers.Add(new Customer { Id = 1, FirstName = "Anıl" });
            //customers.Add(new Customer { Id = 2, FirstName = "Ozan" });

            List<Customer> customers = new List<Customer>
            {
                new Customer{Id=1,FirstName="Anıl"},
                new Customer{Id=2,FirstName="Ozan"}
            };

            Console.WriteLine(customers.Contains(new Customer { Id = 1, FirstName = "Anıl" }));

            var customer1 = new Customer
            {
                Id = 3,
                FirstName = "Salih"
            };
            customers.Add(customer1);
            customers.AddRange(new Customer[2] { new Customer { Id = 4, FirstName = "Ali" }, new Customer { Id = 5, FirstName = "Ayşe" } });
            foreach (var customer in customers)
            {
                Console.WriteLine(customer.FirstName);
            }

            //customers.Clear();

            var index = customers.IndexOf(customer1);
            Console.WriteLine("Index : {0}", index);

            customers.Add(customer1);

            var index2 = customers.LastIndexOf(customer1);
            Console.WriteLine("Index : {0}", index2);

            customers.Insert(0, customer1);

            customers.Remove(customer1);
            customers.RemoveAll(c => c.FirstName == "Salih");

            var count = customers.Count;
            Console.WriteLine(count);

            Console.ReadLine();
        }
    }

    class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
    }
}
