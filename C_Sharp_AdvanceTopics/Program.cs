﻿using ReadOnlyCustomer=C_Sharp_AdvanceTopics_ReadOnlyConcept;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C_Sharp_AdvanceTopics.ClassConcept;

namespace C_Sharp_AdvanceTopics
{
    
    class Program
    {

        static void Main(string[] args)
        {
            ConstructorOverLoading();
            MethodOverloading();
            UseOfParamArgumentModifier();
            UsagesOfOut();
            UseOfRefArgumentModifiers();
            UseOfReadOnly();
            UserOfProperties();
            UseOfIndexes();

        }

        private static void UseOfIndexes()
        {
            Console.WriteLine("Use of Indexer");
            Indexer indexer = new Indexer();
            indexer["Name"] = "This is test text";
            Console.WriteLine(indexer["Name"]);
            Console.ReadLine();
        }

        private static void UserOfProperties()
        {
            Console.WriteLine("Use of Encapsulation");
            Encapsulation.Customer customer = new Encapsulation.Customer();
            customer.SetBirthday(new DateTime(1990, 6, 24));
            Console.WriteLine("Age of Customer Today:{0}", customer.Age);

        }

        private static void UseOfReadOnly()
        {
            ReadOnlyCustomer.Customer customer = new ReadOnlyCustomer.Customer();
            Console.WriteLine("Order Detail for First Customer");
            customer.Order.Add(new ReadOnlyCustomer.Orders { OrderNumber = 1, OrderSummary = "Item1" });
            foreach (var order in customer.Order)
            {
                Console.WriteLine("Order number :{0} and Order Summary:{0}", order.OrderNumber, order.OrderSummary);
            }
            /*
             *as in above class Order is not declared as read only so you might accidently assign it new object and old values gonna destroyed;
             * to above this we gonna use readOnly
             */
            Console.WriteLine("Order Detail for Second Customer");
            ReadOnlyCustomer.Customer customer1 = new ReadOnlyCustomer.Customer();
            foreach (var order in customer1.Order)
            {
                Console.WriteLine("Order number :{0} and Order Summary:{0}", order.OrderNumber, order.OrderSummary);
            }
            /*
             * so as we see second customer don't have any order that's true.
             * that reveals a concept that readonly fields cannot be assigned to(except in construtor or variable initializer)
             * uncomment method InitializeCustomerOrder under  ReadOnlyCustomer.Customer and see the error message
             */
        }

        private static void UseOfRefArgumentModifiers()
        {
            /*
             * int refVar is value type if you pass it directly and look it's value after the method call then you get it's original
             * value there never gonna change but if you pass it by ref(pass by ref means passing varible with point to it's address in memory befault value types 
             * occupies memory in stack and ref types occupy memory in heap .Heap and stack are just ther logical memory section for yor program elements)
             * Latter on we will discuss this stack and heap in greater detail.
             */
            int refVar = 9;
            DoSomeOperationOnRefVariable(ref refVar);
            Console.WriteLine("value of refVar after doing some operation:{0}", refVar);
        }

        private static void DoSomeOperationOnRefVariable(ref int refVar)
        {
            refVar += 2;
        }

        private static void UsagesOfOut()
        {
            Console.WriteLine("use of Out Argument Modifier");
            UseOfOutArumentModifier(out int number);
            Console.WriteLine(number);
            Console.WriteLine("example of out in .Net built in methods");
            int result = 0;
            UseOfOutWithTryParseMethod("abc", out result);
            Console.WriteLine("what we got after conveersion:{0}", result);
            UseOfOutWithTryParseMethod("234", out result);
            Console.WriteLine("what we got after conveersion:{0}", result);
        }

        private static void UseOfOutWithTryParseMethod(string v, out int result)
        {
            bool isConvertable = int.TryParse(v,out result);
            if (isConvertable)
                Console.WriteLine("conversion Successfull");
            else
                Console.WriteLine("Conversion Failed");

        }

        private static void UseOfOutArumentModifier(out int number)
        {
            //even out argument modifier is not the best practice but there are some situations when we have to use this.

            // out can help to return values while actually your method does'nt have any return type
            number = 6;

        }

       
        private static void UseOfParamArgumentModifier()
        {
            Console.WriteLine("Use of Method Argument Modifiers Like Ref,Out and Params");
            Console.WriteLine("Use of Param Argument Modifier");
            Calculations calulate = new Calculations();
            Console.WriteLine("Sum of number by passing new Array of number:{0} ", calulate.Add(new int[] { 1, 2, 3, 4 }));
            Console.WriteLine("Sum of number by passing numbers:{0} ", calulate.Add(1, 2, 3, 4));
        }

        private static void MethodOverloading()
        {
            Console.WriteLine("=============Methods=============");
            try
            {
                var point = new Point(10, 20);
                point.Move(new Point(40, 30));
                Console.WriteLine("Point is at x:{0} and y:{1}", point.X, point.Y);
                point.Move(100, 200);
                Console.WriteLine("Point is at x:{0} and y:{1}", point.X, point.Y);
                point.Move(null);
                Console.WriteLine("Point is at x:{0} and y:{1}", point.X, point.Y);
            }
            catch (Exception ex)
            {

                Console.WriteLine("Unhandled Excceptions:{0}", ex.Message);
            }
        }

        private static void ConstructorOverLoading()
        {
            //Initializing object with Constructor syntax
            var Customer = new Customer(1, "Name");
            //object Initializaition for Order class intead of Creating Multiple Constructors
            //For Object Initializaion consider curly braces after new Order
            Customer.Orders.Add(new Orders { OrderId = 1, OrderDetail = "Excellent C#Book" });
            //{0} is called place holders
            Console.WriteLine("Customer Id:{0} and Customer Name:{0}", Customer.Id, Customer.Name);
            Console.WriteLine("==========Order Detail=============");
            foreach (var item in Customer.Orders)
            {
                Console.WriteLine("OrderId:{0} and OrderDetail:{1}", item.OrderId, item.OrderDetail);
            }
        }
    }
}