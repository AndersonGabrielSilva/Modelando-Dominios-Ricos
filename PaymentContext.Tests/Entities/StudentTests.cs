using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Entities;
using PaymentContext.Domain.ValueObjects;
using System;

namespace PaymentContext.Tests
{
    [TestClass]
    public class StudentTests
    {
        private readonly Name _name;
        private readonly Document _document;
        private readonly Email _email;
        private readonly Address _address;
        private readonly Student _student;
        private readonly Subscription _subscription;

        public StudentTests()
        {
            _name = new Name("Anderson", "Gabriel");
            _document = new Document("42813652396", Domain.Enums.EDocumentType.CPF);
            _email = new Email("andersonsilva@silva.com");
            _address = new Address("Rua Ponton", "1010", "Dos Touros", "Boiadeiros", "SP", "BR", "14023654");
            _student = new Student(_name, _document, _email);
            _subscription = new Subscription(null);

        }

        [TestMethod]
        public void ShoulReturnErrorWhenHadActiveSubscription()//Retorne um erro quando ouver uma assinatura ativa
        {
            var payment = new PayPalPayment("12345678", DateTime.Now, DateTime.Now.AddDays(5),
                       10, 10, "Wayne Corp", _document, _address, _email);

            _subscription.AddPayment(payment);
            _student.AddSubscription(_subscription);
            _student.AddSubscription(_subscription);

            Assert.IsTrue(_student.Invalid);
        }

        [TestMethod]
        public void ShoulReturnSucessWhenHadNoActiveSubscription()//Retorne secesso quando não tiver uma assinatura ativa
        {
            _student.AddSubscription(_subscription);
            _student.AddSubscription(_subscription);

            Assert.IsTrue(_student.Valid);
        }

        [TestMethod]
        public void ShoulReturnErrorWhenHadActiveSubscriptionHasNoPayment()//Retorne um erro quando ouver uma assinatura ativa
        {          
            _student.AddSubscription(_subscription);
            Assert.IsTrue(_student.Invalid);
        }

        [TestMethod]
        public void ShoulReturnSucessWhenHadAddSubscriptionHasPayment()//Retorne secesso quando não tiver uma assinatura ativa
        {
                  var payment = new PayPalPayment("12345678", DateTime.Now, DateTime.Now.AddDays(5),
                       10, 10, "Wayne Corp", _document, _address, _email);

            _subscription.AddPayment(payment);
            _student.AddSubscription(_subscription);

            Assert.IsTrue(_student.Valid);
        }
    }
}
