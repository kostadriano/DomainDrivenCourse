using System;
using System.Collections.Generic;
using System.Linq;
using Flunt.Validations;
using PaymentContext.Domain.ValueObjects;
using PaymentContext.Shared.Entities;

namespace PaymentContext.Domain.Entities {
    public class Student : Entity {
        private IList<Subscription> _subscritpions;
        public Student (Name name,
            Document document,
            Email email
        ) {

            Name = name;
            Document = document;
            Email = email;
            _subscritpions = new List<Subscription> ();

            AddNotifications (name, document, email);
        }

        public Name Name { get; private set; }
        public Document Document { get; private set; }
        public Email Email { get; private set; }
        public Address Address { get; private set; }
        public IReadOnlyCollection<Subscription> Subscriptions { get { return _subscritpions.ToArray (); } }

        public void AddSubscription (Subscription subscription) {
            
            
            var hasSubscriptionActive = false;
            foreach (var sub in Subscriptions) {
                if (sub.Active)
                    hasSubscriptionActive = true;
            }

            AddNotifications (new Contract ()
                .Requires ()
                .AreEquals(0,subscription.Payments.Count,"Students.Subscription.Payments","Nao possui pagamentos")
                .IsFalse (hasSubscriptionActive, "Student.Subscriptions", "O Aluno ja tem uma assinatura ativa"));
        }
    }

}