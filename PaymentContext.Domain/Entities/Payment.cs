using System;
using Flunt.Validations;
using PaymentContext.Domain.ValueObjects;
using PaymentContext.Shared.Entities;

namespace PaymentContext.Domain.Entities
{
    public abstract class Payment : Entity
    {
        protected Payment(DateTime paidDate, DateTime expireDate, decimal total, decimal totalPaid, string owner, Document document, Address addres, Email email)
        {
            Number = Guid.NewGuid().ToString().Replace("-","").Substring(0,10).ToUpper();
            PaidDate = paidDate;
            ExpireDate = expireDate;
            Total = total;
            TotalPaid = totalPaid;
            Owner = owner;
            Document = document;
            Addres = addres;
            Email = email;

            AddNotifications(new Contract()
            .Requires()
            .IsGreaterThan(0,Total,"Payment.Total","O Total deve ser maior que zero")
            .IsGreaterOrEqualsThan(Total,TotalPaid,"Payment.TotalPaid","O valor pago é menor que o valor do pagamento")
            );
        }
       
        
        public string Number { get; private set; }//Numero Interno, nosso.
        public DateTime PaidDate { get; private set; }//Data Pagamento
        public DateTime ExpireDate { get; private set; }//Data de Validade/Data de expiração
        public decimal Total { get; private set; }
        public decimal TotalPaid { get; private set; }//Total Pago.
        public string Owner { get; private set; }//Proprietário.
        public Document Document { get; private set; }//
        public Address Addres { get; private set; }
        public Email Email { get; private set; }

    }
    
}