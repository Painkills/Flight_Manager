using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopProjectGui
{
    class BookingManager
    {
        private int maxBookings;
        private int numBookings;
        private Booking[] bookingList;

        public BookingManager(int max)
        {
            maxBookings = max;
            numBookings = 0;
            bookingList = new Booking[maxBookings];
        }

        public int getNumBookings() { return numBookings; }

        public bool findCustomerBooking(int cId)
        {
            for (int i = 0; i < numBookings; i++)
            {
                if (bookingList[i].getCustomer().getId() == cId) { return true; }
            }
            return false;
        }

        public int findBooking(int bId)
        {
            for (int x = 0; x < numBookings; x++)
            {
                if (bookingList[x].getBookingNumber() == bId)
                    return x;
            }
            return -1;
        }

        public bool bookingExists(int bId)
        {
            int loc = findBooking(bId);
            if (loc == -1) { return false; }
            return true;
        }

        public Booking getBooking(int bId)
        {
            int loc = findBooking(bId);
            if (loc == -1) { return null; }
            return bookingList[loc];
        }

        // returns int to be able to differentiate error types
        public int addBooking(Flight flight, Customer customer)
        {
            if (numBookings >= maxBookings) { return 1; } // error if booking list is full            
            int bId = 500 + numBookings;
            if (!flight.addPassenger(customer)) { return 2; }  // error 2 if flight is full
            customer.addBooking();
            Booking b = new Booking(bId, flight, customer);
            bookingList[numBookings] = b;
            numBookings++;
            return 0;
        }

        public string getBookingList()
        {
            string s = "-----Booking List:-----\n";
            if (numBookings < 1)
            {
                return "\n\nThere are no Bookings yet.";
            }
            for (int x = 0; x < numBookings; x++)
            {
                s = s + "\n" + bookingList[x].getBookingNumber() + ": for " + bookingList[x].getCustomer().getFullName() + " on flight " + bookingList[x].getFlight().getFlightNumber();
            }
            return s;
        }
    }
}
