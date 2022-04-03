using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7Var3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Task1Form task1Form = new Task1Form();
            task1Form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Task2Form task2Form = new Task2Form();
            task2Form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Task3Form task3Form = new Task3Form(); 
            task3Form.Show();  
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();    
        }
    }
}
 