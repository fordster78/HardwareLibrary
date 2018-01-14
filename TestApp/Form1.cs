using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HardwareLibrary;

namespace TestApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = SystemProperties.ComputerName();
            label2.Text = SystemProperties.ComputerMake();
            label3.Text = SystemProperties.ComputerModel();
            label4.Text = SystemProperties.SerialNumber();
        }
    }
}
