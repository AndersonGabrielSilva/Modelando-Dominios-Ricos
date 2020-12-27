using Flunt.Validations;
using PaymentContext.Shared.ValueObject;

namespace PaymentContext.Domain.ValueObjects
{
    public class Address : ValueObject
    {
        public Address(string street, string number, string neighborhood, string city, string state, string country, string zipCode)
        {
            Street = street;
            Number = number;
            Neighborhood = neighborhood;
            City = city;
            State = state;
            Country = country;
            ZipCode = zipCode;

            AddNotifications(new Contract()
                .Requires()
                .HasMinLen(Street,3,"Address.Street", "Rua deve conter pelo menos 3 caracteres")
                .HasMinLen(Number,3,"Address.Number", "Numero deve conter no menos 3 caracteres")
                .HasMaxLen(Neighborhood,50,"Address.Neighborhood","Bairro deve conter no máximo 50 caracteres")
                );
        
        }

        public string Street { get; private set; }
        public string Number { get; private set; }
        public string Neighborhood { get; private set; }//Bairro
        public string City { get; private set; }
        public string State { get; private set; }//Estado
        public string Country { get; private set; }//Pais
        public string ZipCode { get; private set; }//Código Postal
    }
}