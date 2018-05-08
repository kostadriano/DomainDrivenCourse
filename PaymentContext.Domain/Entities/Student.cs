using System;
using System.Collections.Generic;
using System.Linq;
using PaymentContext.Domain.ValueObjects;
using PaymentContext.Shared.Entities;

namespace PaymentContext.Domain.Entities {
    public class Student : Entity {
        private IList<Subscription> _subscritpions;
        public Student (Name name,
            Document document,
            string email,
            Address address
        ) {

            Name = name;
            Address = address;
            Document = document;
            Email = email;
            _subscritpions = new List<Subscription> ();
        }

        public Name Name { get; private set; }
        public Document Document { get; private set; }
        public string Email { get; private set; }
        public Address Address { get; private set; }
        public IReadOnlyCollection<Subscription> Subscriptions { get { return _subscritpions.ToArray (); } }

        public void AddSubscription (Subscription subscription) {
            //Se tiver uma assinatura ativa cancela

            //Cancela todas as outras assinaturas e coloca essa como principal
            foreach (var sub in Subscriptions) {
                sub.Inactivate ();
            }
            _subscritpions.Add (subscription);
        }
    }

}