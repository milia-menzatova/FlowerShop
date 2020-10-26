using System.Collections.Generic;
namespace FlowerShop
{
    public class Customer
    {
        //public long Id { get; private set; }
        //private List<Order> orders;
        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        public string Email { get; private set; }

        public Customer(string Email, string FirstName, string LastName)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Email = Email;

            if (FirstName.Length > 30)
            {
                throw new System.Exception("First name is too long");
            }
            if (LastName.Length > 30)
            {
                throw new System.Exception("Last name is too long");
            }
        }


    }
}