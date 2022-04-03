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
    public partial class DeleteFromArrayForm : Form
    {
        private int key;

        public int GetKey()
        {
            return key;
        }
        public DeleteFromArrayForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool isValidInput = int.TryParse(textBox1.Text, out key);

            if (!isValidInput)
            {
                MessageBox.Show("Вы ввели некорретные данные!");
            }
            else
            {
                Close();
            }
        }
    }
}
