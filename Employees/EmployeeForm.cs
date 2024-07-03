using Employees.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employees
{
    public partial class EmployeeForm : Form
    {
        EmployeeModel dudu = new EmployeeModel(
            "1",
            "323052670",
            "Dudo",
            "Azulay",
            Gender.MALE,
            new DateOnly(2000, 11, 11),
            FamilyStatus.Married,
            "0508813867",
            "025536457",
            "habevieim",
            "54",
            "rosh hahain"
        );

        public EmployeeForm()
        {
            InitializeComponent();
            FillDetails();
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
        private void FillDetails()
        {
            textBoxstreet.Text = dudu.Street;
            textBox_city.Text = dudu.City;
            textBox_phone.Text = dudu.Phone;
            textBox_selolar.Text = dudu.CellPhone;
            textBox_num.Text = dudu.Home_num;
            textBox_tz.Text = dudu.Tz;
            textBox_first.Text = dudu.FirstName;
            textBox_last.Text = dudu.LastName;
            dateTimePicker1.Text = dudu.Bod.ToShortDateString();

        }

        private void DeleteDetails(object sender, EventArgs e)
        {
            textBoxstreet.Text = "";
            textBox_city.Text = "";
            textBox_phone.Text = "";
            textBox_selolar.Text = "";
            textBox_num.Text = "";
            textBox_tz.Text = "";
            textBox_first.Text = "";
            textBox_last.Text = "";
            dateTimePicker1.Value= DateTime.Now;
        }


    }
}
