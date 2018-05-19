using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_AdvanceTopics
{
    
    class Program
    {
        static void Main(string[] args)
        {
            //Initializing object with Constructor syntax
            var Customer = new Customer(1,"Name");
            //object Initializaition for Order class intead of Creating Multiple Constructors
            //For Object Initializaion consider curly braces after new Order
            Customer.Orders.Add(new Orders { OrderId = 1, OrderDetail = "Excellent C#Book" });
            //{0} is called place holders
            Console.WriteLine("Customer Id:{0} and Customer Name:{0}",Customer.Id,Customer.Name);            
            Console.WriteLine("==========Order Detail=============");
            foreach (var item in Customer.Orders)
            {
                Console.WriteLine("OrderId:{0} and OrderDetail:{1}", item.OrderId, item.OrderDetail);
            }
            Console.ReadLine();
            
        }
    }
}
