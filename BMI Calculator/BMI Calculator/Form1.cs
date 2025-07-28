using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI_Calculator
{
    public partial class BMIcalculator : Form
    {
        public BMIcalculator()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double h, w, BMI;
            h = Convert.ToDouble(txtHeight.Text);
            w = Convert.ToDouble(txtWeight.Text);
            BMI = w / (h * h);

            txtBMI.Text = BMI.ToString();


             if (BMI <= 18.5)
             {

                 txtIndicator.BackColor = Color.Red;
                 txtStatus.Text = "Under Weight";
             }

             else if (BMI <= 25)
             {

                 txtIndicator.BackColor = Color.Blue;
                 txtStatus.Text = "Normal";
             }

             else if (BMI <= 30)
             {

                 txtIndicator.BackColor = Color.Orange;
                 txtStatus.Text = "Obesity Class 1";
             }

             else if (BMI <= 40)
             {

                 txtIndicator.BackColor = Color.Pink;
                 txtStatus.Text = "Obesity Class 2";
             }

             else
             {

                 txtIndicator.BackColor = Color.Brown;
                 txtStatus.Text = "Obesity Class 3";
             }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtHeight.Clear();
            txtWeight.Clear();
            txtBMI.Clear();
            txtStatus.Clear();
            txtIndicator.BackColor = Color.White;

        }

    
    }
}
