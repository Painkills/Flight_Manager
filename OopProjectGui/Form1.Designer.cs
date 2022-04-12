
namespace OopProjectGui
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.f_btnFlights = new System.Windows.Forms.Button();
            this.c_btnCustomers = new System.Windows.Forms.Button();
            this.btnBookings = new System.Windows.Forms.Button();
            this.titlePanel = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.Icon = new System.Windows.Forms.Panel();
            this.FlightMenu = new System.Windows.Forms.Panel();
            this.fvError = new System.Windows.Forms.Label();
            this.f_viewOneFlightPanel = new System.Windows.Forms.Panel();
            this.f_lblViewOneFlight = new System.Windows.Forms.Label();
            this.f_btnCloseOneFlight = new System.Windows.Forms.Button();
            this.fdError = new System.Windows.Forms.Label();
            this.f_txtDelFlight = new System.Windows.Forms.TextBox();
            this.f_lblViewFlights = new System.Windows.Forms.Label();
            this.f_AddFlightPanel = new System.Windows.Forms.Panel();
            this.fsError = new System.Windows.Forms.Label();
            this.fnError = new System.Windows.Forms.Label();
            this.f_txtEnterSeats = new System.Windows.Forms.TextBox();
            this.f_lblEnterSeats = new System.Windows.Forms.Label();
            this.f_lblAddFlightMenu = new System.Windows.Forms.Label();
            this.f_btnAddFlight = new System.Windows.Forms.Button();
            this.f_txtEnterDest = new System.Windows.Forms.TextBox();
            this.f_lblEnterDest = new System.Windows.Forms.Label();
            this.f_txtEnterOrigin = new System.Windows.Forms.TextBox();
            this.f_lblEnterOrigin = new System.Windows.Forms.Label();
            this.f_txtEnterFN = new System.Windows.Forms.TextBox();
            this.f_lblEnterFN = new System.Windows.Forms.Label();
            this.f_btnDeleteFlight = new System.Windows.Forms.Button();
            this.f_btnViewFlight = new System.Windows.Forms.Button();
            this.f_txtViewFlight = new System.Windows.Forms.TextBox();
            this.flightListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.xYZDatabaseDataSet = new OopProjectGui.XYZDatabaseDataSet();
            this.panelBtnShow = new System.Windows.Forms.Panel();
            this.CustomerMenu = new System.Windows.Forms.Panel();
            this.c_viewOneCustomerPanel = new System.Windows.Forms.Panel();
            this.c_lblViewOneCustomer = new System.Windows.Forms.Label();
            this.c_btnCloseOneCustomer = new System.Windows.Forms.Button();
            this.c_lblViewCustomers = new System.Windows.Forms.Label();
            this.c_txtDelCustomer = new System.Windows.Forms.TextBox();
            this.c_addCustomerPanel = new System.Windows.Forms.Panel();
            this.c_lblAddCustomerMenu = new System.Windows.Forms.Label();
            this.c_btnAddCustomer = new System.Windows.Forms.Button();
            this.c_txtEnterLName = new System.Windows.Forms.TextBox();
            this.c_lblEnterLName = new System.Windows.Forms.Label();
            this.c_txtEnterPhone = new System.Windows.Forms.TextBox();
            this.c_lblEnterPhone = new System.Windows.Forms.Label();
            this.c_txtEnterFName = new System.Windows.Forms.TextBox();
            this.c_lblEnterFName = new System.Windows.Forms.Label();
            this.c_btnDeleteCustomer = new System.Windows.Forms.Button();
            this.c_btnViewCustomer = new System.Windows.Forms.Button();
            this.c_txtViewCustomer = new System.Windows.Forms.TextBox();
            this.lblWelcomeMessage = new System.Windows.Forms.Label();
            this.BookingMenu = new System.Windows.Forms.Panel();
            this.b_addBookingPanel = new System.Windows.Forms.Panel();
            this.b_btnAddBooking = new System.Windows.Forms.Button();
            this.b_txtCustomerBook = new System.Windows.Forms.TextBox();
            this.b_lblEnterCustomerBooking = new System.Windows.Forms.Label();
            this.b_txtFlightBook = new System.Windows.Forms.TextBox();
            this.b_lblEnterFlightBooking = new System.Windows.Forms.Label();
            this.b_btnViewBooking = new System.Windows.Forms.Button();
            this.b_txtViewBooking = new System.Windows.Forms.TextBox();
            this.lblProcessResult = new System.Windows.Forms.Label();
            this.flightListTableAdapter = new OopProjectGui.XYZDatabaseDataSetTableAdapters.FlightListTableAdapter();
            this.cdError = new System.Windows.Forms.Label();
            this.cvError = new System.Windows.Forms.Label();
            this.ccError = new System.Windows.Forms.Label();
            this.b_viewOneBookingPanel = new System.Windows.Forms.Panel();
            this.b_lblViewOneBooking = new System.Windows.Forms.Label();
            this.b_btnCloseOneBooking = new System.Windows.Forms.Button();
            this.b_lblAddBooking = new System.Windows.Forms.Label();
            this.b_lblViewBookings = new System.Windows.Forms.Label();
            this.bfError = new System.Windows.Forms.Label();
            this.bcError = new System.Windows.Forms.Label();
            this.bvError = new System.Windows.Forms.Label();
            this.b_lblShowFlights = new System.Windows.Forms.Label();
            this.b_lblShowCustomers = new System.Windows.Forms.Label();
            this.titlePanel.SuspendLayout();
            this.FlightMenu.SuspendLayout();
            this.f_viewOneFlightPanel.SuspendLayout();
            this.f_AddFlightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flightListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xYZDatabaseDataSet)).BeginInit();
            this.CustomerMenu.SuspendLayout();
            this.c_viewOneCustomerPanel.SuspendLayout();
            this.c_addCustomerPanel.SuspendLayout();
            this.BookingMenu.SuspendLayout();
            this.b_addBookingPanel.SuspendLayout();
            this.b_viewOneBookingPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // f_btnFlights
            // 
            this.f_btnFlights.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f_btnFlights.ForeColor = System.Drawing.SystemColors.MenuText;
            this.f_btnFlights.Location = new System.Drawing.Point(18, 105);
            this.f_btnFlights.Name = "f_btnFlights";
            this.f_btnFlights.Size = new System.Drawing.Size(152, 105);
            this.f_btnFlights.TabIndex = 0;
            this.f_btnFlights.Text = "Flights";
            this.f_btnFlights.UseVisualStyleBackColor = true;
            this.f_btnFlights.Click += new System.EventHandler(this.btnFlights_Click);
            // 
            // c_btnCustomers
            // 
            this.c_btnCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c_btnCustomers.ForeColor = System.Drawing.SystemColors.MenuText;
            this.c_btnCustomers.Location = new System.Drawing.Point(18, 219);
            this.c_btnCustomers.Name = "c_btnCustomers";
            this.c_btnCustomers.Size = new System.Drawing.Size(152, 105);
            this.c_btnCustomers.TabIndex = 1;
            this.c_btnCustomers.Text = "Customers";
            this.c_btnCustomers.UseVisualStyleBackColor = true;
            this.c_btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // btnBookings
            // 
            this.btnBookings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookings.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnBookings.Location = new System.Drawing.Point(18, 333);
            this.btnBookings.Name = "btnBookings";
            this.btnBookings.Size = new System.Drawing.Size(152, 105);
            this.btnBookings.TabIndex = 2;
            this.btnBookings.Text = "Bookings";
            this.btnBookings.UseVisualStyleBackColor = true;
            this.btnBookings.Click += new System.EventHandler(this.btnBookings_Click_1);
            // 
            // titlePanel
            // 
            this.titlePanel.Controls.Add(this.lblTitle);
            this.titlePanel.Controls.Add(this.Icon);
            this.titlePanel.Location = new System.Drawing.Point(5, 5);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(1292, 94);
            this.titlePanel.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Bell MT", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(182, 16);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(575, 69);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "XYZ Airlines Limited";
            // 
            // Icon
            // 
            this.Icon.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Icon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Icon.BackgroundImage")));
            this.Icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Icon.Location = new System.Drawing.Point(-1, 3);
            this.Icon.Name = "Icon";
            this.Icon.Size = new System.Drawing.Size(166, 82);
            this.Icon.TabIndex = 1;
            // 
            // FlightMenu
            // 
            this.FlightMenu.Controls.Add(this.fvError);
            this.FlightMenu.Controls.Add(this.fdError);
            this.FlightMenu.Controls.Add(this.f_txtDelFlight);
            this.FlightMenu.Controls.Add(this.f_lblViewFlights);
            this.FlightMenu.Controls.Add(this.f_AddFlightPanel);
            this.FlightMenu.Controls.Add(this.f_btnDeleteFlight);
            this.FlightMenu.Controls.Add(this.f_btnViewFlight);
            this.FlightMenu.Controls.Add(this.f_txtViewFlight);
            this.FlightMenu.Location = new System.Drawing.Point(186, 106);
            this.FlightMenu.Name = "FlightMenu";
            this.FlightMenu.Size = new System.Drawing.Size(1111, 515);
            this.FlightMenu.TabIndex = 2;
            // 
            // fvError
            // 
            this.fvError.AutoSize = true;
            this.fvError.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.fvError.Location = new System.Drawing.Point(10, 48);
            this.fvError.Name = "fvError";
            this.fvError.Size = new System.Drawing.Size(161, 17);
            this.fvError.TabIndex = 16;
            this.fvError.Text = "*Please enter a number.";
            this.fvError.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.fvError.Visible = false;
            // 
            // f_viewOneFlightPanel
            // 
            this.f_viewOneFlightPanel.Controls.Add(this.f_lblViewOneFlight);
            this.f_viewOneFlightPanel.Controls.Add(this.f_btnCloseOneFlight);
            this.f_viewOneFlightPanel.Location = new System.Drawing.Point(1, 0);
            this.f_viewOneFlightPanel.Name = "f_viewOneFlightPanel";
            this.f_viewOneFlightPanel.Size = new System.Drawing.Size(493, 505);
            this.f_viewOneFlightPanel.TabIndex = 10;
            this.f_viewOneFlightPanel.Visible = false;
            // 
            // f_lblViewOneFlight
            // 
            this.f_lblViewOneFlight.AutoSize = true;
            this.f_lblViewOneFlight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f_lblViewOneFlight.Location = new System.Drawing.Point(71, 8);
            this.f_lblViewOneFlight.Name = "f_lblViewOneFlight";
            this.f_lblViewOneFlight.Size = new System.Drawing.Size(64, 25);
            this.f_lblViewOneFlight.TabIndex = 10;
            this.f_lblViewOneFlight.Text = "label2";
            // 
            // f_btnCloseOneFlight
            // 
            this.f_btnCloseOneFlight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f_btnCloseOneFlight.ForeColor = System.Drawing.SystemColors.MenuText;
            this.f_btnCloseOneFlight.Location = new System.Drawing.Point(363, 448);
            this.f_btnCloseOneFlight.Name = "f_btnCloseOneFlight";
            this.f_btnCloseOneFlight.Size = new System.Drawing.Size(114, 36);
            this.f_btnCloseOneFlight.TabIndex = 9;
            this.f_btnCloseOneFlight.Text = "Close";
            this.f_btnCloseOneFlight.UseVisualStyleBackColor = true;
            this.f_btnCloseOneFlight.Click += new System.EventHandler(this.btnCloseOneFlight_Click);
            // 
            // fdError
            // 
            this.fdError.AutoSize = true;
            this.fdError.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.fdError.Location = new System.Drawing.Point(375, 48);
            this.fdError.Name = "fdError";
            this.fdError.Size = new System.Drawing.Size(161, 17);
            this.fdError.TabIndex = 15;
            this.fdError.Text = "*Please enter a number.";
            this.fdError.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.fdError.Visible = false;
            // 
            // f_txtDelFlight
            // 
            this.f_txtDelFlight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f_txtDelFlight.Location = new System.Drawing.Point(378, 15);
            this.f_txtDelFlight.Name = "f_txtDelFlight";
            this.f_txtDelFlight.Size = new System.Drawing.Size(71, 30);
            this.f_txtDelFlight.TabIndex = 8;
            // 
            // f_lblViewFlights
            // 
            this.f_lblViewFlights.AutoSize = true;
            this.f_lblViewFlights.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f_lblViewFlights.Location = new System.Drawing.Point(17, 77);
            this.f_lblViewFlights.Name = "f_lblViewFlights";
            this.f_lblViewFlights.Size = new System.Drawing.Size(64, 25);
            this.f_lblViewFlights.TabIndex = 9;
            this.f_lblViewFlights.Text = "label2";
            // 
            // f_AddFlightPanel
            // 
            this.f_AddFlightPanel.Controls.Add(this.fsError);
            this.f_AddFlightPanel.Controls.Add(this.f_viewOneFlightPanel);
            this.f_AddFlightPanel.Controls.Add(this.fnError);
            this.f_AddFlightPanel.Controls.Add(this.f_txtEnterSeats);
            this.f_AddFlightPanel.Controls.Add(this.f_lblEnterSeats);
            this.f_AddFlightPanel.Controls.Add(this.f_lblAddFlightMenu);
            this.f_AddFlightPanel.Controls.Add(this.f_btnAddFlight);
            this.f_AddFlightPanel.Controls.Add(this.f_txtEnterDest);
            this.f_AddFlightPanel.Controls.Add(this.f_lblEnterDest);
            this.f_AddFlightPanel.Controls.Add(this.f_txtEnterOrigin);
            this.f_AddFlightPanel.Controls.Add(this.f_lblEnterOrigin);
            this.f_AddFlightPanel.Controls.Add(this.f_txtEnterFN);
            this.f_AddFlightPanel.Controls.Add(this.f_lblEnterFN);
            this.f_AddFlightPanel.Location = new System.Drawing.Point(614, 7);
            this.f_AddFlightPanel.Name = "f_AddFlightPanel";
            this.f_AddFlightPanel.Size = new System.Drawing.Size(496, 490);
            this.f_AddFlightPanel.TabIndex = 8;
            // 
            // fsError
            // 
            this.fsError.AutoSize = true;
            this.fsError.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.fsError.Location = new System.Drawing.Point(322, 183);
            this.fsError.Name = "fsError";
            this.fsError.Size = new System.Drawing.Size(161, 17);
            this.fsError.TabIndex = 14;
            this.fsError.Text = "*Please enter a number.";
            this.fsError.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.fsError.Visible = false;
            // 
            // fnError
            // 
            this.fnError.AutoSize = true;
            this.fnError.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.fnError.Location = new System.Drawing.Point(320, 82);
            this.fnError.Name = "fnError";
            this.fnError.Size = new System.Drawing.Size(161, 17);
            this.fnError.TabIndex = 12;
            this.fnError.Text = "*Please enter a number.";
            this.fnError.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.fnError.Visible = false;
            // 
            // f_txtEnterSeats
            // 
            this.f_txtEnterSeats.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f_txtEnterSeats.Location = new System.Drawing.Point(353, 153);
            this.f_txtEnterSeats.Name = "f_txtEnterSeats";
            this.f_txtEnterSeats.Size = new System.Drawing.Size(129, 27);
            this.f_txtEnterSeats.TabIndex = 2;
            // 
            // f_lblEnterSeats
            // 
            this.f_lblEnterSeats.AutoSize = true;
            this.f_lblEnterSeats.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f_lblEnterSeats.Location = new System.Drawing.Point(43, 156);
            this.f_lblEnterSeats.Name = "f_lblEnterSeats";
            this.f_lblEnterSeats.Size = new System.Drawing.Size(93, 20);
            this.f_lblEnterSeats.TabIndex = 12;
            this.f_lblEnterSeats.Text = "Max Seats:";
            // 
            // f_lblAddFlightMenu
            // 
            this.f_lblAddFlightMenu.AutoSize = true;
            this.f_lblAddFlightMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f_lblAddFlightMenu.Location = new System.Drawing.Point(172, 8);
            this.f_lblAddFlightMenu.Name = "f_lblAddFlightMenu";
            this.f_lblAddFlightMenu.Size = new System.Drawing.Size(166, 25);
            this.f_lblAddFlightMenu.TabIndex = 10;
            this.f_lblAddFlightMenu.Text = "---- Add Flight ----";
            // 
            // f_btnAddFlight
            // 
            this.f_btnAddFlight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f_btnAddFlight.ForeColor = System.Drawing.SystemColors.MenuText;
            this.f_btnAddFlight.Location = new System.Drawing.Point(352, 435);
            this.f_btnAddFlight.Name = "f_btnAddFlight";
            this.f_btnAddFlight.Size = new System.Drawing.Size(130, 36);
            this.f_btnAddFlight.TabIndex = 5;
            this.f_btnAddFlight.Text = "Add Flight";
            this.f_btnAddFlight.UseVisualStyleBackColor = true;
            this.f_btnAddFlight.Click += new System.EventHandler(this.btnAddFlight_Click_1);
            // 
            // f_txtEnterDest
            // 
            this.f_txtEnterDest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f_txtEnterDest.Location = new System.Drawing.Point(353, 355);
            this.f_txtEnterDest.Name = "f_txtEnterDest";
            this.f_txtEnterDest.Size = new System.Drawing.Size(129, 27);
            this.f_txtEnterDest.TabIndex = 4;
            // 
            // f_lblEnterDest
            // 
            this.f_lblEnterDest.AutoSize = true;
            this.f_lblEnterDest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f_lblEnterDest.Location = new System.Drawing.Point(43, 358);
            this.f_lblEnterDest.Name = "f_lblEnterDest";
            this.f_lblEnterDest.Size = new System.Drawing.Size(154, 20);
            this.f_lblEnterDest.TabIndex = 6;
            this.f_lblEnterDest.Text = "Port of Destination:";
            // 
            // f_txtEnterOrigin
            // 
            this.f_txtEnterOrigin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f_txtEnterOrigin.Location = new System.Drawing.Point(353, 254);
            this.f_txtEnterOrigin.Name = "f_txtEnterOrigin";
            this.f_txtEnterOrigin.Size = new System.Drawing.Size(129, 27);
            this.f_txtEnterOrigin.TabIndex = 3;
            // 
            // f_lblEnterOrigin
            // 
            this.f_lblEnterOrigin.AutoSize = true;
            this.f_lblEnterOrigin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f_lblEnterOrigin.Location = new System.Drawing.Point(43, 257);
            this.f_lblEnterOrigin.Name = "f_lblEnterOrigin";
            this.f_lblEnterOrigin.Size = new System.Drawing.Size(114, 20);
            this.f_lblEnterOrigin.TabIndex = 2;
            this.f_lblEnterOrigin.Text = "Port of Origin:";
            // 
            // f_txtEnterFN
            // 
            this.f_txtEnterFN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f_txtEnterFN.Location = new System.Drawing.Point(353, 52);
            this.f_txtEnterFN.Name = "f_txtEnterFN";
            this.f_txtEnterFN.Size = new System.Drawing.Size(129, 27);
            this.f_txtEnterFN.TabIndex = 1;
            // 
            // f_lblEnterFN
            // 
            this.f_lblEnterFN.AutoSize = true;
            this.f_lblEnterFN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f_lblEnterFN.Location = new System.Drawing.Point(43, 55);
            this.f_lblEnterFN.Name = "f_lblEnterFN";
            this.f_lblEnterFN.Size = new System.Drawing.Size(119, 20);
            this.f_lblEnterFN.TabIndex = 0;
            this.f_lblEnterFN.Text = "Flight Number:";
            // 
            // f_btnDeleteFlight
            // 
            this.f_btnDeleteFlight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f_btnDeleteFlight.ForeColor = System.Drawing.SystemColors.MenuText;
            this.f_btnDeleteFlight.Location = new System.Drawing.Point(457, 12);
            this.f_btnDeleteFlight.Name = "f_btnDeleteFlight";
            this.f_btnDeleteFlight.Size = new System.Drawing.Size(137, 36);
            this.f_btnDeleteFlight.TabIndex = 9;
            this.f_btnDeleteFlight.Text = "Delete Flight";
            this.f_btnDeleteFlight.UseVisualStyleBackColor = true;
            this.f_btnDeleteFlight.Click += new System.EventHandler(this.btnDeleteFlight_Click);
            // 
            // f_btnViewFlight
            // 
            this.f_btnViewFlight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f_btnViewFlight.ForeColor = System.Drawing.SystemColors.MenuText;
            this.f_btnViewFlight.Location = new System.Drawing.Point(90, 12);
            this.f_btnViewFlight.Name = "f_btnViewFlight";
            this.f_btnViewFlight.Size = new System.Drawing.Size(171, 36);
            this.f_btnViewFlight.TabIndex = 7;
            this.f_btnViewFlight.Text = "View Flight by Id:";
            this.f_btnViewFlight.UseVisualStyleBackColor = true;
            this.f_btnViewFlight.Click += new System.EventHandler(this.btnViewFlight_Click);
            // 
            // f_txtViewFlight
            // 
            this.f_txtViewFlight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f_txtViewFlight.Location = new System.Drawing.Point(13, 15);
            this.f_txtViewFlight.Name = "f_txtViewFlight";
            this.f_txtViewFlight.Size = new System.Drawing.Size(68, 30);
            this.f_txtViewFlight.TabIndex = 6;
            // 
            // flightListBindingSource
            // 
            this.flightListBindingSource.DataMember = "FlightList";
            this.flightListBindingSource.DataSource = this.xYZDatabaseDataSet;
            // 
            // xYZDatabaseDataSet
            // 
            this.xYZDatabaseDataSet.DataSetName = "XYZDatabaseDataSet";
            this.xYZDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panelBtnShow
            // 
            this.panelBtnShow.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panelBtnShow.Location = new System.Drawing.Point(5, 105);
            this.panelBtnShow.Name = "panelBtnShow";
            this.panelBtnShow.Size = new System.Drawing.Size(10, 103);
            this.panelBtnShow.TabIndex = 0;
            // 
            // CustomerMenu
            // 
            this.CustomerMenu.Controls.Add(this.cvError);
            this.CustomerMenu.Controls.Add(this.cdError);
            this.CustomerMenu.Controls.Add(this.c_viewOneCustomerPanel);
            this.CustomerMenu.Controls.Add(this.c_lblViewCustomers);
            this.CustomerMenu.Controls.Add(this.c_txtDelCustomer);
            this.CustomerMenu.Controls.Add(this.c_addCustomerPanel);
            this.CustomerMenu.Controls.Add(this.c_btnDeleteCustomer);
            this.CustomerMenu.Controls.Add(this.c_btnViewCustomer);
            this.CustomerMenu.Controls.Add(this.c_txtViewCustomer);
            this.CustomerMenu.Location = new System.Drawing.Point(186, 106);
            this.CustomerMenu.Name = "CustomerMenu";
            this.CustomerMenu.Size = new System.Drawing.Size(1107, 515);
            this.CustomerMenu.TabIndex = 8;
            // 
            // c_viewOneCustomerPanel
            // 
            this.c_viewOneCustomerPanel.Controls.Add(this.c_lblViewOneCustomer);
            this.c_viewOneCustomerPanel.Controls.Add(this.c_btnCloseOneCustomer);
            this.c_viewOneCustomerPanel.Location = new System.Drawing.Point(615, 3);
            this.c_viewOneCustomerPanel.Name = "c_viewOneCustomerPanel";
            this.c_viewOneCustomerPanel.Size = new System.Drawing.Size(494, 512);
            this.c_viewOneCustomerPanel.TabIndex = 12;
            this.c_viewOneCustomerPanel.Visible = false;
            // 
            // c_lblViewOneCustomer
            // 
            this.c_lblViewOneCustomer.AutoSize = true;
            this.c_lblViewOneCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c_lblViewOneCustomer.Location = new System.Drawing.Point(71, 7);
            this.c_lblViewOneCustomer.Name = "c_lblViewOneCustomer";
            this.c_lblViewOneCustomer.Size = new System.Drawing.Size(64, 25);
            this.c_lblViewOneCustomer.TabIndex = 10;
            this.c_lblViewOneCustomer.Text = "label2";
            // 
            // c_btnCloseOneCustomer
            // 
            this.c_btnCloseOneCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c_btnCloseOneCustomer.ForeColor = System.Drawing.SystemColors.MenuText;
            this.c_btnCloseOneCustomer.Location = new System.Drawing.Point(368, 455);
            this.c_btnCloseOneCustomer.Name = "c_btnCloseOneCustomer";
            this.c_btnCloseOneCustomer.Size = new System.Drawing.Size(114, 36);
            this.c_btnCloseOneCustomer.TabIndex = 9;
            this.c_btnCloseOneCustomer.Text = "Close";
            this.c_btnCloseOneCustomer.UseVisualStyleBackColor = true;
            this.c_btnCloseOneCustomer.Click += new System.EventHandler(this.c_btnCloseOneCustomer_Click);
            // 
            // c_lblViewCustomers
            // 
            this.c_lblViewCustomers.AutoSize = true;
            this.c_lblViewCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c_lblViewCustomers.Location = new System.Drawing.Point(15, 77);
            this.c_lblViewCustomers.Name = "c_lblViewCustomers";
            this.c_lblViewCustomers.Size = new System.Drawing.Size(64, 25);
            this.c_lblViewCustomers.TabIndex = 11;
            this.c_lblViewCustomers.Text = "label1";
            // 
            // c_txtDelCustomer
            // 
            this.c_txtDelCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c_txtDelCustomer.Location = new System.Drawing.Point(378, 14);
            this.c_txtDelCustomer.Name = "c_txtDelCustomer";
            this.c_txtDelCustomer.Size = new System.Drawing.Size(71, 28);
            this.c_txtDelCustomer.TabIndex = 7;
            // 
            // c_addCustomerPanel
            // 
            this.c_addCustomerPanel.Controls.Add(this.ccError);
            this.c_addCustomerPanel.Controls.Add(this.c_lblAddCustomerMenu);
            this.c_addCustomerPanel.Controls.Add(this.c_btnAddCustomer);
            this.c_addCustomerPanel.Controls.Add(this.c_txtEnterLName);
            this.c_addCustomerPanel.Controls.Add(this.c_lblEnterLName);
            this.c_addCustomerPanel.Controls.Add(this.c_txtEnterPhone);
            this.c_addCustomerPanel.Controls.Add(this.c_lblEnterPhone);
            this.c_addCustomerPanel.Controls.Add(this.c_txtEnterFName);
            this.c_addCustomerPanel.Controls.Add(this.c_lblEnterFName);
            this.c_addCustomerPanel.Location = new System.Drawing.Point(619, 4);
            this.c_addCustomerPanel.Name = "c_addCustomerPanel";
            this.c_addCustomerPanel.Size = new System.Drawing.Size(488, 508);
            this.c_addCustomerPanel.TabIndex = 9;
            // 
            // c_lblAddCustomerMenu
            // 
            this.c_lblAddCustomerMenu.AutoSize = true;
            this.c_lblAddCustomerMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c_lblAddCustomerMenu.Location = new System.Drawing.Point(115, 14);
            this.c_lblAddCustomerMenu.Name = "c_lblAddCustomerMenu";
            this.c_lblAddCustomerMenu.Size = new System.Drawing.Size(208, 25);
            this.c_lblAddCustomerMenu.TabIndex = 10;
            this.c_lblAddCustomerMenu.Text = "-----Add Customer-----";
            // 
            // c_btnAddCustomer
            // 
            this.c_btnAddCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c_btnAddCustomer.ForeColor = System.Drawing.SystemColors.MenuText;
            this.c_btnAddCustomer.Location = new System.Drawing.Point(331, 458);
            this.c_btnAddCustomer.Name = "c_btnAddCustomer";
            this.c_btnAddCustomer.Size = new System.Drawing.Size(146, 36);
            this.c_btnAddCustomer.TabIndex = 4;
            this.c_btnAddCustomer.Text = "Add Customer";
            this.c_btnAddCustomer.UseVisualStyleBackColor = true;
            this.c_btnAddCustomer.Click += new System.EventHandler(this.c_btnAddCustomer_Click);
            // 
            // c_txtEnterLName
            // 
            this.c_txtEnterLName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c_txtEnterLName.Location = new System.Drawing.Point(331, 240);
            this.c_txtEnterLName.Name = "c_txtEnterLName";
            this.c_txtEnterLName.Size = new System.Drawing.Size(145, 28);
            this.c_txtEnterLName.TabIndex = 2;
            // 
            // c_lblEnterLName
            // 
            this.c_lblEnterLName.AutoSize = true;
            this.c_lblEnterLName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c_lblEnterLName.Location = new System.Drawing.Point(14, 244);
            this.c_lblEnterLName.Name = "c_lblEnterLName";
            this.c_lblEnterLName.Size = new System.Drawing.Size(104, 24);
            this.c_lblEnterLName.TabIndex = 4;
            this.c_lblEnterLName.Text = "Last Name:";
            // 
            // c_txtEnterPhone
            // 
            this.c_txtEnterPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c_txtEnterPhone.Location = new System.Drawing.Point(331, 350);
            this.c_txtEnterPhone.Name = "c_txtEnterPhone";
            this.c_txtEnterPhone.Size = new System.Drawing.Size(145, 28);
            this.c_txtEnterPhone.TabIndex = 3;
            // 
            // c_lblEnterPhone
            // 
            this.c_lblEnterPhone.AutoSize = true;
            this.c_lblEnterPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c_lblEnterPhone.Location = new System.Drawing.Point(13, 361);
            this.c_lblEnterPhone.Name = "c_lblEnterPhone";
            this.c_lblEnterPhone.Size = new System.Drawing.Size(145, 24);
            this.c_lblEnterPhone.TabIndex = 2;
            this.c_lblEnterPhone.Text = "Phone Number:";
            // 
            // c_txtEnterFName
            // 
            this.c_txtEnterFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c_txtEnterFName.Location = new System.Drawing.Point(330, 130);
            this.c_txtEnterFName.Name = "c_txtEnterFName";
            this.c_txtEnterFName.Size = new System.Drawing.Size(145, 28);
            this.c_txtEnterFName.TabIndex = 1;
            // 
            // c_lblEnterFName
            // 
            this.c_lblEnterFName.AutoSize = true;
            this.c_lblEnterFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c_lblEnterFName.Location = new System.Drawing.Point(13, 127);
            this.c_lblEnterFName.Name = "c_lblEnterFName";
            this.c_lblEnterFName.Size = new System.Drawing.Size(106, 24);
            this.c_lblEnterFName.TabIndex = 0;
            this.c_lblEnterFName.Text = "First Name:";
            // 
            // c_btnDeleteCustomer
            // 
            this.c_btnDeleteCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c_btnDeleteCustomer.ForeColor = System.Drawing.SystemColors.MenuText;
            this.c_btnDeleteCustomer.Location = new System.Drawing.Point(455, 10);
            this.c_btnDeleteCustomer.Name = "c_btnDeleteCustomer";
            this.c_btnDeleteCustomer.Size = new System.Drawing.Size(158, 36);
            this.c_btnDeleteCustomer.TabIndex = 8;
            this.c_btnDeleteCustomer.Text = "Delete Customer";
            this.c_btnDeleteCustomer.UseVisualStyleBackColor = true;
            this.c_btnDeleteCustomer.Click += new System.EventHandler(this.c_btnDeleteCustomer_Click);
            // 
            // c_btnViewCustomer
            // 
            this.c_btnViewCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c_btnViewCustomer.ForeColor = System.Drawing.SystemColors.MenuText;
            this.c_btnViewCustomer.Location = new System.Drawing.Point(90, 10);
            this.c_btnViewCustomer.Name = "c_btnViewCustomer";
            this.c_btnViewCustomer.Size = new System.Drawing.Size(206, 36);
            this.c_btnViewCustomer.TabIndex = 6;
            this.c_btnViewCustomer.Text = "View Customer by Id:";
            this.c_btnViewCustomer.UseVisualStyleBackColor = true;
            this.c_btnViewCustomer.Click += new System.EventHandler(this.c_btnViewCustomer_Click);
            // 
            // c_txtViewCustomer
            // 
            this.c_txtViewCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c_txtViewCustomer.Location = new System.Drawing.Point(13, 14);
            this.c_txtViewCustomer.Name = "c_txtViewCustomer";
            this.c_txtViewCustomer.Size = new System.Drawing.Size(71, 28);
            this.c_txtViewCustomer.TabIndex = 5;
            // 
            // lblWelcomeMessage
            // 
            this.lblWelcomeMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeMessage.Location = new System.Drawing.Point(250, 150);
            this.lblWelcomeMessage.Name = "lblWelcomeMessage";
            this.lblWelcomeMessage.Size = new System.Drawing.Size(560, 144);
            this.lblWelcomeMessage.TabIndex = 10;
            this.lblWelcomeMessage.Text = "Welcome to XYZ Airlines\' Booking Management System";
            this.lblWelcomeMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BookingMenu
            // 
            this.BookingMenu.Controls.Add(this.b_addBookingPanel);
            this.BookingMenu.Controls.Add(this.bvError);
            this.BookingMenu.Controls.Add(this.b_lblViewBookings);
            this.BookingMenu.Controls.Add(this.b_btnViewBooking);
            this.BookingMenu.Controls.Add(this.b_txtViewBooking);
            this.BookingMenu.Location = new System.Drawing.Point(186, 106);
            this.BookingMenu.Name = "BookingMenu";
            this.BookingMenu.Size = new System.Drawing.Size(1111, 516);
            this.BookingMenu.TabIndex = 9;
            // 
            // b_addBookingPanel
            // 
            this.b_addBookingPanel.Controls.Add(this.b_viewOneBookingPanel);
            this.b_addBookingPanel.Controls.Add(this.b_lblShowCustomers);
            this.b_addBookingPanel.Controls.Add(this.bcError);
            this.b_addBookingPanel.Controls.Add(this.b_lblShowFlights);
            this.b_addBookingPanel.Controls.Add(this.bfError);
            this.b_addBookingPanel.Controls.Add(this.b_lblAddBooking);
            this.b_addBookingPanel.Controls.Add(this.b_btnAddBooking);
            this.b_addBookingPanel.Controls.Add(this.b_txtCustomerBook);
            this.b_addBookingPanel.Controls.Add(this.b_lblEnterCustomerBooking);
            this.b_addBookingPanel.Controls.Add(this.b_txtFlightBook);
            this.b_addBookingPanel.Controls.Add(this.b_lblEnterFlightBooking);
            this.b_addBookingPanel.Location = new System.Drawing.Point(457, 3);
            this.b_addBookingPanel.Name = "b_addBookingPanel";
            this.b_addBookingPanel.Size = new System.Drawing.Size(654, 513);
            this.b_addBookingPanel.TabIndex = 10;
            // 
            // b_btnAddBooking
            // 
            this.b_btnAddBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_btnAddBooking.ForeColor = System.Drawing.SystemColors.MenuText;
            this.b_btnAddBooking.Location = new System.Drawing.Point(466, 454);
            this.b_btnAddBooking.Name = "b_btnAddBooking";
            this.b_btnAddBooking.Size = new System.Drawing.Size(158, 36);
            this.b_btnAddBooking.TabIndex = 9;
            this.b_btnAddBooking.Text = "Add Booking";
            this.b_btnAddBooking.UseVisualStyleBackColor = true;
            this.b_btnAddBooking.Click += new System.EventHandler(this.b_btnAddBooking_Click);
            // 
            // b_txtCustomerBook
            // 
            this.b_txtCustomerBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_txtCustomerBook.Location = new System.Drawing.Point(466, 403);
            this.b_txtCustomerBook.Name = "b_txtCustomerBook";
            this.b_txtCustomerBook.Size = new System.Drawing.Size(158, 28);
            this.b_txtCustomerBook.TabIndex = 5;
            // 
            // b_lblEnterCustomerBooking
            // 
            this.b_lblEnterCustomerBooking.AutoSize = true;
            this.b_lblEnterCustomerBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_lblEnterCustomerBooking.Location = new System.Drawing.Point(102, 407);
            this.b_lblEnterCustomerBooking.Name = "b_lblEnterCustomerBooking";
            this.b_lblEnterCustomerBooking.Size = new System.Drawing.Size(116, 24);
            this.b_lblEnterCustomerBooking.TabIndex = 4;
            this.b_lblEnterCustomerBooking.Text = "Customer Id:";
            // 
            // b_txtFlightBook
            // 
            this.b_txtFlightBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_txtFlightBook.Location = new System.Drawing.Point(466, 336);
            this.b_txtFlightBook.Name = "b_txtFlightBook";
            this.b_txtFlightBook.Size = new System.Drawing.Size(158, 28);
            this.b_txtFlightBook.TabIndex = 1;
            // 
            // b_lblEnterFlightBooking
            // 
            this.b_lblEnterFlightBooking.AutoSize = true;
            this.b_lblEnterFlightBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_lblEnterFlightBooking.Location = new System.Drawing.Point(117, 340);
            this.b_lblEnterFlightBooking.Name = "b_lblEnterFlightBooking";
            this.b_lblEnterFlightBooking.Size = new System.Drawing.Size(81, 24);
            this.b_lblEnterFlightBooking.TabIndex = 0;
            this.b_lblEnterFlightBooking.Text = "Flight Id:";
            // 
            // b_btnViewBooking
            // 
            this.b_btnViewBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_btnViewBooking.ForeColor = System.Drawing.SystemColors.MenuText;
            this.b_btnViewBooking.Location = new System.Drawing.Point(177, 9);
            this.b_btnViewBooking.Name = "b_btnViewBooking";
            this.b_btnViewBooking.Size = new System.Drawing.Size(215, 36);
            this.b_btnViewBooking.TabIndex = 6;
            this.b_btnViewBooking.Text = "View Booking by Id:";
            this.b_btnViewBooking.UseVisualStyleBackColor = true;
            this.b_btnViewBooking.Click += new System.EventHandler(this.b_btnViewBooking_Click);
            // 
            // b_txtViewBooking
            // 
            this.b_txtViewBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_txtViewBooking.Location = new System.Drawing.Point(13, 11);
            this.b_txtViewBooking.Name = "b_txtViewBooking";
            this.b_txtViewBooking.Size = new System.Drawing.Size(153, 30);
            this.b_txtViewBooking.TabIndex = 5;
            // 
            // lblProcessResult
            // 
            this.lblProcessResult.AutoSize = true;
            this.lblProcessResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProcessResult.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblProcessResult.Location = new System.Drawing.Point(182, 624);
            this.lblProcessResult.Name = "lblProcessResult";
            this.lblProcessResult.Size = new System.Drawing.Size(232, 20);
            this.lblProcessResult.TabIndex = 11;
            this.lblProcessResult.Text = "#result of operation goes here";
            // 
            // flightListTableAdapter
            // 
            this.flightListTableAdapter.ClearBeforeFill = true;
            // 
            // cdError
            // 
            this.cdError.AutoSize = true;
            this.cdError.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.cdError.Location = new System.Drawing.Point(375, 49);
            this.cdError.Name = "cdError";
            this.cdError.Size = new System.Drawing.Size(161, 17);
            this.cdError.TabIndex = 11;
            this.cdError.Text = "*Please enter a number.";
            this.cdError.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cdError.Visible = false;
            // 
            // cvError
            // 
            this.cvError.AutoSize = true;
            this.cvError.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.cvError.Location = new System.Drawing.Point(10, 45);
            this.cvError.Name = "cvError";
            this.cvError.Size = new System.Drawing.Size(161, 17);
            this.cvError.TabIndex = 13;
            this.cvError.Text = "*Please enter a number.";
            this.cvError.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cvError.Visible = false;
            // 
            // ccError
            // 
            this.ccError.AutoSize = true;
            this.ccError.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.ccError.Location = new System.Drawing.Point(312, 438);
            this.ccError.Name = "ccError";
            this.ccError.Size = new System.Drawing.Size(163, 17);
            this.ccError.TabIndex = 14;
            this.ccError.Text = "*Customer already exists";
            this.ccError.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ccError.Visible = false;
            // 
            // b_viewOneBookingPanel
            // 
            this.b_viewOneBookingPanel.Controls.Add(this.b_lblViewOneBooking);
            this.b_viewOneBookingPanel.Controls.Add(this.b_btnCloseOneBooking);
            this.b_viewOneBookingPanel.Location = new System.Drawing.Point(4, 0);
            this.b_viewOneBookingPanel.Name = "b_viewOneBookingPanel";
            this.b_viewOneBookingPanel.Size = new System.Drawing.Size(647, 514);
            this.b_viewOneBookingPanel.TabIndex = 13;
            this.b_viewOneBookingPanel.Visible = false;
            // 
            // b_lblViewOneBooking
            // 
            this.b_lblViewOneBooking.AutoSize = true;
            this.b_lblViewOneBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_lblViewOneBooking.Location = new System.Drawing.Point(31, 17);
            this.b_lblViewOneBooking.Name = "b_lblViewOneBooking";
            this.b_lblViewOneBooking.Size = new System.Drawing.Size(163, 25);
            this.b_lblViewOneBooking.TabIndex = 10;
            this.b_lblViewOneBooking.Text = "One Booking Info";
            // 
            // b_btnCloseOneBooking
            // 
            this.b_btnCloseOneBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_btnCloseOneBooking.ForeColor = System.Drawing.SystemColors.MenuText;
            this.b_btnCloseOneBooking.Location = new System.Drawing.Point(507, 460);
            this.b_btnCloseOneBooking.Name = "b_btnCloseOneBooking";
            this.b_btnCloseOneBooking.Size = new System.Drawing.Size(114, 36);
            this.b_btnCloseOneBooking.TabIndex = 9;
            this.b_btnCloseOneBooking.Text = "Close";
            this.b_btnCloseOneBooking.UseVisualStyleBackColor = true;
            this.b_btnCloseOneBooking.Click += new System.EventHandler(this.b_btnCloseOneBooking_Click);
            // 
            // b_lblAddBooking
            // 
            this.b_lblAddBooking.AutoSize = true;
            this.b_lblAddBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_lblAddBooking.Location = new System.Drawing.Point(217, 290);
            this.b_lblAddBooking.Name = "b_lblAddBooking";
            this.b_lblAddBooking.Size = new System.Drawing.Size(194, 25);
            this.b_lblAddBooking.TabIndex = 10;
            this.b_lblAddBooking.Text = "-----Add Booking-----";
            // 
            // b_lblViewBookings
            // 
            this.b_lblViewBookings.AutoSize = true;
            this.b_lblViewBookings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_lblViewBookings.Location = new System.Drawing.Point(20, 77);
            this.b_lblViewBookings.Name = "b_lblViewBookings";
            this.b_lblViewBookings.Size = new System.Drawing.Size(120, 25);
            this.b_lblViewBookings.TabIndex = 11;
            this.b_lblViewBookings.Text = "Booking Info";
            // 
            // bfError
            // 
            this.bfError.AutoSize = true;
            this.bfError.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.bfError.Location = new System.Drawing.Point(448, 367);
            this.bfError.Name = "bfError";
            this.bfError.Size = new System.Drawing.Size(161, 17);
            this.bfError.TabIndex = 11;
            this.bfError.Text = "*Please enter a number.";
            this.bfError.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bfError.Visible = false;
            // 
            // bcError
            // 
            this.bcError.AutoSize = true;
            this.bcError.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.bcError.Location = new System.Drawing.Point(448, 435);
            this.bcError.Name = "bcError";
            this.bcError.Size = new System.Drawing.Size(161, 17);
            this.bcError.TabIndex = 12;
            this.bcError.Text = "*Please enter a number.";
            this.bcError.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bcError.Visible = false;
            // 
            // bvError
            // 
            this.bvError.AutoSize = true;
            this.bvError.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.bvError.Location = new System.Drawing.Point(10, 46);
            this.bvError.Name = "bvError";
            this.bvError.Size = new System.Drawing.Size(161, 17);
            this.bvError.TabIndex = 13;
            this.bvError.Text = "*Please enter a number.";
            this.bvError.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bvError.Visible = false;
            // 
            // b_lblShowFlights
            // 
            this.b_lblShowFlights.AutoSize = true;
            this.b_lblShowFlights.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_lblShowFlights.Location = new System.Drawing.Point(9, 8);
            this.b_lblShowFlights.Name = "b_lblShowFlights";
            this.b_lblShowFlights.Size = new System.Drawing.Size(91, 24);
            this.b_lblShowFlights.TabIndex = 13;
            this.b_lblShowFlights.Text = "Flight Info";
            // 
            // b_lblShowCustomers
            // 
            this.b_lblShowCustomers.AutoSize = true;
            this.b_lblShowCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_lblShowCustomers.Location = new System.Drawing.Point(324, 8);
            this.b_lblShowCustomers.Name = "b_lblShowCustomers";
            this.b_lblShowCustomers.Size = new System.Drawing.Size(126, 24);
            this.b_lblShowCustomers.TabIndex = 14;
            this.b_lblShowCustomers.Text = "Customer Info";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.ClientSize = new System.Drawing.Size(1316, 818);
            this.Controls.Add(this.BookingMenu);
            this.Controls.Add(this.lblProcessResult);
            this.Controls.Add(this.CustomerMenu);
            this.Controls.Add(this.btnBookings);
            this.Controls.Add(this.FlightMenu);
            this.Controls.Add(this.panelBtnShow);
            this.Controls.Add(this.c_btnCustomers);
            this.Controls.Add(this.titlePanel);
            this.Controls.Add(this.f_btnFlights);
            this.Controls.Add(this.lblWelcomeMessage);
            this.ForeColor = System.Drawing.SystemColors.Window;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.titlePanel.ResumeLayout(false);
            this.titlePanel.PerformLayout();
            this.FlightMenu.ResumeLayout(false);
            this.FlightMenu.PerformLayout();
            this.f_viewOneFlightPanel.ResumeLayout(false);
            this.f_viewOneFlightPanel.PerformLayout();
            this.f_AddFlightPanel.ResumeLayout(false);
            this.f_AddFlightPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flightListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xYZDatabaseDataSet)).EndInit();
            this.CustomerMenu.ResumeLayout(false);
            this.CustomerMenu.PerformLayout();
            this.c_viewOneCustomerPanel.ResumeLayout(false);
            this.c_viewOneCustomerPanel.PerformLayout();
            this.c_addCustomerPanel.ResumeLayout(false);
            this.c_addCustomerPanel.PerformLayout();
            this.BookingMenu.ResumeLayout(false);
            this.BookingMenu.PerformLayout();
            this.b_addBookingPanel.ResumeLayout(false);
            this.b_addBookingPanel.PerformLayout();
            this.b_viewOneBookingPanel.ResumeLayout(false);
            this.b_viewOneBookingPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.Panel FlightMenu;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button f_btnFlights;
        private System.Windows.Forms.Button c_btnCustomers;
        private System.Windows.Forms.Button btnBookings;
        private System.Windows.Forms.Panel Icon;
        private System.Windows.Forms.Panel panelBtnShow;
        private System.Windows.Forms.Panel BookingMenu;
        private System.Windows.Forms.Button b_btnViewBooking;
        private System.Windows.Forms.TextBox b_txtViewBooking;
        private System.Windows.Forms.Panel CustomerMenu;
        private System.Windows.Forms.Button c_btnDeleteCustomer;
        private System.Windows.Forms.Button c_btnViewCustomer;
        private System.Windows.Forms.TextBox c_txtViewCustomer;
        private System.Windows.Forms.Button f_btnDeleteFlight;
        private System.Windows.Forms.Button f_btnViewFlight;
        private System.Windows.Forms.TextBox f_txtViewFlight;
        private System.Windows.Forms.Label lblWelcomeMessage;
        private System.Windows.Forms.Panel f_AddFlightPanel;
        private System.Windows.Forms.TextBox f_txtEnterDest;
        private System.Windows.Forms.Label f_lblEnterDest;
        private System.Windows.Forms.TextBox f_txtEnterOrigin;
        private System.Windows.Forms.Label f_lblEnterOrigin;
        private System.Windows.Forms.TextBox f_txtEnterFN;
        private System.Windows.Forms.Label f_lblEnterFN;
        private System.Windows.Forms.Button f_btnAddFlight;
        private System.Windows.Forms.Panel c_addCustomerPanel;
        private System.Windows.Forms.Button c_btnAddCustomer;
        private System.Windows.Forms.TextBox c_txtEnterLName;
        private System.Windows.Forms.Label c_lblEnterLName;
        private System.Windows.Forms.TextBox c_txtEnterPhone;
        private System.Windows.Forms.Label c_lblEnterPhone;
        private System.Windows.Forms.TextBox c_txtEnterFName;
        private System.Windows.Forms.Label c_lblEnterFName;
        private System.Windows.Forms.Panel b_addBookingPanel;
        private System.Windows.Forms.Button b_btnAddBooking;
        private System.Windows.Forms.TextBox b_txtCustomerBook;
        private System.Windows.Forms.Label b_lblEnterCustomerBooking;
        private System.Windows.Forms.TextBox b_txtFlightBook;
        private System.Windows.Forms.Label b_lblEnterFlightBooking;
        private System.Windows.Forms.Panel f_viewOneFlightPanel;
        private System.Windows.Forms.Button f_btnCloseOneFlight;
        private System.Windows.Forms.Label f_lblAddFlightMenu;
        private System.Windows.Forms.Label lblProcessResult;
        private XYZDatabaseDataSet xYZDatabaseDataSet;
        private System.Windows.Forms.BindingSource flightListBindingSource;
        private XYZDatabaseDataSetTableAdapters.FlightListTableAdapter flightListTableAdapter;
        private System.Windows.Forms.TextBox f_txtEnterSeats;
        private System.Windows.Forms.Label f_lblEnterSeats;
        private System.Windows.Forms.Label f_lblViewFlights;
        private System.Windows.Forms.TextBox f_txtDelFlight;
        private System.Windows.Forms.Label fnError;
        private System.Windows.Forms.Label fvError;
        private System.Windows.Forms.Label fdError;
        private System.Windows.Forms.Label fsError;
        private System.Windows.Forms.Label f_lblViewOneFlight;
        private System.Windows.Forms.TextBox c_txtDelCustomer;
        private System.Windows.Forms.Label c_lblAddCustomerMenu;
        private System.Windows.Forms.Label c_lblViewCustomers;
        private System.Windows.Forms.Panel c_viewOneCustomerPanel;
        private System.Windows.Forms.Label c_lblViewOneCustomer;
        private System.Windows.Forms.Button c_btnCloseOneCustomer;
        private System.Windows.Forms.Label cvError;
        private System.Windows.Forms.Label cdError;
        private System.Windows.Forms.Label ccError;
        private System.Windows.Forms.Panel b_viewOneBookingPanel;
        private System.Windows.Forms.Label b_lblViewOneBooking;
        private System.Windows.Forms.Button b_btnCloseOneBooking;
        private System.Windows.Forms.Label bvError;
        private System.Windows.Forms.Label b_lblViewBookings;
        private System.Windows.Forms.Label bcError;
        private System.Windows.Forms.Label bfError;
        private System.Windows.Forms.Label b_lblAddBooking;
        private System.Windows.Forms.Label b_lblShowFlights;
        private System.Windows.Forms.Label b_lblShowCustomers;
    }
}

