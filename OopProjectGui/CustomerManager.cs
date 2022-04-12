using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopProjectGui
{
    class CustomerManager
    {
        private int maxCustomers;
        private int numCustomers;
        private Customer[] customerList;

        public CustomerManager(int max)
        {
            maxCustomers = max;
            numCustomers = 0;
            customerList = new Customer[maxCustomers];
        }

        public int findCustomer(int cId)
        {
            for (int x = 0; x < numCustomers; x++)
            {
                if (customerList[x].getId() == cId)
                    return x;
            }
            return -1;
        }

        public bool customerExists(int cId)
        {
            int loc = findCustomer(cId);
            if (loc == -1) { return false; }
            return true;
        }

        public Customer getCustomer(int cId)
        {
            int loc = findCustomer(cId);
            if (loc == -1) { return null; }
            return customerList[loc];
        }

        // returns int to be able to differentiate error types
        public int addCustomer(string fName, string lName, string ph)
        {
            if (numCustomers >= maxCustomers) { return 1; }
            // avoid duplicate customer
            for (int i = 0; i < numCustomers; i++)
            {
                if (customerList[i].getFirstName() == fName && customerList[i].getLastName() == lName && customerList[i].getPhone() == ph) { return 2; }
            }
            int cId = 100 + numCustomers;
            Customer c = new Customer(cId, fName, lName, ph);
            customerList[numCustomers] = c;
            numCustomers++;
            return 0;
        }

        public int deleteCustomer(int cId)
        {
            int loc = findCustomer(cId);
            if (loc == -1) { return 1; } // error 1 if customer not found
            customerList[loc] = customerList[numCustomers - 1];
            numCustomers--;
            return 0; // no error
        }

        public string getCustomerList()
        {
            string s = "-----Customer List:-----\n";
            if (numCustomers < 1)
            {
                return "\n\nThere are no Customers yet.";
            }
            for (int x = 0; x < numCustomers; x++)
            {
                s = s + "\n" + customerList[x].getId() + ": " + customerList[x].getFirstName() + " " + customerList[x].getLastName();
            }
            return s;
        }
    }
}
