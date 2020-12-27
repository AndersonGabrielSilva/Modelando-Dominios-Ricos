using System;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Domain.Entities
{
    
    public class CreditCardPayment: Payment
    {
        public CreditCardPayment(string cardHolderName, string cardNumber, string lastTransactionNumber,DateTime paidDate, DateTime expireDate, decimal total, decimal totalPaid, string owner, Document document, Address addres, Email email)
        :base( paidDate,expireDate,total,totalPaid,owner,document,addres,email)
        {
            CardHolderName = cardHolderName;
            CardNumber = cardNumber;
            LastTransactionNumber = lastTransactionNumber;
        }

        public string CardHolderName { get; private set; }//Nome Titular do Cartão.
        public string CardNumber { get; private set; }//Quatro ultimos numeros do cartão.
        public string LastTransactionNumber { get; private set; }//Último Número de Transações.
    }
}