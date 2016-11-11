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
    //Addie Pant
    //Second Summative- Makeup Pallette cash register
    //October 14, 2016
    public partial class makeupCashRegister : Form
    {
        //Define cost of each item     
        const double SNOW_ANGEL_COST = 10.50;
        const double SILVER_WINGS_COST = 11.50;
        const double CHAMPAGNE_COST = 11.50;
        const double COPPER_HEART_COST = 11.50;
        const double FLOWERS_COST = 12.99;
        const double ROSE_PLUM_COST = 15.99;

        //create a 'price' and 'total' components and enter intial amount of product
        double price;
        double taxAmount;
        double total;
        int snowAngel = 0;
        int silverWings = 0;
        int champagne = 0;
        int copperHeart = 0;
        int flowers = 0;
        int rosePlum = 0;
        double tax = .13;
        double change = 0;
        double tendered = 0;

        public makeupCashRegister()
        {
            InitializeComponent();
        }

        private void checkoutLabel_Click(object sender, EventArgs e)
        {
            try
            {
                //Make products equal amount entered into the textboxes
                snowAngel = Convert.ToInt16(textBoxInput.Text);
                silverWings = Convert.ToInt16(textBoxInput2.Text);
                champagne = Convert.ToInt16(textBoxInput3.Text);
                copperHeart = Convert.ToInt16(textBoxInput4.Text);
                flowers = Convert.ToInt16(textBoxInput5.Text);
                rosePlum = Convert.ToInt16(textBoxInput6.Text);

                //overall price minus tax
                price = snowAngel * SNOW_ANGEL_COST + silverWings * SILVER_WINGS_COST + champagne * CHAMPAGNE_COST
                    + COPPER_HEART_COST * copperHeart + flowers * FLOWERS_COST + rosePlum * ROSE_PLUM_COST;

                //price times tax $3
                taxAmount = price * tax;

                total = price + taxAmount;


                //total
                outputLabel.Text = "Your Total comes to " + total.ToString("$0.00");
                taxAmountLabel.Text = "Tax Amount " + taxAmount.ToString("$0.00");
                priceLabel.Text = "Price without tax " + price.ToString("$0.00");
            }
            catch
            {
                outputLabel.Text = "ERROR";
            }


        }

        private void receiptButton_Click(object sender, EventArgs e)
        {
            //Define Graphics
            Graphics formGraphics = this.CreateGraphics();
            SolidBrush recieptBrush = new SolidBrush(Color.White);
            SolidBrush wordBrush = new SolidBrush(Color.Black);

            //Pen wordPen = new Pen(Color.Black);
            Font recieptFont = new Font("Courier New", 8);

            //Create white background for receipt
            formGraphics.FillRectangle(recieptBrush, 200, 0, 300, 300);

            //create strings that stat each product and price
            formGraphics.DrawString(" SnowAngel x" + snowAngel + " $" + SNOW_ANGEL_COST, recieptFont, wordBrush, 210, 60);
            formGraphics.DrawString( " SilverWings x" + silverWings + " $" + SILVER_WINGS_COST, recieptFont, wordBrush, 210, 80);
            formGraphics.DrawString(" Champagne x" + champagne + " $" + CHAMPAGNE_COST, recieptFont, wordBrush, 210, 100);
            formGraphics.DrawString(" copperHeart x" + copperHeart + " $" + COPPER_HEART_COST, recieptFont, wordBrush, 210, 120);
            formGraphics.DrawString(" flowers x" + flowers + " $" + FLOWERS_COST, recieptFont, wordBrush, 210, 140);
            formGraphics.DrawString(" rose plum x" + rosePlum + " $" +  ROSE_PLUM_COST, recieptFont, wordBrush, 210, 160);
            formGraphics.DrawString(" Total Cost $" + total, recieptFont, wordBrush, 210, 180);
            formGraphics.DrawString(" Amount given $" + tendered, recieptFont, wordBrush, 210, 200);
            formGraphics.DrawString(" Change $" + change, recieptFont, wordBrush, 210, 220);

        }

        private void tenderedButton_Click(object sender, EventArgs e)
        {
            try
            {
                tendered = Convert.ToDouble(tenderedBox.Text);
                change = tendered - total; ;
                changeLabel.Text = "Change: " + change.ToString("C");
            }
            catch
            {
                changeLabel.Text = "ERROR";
            }
        }

    }
}
