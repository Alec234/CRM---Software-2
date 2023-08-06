using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.IO;
using System.Runtime.CompilerServices;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Collections;
using Org.BouncyCastle.Tls;

namespace C969_Symmonds_winform
{
    class Helper
    {
        public static DataGridView CustGrid { get; set; }
        public static string connectionString = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
        public Helper()
        {

        }

        public static bool loginIsStringValidation(string uName)
        {
            bool result = true;
            //bool uNameIsString = int.TryParse(uName, out int uNameNum);
            //bool PwdIsString = int.TryParse(pwd, out int PwdNum);

            foreach (char c in uName)
            {
                bool uNameIsString = int.TryParse(c.ToString(), out int uNameNum);
                if (uNameIsString)
                {
                    result = false;
                    break;
                }
            }


            return result;
        }

        public static void logUser(string user)
        {
            try
            {
                string path = ConfigurationManager.AppSettings.Get("UserLogFilePath");

                // Check if the directory exists, and if not, create it.
                string directory = Path.GetDirectoryName(path);
                if (!Directory.Exists(directory))
                {
                    try
                    {
                        Directory.CreateDirectory(directory);
                        Console.WriteLine($"Directory '{directory}' created successfully.");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error creating directory '{directory}': {ex.Message}");
                        // You may choose to throw an exception here or handle the error accordingly.
                    }
                }

                using (StreamWriter sr = new StreamWriter(path, true))
                {
                    string content = "User: " + user + " ||" + " DateTime: " + DateTime.Now;
                    sr.WriteLine(content);
                }
            }
            catch (Exception ex)
            {
                // Second lambda expression used here to simplify code
                Action<string> logAction = message =>
                {
                    Helper.log("Logging: " + message);
                };

                logAction(ex.ToString());
            }
        }

        public static void log(string message)
        {
            string path = ConfigurationManager.AppSettings.Get("LogFilePath");

            // Check if the directory exists, and if not, create it.
            string directory = Path.GetDirectoryName(path);
            if (!Directory.Exists(directory))
            {
                try
                {
                    Directory.CreateDirectory(directory);
                    Console.WriteLine($"Directory '{directory}' created successfully.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error creating directory '{directory}': {ex.Message}");
                }
            }

            // Now, write the log message to the file.
            try
            {
                using (StreamWriter sr = new StreamWriter(path, true))
                {
                    sr.WriteLine(message);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error writing to log file '{path}': {ex.Message}");
            }
        }


        //populate datagrid with current user appointments
        public static void populateGrid(DataGridView grid, string query)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(query, connection);
                    MySqlDataReader dataReader = command.ExecuteReader();

                    if(dataReader != null)
                    {
                        while (dataReader.Read())
                        {
                            object[] rowData = new object[dataReader.FieldCount];

                            // Fill the rowData array with values from the reader
                            dataReader.GetValues(rowData);

                            // Add the row to the DataGridView
                            grid.Rows.Add(rowData);
                        }
                    }
                    else
                    {
                        MessageBox.Show("There are no results that match your query");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error getting data");
                Helper.log($"{DateTime.Now} {ex.ToString()}");
            }

        }

        //add in reminder logic here
        //application will perform search for appointments on the same day based on user login time and user
        //credentials. store this list of same day appointments for the user and check every 5 minutes for any appointments
        //occuring within 15 minutes of datetime.now

        public static void command(string query)
        {

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();
            }
        }

        public static void command_multiple(List<string> queries)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                foreach (string query in queries)
                {
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static int AddressExist(string address)
        {
            string query = $"select addressId from address where 'address' = '{address}';";
            string connectionString = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();
                if(reader.Read())
                {
                    return reader.GetInt32(0);
                }
                else
                {
                    return 0;
                }
            }
        }

        public static int CountryExist(string country)
        {
            string query = $"select countryId from country where 'country' = '{country}';";
            string connectionString = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    return reader.GetInt32(0);
                }
                else
                {
                    return 0;
                }
            }
        }

        public static int CityExist(string city)
        {
            string query = $"select cityId from address where 'city' = '{city}';";
            string connectionString = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    return reader.GetInt32(0);
                }
                else
                {
                    return 0;
                }
            }
        }

        public static void reminder(DataGridView grid)
        {
            DateTime currentTime = DateTime.Now;
            DateTime fifteenMinutesFromNow = currentTime.AddMinutes(15);

            foreach (DataGridViewRow row in grid.Rows)
            {
                if (row.Cells["StartTime"].Value is DateTime appointmentStart)
                {
                    if (appointmentStart >= currentTime && appointmentStart <= fifteenMinutesFromNow)
                    {
                        MessageBox.Show("You have an appointment within 15 minutes!");
                    }
                }
            }

        }

        public static int InsertAddress(string address, string phone, int cityId)
        {
            int addressId = 0;
            string query = @"INSERT INTO ADDRESS (address, address2, cityId, postalCode, phone, createDate, createdBy, lastUpdate, lastUpdateBy)
                         VALUES (@address, '', @cityId, '', @phone, NOW(), '', NOW(), '')";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@address", address);
                    command.Parameters.AddWithValue("@phone", phone);
                    command.Parameters.AddWithValue("@cityId", cityId);
                    command.ExecuteNonQuery();

                    // Get the generated addressId
                    addressId = (int)command.LastInsertedId;
                }
            }

            return addressId;
        }

        public static int InsertCity(string city, string country)
        {
            int cityId = 0;
            int countryId = InsertCountry(country);
            string query = @"INSERT INTO CITY (city, countryId, createDate, createdBy, lastUpdate, lastUpdateBy)
                         VALUES (@city, @countryId, NOW(), '', NOW(), '')";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@city", city);
                    command.Parameters.AddWithValue("@countryId", countryId);
                    command.ExecuteNonQuery();

                    // Get the generated cityId
                    cityId = (int)command.LastInsertedId;
                }
            }

            return cityId;
        }

        public static int InsertCountry(string country)
        {
            int countryId = 0;
            string query = @"INSERT INTO COUNTRY (country, createDate, createdBy, lastUpdate, lastUpdateBy)
                             VALUES (@country, NOW(), '', NOW(), '')";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@country", country);
                    command.ExecuteNonQuery();
            
                    // Get the generated countryId
                    countryId = (int)command.LastInsertedId;
                }
            }

            return countryId;
        }

        public static void InsertCustomer(string name, int addressId, string phone)
        {
            string query = $@"INSERT INTO CUSTOMER (customerName, addressId, active, createDate, createdBy, lastUpdate, lastUpdateBy)
                     VALUES (@name, @addressId, 1, NOW(), '{User_information.userName}', NOW(), '{User_information.userName}')";

            //int customerId = 0;
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@addressId", addressId);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static int custExist(string customerName)
        {
            string query = $"select * from customer where customerName = '{customerName}';";
            string connectionString = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    return reader.GetInt32(0);
                }

                return 0;

            }
        }

        //consume date
        //check if that date matches any start or end times -/+ 1 min
        public static bool overlappingAppointment(DateTime start, DateTime end)
        {
            string query = $@"SELECT COUNT(*) FROM APPOINTMENT
                  WHERE (start < '{end.ToString("yyyy-MM-dd HH:mm:ss")}'
                  AND end > '{start.ToString("yyyy-MM-dd HH:mm:ss")}')";

            int overlappingCount = 0;
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(query, connection);
                overlappingCount = Convert.ToInt32(command.ExecuteScalar());
            }
            //This lambda statement makes the code a lot cleaner than an if/else statement as well as providing an increase
            //in readability.

            return overlappingCount > 0;
        }

        public static void convertTimeZone(DataGridView grid, string columnName)
        {
            TimeZoneInfo userTimeZone = TimeZoneInfo.Local;

            // Iterate through the rows of the DataGridView
            foreach (DataGridViewRow row in grid.Rows)
            {
                DataGridViewCell cell = row.Cells[columnName];
                if (cell.Value is DateTime originalDateTime)
                {
                    TimeZoneInfo cstTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Central Standard Time");
                    DateTime userDateTime = TimeZoneInfo.ConvertTime(originalDateTime, cstTimeZone, userTimeZone);
                    cell.Value = userDateTime;
                }
            }
        }

        public static void reminders(string userId)
        {
            string query = $@"SELECT customer.customerName,
                            appointment.type,
                            appointment.start
                            FROM appointment JOIN customer ON appointment.customerId = customer.customerId
                            WHERE appointment.start BETWEEN DATE_SUB(NOW(), INTERVAL 15 MINUTE) AND NOW() AND userId = '{userId}';";

            string connectionString = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;


            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    string customerName = reader.GetString(0);
                    string appointmentType = reader.GetString(1);
                    string time = reader.GetDateTime(2).ToString();
                }

            }

            string message = @"Reminder that you have an appointment with {customerName} for appointment type: {appointmentType} at {time}";
            MessageBox.Show(message);

            
        }

        public static bool appointmentExists(int appointment_Id)
        {
            string query = $"Select * from appointment where appointmentId = '{appointment_Id.ToString()}';";
            string connectionString = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    return true;
                }
                else { return false; }
            }
        }

    }
}

