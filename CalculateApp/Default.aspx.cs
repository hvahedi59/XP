using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CalculateApp
{
    public partial class _Default : Page
    {
        CalculateService myService = new CalculateApp.CalculateService();

        protected void Page_Load(object sender, EventArgs e)
        {
            CalculateService serv = new CalculateApp.CalculateService();
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            txtOperation.Text = string.Empty;
        }

        protected void btnPlus_Click(object sender, EventArgs e)
        {
            txtOperation.Text += "+";
        }

        protected void btnSubstract_Click(object sender, EventArgs e)
        {
            txtOperation.Text += "-";
        }

        protected void btnMultiple_Click(object sender, EventArgs e)
        {
            txtOperation.Text += "*";
        }

        protected void btnDivision_Click(object sender, EventArgs e)
        {
            txtOperation.Text += "/";
        }

        protected void btnCalculate_Click(object sender, EventArgs e)
        {
            txtOperation.Text = myService.Calculate(txtOperation.Text).ToString();
        }

        protected void btn1_Click(object sender, EventArgs e)
        {
            txtOperation.Text += "1";
        }

        protected void btn2_Click(object sender, EventArgs e)
        {
            txtOperation.Text += "2";

        }

        protected void btn3_Click(object sender, EventArgs e)
        {
            txtOperation.Text += "3";

        }

        protected void btn4_Click(object sender, EventArgs e)
        {
            txtOperation.Text += "4";

        }

        protected void btn5_Click(object sender, EventArgs e)
        {
            txtOperation.Text += "5";

        }

        protected void btn6_Click(object sender, EventArgs e)
        {
            txtOperation.Text += "6";

        }

        protected void btn7_Click(object sender, EventArgs e)
        {
            txtOperation.Text += "7";

        }

        protected void btn8_Click(object sender, EventArgs e)
        {
            txtOperation.Text += "8";

        }

        protected void btn9_Click(object sender, EventArgs e)
        {
            txtOperation.Text += "9";

        }

        protected void btn0_Click(object sender, EventArgs e)
        {
            txtOperation.Text += "0";

        }

        protected void btnSaveMemory_Click(object sender, EventArgs e)
        {
            var result = txtOperation.Text.Trim();
            myService.SaveMemory(result);
        }
    }
}