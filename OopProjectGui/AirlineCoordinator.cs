using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopProjectGui
{
    class AirlineCoordinator
    {
        private FlightManager fManager;
        private CustomerManager cManager;
        private BookingManager bManager;


        public AirlineCoordinator(int maxFlights, int maxCustomers, int maxBookings)
        {
            fManager = new FlightManager(maxFlights);
            cManager = new CustomerManager(maxCustomers);
            bManager = new BookingManager(maxBookings);

        }


        // Flight-related operations
        public int addFlight(int flightNo, string origin, string destination, int maxSeats)
        {
            return fManager.addFlight(flightNo, origin, destination, maxSeats);
        }

        public Flight getFlight(int fId)
        {
            return fManager.getFlight(fId);
        }

        public bool flightExists(int fId)
        {
            return fManager.flightExists(fId);
        }


        public string flightList()
        {
            return fManager.getFlightList();
        }


        public int deleteFlight(int fid)
        {
            return fManager.deleteFlight(fid);
        }


        // Customer-related operations
        public int addCustomer(string fName, string lName, string ph)
        {
            return cManager.addCustomer(fName, lName, ph);
        }

        public Customer getCustomer(int cId)
        {
            return cManager.getCustomer(cId);
        }

        public bool customerExists(int cId)
        {
            return cManager.customerExists(cId);
        }

        public int deleteCustomer(int cId)
        {
            if (bManager.findCustomerBooking(cId)) { return 2; } // error 2 if customer still has a booking
            return cManager.deleteCustomer(cId);
        }

        public string customerList()
        {
            return cManager.getCustomerList();
        }




        // Booking-related operations
        public int addBooking(Flight flight, Customer customer)
        {
            return bManager.addBooking(flight, customer); // 0 = succes, 1 = booking is full, 2 = flight is full
        }


        public string bookingList()
        {
            return bManager.getBookingList();
        }

        public bool bookingExists(int bId)
        {
            return bManager.bookingExists(bId);
        }

        public Booking getBooking(int bId)
        {
            return bManager.getBooking(bId);
        }
    }
}
