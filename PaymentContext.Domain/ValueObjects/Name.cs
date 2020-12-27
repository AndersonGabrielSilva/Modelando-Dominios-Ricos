using PaymentContext.Shared.ValueObject;

namespace PaymentContext.Domain.ValueObjects
{
    public class Name : ValueObject
    {
        public Name(string firsName, string lastName)
        {
            FirsName = firsName;
            LastName = lastName;
        }

        public string FirsName { get; private set; }
        public string LastName { get; private set; }
    }
}