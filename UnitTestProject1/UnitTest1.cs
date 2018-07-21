using System;
using C_Sharp_AdvanceTopics.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class OrderProcessorTest
    {
        //MethodName_Condition_Expectation
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Process_OrderIsAlreadyShiped_ThrowsAnException()
        {
            var orderProcessor = new OrderProcessor( new FakeShippingCalculator());
            var order = new Order
            {
                Shipment=new Shipment()
            };
            orderProcessor.Process(order);
        }
        [TestMethod]
        public void Process_OrderIsNotShiped_shouldSetTheShipmentPropertyOfshipmentClass()
        {
            var orderProcessor = new OrderProcessor(new FakeShippingCalculator());
            var order = new Order();
            orderProcessor.Process(order);
            Assert.IsTrue(order.IsShipped);
            Assert.AreEqual(1, order.Shipment.Cost);
            Assert.AreEqual(DateTime.Today.AddDays(1), order.Shipment.ShipmentDate);
        }
    }


    public class FakeShippingCalculator : IShippingCalculator
    {
        public float CalculateShipping(Order order)
        {
            return 1;
        }
    }
}
