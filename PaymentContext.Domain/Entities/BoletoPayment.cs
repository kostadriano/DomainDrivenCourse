using System;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Domain.Entities {

    public class BoletoPayment : Payment {
        public BoletoPayment (string barCode, string boletoNumber, DateTime paidDate, DateTime expireDate, decimal total, decimal totalpaid, Document document, string payer, Address address, Email email) : base (paidDate, expireDate, total, totalpaid, document, payer, address, email) {
            BarCode = barCode;
            BoletoNumber = boletoNumber;
        }

        public string BarCode { get; private set; }
        public string BoletoNumber { get; private set; }

    }
}