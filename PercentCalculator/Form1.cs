using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PercentCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void calc_button_Click_1(object sender, EventArgs e)
        {
            try
            {
                double oldprice = Double.Parse(input1.Text);
                double newprice = Double.Parse(input2.Text);
                double difprice = newprice - oldprice;
                double ans = (difprice / oldprice) *100;
                //((Current Price - Old Price) / Old Price)*100

                changeoutput.Text = ans.ToString();
                difoutput.Text = difprice.ToString();
                input1.Select();

            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            input1.Text = string.Empty;
            input2.Text = string.Empty;
            changeoutput.Text = string.Empty;
            difoutput.Text = string.Empty;
            input1.Select();

        }

        private void Form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

    }
}
