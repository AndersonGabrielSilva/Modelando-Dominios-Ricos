using PaymentContext.Shared.ValueObject;

namespace PaymentContext.Domain.ValueObjects
{
    public class Address : ValueObject
    {
        public string Street { get; private set; }
        public string Number { get; private set; }
        public string Neighborhood { get; private set; }//Bairro
        public string City { get; private set; }
        public string State { get; private set; }//Estado
        public string Country { get; private set; }//Pais
        public string ZipCode { get; private set; }//Código Postal
    }
}