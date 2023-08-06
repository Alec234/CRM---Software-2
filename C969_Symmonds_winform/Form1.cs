using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Globalization;

namespace C969_Symmonds_winform
{
    public partial class Form1 : Form
    {
        string userValidation = "";
        string loginValidation = "";
        CultureInfo currentCulture = null;
        string userValMessage = "Username can only contain letters, please enter a valid username.";
        string message = "Invalid Username or Password.";

        public Form1()
        {
            InitializeComponent();
            //currentCulture = new CultureInfo("ru");
            this.Load += Form1_Load;

            
           // Console.WriteLine("Current Culture: " + currentCulture.Name);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Get the current user's culture
            this.currentCulture = CultureInfo.CurrentCulture;
            Console.WriteLine("Current Culture: " + currentCulture.Name);
            User_information.userTimeZone = TimeZoneInfo.Local;
            Console.WriteLine(User_information.userTimeZone);

            // Translate labels and other controls based on the user's region
            TranslateControls(currentCulture);
        }

        private void TranslateControls(CultureInfo currentCulture)
        {
            //china
            if (currentCulture.Name == "zh-CN")
            {
                label1.Text = "你好！";
                label2.Text = "欢迎使用该应用程序。";
                Login_Button.Text = "登录";
                this.userValMessage = "用户名只能包含字母，请输入有效的用户名。";
                this.message = "用户名或密码无效。";
            }
            //russia
            else if (currentCulture.Name == "ru")
            {
                label1.Text = "Привет!";
                label2.Text = "Добро пожаловать в приложение.";
                Login_Button.Text = "Войти";
                this.userValMessage = "Имя пользователя может содержать только буквы, введите правильное имя пользователя.";
                this.message = "Неправильное имя пользователя или пароль.";
            }

        }

        private void Login_Button_Click(object sender, EventArgs e)
        {
            try
            {
                //trying something new -> use a static class to hold current user values, hopefully garbage collection kills
                //it after program termination or logout if i add that feature.
                User_information.userName = Username_Text.Text;
                User_information.password = Pwd_Text.Text;
                User_information.currentUser = new string[2] { User_information.userName, User_information.password };

                string connectionString = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;

                if (Helper.loginIsStringValidation(User_information.userName))
                {



                    string loginQuery = $"Select * from user where userName = \'{User_information.userName}\' and password = \'{User_information.password}\';";
                    //MySqlConnection
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();
                        MySqlCommand command = new MySqlCommand(loginQuery, connection);
                        MySqlDataReader dataReader = command.ExecuteReader();

                        while (dataReader.Read())
                        {
                            int.TryParse(dataReader.GetValue(0).ToString(), out User_information.UserID);

                            if (User_information.userName == dataReader.GetValue(1).ToString() && User_information.password == dataReader.GetValue(2).ToString())
                            {
                                Helper.logUser(User_information.userName);
                                MessageBox.Show("Success!");
                                MainForm form = new MainForm();
                                this.Hide();
                                form.Show();
                                break;
                            }
                        }
                        if(!dataReader.HasRows)
                        {
                            MessageBox.Show(message);
                        }
                    }
                }
                else
                {
                    MessageBox.Show(userValMessage);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(message);
                Helper.log(ex.ToString());
            }
        }

        private void TimeZone_Combo_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void DST_Combo_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
