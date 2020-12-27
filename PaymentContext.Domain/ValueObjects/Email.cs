using Flunt.Validations;
using PaymentContext.Shared.ValueObject;

namespace PaymentContext.Domain.ValueObjects
{
    public class Email : ValueObject
    {
        public Email(string addres)
        {
            Address = addres;

            AddNotifications(new Contract()
                            .Requires()
                            .IsEmail(Address,"Email.Address","E-Mail inválido")
                            );

        }
        public string Address { get; private set; }
    }
}