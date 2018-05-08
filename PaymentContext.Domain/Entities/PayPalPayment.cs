using System;

namespace PaymentContext.Domain.Entities {
    public class PayPalPayment : Payment {
        public PayPalPayment (string transactionCode, DateTime paidDate, DateTime expireDate, decimal total, decimal totalpaid, string document, string payer, string address, string email) : base (paidDate, expireDate, total, totalpaid, document, payer, address, email) {
            TransactionCode = transactionCode;
        }

        //Just Need Email
        public string TransactionCode { get; private set; }
    }
}