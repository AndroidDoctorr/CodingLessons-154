using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Inheritance.People
{
    public class Customer : Person
    {
        // Morning Challenge:
        // Extend the Person class
        // Give this 3 properties -
        //   IsSubscribedToEmails  (bool)
        //   CustomerSince         (Date)
        //   IsPremium             (bool)
        // if the customer has been with us for 5 years or more, they're premium
        public bool IsSubscribedToEmails { get; set; }
        public DateTime CustomerSince { get; set; }
        public bool IsPremium
        {
            get
            {
                return (DateTime.Now - CustomerSince).TotalDays > (365.24 * 5);
            }
        }

        public Customer() : base()
        {
            CustomerSince = DateTime.Now;
        }
    }
}
