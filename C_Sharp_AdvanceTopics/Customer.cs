using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C_Sharp_AdvanceTopics;

namespace C_Sharp_AdvanceTopics
{
    public class Customer
    {
        public int Id;
        public string Name;
        public List<Orders> Orders;
        public Customer()
        {
            Orders = new List<Orders>();
        }
        //This to call other constructors of the class to avoid repeating line of code
        // for example if we done use this() then to initialize List<Orders> 
        //, we will have to copy/past same line in each constructors
        
        //We have overloaded constructors  which are distinquised by order and type of parameters
        //You can avoid declaring constructor's by using object initializer Syntax as we using in main() for Orders
        public Customer(int id):this()
        {
            this.Id = id;
        }
        public Customer(int id,string name):this(id)
        {
            this.Id = id;
            this.Name = name;
        }

    }
}
