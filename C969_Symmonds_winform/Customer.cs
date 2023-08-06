using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities.Collections;
using System;
using System.Collections;
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
    public partial class Customer : Form
    {
        private string Query = $@"SELECT customer.customerId,
                                  customer.customerName, address.address, address.phone
                                FROM customer
                                JOIN address ON customer.addressId = address.addressId";

        public Customer()
        {
            InitializeComponent();
            Helper.populateGrid(CustomerGridView, this.Query);
           

            //populate fields

            /*
            string CustomerId = CustomerGridView.SelectedRows[0].Cells[0].Value.ToString();
            Name_Text.Text = CustomerGridView.SelectedRows[0].Cells[1].Value.ToString();
            Address_Text.Text = CustomerGridView.SelectedRows[0].Cells[2].Value.ToString();
            Phone_Text.Text = CustomerGridView.SelectedRows[0].Cells[3].Value.ToString();*/
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            // Check if address exists or insert if it doesn't
            int cityId = 0;
            int countryId = 0;
            if(Phone_Text.Text != "" || Name_Text.Text != "")
            {
                int addressId = Helper.AddressExist(Address_Text.Text.ToString());
                if (addressId == 0 && Address_Text.Text != null)
                {
                    // Check if city exists or insert if it doesn't
                    cityId = Helper.CityExist(City_Text.Text.ToString());
                    if (cityId == 0 && City_Text.Text != "")
                    {
                        // Insert city
                        cityId = Helper.InsertCity(City_Text.Text.ToString(), Country_Text.Text.ToString());

                        //Exception Control number 2
                        if (cityId == null)
                        {
                            throw new Exception("cityId is null");
                        }

                        // Check if country exists or insert if it doesn't
                        countryId = Helper.CountryExist(Country_Text.Text.ToString());
                        if (countryId == 0 && Country_Text.Text != "")
                        {
                            // Insert country
                            countryId = Helper.InsertCountry(Country_Text.Text.ToString());
                        }
                    }

                    // Insert address with the valid cityId
                    addressId = Helper.InsertAddress(Address_Text.Text.ToString(), Phone_Text.Text.ToString(), cityId);
                }

                Helper.InsertCustomer(Name_Text.Text.ToString(), addressId, Phone_Text.Text.ToString());
                CustomerGridView.Rows.Clear();
                Helper.populateGrid(CustomerGridView, this.Query);
            }
            else
            {
                MessageBox.Show("All fields must contain a value, they cannot be null.");
            }
            

        }


        //could have fields populate when a row is selected from the grid and the modify button is selected
        private void Modify_button_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> custToModify = new List<string>()
                {
                    CustomerGridView.SelectedRows[0].Cells[0].Value.ToString(),
                    CustomerGridView.SelectedRows[0].Cells[1].Value.ToString(),
                    CustomerGridView.SelectedRows[0].Cells[2].Value.ToString(),
                    CustomerGridView.SelectedRows[0].Cells[3].Value.ToString()
                };

                    Modify_Customer custScreen = new Modify_Customer(custToModify);
                    custScreen.Show();
                    Helper.CustGrid = CustomerGridView;
                    this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Please select a row");
                Helper.log(ex.ToString());
            }


        }

        private void Delete_Button_Click(object sender, EventArgs e)
        {
            int custId = int.Parse(CustomerGridView.SelectedRows[0].Cells[0].Value.ToString());
            string name = CustomerGridView.SelectedRows[0].Cells[1].Value.ToString();
            string address = CustomerGridView.SelectedRows[0].Cells[2].Value.ToString();
            string phone = CustomerGridView.SelectedRows[0].Cells[3].Value.ToString();

            string query = $@"
    DELETE customer, address FROM customer
    JOIN address ON customer.addressId = address.addressId
    WHERE customer.customerName = '{name}' 
    AND address.address = '{address}' 
    AND address.phone = '{phone}' 
    AND customer.customerId = {custId};";
            Helper.command(query);
            CustomerGridView.Rows.Clear();
            Helper.populateGrid(CustomerGridView, this.Query);
            MessageBox.Show("Customer deleted!");

        }

        private void Search_button_Click(object sender, EventArgs e)
        {
            //id, name, address phone
            string name = Search_Text.Text;
            //string query = $"select * from user where customerName like '%{name}%';";

            string newQuery = $@"SELECT customer.customerId, customer.customerName, address.address, address.phone
                                FROM customer
                                JOIN address ON customer.addressId = address.addressId
                                WHERE customer.customerName LIKE '%{name}%';";
            CustomerGridView.Rows.Clear();

            Helper.populateGrid(CustomerGridView, newQuery);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Prev_Button_Click(object sender, EventArgs e)
        {
            MainForm mForm = new MainForm();
            this.Close();
            mForm.Show();
        }
    }
}
