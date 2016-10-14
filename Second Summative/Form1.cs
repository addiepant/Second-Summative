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
    //Second Summative- Makeup Pallette
    //October 14, 2016
    public partial class Form1 : Form
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
        double total;
        int snowAngel = 0;
        int silverWings = 0;
        int champagne = 0;
        int copperHeart = 0;
        int flowers = 0;
        int rosePlum = 0;
        int tax = 3;

        public Form1()
        {
            InitializeComponent();
        }

        private void checkoutLabel_Click(object sender, EventArgs e)
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
            total = price * tax;

            //Define Graphics
            Graphics formGraphics = this.CreateGraphics();
            SolidBrush recieptBrush = new SolidBrush(Color.White);
            Pen wordPen = new Pen(Color.Black);
            Font recieptFont = new Font("Courier New", 8);

            //Create white background for receipt
            formGraphics.FillRectangle(recieptBrush, 200, 0, 300, 300);

            //create strings that stat each product and price
            formGraphics.DrawString("Order:/n " + snowAngel + SNOW_ANGEL_COST,wordPen, 10, 10);
            formGraphics.DrawString("Order:/n " + silverWing + SILVER_WINGS_COST);
            formGraphics.DrawString("Order:/n " + champagne + CHAMPAGNE_COST);
            formGraphics.DrawString("Order:/n " + copperHeart + COPPER_HEART_COST);
            formGraphics.DrawString("Order:/n " + flowers + FLOWERS_COST);

            //total
            outputLabel.Text = "Your Total comes to " + total.ToString("$0.00");
            



        }
    }
}
