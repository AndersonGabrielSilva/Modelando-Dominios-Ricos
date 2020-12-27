using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Entities;

namespace PaymentContext.Tests
{
    [TestClass]
    public class StudentTests
    {
        [TestMethod]
        public void AdicionarAssinatura()
        {

            var subscription = new Subscription(null);
            var student = new Student("Anderson Gabriel","Silva","123456","anderson.gmail.com");
            student.AddSubscription(subscription);




        }
    }
}
