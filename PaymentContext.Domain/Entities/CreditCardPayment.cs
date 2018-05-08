using System;

namespace PaymentContext.Domain.Entities {
        public class CreditCardPayment : Payment{
        public CreditCardPayment(string cardNumber, string cardHolderName, string lastTransactionNumber,DateTime paidDate, DateTime expireDate, decimal total, decimal totalpaid, string document, string payer, string address, string email) : base (paidDate, expireDate, total, totalpaid, document, payer, address, email)
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