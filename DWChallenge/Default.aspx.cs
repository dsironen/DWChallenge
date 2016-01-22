using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DWChallenge
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            int firstValue = int.Parse(firstTextBox.Text);
            int secondValue = int.Parse(secondTextBox.Text);

            int totalValue = 0;

            while (totalValue < 100)
            {
                totalValue += firstValue + secondValue;
                resultLabel.Text += "<br />" + totalValue.ToString();
            }

            resultLabel.Text += "<br />" + String.Format("Final Result {0}", totalValue.ToString());
        }
    }
}