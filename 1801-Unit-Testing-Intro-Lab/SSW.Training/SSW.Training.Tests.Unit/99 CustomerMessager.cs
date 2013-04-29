using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SSW.Training.Tests.OrderManager_Before;

namespace SSW.Training.Tests.OrderManager_Before
{
    public class OrderManager
    {
        public OrderManager()
        {
            TaxRate = 0.1M;
        }

        public decimal TaxRate { get; set; }

        public decimal GetTotalIncGST(Order order)
        {
            decimal total = 0;

            total = order.OrderItems.Sum(oi => oi.Quantity*oi.UnitPrice)*(1 + TaxRate);

            return total;
        }

        public void Process(Customer customer, Order order)
        {

        }

        private void SendEmail()
        {

        }

    }

    public class OrderItem
    {
        public decimal Quantity { get; set; }
        public decimal UnitPrice { get; set; }
    }

    public class NorthwindDataContext : IDisposable
    {
        public NorthwindDataContext()
        {
            Orders = new List<Order>();

            var order = new Order();
            order.OrderItems.Add(new OrderItem() {Quantity = 1M, UnitPrice = 5.0M});
            order.OrderItems.Add(new OrderItem() {Quantity = 2M, UnitPrice = 3.5M});
            Orders.Add(order);
        }

        public List<Order> Orders { get; set; }

        public void Save()
        {
            Console.WriteLine("Saved to database");
        }

        public void Dispose()
        {

        }
    }

    public class Order
    {
        public List<OrderItem> OrderItems { get; set; }

        public Order()
        {
            OrderItems = new List<OrderItem>();
        }
    }

    public class Customer
    {
        public string Name { get; set; }
        public string Email { get; set; }
    }

    public class Message
    {
        public string Subject { get; set; }
        public string Body { get; set; }
    }

    public class NotificationService
    {
        public void Send(Message message, Customer customer)
        {
            var mail = new MailMessage();

            mail.To.Add(customer.Email);
            mail.Subject = message.Subject;
            mail.Body = message.Body;

            using (var smtp = new SmtpClient())
            {
                smtp.Send(mail);
            }
        }
    }

    //our first attempt at a test.
    namespace UnitTests_Version1
    {
        public class Tests
        {
            public void TestProcess()
            {
                var order = new Order();
                var orderItem = new OrderItem { UnitPrice = 5M, Quantity = 2M };
                order.OrderItems.Add(orderItem);

                var customer = new Customer { Name = "Adam Stephensen", Email = "adamstephensen@ssw.com.au" };

                var orderManager = new OrderManager();
                orderManager.Process(customer, order);
            }
        }
    }

    namespace Integration_Tests
    {

        [TestClass]
        public class NotificationServiceTests
        {
            [TestMethod]
            public void Send_Always_SendsMessage()
            {
                var service = new NotificationService();
                var message = new Message {Subject = "Test Subject", Body = "Test Body"};
                var customer = new Customer {Name = "Adam Stephensen", Email = "adamstephensen@ssw.com.au"};
                service.Send(message, customer);
            }
        }
    }


    namespace UnitTests
    {
    
        [TestClass]
        public class OrderManagerTests
        {
            [TestMethod]
            public void TestCalculation()
            {
                var orderManager = new OrderManager();
                using (var db = new NorthwindDataContext())
                {
                    Order order = db.Orders.FirstOrDefault();
                    decimal actual = orderManager.GetTotalIncGST(order);
                    decimal expected = order.OrderItems.Sum(oi => oi.Quantity*oi.UnitPrice)*1.1M;
                    Assert.AreEqual(actual, expected);
                }
            }
        }
    }

}