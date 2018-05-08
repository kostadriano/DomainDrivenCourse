using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Entities;
using PaymentContext.Domain.Enums;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Tests {
    [TestClass]

    public class StudentTest {

        private readonly Student _student;
        private readonly Document _document;
        private readonly Email _email;
        private readonly Name _name;
        private readonly Subscription _subscription;
        public StudentTest () {
            _name = new Name ("Adriano", "Costa");
            _document = new Document ("85284205073", EDocumentType.CPF);
            _email = new Email ("email@email.com");

            _subscription = new Subscription (null);
            _student = new Student (_name, _document, _email);

        }

        [TestMethod]
        public void ShouldReturnErrorWhenActiveSubscription () {
            var payment = new PayPalPayment ("1031654", DateTime.Now, DateTime.Now.AddDays (5), 10, 10, _document, "Corp", null, _email);
            _subscription.AddPayment (payment);

            _student.AddSubscription (_subscription);
            _student.AddSubscription (_subscription);

            Assert.IsTrue (_student.Invalid);
        }
        [TestMethod]
        public void ShouldReturnErrorWhenSubscriptionHasNoPayment () {
            _student.AddSubscription(_subscription);
            Assert.IsTrue(_student.Invalid);
        }
         [TestMethod]
        public void ShouldReturnSuccessWhenActiveSubscription () {
            var payment = new PayPalPayment ("1031654", DateTime.Now, DateTime.Now.AddDays (5), 10, 10, _document, "Corp", null, _email);
            _subscription.AddPayment (payment);

            _student.AddSubscription (_subscription);
            _student.AddSubscription (_subscription);
            

            Assert.IsTrue (_student.Invalid);
        }
    }
}