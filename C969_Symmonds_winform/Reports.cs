using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C969_Symmonds_winform
{
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }

        private void MonthlyAppointments_Click(object sender, EventArgs e)
        {
            string query = @"SELECT COUNT(*), MONTH(start) as Month, type
                    FROM appointment where type != ''
                    GROUP BY MONTH(start), type;";

            string connectionString = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
            string result = "";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int count = reader.GetInt32(0);
                    int month = reader.GetInt32(1);
                    string appointmentType = reader.GetString(2);

                    string monthName = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(month);

                    result += $"{monthName}: {count} Appointment of type {appointmentType}\n";
                }
            }

            MessageBox.Show(result);
        }





        private void ConsultantSchedule_Click(object sender, EventArgs e)
        {
            ConsultantSchedule constSched = new ConsultantSchedule();
            this.Close();
            constSched.Show();
        }

        private void AppUserCount_Click(object sender, EventArgs e)
        {
            string query = $"SELECT count(*) from user;";
            string connectionString = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
            int userCount = 0;


            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    userCount = reader.GetInt32(0);
                }
            }

            MessageBox.Show(userCount.ToString());
        }
    }
}
