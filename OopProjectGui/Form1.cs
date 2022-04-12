using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;


/* OOP Project
 * David Fortich
 * 101314570
 * */

namespace OopProjectGui
{
    public partial class Form1 : Form
    {
        //SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\XYZDatabase.mdf;Integrated Security=True");
        static AirlineCoordinator aCoord;


        public Form1()
        {
            InitializeComponent();

            // Hide menus till one is chosen
            FlightMenu.Visible = false;
            CustomerMenu.Visible = false;
            BookingMenu.Visible = false;
            lblProcessResult.Text = "";
            aCoord = new AirlineCoordinator(15, 15, 15);
        }


        // Main Menu Button Actions
        private void btnFlights_Click(object sender, EventArgs e)
        {
            updateFlightData();


            fnError.Visible = false; // Error Message not shown until error occurs.
            // Move panel button to show what menu user is in.
            panelBtnShow.Height = f_btnFlights.Height; 
            panelBtnShow.Top = f_btnFlights.Top;
            // Show and Hide relevant menus
            FlightMenu.Visible = true; 
            CustomerMenu.Visible = false;
            BookingMenu.Visible = false; 
            lblProcessResult.Text = ""; // Empty Process Result label when moving to new Menu.
            b_viewOneBookingPanel.Visible = false;
            f_viewOneFlightPanel.Visible = false;
            c_viewOneCustomerPanel.Visible = false;
            
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            updateCustomerData();


            // Move panel button to show what menu user is in.
            panelBtnShow.Height = c_btnCustomers.Height;
            panelBtnShow.Top = c_btnCustomers.Top;
            // Show and Hide relevant menus
            FlightMenu.Visible = false;
            CustomerMenu.Visible = true; 
            BookingMenu.Visible = false; 
            lblProcessResult.Text = ""; // Empty Process Result label when moving to new Menu.
            b_viewOneBookingPanel.Visible = false;
            f_viewOneFlightPanel.Visible = false;
            c_viewOneCustomerPanel.Visible = false;
        }

        private void btnBookings_Click_1(object sender, EventArgs e)
        {
            updateBookingData(); // Update list

            // Move panel button to show what menu user is in.
            panelBtnShow.Height = btnBookings.Height;
            panelBtnShow.Top = btnBookings.Top;
            // Show and Hide relevant menus
            FlightMenu.Visible = false;
            CustomerMenu.Visible = false;
            BookingMenu.Visible = true;
            lblProcessResult.Text = ""; // Empty Process Result label when moving to new Menu.
            b_viewOneBookingPanel.Visible = false;
            f_viewOneFlightPanel.Visible = false;
            c_viewOneCustomerPanel.Visible = false;
        }


        // Flight Menu Actions
        private void btnAddFlight_Click_1(object sender, EventArgs e)
        {

            int flightNo, maxSeats, flightAddResult;
            string origin, destination;

            // check valid int input for FlightNo
            fnError.Visible = false;
            fsError.Visible = false;
            if (!int.TryParse(f_txtEnterFN.Text, out flightNo))
            {
                fnError.Visible = true;
                fnError.Text = "*Please enter a number.";
                lblProcessResult.Text = "Flight NOT added. Check starred (*) fields above.";
            }
            else if (!int.TryParse(f_txtEnterSeats.Text, out maxSeats))
            {
                fnError.Visible = false;
                fsError.Visible = true;
                fnError.Text = "*Please enter a number.";
                lblProcessResult.Text = "Flight NOT added. Check starred (*) fields above.";
            }
            else
            {
                fnError.Visible = false;
                fsError.Visible = false;
                origin = f_txtEnterOrigin.Text;
                destination = f_txtEnterDest.Text;

                // save result of operation to a variable to be able to compare it and give correct error message.
                flightAddResult = aCoord.addFlight(flightNo, origin, destination, maxSeats);
                if (flightAddResult == 0)
                {
                    lblProcessResult.Text = ("Flight successfully added.");
                    f_txtEnterFN.Text = f_txtEnterSeats.Text = f_txtEnterOrigin.Text = f_txtEnterDest.Text = ""; // Clear if success.
                }
                else if (flightAddResult == 1)
                {
                    lblProcessResult.Text = ("Flight was not added. Insufficient space.");
                }
                else
                {
                    lblProcessResult.Text = ("Flight was not added. Flight number already exists.");
                    fnError.Visible = true;
                    fnError.Text = "*Flight already exists.";
                }
                
            }
            updateFlightData(); // Update list
        }

        private void btnViewFlight_Click(object sender, EventArgs e)
        {
            int fId;
            // check valid int input for FlightNo
            if (!int.TryParse(f_txtViewFlight.Text, out fId))
            {
                fvError.Visible = true;
                fvError.Text = "*Please enter a number.";
                lblProcessResult.Text = "Flight NOT found. Check starred (*) fields above.";
            } else if (aCoord.flightExists(fId))
            {
                f_viewOneFlightPanel.Visible = true; // show only if success
                fvError.Visible = false;
                f_lblViewOneFlight.Text = aCoord.getFlight(fId).toString();
                f_txtViewFlight.Text = ""; // clear if success
            } else
            {
                fvError.Visible = true;
                fvError.Text = "*Please enter valid flight id.";
                lblProcessResult.Text = "Flight NOT found. Check starred (*) fields above.";
            }
        }

        private void btnCloseOneFlight_Click(object sender, EventArgs e)
        {
            f_viewOneFlightPanel.Visible = false;
        }


        private void btnDeleteFlight_Click(object sender, EventArgs e)
        {
            int fId, deleteResult;
            // check valid int input for FlightNo
            if (!int.TryParse(f_txtDelFlight.Text, out fId))
            {
                fdError.Visible = true;
                fdError.Text = "*Please enter a number.";
                lblProcessResult.Text = "Flight NOT deleted. Check starred (*) fields above.";
            } else
            {
                fdError.Visible = false;
                // save result of delete function to a variable to be able to compare and give correct message to user.
                deleteResult = aCoord.deleteFlight(fId);
                if (deleteResult == 0)
                {
                    lblProcessResult.Text = $"Flight with id {fId} deleted.";
                    f_txtDelFlight.Text = ""; // clear if successful
                }
                else if (deleteResult == 1)
                {
                    lblProcessResult.Text = $"Flight with id {fId} was not found.";
                    fdError.Visible = true;
                    fdError.Text = "*Flight not found.";
                }
                else if (deleteResult == 2)
                {
                    lblProcessResult.Text = $"Flight with id {fId} was not deleted because there are still customers booked to this flight";
                    fdError.Visible = true;
                    fdError.Text = "*Flight not empty.";
                }
            }
            updateFlightData(); // Update list
        }




        // Customer Menu Actions
        private void c_btnAddCustomer_Click(object sender, EventArgs e)
        {
            string fName, lName, ph;
            int customerAddResult;

            ccError.Visible = false;
            fName = c_txtEnterFName.Text;
            lName = c_txtEnterLName.Text;
            ph = c_txtEnterPhone.Text;

            // save result of operation to a variable to be able to compare it and give correct error message.
            customerAddResult = aCoord.addCustomer(fName, lName, ph);
            if (customerAddResult == 0)
            {
                lblProcessResult.Text = ("Customer successfully added.");
                c_txtEnterFName.Text = c_txtEnterLName.Text = c_txtEnterPhone.Text = ""; // Clear if success.
            }
            else if (customerAddResult == 1)
            {
                lblProcessResult.Text = ("Customer was NOT added. Insufficient space.");
            }
            else
            {
                lblProcessResult.Text = ("Customer was not added. A customer with that name and phone already exists.");
                ccError.Visible = true;                
            }
            updateCustomerData();
        }


        private void c_btnViewCustomer_Click(object sender, EventArgs e)
        {
            int cId;
            // check valid int input for CustomerNo
            if (!int.TryParse(c_txtViewCustomer.Text, out cId))
            {
                cvError.Visible = true;
                cvError.Text = "*Please enter a number.";
                lblProcessResult.Text = "Customer NOT found. Check starred (*) fields above.";
            }
            else if (aCoord.customerExists(cId))
            {
                c_viewOneCustomerPanel.Visible = true; // show only if success
                cvError.Visible = false;
                c_lblViewOneCustomer.Text = aCoord.getCustomer(cId).toString();
                c_txtViewCustomer.Text = ""; // clear if success
            }
            else
            {
                cvError.Visible = true;
                cvError.Text = "*Please enter valid customer id.";
                lblProcessResult.Text = "Customer NOT found. Check starred (*) fields above.";
            }
        }


        private void c_btnCloseOneCustomer_Click(object sender, EventArgs e)
        {
            c_viewOneCustomerPanel.Visible = false;
        }


        private void c_btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            int cId, deleteResult;
            // check valid int input for FlightNo
            if (!int.TryParse(c_txtDelCustomer.Text, out cId))
            {
                cdError.Visible = true;
                cdError.Text = "*Please enter a number.";
                lblProcessResult.Text = "Customer NOT deleted. Check starred (*) fields above.";
            }
            else
            {
                cdError.Visible = false;
                // save result of delete function to a variable to be able to compare and give correct message to user.
                deleteResult = aCoord.deleteCustomer(cId);
                if (deleteResult == 0)
                {
                    lblProcessResult.Text = $"Customer with id {cId} deleted.";
                    c_txtDelCustomer.Text = ""; // clear if successful
                }
                else if (deleteResult == 1)
                {
                    lblProcessResult.Text = $"Customer with id {cId} was not found.";
                    cdError.Visible = true;
                    cdError.Text = "*Customer not found.";
                }
                else if (deleteResult == 2)
                {
                    lblProcessResult.Text = $"Customer with id {cId} was not deleted because there are still bookings for this customer.";
                    cdError.Visible = true;
                    cdError.Text = "*Customer has bookings.";
                }
            }
            updateCustomerData(); // Update list
        }




        // Booking Menu Actions

        private void b_btnAddBooking_Click(object sender, EventArgs e)
        {
            int fId, cId, bookingAddResult;
            Flight flight;
            Customer customer;


            // check valid int input for Flight and Customer Ids
            bfError.Visible = false;
            bcError.Visible = false;
            if (!int.TryParse(b_txtFlightBook.Text, out fId) || !aCoord.flightExists(fId))
            {
                bfError.Visible = true;
                bfError.Text = "*Please enter valid flight id.";
                lblProcessResult.Text = "Booking NOT added. Check starred (*) fields above.";
            }
            else if (!int.TryParse(b_txtCustomerBook.Text, out cId) || !aCoord.customerExists(cId))
            {
                bcError.Visible = true;
                bcError.Text = "*Please enter valid customer id.";
                lblProcessResult.Text = "Booking NOT added. Check starred (*) fields above.";
            }
            else
            {
                bfError.Visible = false;
                bcError.Visible = false;
                flight = aCoord.getFlight(fId);
                customer = aCoord.getCustomer(cId);
                // save result of operation to a variable to be able to compare it and give correct error message.
                bookingAddResult = aCoord.addBooking(flight, customer);
                if (bookingAddResult == 0)
                {
                    lblProcessResult.Text = ("Booking successfully added.");
                    b_txtFlightBook.Text = b_txtCustomerBook.Text = "";
                }
                else if (bookingAddResult == 1)
                {
                    lblProcessResult.Text = ("Booking was not added. Insufficient space.");
                }
                else if (bookingAddResult == 2)
                {
                    lblProcessResult.Text = $"Booking was not added; flight with id {fId} is full.";
                }

            }
            updateBookingData(); // Update list
        }

        private void b_btnViewBooking_Click(object sender, EventArgs e)
        {
            int bId;
            // check valid int input for BookingNo
            if (!int.TryParse(b_txtViewBooking.Text, out bId))
            {
                bvError.Visible = true;
                bvError.Text = "*Please enter a number.";
                lblProcessResult.Text = "Booking NOT found. Check starred (*) fields above.";
            }
            else if (aCoord.bookingExists(bId))
            {
                b_viewOneBookingPanel.Visible = true; // show only if success
                bvError.Visible = false;
                b_lblViewOneBooking.Text = aCoord.getBooking(bId).toString();
                b_txtViewBooking.Text = ""; // clear if success
            }
            else
            {
                bvError.Visible = true;
                bvError.Text = "*Please enter valid booking id.";
                lblProcessResult.Text = "Booking NOT found. Check starred (*) fields above.";
            }
        }

        private void b_btnCloseOneBooking_Click(object sender, EventArgs e)
        {
            b_viewOneBookingPanel.Visible = false;
        }





        // Utility Functions
        private void updateFlightData()
        {
            f_lblViewFlights.Text = (aCoord.flightList());
            
        }

        private void updateCustomerData()
        {
            c_lblViewCustomers.Text = (aCoord.customerList());
        }

        private void updateBookingData()
        {
            b_lblViewBookings.Text = (aCoord.bookingList());
            b_lblShowFlights.Text = (aCoord.flightList());
            b_lblShowCustomers.Text = (aCoord.customerList());
        }







        // Result of accidental double clicks, please ignore.


        private void Form1_Load(object sender, EventArgs e)
        {
            //this.flightListTableAdapter.Fill(this.xYZDatabaseDataSet.FlightList);

        }

        /*private void label1_Click(object sender, EventArgs e)
        {

        }*/

        /*private void label2_Click(object sender, EventArgs e)
        {

        }*/

        /*private void btnAddFlight_Click(object sender, EventArgs e)
        {
            

        }*/
    }
}
