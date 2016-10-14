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
        const double SILVER_WINGS_COST = 11.50;
        const double CHAMPAGNE_COST = 11.50;
        const double COPPER_HEART_COST = 11.50;

        double price; 
        int snowAngel = 0;
        int silverWings = 0;
        int champagne = 0;
        int copperHeart = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void checkoutLabel_Click(object sender, EventArgs e)
        {
            snowAngel = Convert.ToInt16(textBoxInput.Text);
            silverWings = Convert.ToInt16(textBoxInput2.Text);
            champagne = Convert.ToInt16(textBoxInput3.Text);
            copperHeart = Convert.ToInt16(textBoxInput4.Text);

            price = snowAngel * SNOW_ANGEL_COST + silverWings * SILVER_WINGS_COST + champagne * CHAMPAGNE_COST 
                + COPPER_HEART_COST * copperHeart;

            outputLabel.Text = "Your Total comes to " + price.ToString("$0.00");
        } 
    }
}
