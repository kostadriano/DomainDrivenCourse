using System;

namespace PaymentContext.Domain.Entities {

    public class BoletoPayment : Payment {
        public BoletoPayment (string barCode, string boletoNumber, DateTime paidDate, DateTime expireDate, decimal total, decimal totalpaid, string document, string payer, string address, string email) : base (paidDate, expireDate, total, totalpaid, document, payer, address, email) {
            BarCode = barCode;
            BoletoNumber = boletoNumber;
        }

        public string BarCode { get; private set; }
        public string BoletoNumber { get; private set; }

    }
}