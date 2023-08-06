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
    public partial class MainForm : Form
    {
        string Query = $"Select userId, title, description, location, start from appointment" +
    $" where UserID = {User_information.UserID}";
        public MainForm()
        {
            InitializeComponent();
            Helper.populateGrid(MainFormGrid, Query);
            Helper.convertTimeZone(MainFormGrid, "StartTime");
            MainFormGrid.Refresh();
            //Helper.reminders(User_information.UserID.ToString());
            Helper.reminder(MainFormGrid);
        }

        //ignore groupBox1_Enter method
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Customer_Button_Click(object sender, EventArgs e)
        {
            Customer cust = new Customer();
            cust.Show();
            this.Hide();
        }

        private void Appointment_Button_Click(object sender, EventArgs e)
        { 
            this.Hide();
            Schedule apnmt = new Schedule();
            apnmt.Show();
        }

        private void Reports_Button_Click(object sender, EventArgs e)
        {
            Reports report = new Reports();
            this.Close();
            report.Show();
        }
    }
}
