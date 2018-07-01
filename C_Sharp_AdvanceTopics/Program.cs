using ReadOnlyCustomer=C_Sharp_AdvanceTopics_ReadOnlyConcept;
using System;
using C_Sharp_AdvanceTopics.ClassConcept;
using C_Sharp_AdvanceTopics.Section1.Exercise_Solution;
using C_Sharp_AdvanceTopics.Section2_Inheritance.Association;
using C_Sharp_AdvanceTopics.Section2_Inheritance.Inheritacne;
using C_Sharp_AdvanceTopics.Section2_Inheritance;
using C_Sharp_AdvanceTopics.Section2_Inheritance.BoxingAndUnBoxing.Structure;
using C_Sharp_AdvanceTopics.Section2_Inheritance.Exercise;
using C_Sharp_AdvanceTopics.MethodOverriding;
using C_Sharp_AdvanceTopics.Pollymorphism.AbstractClass;
using C_Sharp_AdvanceTopics.Pollymorphism.Sealed;

namespace C_Sharp_AdvanceTopics
{
   
    
    class Program
    {

        static void Main(string[] args)
        {
            #region section1-Classes
            //ConstructorOverLoading();
            //MethodOverloading();
            //UseOfParamArgumentModifier();
            //UsagesOfOut();
            //UseOfRefArgumentModifiers();
            //UseOfReadOnly();
            //UserOfProperties();
            //UseOfIndexes();
            #region Exercise And Solution
            //StopWatch stopWatch = new StopWatch();
            //CommonStartUpMessage();
            //while (true)
            //{
            //    string userInput = Console.ReadLine();
            //    switch (userInput)
            //    {
            //        case "start":
            //            try
            //            {
            //                stopWatch.StartClock();
            //            }
            //            catch (Exception ex)

            //            {
            //                Console.WriteLine(ex.Message);
            //                CommonStartUpMessage();
            //            }

            //            break;
            //        case "stop":
            //            stopWatch.StopClock();
            //            break;
            //        case "duration":
            //            Console.WriteLine(stopWatch.Duration);
            //            break;

            //        case "exit":
            //            Environment.Exit(0);
            //            break;
            //        default:
            //            Console.WriteLine("Please provide valid input");
            //            CommonStartUpMessage();
            //            break;
            //    }
            //}

            #endregion
            #endregion
            #region section-2 
            //Access modifiers

            //for detail find the class inside Section2_Inheritance/AccessModifiers
            #region Association
            /*
             * We have two ways of code re-usablity Inheritance and Composition
             * Here we will be discussing about Composition . and it's benifits over Inheritance
             * When talk about best software design then we come to point about loos coupling means changes in one class should 
             * not afftect the other's or affect should be very minor.
             * Inheritnace come up with tight coupling this depend on project requirement what we have to use there.
             * But composition comes up with loos coupling .This is also knows as HAS-A relation whereas Inheritance is also knowns as 
             * IS-A relation.
             * Read the descriptions mentionsed in each class under this section.
             */
            //Logger logger = new Logger();
            //var dbMigrator = new DbMigrator(logger);
            //dbMigrator.Migrate();
            //var installer = new Installer(logger);
            //installer.Install();

            #endregion
            #region Inheritacne
            //string registrationNumber = "cbfh";
            //Car car = new Car(registrationNumber);
            //Console.WriteLine("Car regisration number is :{0}", car.GetRegistationNumber());
            //Console.WriteLine("Car Specs are :{0}", car.GetCarSpecs());
            ///*Now let's understand Upcasting(derived class=> Base class) and downcasting(BaseClass to Derived class)
            // * Upcasting is implicit
            // * Downcasting is explicit
            // * Let's see itmes in action
            // */
            ////Way one upcasting
            //Vehicle vehicle = car;
            //Console.WriteLine("Car regisration number is :{0}", vehicle.GetRegistationNumber());
            ////below line will not compile because Vehicle does not have any info regarding car
            ////Console.WriteLine("Car Specs are :{0}", vehicle.GetCarSpecs());

            ////Down Casting which is Explicit
            ////way one Down casting
            //Car car1 = (Car)vehicle;
            //Console.WriteLine("Car regisration number is :{0}", car1.GetRegistationNumber());
            ////---To avoid wrong Downcasting you can use any of the below ways otherwise it will throw invalid cast exception
            ////Way two upcasting
            //if (vehicle is Car)//This will be false if car is not derived from Vehicle
            //{
            //    Car car2 = (Car)vehicle;
            //    Console.WriteLine("Car regisration number is :{0}", car2.GetRegistationNumber());
            //    Console.WriteLine("Car Specs are :{0}", car2.GetCarSpecs());
            //}
            ////Way three Upcasting
            ////This will return null if car is not derived from Vehilce
            //Car car3 = vehicle as Car;
            //if (vehicle != null)
            //{
            //    Vehicle vehicle1 = car;
            //    Console.WriteLine("Car regisration number is :{0}", car3.GetRegistationNumber());
            //    Console.WriteLine("Car Specs are :{0}", car3.GetCarSpecs());

            //}

            #endregion
            #region Boxing and UnBoxing
            //Test t1;
            //Test t2 = new Test();
            //Console.WriteLine("Stack Initialized Values");
            ////Console.WriteLine("a:{0},b:{0}", t1.a, t1.b);
            //Console.WriteLine("Heap Initialized Vaues");
            //Console.WriteLine("a:{0},b:{0}", t2.a, t2.b);
            #endregion

            //Note structure does not takes memory inside the object even if they are declare inside the class
            //otherwise we would be able to access the  object just with reference but this is not possible
            //When every you initialize struct with new keywork there is always seperate memory allocation.
            //CoOrdinates.SampleStruct t = new CoOrdinates.SampleStruct();
            //    Console.WriteLine("a:{0}",t.a);
            //Console.WriteLine("......Test static ....");
            //CoOrdinates c = new CoOrdinates();

            //CoOrdinates.StaticMethod();
            //c.InstanceMethod();
            //c.PrintstrutureMember();
            //c.StrucOutSideTheClass();
            //CoOrdinates c1 = new CoOrdinates();
            //c1.PrintstrutureMember();
            #region Exercise
            //Stack stack = new Stack();
            //try
            //{

            //    stack.Push(1);
            //    stack.Push(2);
            //    stack.Push(3);
            //    Console.WriteLine(stack.Pop());
            //    Console.WriteLine(stack.Pop());
            //    Console.WriteLine(stack.Pop());
            //}
            //catch(Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            #endregion


            #endregion
            #region Method overriding
            //Circle circle = new Circle();
            //circle.Draw();
            //Rectangle rectangle = new Rectangle();
            //rectangle.Draw();
            #endregion
            //#region Abstract class
            //Pollymorphism.AbstractClass.Shape square = new Square(2);
            //Console.WriteLine("Area of Square is :" + square.Area());
            //#endregion
            #region Sealed Class
            FirstClass fc = new  ThirdClass();
            fc.MethodTwo();
            #endregion
            #region Inner Classes
            #endregion


            Console.ReadLine();

        }
        public static void CommonStartUpMessage()
        {
            Console.WriteLine("Follow Instructions to use StopWatch");
            Console.WriteLine("Type start then Press enter to Start.");
            Console.WriteLine("Type stop then Press enter to Stop.");
            Console.WriteLine("Type Duration then press enter to get total duration");
            Console.WriteLine("Type exit then Press enter to Exit.\n\n\n\n");
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
           
            //customer.InitializeCustomerOrder();
            Console.WriteLine("Second order for same customer");
            customer.Order.Add(new ReadOnlyCustomer.Orders { OrderNumber = 2, OrderSummary = "Item1" });
            foreach (var order in customer.Order)
            {
                Console.WriteLine("Order number :{0} and Order Summary:{0}", order.OrderNumber, order.OrderSummary);
            }
            /*
             * The benifit of readonly field's is that they are initialized onyl once within constructor or as property initialization
             * As an example in above line of code if we dont declare Order field in customer class readonly and we accidently call method 
             * IinitializeCustomerOrder fo customer Class what will happen your previous data will be lost that the reason we declared order 
             * as read onyl .
             * if you decalare field as readonly and try to initialize it inside of method or anywhere else except in cosntructor or
             * as property initialization then compiler will detect it and show the error ,to see the error just uncomment the mehtod
             * InitializeCustomerOrder in Customer class.
             **/
           
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
