using System;

namespace PaymentContext.Domain.Commands {
    public class CreatePayPalSubscritpionCommand {
        public string FirstName { get;  set; }
        public string LastName { get;  set; }
        public string Number { get;  set; }
        public string Address { get;  set; }
        public string TransactionCode { get;  set; }
        public string PaymentNumber { get;  set; }
        public DateTime PaidDate { get;  set; }
        public DateTime ExpireDate { get;  set; }
        public decimal Total { get;  set; }
        public decimal Totalpaid { get;  set; }
        public string PayerDocument { get;  set; }
        public string Payer { get;  set; }
        public string Email { get;  set; }
    }
}