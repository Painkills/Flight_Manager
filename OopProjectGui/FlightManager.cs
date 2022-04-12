using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopProjectGui
{
    class FlightManager
    {

        private int maxFlights;
        private int numFlights;
        private Flight[] flightList;

        public FlightManager(int max)
        {
            maxFlights = max;
            numFlights = 0;
            flightList = new Flight[maxFlights];
        }

        // returns int to be able to differentiate error types
        public int addFlight(int fn, string origin, string destination, int maxSeats)
        {
            if (numFlights >= maxFlights) { return 1; } // error if full

            for (int i = 0; i < numFlights; i++)
            {
                if (flightList[i].getFlightNumber() == fn) { return 2; } // avoid duplicate flights
            }
            Flight f = new Flight(fn, origin, destination, maxSeats);
            flightList[numFlights] = f;
            numFlights++;
            return 0;
        }

        public int findFlight(int fId)
        {
            for (int x = 0; x < numFlights; x++)
            {
                if (flightList[x].getFlightNumber() == fId)
                    return x;
            }
            return -1;
        }

        public bool flightExists(int fId)
        {
            int loc = findFlight(fId);
            if (loc == -1) { return false; }
            return true;
        }

        public Flight getFlight(int fId)
        {
            int loc = findFlight(fId);
            if (loc == -1) { return null; }
            return flightList[loc];
        }

        public int deleteFlight(int fId)
        {
            int loc = findFlight(fId);
            if (loc == -1) { return 1; } // error 1 if flight not found
            if (getFlight(fId).getNumPassengers() > 0) { return 2; } // error 2 if there are passengers on flight
            flightList[loc] = flightList[numFlights - 1];
            numFlights--;
            return 0; // no error
        }

        public string getFlightList()
        {
            string s = "-----Flight List-----\n";
            if (numFlights < 1)
            {
                return "\n\nThere are no Flights yet.";
            }
            for (int x = 0; x < numFlights; x++)
            {
                s = s + "\n" + flightList[x].getFlightNumber() + ": from " + flightList[x].getOrigin() + " to " + flightList[x].getDestination();
            }
            return s;
        }
    }
}
