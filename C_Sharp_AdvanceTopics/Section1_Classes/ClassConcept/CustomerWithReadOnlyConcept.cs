using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_AdvanceTopics_ReadOnlyConcept
{
    class Customer
    {
        //now if create object of this class you gonner get a empty list each time 
        public readonly List<Orders> Order = new List<Orders>();
        //public void InitializeCustomerOrder()
        //{
        //    this.Order = new List<C_Sharp_AdvanceTopics.Orders>();
        //}

    }
    class Orders
    {
        public int OrderNumber;
        public string OrderSummary;
    }
}
