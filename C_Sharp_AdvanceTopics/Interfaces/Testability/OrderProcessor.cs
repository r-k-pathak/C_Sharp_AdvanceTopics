using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_AdvanceTopics.Interfaces
{
   public  class OrderProcessor
    {
        private readonly IShippingCalculator _shipmentCalculator;
        public OrderProcessor(IShippingCalculator _shipmentCalculator)
        {
            this._shipmentCalculator = _shipmentCalculator;
        }
        public void Process(Order order)
        {
            if (order.IsShipped)
                throw new InvalidOperationException("Order is already shipped.");
            order.Shipment = new Shipment
            {
                Cost = _shipmentCalculator.CalculateShipping(order),
                ShipmentDate = DateTime.Now.AddDays(1)
            };
            Console.WriteLine("Order is processed successfully");

        }
    }
}
