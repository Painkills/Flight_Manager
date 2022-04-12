using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopProjectGui
{
    class Booking
    {
        private string date;
        private int bookingNumber;
        private Flight flight;
        private Customer customer;

        public Booking(int bookingNumber, Flight flight, Customer customer)
        {
            this.date = DateTime.Now.ToString(@"MM\/dd\/yyyy h\:mm tt");
            this.bookingNumber = bookingNumber;
            this.flight = flight;
            this.customer = customer;
        }

        public string getDate() { return date; }
        public int getBookingNumber() { return bookingNumber; }
        public Flight getFlight() { return flight; }
        public Customer getCustomer() { return customer; }

        public string toString()
        {
            string s = "Booking Number: " + bookingNumber;
            s = s + "\nDate: " + date;
            s = s + "\nFlight:" + flight.getFlightNumber();
            s = s + "\nCustomer:" + customer.getFirstName() + " " + customer.getLastName();
            return s;
        }
    }
}
