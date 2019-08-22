using System;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Domain.Entities
{
  public class PayPalPayment : Payment
  {
    public PayPalPayment(string transaction, DateTime paiDate, DateTime expireDate, decimal total, decimal totalPaid, string payer, Document document, Address address, Email email) : base(paiDate, expireDate, total, totalPaid, payer, document, address, email)
    {
      TransactionCode = transaction;
    }

    public string TransactionCode { get; private set; }
  }
}