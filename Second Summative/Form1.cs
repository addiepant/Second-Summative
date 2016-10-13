using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Second_Summative
{
    public partial class Form1 : Form
    {
        const double SNOW_ANGEL_COST = 10.50;
        double price;
        //int amount = 0;
        int snowAngel = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void checkoutLabel_Click(object sender, EventArgs e)
        {
            snowAngel = Convert.ToInt16(textBoxInput.Text);

            price = snowAngel * SNOW_ANGEL_COST;

            outputLabel.Text = "Your Total comes to" + price.ToString("$0.00");
        }
    }
}
