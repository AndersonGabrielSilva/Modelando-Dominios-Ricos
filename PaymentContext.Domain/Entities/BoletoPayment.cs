using System;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Domain.Entities
{    

    public class BoletoPayment : Payment
    {
        public BoletoPayment(string barCode, string boletoNumber,DateTime paidDate, DateTime expireDate, decimal total, decimal totalPaid, string owner, Document document, Address addres, Email email)
        :base( paidDate,expireDate,total,totalPaid,owner,document,addres,email)
        {
            BarCode = barCode;
            BoletoNumber = boletoNumber;
        }

        public string BarCode { get; private set; }//Codigo de Barras.
        public string BoletoNumber { get; private set; }//Numero do Boleto.
    }

   
}