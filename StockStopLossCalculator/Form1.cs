using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockStopLossCalculator
{
    public partial class Form1 : Form
    {
        double startingPrice, buyIncrements, stopLoss;

        public Form1()
        {
            InitializeComponent();
        }

        void Calculate()
        {
            buyPoint1TB.Text = ((startingPrice * (buyIncrements / 100)) + startingPrice).ToString("N2");
            buyPoint2TB.Text = ((Convert.ToDouble(buyPoint1TB.Text) * (buyIncrements / 100) + Convert.ToDouble(buyPoint1TB.Text))).ToString("N2");
            buyPoint3TB.Text = ((Convert.ToDouble(buyPoint2TB.Text) * (buyIncrements / 100) + Convert.ToDouble(buyPoint2TB.Text))).ToString("N2");
            buyPoint4TB.Text = ((Convert.ToDouble(buyPoint3TB.Text) * (buyIncrements / 100) + Convert.ToDouble(buyPoint3TB.Text))).ToString("N2");
            buyPoint5TB.Text = ((Convert.ToDouble(buyPoint4TB.Text) * (buyIncrements / 100) + Convert.ToDouble(buyPoint4TB.Text))).ToString("N2");

            stopLoss1TB.Text = ((1 - ((Convert.ToDouble(stopLossTB.Text) / 100))) * Convert.ToDouble(startPriceTB.Text)).ToString("N2");
            stopLoss2TB.Text = ((1 - ((Convert.ToDouble(stopLossTB.Text) / 100))) * Convert.ToDouble(buyPoint1TB.Text)).ToString("N2");
            stopLoss3TB.Text = ((1 - ((Convert.ToDouble(stopLossTB.Text) / 100))) * Convert.ToDouble(buyPoint2TB.Text)).ToString("N2");
            stopLoss4TB.Text = ((1 - ((Convert.ToDouble(stopLossTB.Text) / 100))) * Convert.ToDouble(buyPoint3TB.Text)).ToString("N2");
            stopLoss5TB.Text = ((1 - ((Convert.ToDouble(stopLossTB.Text) / 100))) * Convert.ToDouble(buyPoint4TB.Text)).ToString("N2");
        }
        double Calculate_Two(Double Y1, Double Y2)
        {
            return (((Y2 - Y1) / Y1) * 100);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                startingPrice = double.Parse(startPriceTB.Text);
            }
            catch
            {
                MessageBox.Show("Please enter a valid input in the Stock Start Price text box.", "Error");
                return; // stop further message boxes from popping up after the first error
            }
            try
            {
                buyIncrements = double.Parse(buyIncrementTB.Text);
            }
            catch
            {
                MessageBox.Show("Please enter a valid input in the Buy Increments (%) text box.", "Error");
                return; // stop further message boxes from popping up after the second error
            }
            try
            {
                stopLoss = double.Parse(stopLossTB.Text);
            }
            catch
            {
                MessageBox.Show("Please enter a valid input in the Stop Loss (%) text box.", "Error");
                return; // stop the software from prematurely using the calculate function
            }

            Calculate();
        }

        private void stopLossTB_KeyDown(object sender, KeyEventArgs e) //allows enter key to also be used for calculation while cursor is in final text box
        {
            if (e.KeyData == Keys.Enter)
            {
                button1.PerformClick();
            }
        }

        private void buyIncrementTB_KeyDown(object sender, KeyEventArgs e) //allows enter key to also be used for calculation while cursor is in middle text box
        {
            if (e.KeyData == Keys.Enter)
            {
                button1.PerformClick();
            }
        }

        private void startPriceTB_KeyDown(object sender, KeyEventArgs e) //allows enter key to also be used for calculation while cursor is in first text box
        {
            if (e.KeyData == Keys.Enter)
            {
                button1.PerformClick();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                ChangeResultTB.Text = Calculate_Two(Convert.ToDouble(Y1TB.Text), Convert.ToDouble(Y2TB.Text)).ToString("N2") + "%";
                button3.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Please enter a valid input in the Start Value and End Value text boxes.", "Error");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                gainLossTB.Text = ChangeResultTB.Text.TrimEnd('%');
                gainLossTB.Text = "$" + ((Convert.ToDouble(gainLossTB.Text) / 100) * Convert.ToDouble(priorCashValueTB.Text)).ToString("N2");
            }
            catch
            {
                gainLossTB.Text = "$";
                MessageBox.Show("Please enter a valid input in the Prior Cash Value text box.", "Error");
            }
        }

        private void Y1TB_KeyDown(object sender, KeyEventArgs e) //allows enter key to also be used for calculation while cursor is in "Start Value" text box
        {
            if (e.KeyData == Keys.Enter)
            {
                button2.PerformClick();
            }
        }

        private void Y2TB_KeyDown(object sender, KeyEventArgs e) //allows enter key to also be used for calculation while cursor is in "End Value" text box
        {
            if (e.KeyData == Keys.Enter)
            {
                button2.PerformClick();
            }
        }

        private void priorCashValueTB_KeyDown(object sender, KeyEventArgs e) //allows enter key to also be used for calculation while cursor is in "Prior Cash Value" text box
        {
            if (e.KeyData == Keys.Enter)
            {
                button3.PerformClick();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
