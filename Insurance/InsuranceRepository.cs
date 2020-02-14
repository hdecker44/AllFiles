using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance
{
    public class InsuranceRepository
    {
        private List<Customer> customerList = new List<Customer>();

        public void AddCustomerToList(Customer newCustomer)
        {
            customerList.Add(newCustomer);
        }
        public string GetThankYou(Customer customer)
        {
            if (customer.YearsUsing <= 5)
            {
                return "Thank you for being a customer.";
            }
            else
            {
                return "Thank you for being a gold member!";
            }
            /*foreach (Customer name in customerList)
                if (name.YearsUsing >= 5)
                {
                    return "Thank you for being a gold member.";
                }
                else if (name.YearsUsing >= 1)
                { 
                    return "Thank you for being a customer";
                }
              return null; */
        }
    }
}
