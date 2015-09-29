using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeFirstPapaBobsWebsite
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void purchaseButton_Click(object sender, EventArgs e)
        {
            //INITALIZE resultLabel.Text AND total VARIABLES
            resultLabel.Text = " ";
            double total = 0;

            //SELECT PIZZA SIZE BASED ON SELECTED RADIO BUTTON
            if (smallRadioButton.Checked)
                total += 10;
            else if (mediumRadioButton.Checked)
                total += 13;
            else if (largeRadioButton.Checked)
                total += 16;

            //IF DEEP DISH IS SELECTED, ADD $2 TO TOTAL
            if (deepDishRadioButton.Checked)
                total += 2;

            //ADD TOPPING PRICE TO TOTAL BASED ON SELECTED TOPPINGS
            total = (pepperoniCheckBox.Checked) ? total += 1.5 : total;
            total = (onionsCheckBox.Checked) ? total += 0.75 : total;
            total = (greenPepperCheckBox.Checked) ? total += 0.5 : total;
            total = (redPepperCheckBox.Checked) ? total += 0.75 : total;
            total = (anchoviesCheckBox.Checked) ? total += 2 : total;

            //SAVE $2 IF PEP/GP/ANCH OR PEP/RP/ONIONS SELECTED
            if ((pepperoniCheckBox.Checked && greenPepperCheckBox.Checked && anchoviesCheckBox.Checked)
                || (pepperoniCheckBox.Checked && redPepperCheckBox.Checked && onionsCheckBox.Checked))
                total -= 2;

            //PRINT TOTAL TO STRING TO DISPLAY
            resultLabel.Text = "Total: $" + total.ToString();

        }
    }
}