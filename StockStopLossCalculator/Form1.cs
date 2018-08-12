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
        double startingPrice;
        double buyIncrements;
        double stopLoss;

        public Form1()
        {
            InitializeComponent();            
        }

        void Calculate()
        {           
            buyPoint1TB.Text = ((startingPrice * (buyIncrements/100)) + startingPrice).ToString("N2");
            buyPoint2TB.Text = ((Convert.ToDouble(buyPoint1TB.Text) * (buyIncrements / 100) + Convert.ToDouble(buyPoint1TB.Text))).ToString("N2");
            buyPoint3TB.Text = ((Convert.ToDouble(buyPoint2TB.Text) * (buyIncrements / 100) + Convert.ToDouble(buyPoint2TB.Text))).ToString("N2");
            buyPoint4TB.Text = ((Convert.ToDouble(buyPoint3TB.Text) * (buyIncrements / 100) + Convert.ToDouble(buyPoint3TB.Text))).ToString("N2");
            buyPoint5TB.Text = ((Convert.ToDouble(buyPoint4TB.Text) * (buyIncrements / 100) + Convert.ToDouble(buyPoint4TB.Text))).ToString("N2");
           
            stopLoss1TB.Text = ((Convert.ToDouble(buyPoint1TB.Text)) - ((Convert.ToDouble(buyPoint1TB.Text) * (stopLoss / 100)))).ToString("N2");
            stopLoss2TB.Text = ((Convert.ToDouble(buyPoint2TB.Text)) - ((Convert.ToDouble(buyPoint2TB.Text) * (stopLoss / 100)))).ToString("N2");
            stopLoss3TB.Text = ((Convert.ToDouble(buyPoint3TB.Text)) - ((Convert.ToDouble(buyPoint3TB.Text) * (stopLoss / 100)))).ToString("N2");
            stopLoss4TB.Text = ((Convert.ToDouble(buyPoint4TB.Text)) - ((Convert.ToDouble(buyPoint4TB.Text) * (stopLoss / 100)))).ToString("N2");
            stopLoss5TB.Text = ((Convert.ToDouble(buyPoint5TB.Text)) - ((Convert.ToDouble(buyPoint5TB.Text) * (stopLoss / 100)))).ToString("N2");
        }

        private void button1_Click(object sender, EventArgs e)
        {          
            double.TryParse(startPriceTB.Text, out startingPrice);
            double.TryParse(buyIncrementTB.Text, out buyIncrements);          
            double.TryParse(stopLossTB.Text, out stopLoss);
            Calculate();            
        }

        private void stopLossTB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                button1.PerformClick();
            }
        }
    }
}
