using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C969_Symmonds_winform
{
    public partial class Modify_Customer : Form
    {
        public Modify_Customer()
        {
            InitializeComponent();
        }

        public Modify_Customer(List<string> CustomerToModify)
        {
            InitializeComponent();
            CustId_Text.Text = CustomerToModify[0];
            Name_Text.Text = CustomerToModify[1];
            Address_Text.Text = CustomerToModify[2];
            Phone_Text.Text = CustomerToModify[3];
        }

        private void Modify_Customer_Load(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string Name = Name_Text.Text.ToString();
            string Address = Address_Text.Text.ToString();
            string Phone = Phone_Text.Text.ToString();
            string CustomerId = CustId_Text.Text.ToString();

            int.Parse(CustomerId);

            string query = $@"UPDATE customer
                            JOIN address ON customer.addressId = address.addressId
                            SET customer.customerName = '{Name}',
                                address.address = '{Address}',
                                address.phone = '{Phone}' 
                            WHERE customer.customerId = {CustomerId};";

            Helper.command(query);
            Helper.CustGrid.Refresh();
            MessageBox.Show("Customer saved!");
            this.Close();
            Customer custScreen = new Customer();
            custScreen.Show();
        }

        private void MainPage_Button_Click(object sender, EventArgs e)
        {
            MainForm mainPage = new MainForm();
            mainPage.Show();
            this.Close();

        }

        private void prevScreen_button_Click(object sender, EventArgs e)
        {
            Customer custView = new Customer();
            custView.Show();
            this.Close();
        }
    }
}
