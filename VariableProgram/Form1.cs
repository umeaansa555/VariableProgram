using System;
using System.Windows.Forms;

namespace VariableProgram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void hockeyButton_Click(object sender, EventArgs e)
        {
            string playerName = "Wayne Gretzky";
            int playerNumber = 99;
            textDisplayLabel.Text = $"{playerName} is number {playerNumber}.";
        }

        private void areaButton_Click(object sender, EventArgs e)
        {
            double radius = 15;
            double pi = 3.14;
            double area = pi * radius * radius;
            textDisplayLabel.Text = $"The area of circle with a radius of 15cm is {area}cm^2.";
        }

        private void carpetButton_Click(object sender, EventArgs e)
        {
            double length = 8.5;
            double width = 6;
            double costPerMeter = 19.95;
            double area = length * width;
            double totalCost = area * costPerMeter;
            textDisplayLabel.Text = $"The area of a room with dimensions 8.5m x 6m is {area}m^2.";
            textDisplayLabel.Text += $"\n\nThe cost to carpet this area at 19.95 per square metre is {totalCost}.";
        }

        private void receiptButton_Click(object sender, EventArgs e)
        {
            double shirtPrice = 12.49;
            double tax = 0.13 * shirtPrice;
            double totalPrice = shirtPrice + tax;
            double cashPaid = 20.00;
            double change = cashPaid - totalPrice;
            textDisplayLabel.Text = $"Bill of Sale" +
                $"\n\nShirt:  {shirtPrice}" +
                $"\nTax:    {tax}" +
                $"\nTotal:    {totalPrice}";
            textDisplayLabel.Text += $"\n\nTendered: {cashPaid}" +
                $"\nChange: {change}";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
