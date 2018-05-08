using System.Collections.Generic;
using System.Linq;

namespace PaymentContext.Domain.Entities {
    public class Student {
        private IList<Subscription> _subscritpions;
        public Student (string firstName, string lastName, string document, string email) {
            FirstName = firstName;
            LastName = lastName;
            Document = document;
            Email = email;
            _subscritpions = new List<Subscription>();
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Document { get; private set; }
        public string Email { get; private set; }
        public string Address { get; private set; }
        public IReadOnlyCollection<Subscription> Subscriptions { get{return _subscritpions.ToArray();}}

        public void AddSubscription (Subscription subscription) {
            //Se tiver uma assinatura ativa cancela

            //Cancela todas as outras assinaturas e coloca essa como principal
            foreach (var sub in Subscriptions) {
                sub.Inactivate();
            }
            _subscritpions.Add(subscription);
        }
    }

}