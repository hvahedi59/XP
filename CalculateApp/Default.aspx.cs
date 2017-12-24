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
            txtOperation.Text= myService.Calculate(txtOperation.Text).ToString();
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
    }
}