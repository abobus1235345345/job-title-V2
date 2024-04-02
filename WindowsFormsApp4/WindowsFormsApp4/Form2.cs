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
    // В Form2.cs
    public partial class Form2 : Form
    {
        public string EmployeeName
        {
            get { return NameLabel1.Text; }
            set { NameLabel1.Text = value; }
        }

        public string EmployeePosition
        {
            get { return PositionLabel1.Text; }
            set { PositionLabel1.Text = value; }
        }

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}



