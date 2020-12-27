using PaymentContext.Shared.ValueObject;

namespace PaymentContext.Domain.ValueObjects
{
    public class Email : ValueObject
    {
        public Email(string addres)
        {
            Address = addres;
        }
        public string Address { get; private set; }
    }
}