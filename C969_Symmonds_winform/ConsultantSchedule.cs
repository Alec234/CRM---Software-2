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
    public partial class ConsultantSchedule : Form
    {
        public ConsultantSchedule()
        {
            InitializeComponent();
        }

        private void prev_button_Click(object sender, EventArgs e)
        {
            this.Close();
            Reports report = new Reports();
            report.Show();
        }

        private void find_Button_Click(object sender, EventArgs e)
        {
            string name = find_Text.Text;
            //string query = $"select * from user where customerName like '%{name}%';";

            string query = $@"SELECT user.userName, appointment.type, appointment.start, appointment.end
                                FROM user
                                JOIN appointment ON user.userId = appointment.userId
                                WHERE user.userName LIKE '%{name}%';";
            consultantGridView.Rows.Clear();

            Helper.populateGrid(consultantGridView, query);
            Helper.convertTimeZone(consultantGridView, "startTime");
            Helper.convertTimeZone(consultantGridView, "endTime");
            consultantGridView.Refresh();
        }
    }
}
