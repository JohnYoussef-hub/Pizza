using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        void UpdateToppingsSummary()
        {
            List<String> SelectedToppings = new List<string>();

            if (chbxExtraCheese.Checked) SelectedToppings.Add("Extra Cheese");
            if (chbxOnion.Checked) SelectedToppings.Add("Onion");
            if (chbxMushrooms.Checked) SelectedToppings.Add("Mushrooms");
            if (chbxOlives.Checked) SelectedToppings.Add("Olives");
            if (chbxTomatoes.Checked) SelectedToppings.Add("Tomatoes");
            if (chbxGreenPeppers.Checked) SelectedToppings.Add("Green Peppers");


            String ToppingsSummary = string.Join(", ", SelectedToppings.Take(3));

            if (SelectedToppings.Count > 3)
            {
                ToppingsSummary = string.Join(", ", SelectedToppings.Take(3))
                    + Environment.NewLine + string.Join(", ", SelectedToppings.Skip(3));
            }

            lblToppings.Text = ToppingsSummary;
        }

        void ResetForm()
        {
            gbSize.Enabled = true;
            gbCrustType.Enabled = true;
            gbToppings.Enabled = true;
            gbWhere.Enabled = true;

            rdbMedium.Checked = true;

            rdbThick.Checked = false;
            rdbThin.Checked = false;

            rdbTakeOut.Checked = false;
            rdbEatIn.Checked = false;

            chbxExtraCheese.Checked = false;
            chbxGreenPeppers.Checked = false;
            chbxMushrooms.Checked = false;
            chbxOlives.Checked = false;
            chbxOnion.Checked = false;
            chbxTomatoes.Checked = false;

            lblToppings.Text = "no toppings";
            lblWhere.Text = "";
            lblCrustType.Text = "";
        }

        short UpdateSizePrice()
        {
            short price = 0;

            if (rdbSmall.Checked) 
                return price = (short)Convert.ToSingle(rdbSmall.Tag);

            if (rdbMedium.Checked)
                return price = (short)Convert.ToSingle(rdbMedium.Tag);

            if (rdbLarge.Checked)
                return price = (short)Convert.ToSingle(rdbLarge.Tag);

            return price;
        }

        short UpdateCrustTypePrice()
        {
            short price = 0;

            if(rdbThick.Checked)
                return( price = (short)Convert.ToSingle(rdbThick.Tag));

            if (rdbThin.Checked)
                return (price = (short)Convert.ToSingle(rdbThin.Tag));

            return price;
        }

        short UpdateToppingsPrice()
        {
            short price = 0;

            if (chbxExtraCheese.Checked)
                price += (short)Convert.ToSingle(chbxExtraCheese.Tag);

            if (chbxOnion.Checked)
                price += (short)Convert.ToSingle(chbxOnion.Tag);

            if (chbxMushrooms.Checked)
                price += (short)Convert.ToSingle(chbxMushrooms.Tag);

            if (chbxOlives.Checked)
                price += (short)Convert.ToSingle(chbxOlives.Tag);

            if (chbxTomatoes.Checked)
                price += (short)Convert.ToSingle(chbxTomatoes.Tag);

            if (chbxGreenPeppers.Checked)
                price += (short)Convert.ToSingle(chbxGreenPeppers.Tag);

            return price;
        }


        short CalculateTotalPrice()
        {
            return (short)(UpdateSizePrice() + UpdateCrustTypePrice() + UpdateToppingsPrice());
        }

        void UpdateTotalPrice()
        {
            lblTotalPrice.Text = "$ " + CalculateTotalPrice().ToString();
        }


        private void rdbSmall_CheckedChanged(object sender, EventArgs e)
        {

            lblSize.Text = "Small";
            UpdateTotalPrice();
        }

        private void rdbMedium_CheckedChanged(object sender, EventArgs e)
        {
            
            lblSize.Text = "Medium";
            UpdateTotalPrice();
        }

        private void rdbLarge_CheckedChanged(object sender, EventArgs e)
        {

            lblSize.Text = "Large";
            UpdateTotalPrice();
        }

        private void rdbThin_CheckedChanged(object sender, EventArgs e)
        {

            lblCrustType.Text = rdbThin.Text;
            UpdateTotalPrice();
        }

        private void rdbThick_CheckedChanged(object sender, EventArgs e)
        {

            lblCrustType.Text = rdbThick.Text;
            UpdateTotalPrice();
        }

        private void chbxExtraCheese_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
            UpdateToppingsSummary();
        }

        private void chbxOnion_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
            UpdateToppingsSummary();
        }

        private void chbxMushrooms_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
            UpdateToppingsSummary();
        }

        private void chbxOlives_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
            UpdateToppingsSummary();
        }

        private void chbxTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
            UpdateToppingsSummary();
        }

        private void chbxGreenPeppers_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
            UpdateToppingsSummary();
        }

        private void rdbEatIn_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbEatIn.Checked)
                lblWhere.Text = rdbEatIn.Text;
        }

        private void rdbTakeOut_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbTakeOut.Checked)
                lblWhere.Text = rdbTakeOut.Text;
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("Are you sure to place this order?", "Confirm", 
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question, 
                MessageBoxDefaultButton.Button2);

            if (Result == DialogResult.OK)
            {
                if (lblSize.Text == "" || lblCrustType.Text == "" || lblWhere.Text == "")
                {
                    MessageBox.Show("You should to choose something from these (*) Catigories!"
                        , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                gbSize.Enabled = false;
                gbCrustType.Enabled = false;
                gbToppings.Enabled = false;
                gbWhere.Enabled = false;

                MessageBox.Show("Order Placed Successfully! ENJOY :)"
                    ,"Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnResetForm_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("Reset this form?", "Reset Form"
                , MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (Result == DialogResult.OK)
            {
                ResetForm();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            rdbMedium.Checked = true;
            //rdbThin.Checked = true;
            //rdbEatIn.Checked = true;
            UpdateTotalPrice();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
