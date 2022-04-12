using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopProjectGui
{
    class Customer
    {
        private int customerId;
        private string firstName;
        private string lastName;
        private string phone;
        private int bookings;

        public Customer(int cId, string fName, string lName, string ph)
        {
            bookings = 0;
            customerId = cId;
            firstName = fName;
            lastName = lName;
            phone = ph;
        }

        public int getId() { return customerId; }
        public string getFirstName() { return firstName; }
        public string getLastName() { return lastName; }

        public string getFullName() { return firstName + " " + lastName; }
        public string getPhone() { return phone; }
        public int getNumBookings() { return bookings; }

        public void addBooking() { bookings++; }

        public string toString()
        {
            string s = "Customer " + customerId;
            s = s + "\nName: " + firstName + " " + lastName;
            s = s + "\nPhone: " + phone;
            s = s + "\n Bookings: " + bookings;

            return s;
        }

    }
}
