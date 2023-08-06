using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace C969_Symmonds_winform
{
    public partial class Schedule : Form
    {
        string classQuery = $@"SELECT appointment.customerId, appointment.appointmentId, 
                  customer.customerName, appointment.title, appointment.description,
                  appointment.location, appointment.start AS DateOnly
                  FROM customer
                  JOIN appointment ON customer.customerId = appointment.customerId
                  WHERE DATE(appointment.start) = CURDATE();";
        public Schedule()
        {
            InitializeComponent();
            ScheduleGridView.SelectionChanged += ScheduleGridView_SelectionChanged;
            Helper.populateGrid(ScheduleGridView, this.classQuery);
            Helper.convertTimeZone(ScheduleGridView, "startTime");
            ScheduleGridView.Refresh();
        }

        private void monthCalendar2_DateChanged(object sender, DateRangeEventArgs e)
        {

            DateTime selectedDate = monthCalendar2.SelectionStart;
            string formattedDate = selectedDate.ToString("yyyy-MM-dd");

            //MessageBox.Show(formattedDate);

            string query = $@"SELECT appointment.customerId, appointment.appointmentId, 
                  customer.customerName, appointment.title, appointment.description,
                  appointment.location, appointment.start AS DateOnly, appointment.type
                  FROM customer
                  JOIN appointment ON customer.customerId = appointment.customerId
                  WHERE DATE(appointment.start) = DATE('{formattedDate}');";
            ScheduleGridView.Rows.Clear();
            Helper.populateGrid(ScheduleGridView, query);
            Helper.convertTimeZone(ScheduleGridView, "startTime");
            ScheduleGridView.Refresh();

        }

        private void Prev_Button_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            this.Close();
            mainForm.Show();
        }

        private void Add_Button_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;

                //logic to ensure time is formatted( 00:00 )
                DateTime selectedDate = Date_Value.Value.Date;
                string timeText = StartTime_Text.Text;

                DateTime modifiedDateTimeStart = new DateTime(selectedDate.Year, selectedDate.Month, selectedDate.Day,
                                                         0, 0, 0).Add(TimeSpan.Parse(timeText));
                DateTime modifiedDateTimeEnd = modifiedDateTimeStart.AddMinutes(30);



                DateTime businessHoursStart = DateTime.Today.AddHours(9);
                DateTime businessHoursEnd = DateTime.Today.AddHours(17);


                //returns the customerID
                int custExistsId = Helper.custExist(CustomerName_Text.Text.ToString());
                if (custExistsId != 0)
                {
                    
                    string query = $@"INSERT INTO APPOINTMENT (userId, type, customerId, title, description, contact, url, location, start, end, createDate, createdBy, lastUpdate, lastUpdateBy)
                    VALUES (
                    {User_information.UserID},
                    '{Type_DropDown.Text.ToString()}',
                    (SELECT customerId FROM CUSTOMER WHERE customerName = '{CustomerName_Text.Text.ToString()}'),
                    '{Title_Text.Text.ToString()}',
                    '{Description_Text.Text.ToString()}',
                    '',
                    '',
                    '{Location_Text.Text.ToString()}',
                    '{modifiedDateTimeStart.ToString("yyyy-MM-dd HH:mm:ss")}',
                    '{modifiedDateTimeEnd.ToString("yyyy-MM-dd HH:mm:ss")}',
                    NOW(),
                    '{User_information.userName}', 
                    NOW(), 
                    '{User_information.userName}'
                    );";
                    //grid is not populating times properly
                    if (modifiedDateTimeStart.TimeOfDay >= businessHoursStart.TimeOfDay && modifiedDateTimeEnd.TimeOfDay <= businessHoursEnd.TimeOfDay)
                    {
                        if(!Helper.overlappingAppointment(modifiedDateTimeStart, modifiedDateTimeEnd))
                        {
                            using (MySqlConnection connection = new MySqlConnection(connectionString))
                            {
                                connection.Open();

                                using (MySqlCommand command = new MySqlCommand(query, connection))
                                {
                                    command.ExecuteNonQuery();
                                }
                            }
                            MessageBox.Show("Appointment successfully added!");
                        }
                        else
                        {
                            MessageBox.Show("An appointment within that time already exists, please choose a different time.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter hours between 0900 and 1630.");
                    }
                }
                else
                {
                    MessageBox.Show("Customer must exist.");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);    
            }


        }

        private void Modify_Button_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;

                // Logic to ensure time is formatted (00:00)
                DateTime selectedDate = Date_Value.Value.Date;
                string timeText = StartTime_Text.Text;

                DateTime dateTime;
                if (DateTime.TryParse(timeText, out dateTime))
                {
                    // Parsing successful, extract the time component
                    TimeSpan timeSpan = dateTime.TimeOfDay;

                    DateTime modifiedDateTimeStart = new DateTime(selectedDate.Year, selectedDate.Month, selectedDate.Day,
                                                                 timeSpan.Hours, timeSpan.Minutes, 0);
                    DateTime modifiedDateTimeEnd = modifiedDateTimeStart.AddMinutes(30);

                    DateTime businessHoursStart = DateTime.Today.AddHours(9);
                    DateTime businessHoursEnd = DateTime.Today.AddHours(17);

                    int appointmentId = int.Parse(appointmentId_Text.Text); // Assuming you have a text box for the Appointment ID

                    // Check if the appointment exists in the database
                    if (Helper.appointmentExists(appointmentId))
                    {
                        string query = $@"UPDATE APPOINTMENT 
                                  SET userId = {User_information.UserID},
                                      type = '{Type_DropDown.Text}',
                                      customerId = (SELECT customerId FROM CUSTOMER WHERE customerName = '{CustomerName_Text.Text.ToString()}'),
                                      title = '{Title_Text.Text.ToString()}',
                                      description = '{Description_Text.Text.ToString()}',
                                      location = '{Location_Text.Text.ToString()}',
                                      start = '{modifiedDateTimeStart.ToString("yyyy-MM-dd HH:mm:ss")}',
                                      end = '{modifiedDateTimeEnd.ToString("yyyy-MM-dd HH:mm:ss")}',
                                      lastUpdate = NOW(),
                                      lastUpdateBy = '{User_information.userName}'
                                  WHERE appointmentId = {appointmentId};";

                        // Check if the appointment time is within business hours and not overlapping
                        if (modifiedDateTimeStart.TimeOfDay >= businessHoursStart.TimeOfDay && modifiedDateTimeEnd.TimeOfDay <= businessHoursEnd.TimeOfDay)
                        {
                            if (!Helper.overlappingAppointment(modifiedDateTimeStart, modifiedDateTimeEnd))
                            {
                                using (MySqlConnection connection = new MySqlConnection(connectionString))
                                {
                                    connection.Open();

                                    using (MySqlCommand command = new MySqlCommand(query, connection))
                                    {
                                        command.ExecuteNonQuery();
                                    }
                                }
                                MessageBox.Show("Appointment successfully modified!");

                                DateTime selecteddDate = monthCalendar2.SelectionStart;
                                string formattedDate = selecteddDate.ToString("yyyy-MM-dd");

                                //MessageBox.Show(formattedDate);

                                string qquery = $@"SELECT appointment.customerId, appointment.appointmentId, 
                  customer.customerName, appointment.title, appointment.description,
                  appointment.location, appointment.start AS DateOnly, appointment.type
                  FROM customer
                  JOIN appointment ON customer.customerId = appointment.customerId
                  WHERE DATE(appointment.start) = DATE('{formattedDate}');";
                                ScheduleGridView.Rows.Clear();
                                Helper.populateGrid(ScheduleGridView, qquery);
                                Helper.convertTimeZone(ScheduleGridView, "startTime");
                                ScheduleGridView.Refresh();
                            }
                            else
                            {
                                MessageBox.Show("An appointment within that time already exists, please choose a different time.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please enter hours between 0900 and 1630.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Appointment does not exist.");
                    }
                }
                else
                {
                    // Parsing failed, handle the invalid format (e.g., show an error message)
                    MessageBox.Show("Invalid time format. Please enter time in hh:mm tt format (e.g., 2:30 PM).");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void ScheduleGridView_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (ScheduleGridView.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = ScheduleGridView.SelectedRows[0];
                    appointmentId_Text.Text = selectedRow.Cells["AppointmentId"].Value.ToString();
                    CustomerName_Text.Text = selectedRow.Cells["customerName"].Value.ToString();
                    Title_Text.Text = selectedRow.Cells["title"].Value.ToString();
                    Description_Text.Text = selectedRow.Cells["description"].Value.ToString();
                    Location_Text.Text = selectedRow.Cells["location"].Value.ToString();
                    StartTime_Text.Text = selectedRow.Cells["startTime"].Value.ToString();
                    //lambda expression
                    Type_DropDown.Text = selectedRow.Cells["type"].Value?.ToString() ?? "";


                    // Convert the date string to a DateTime object
                    if (DateTime.TryParse(selectedRow.Cells["startTime"].Value.ToString(), out DateTime dateValue))
                    {
                        Date_Value.Value = dateValue;
                    }
                    else
                    {
                        // Handle invalid date format or null value, e.g., set a default date
                        Date_Value.Value = DateTime.Today;
                    }
                }
            }
            catch(Exception ex)
            {
                Helper.log(ex.ToString());
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            string query = $"delete from appointment where appointmentId = '{appointmentId_Text.Text}';";
            Helper.command(query);
            MessageBox.Show("Record successfully deleted!");

            DateTime selecteddDate = monthCalendar2.SelectionStart;
            string formattedDate = selecteddDate.ToString("yyyy-MM-dd");

            //MessageBox.Show(formattedDate);

            string qquery = $@"SELECT appointment.customerId, appointment.appointmentId, 
                  customer.customerName, appointment.title, appointment.description,
                  appointment.location, appointment.start AS DateOnly, appointment.type
                  FROM customer
                  JOIN appointment ON customer.customerId = appointment.customerId
                  WHERE DATE(appointment.start) = DATE('{formattedDate}');";
            ScheduleGridView.Rows.Clear();
            Helper.populateGrid(ScheduleGridView, qquery);
            Helper.convertTimeZone(ScheduleGridView, "startTime");
            ScheduleGridView.Refresh();

        }
    }
}
