using System;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Domain.Entities
{
    public class PayPalPayment: Payment
    {
        public PayPalPayment(string transactionCode,DateTime paidDate, DateTime expireDate, decimal total, decimal totalPaid, string owner, Document document, Address addres, Email email)
        :base( paidDate,expireDate,total,totalPaid,owner,document,addres,email)
        {
            TransactionCode = transactionCode;
        }

        public string TransactionCode { get; private set; }//Código de Transações.
        
    }
}