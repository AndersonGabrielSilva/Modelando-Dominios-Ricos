using System.Collections.Generic;
using System.Linq;

namespace PaymentContext.Domain.Entities
{
    public class Student
    {
        private IList<Subscription> _subscriptions;
        public Student(string firsName, string lastName, string document, string email)
        {
            FirsName = firsName;
            LastName = lastName;
            Document = document;
            Email = email;
            _subscriptions = new List<Subscription>();
        }

        public string FirsName{ get; private set; } 
        public string LastName { get; private set; }        
        public string Document { get; private set; }
        public string Email{ get; private set; }   
        public string Address { get; private set; }
        public IReadOnlyCollection<Subscription> Subscriptions {get => _subscriptions.ToArray();} 

        public void AddSubscription(Subscription subscription)
        {
            //Se já tiver uma assinatura ativa, cancela.

            //Cancela todas as outras assinaturas, e coloca está como principal.

            foreach(var sub in Subscriptions)
                sub.Inactivate();
            
            _subscriptions.Add(subscription);
        }
    }
}
