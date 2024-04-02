using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        // В Form1.cs
        private void button2_Click(object sender, EventArgs e)
        {
            string login = LoginTextBox.Text;
            string password = textBox4.Text;

            Dictionary<string, string[]> employeesData = new Dictionary<string, string[]>()
    {
        {"Илья", new string[] {"Qwerty", "Илья", "Разработчик"}},
        {"user2", new string[] { "user", "qwe", "Менеджер"}},
        {"user3", new string[] { "user", "ewq", "Менеджер"}},
        {"user4", new string[] { "user", "zxc", "Менеджер"}},
    };

            if (employeesData.ContainsKey(login) && employeesData[login][0] == password)
            {
                string name = employeesData[login][1];
                string position = employeesData[login][2];

                Form2 form2 = new Form2();
                form2.EmployeeName = $"Имя: {name}";
                form2.EmployeePosition = $"Должность: {position}";
                form2.Show();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль", "Ошибка");
            }
        }


        private void LoginTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
    

}

        
        