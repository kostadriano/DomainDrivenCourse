using System;
using System.Collections.Generic;
using Flunt.Validations;
using PaymentContext.Shared.Entities;

namespace PaymentContext.Domain.Entities {
    public class Subscription : Entity {
        private List<Payment> _payments;
        public Subscription (DateTime? expireDate) {
            CreateDate = DateTime.Now;
            LastUpdateDate = DateTime.Now;
            ExpireDate = expireDate;
            Active = true;
            _payments = new List<Payment> ();
        }

        public DateTime CreateDate { get; private set; }
        public DateTime LastUpdateDate { get; private set; }
        public DateTime? ExpireDate { get; private set; }
        public bool Active { get; private set; }
        public IReadOnlyCollection<Payment> Payments { get { return _payments.ToArray (); } }

        public void AddPayment (Payment payment) {
            //Ver se a data do pagamento nao e no passado
            AddNotifications (new Contract ()
                .Requires ()
                .IsGreaterThan (DateTime.Now, payment.PaidDate, "Subscriptions.Payments", "A data do pagamento nao pode ser maior que hoje"));
            
            
            _payments.Add (payment);
        }
        public void Activate () {
            Active = true;
            LastUpdateDate = DateTime.Now;
        }
        public void Inactivate () {
            Active = false;
            LastUpdateDate = DateTime.Now;
        }
    }

}