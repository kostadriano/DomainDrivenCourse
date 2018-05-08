using System;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Domain.Entities {
        public class CreditCardPayment : Payment{
        public CreditCardPayment(string cardNumber, string cardHolderName, string lastTransactionNumber,DateTime paidDate, DateTime expireDate, decimal total, decimal totalpaid, Document document, string payer, Address address, Email email) : base (paidDate, expireDate, total, totalpaid, document, payer, address, email)
        {
            CardNumber = cardNumber;
            CardHolderName = cardHolderName;
            LastTransactionNumber = lastTransactionNumber;
        }

        public string CardNumber { get; private set; }
        public string CardHolderName { get; private set; }
        public string LastTransactionNumber { get; private set; }
        
    }
}