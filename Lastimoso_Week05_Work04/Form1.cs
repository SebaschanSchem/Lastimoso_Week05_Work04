using System;
using System.Globalization;
using System.Windows.Forms;

namespace Lastimoso_Week05_Work04
{
    public partial class Form1 : Form                                                                                                                                   
    {
        public Form1()
        {
            InitializeComponent();

            lblCategory.Items.AddRange(new object[]
            {
                "Food",
                "Beverage",
                "Clothing",
                "Electronics",
                "Household",
                "Other"
            });

            lblCategory.SelectedIndex = -1;
            lblLocal.Checked = true;
            lblActive.Checked = true;
        }

        private void lblCode_TextChanged(object sender, EventArgs e)
        {
            lblCode.Text = lblCode.Text.TrimStart();
        }

        private void lblProductName_TextChanged(object sender, EventArgs e)
        {
            lblProductName.Text = lblProductName.Text.TrimStart();
        }

        private void lblDescription_TextChanged(object sender, EventArgs e)
        {
            lblDescription.Text = lblDescription.Text.TrimStart();
        }

        private void lblCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lblCategory.SelectedIndex >= 0)
            {
                Text = "Product - " + lblCategory.SelectedItem;
            }
        }

        private void lblLocal_CheckedChanged(object sender, EventArgs e)
        {
            if (lblLocal.Checked)
            {
                lblAbroad.Checked = false;
            }
        }

        private void lblAbroad_CheckedChanged(object sender, EventArgs e)
        {
            if (lblAbroad.Checked)
            {
                lblLocal.Checked = false;
            }
        }

        private void lblActive_CheckedChanged(object sender, EventArgs e)
        {
            lblActive.Text = lblActive.Checked ? "Active" : "Inactive";
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            CalculateMarkup();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            CalculateMarkup();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to close the form?",
                "Cancel",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Close();
            }
        }

        private void lblClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void lblSave_Click(object sender, EventArgs e)
        {
            if (!ValidateProduct())
            {
                return;
            }

            string origin = lblLocal.Checked ? "Local" : "Abroad";
            string status = lblActive.Checked ? "Active" : "Inactive";

            MessageBox.Show(
                "Product saved successfully.\r\n\r\n"
                + "Barcode: " + lblCode.Text + "\r\n"
                + "Name: " + lblProductName.Text + "\r\n"
                + "Category: " + lblCategory.SelectedItem + "\r\n"
                + "Origin: " + origin + "\r\n"
                + "Status: " + status + "\r\n"
                + "Cost: " + lblCost.Text + "\r\n"
                + "Price: " + textBox6.Text + "\r\n"
                + "Markup: " + textBox7.Text + "%",
                "Save",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private bool ValidateProduct()
        {
            if (string.IsNullOrWhiteSpace(lblCode.Text))
            {
                ShowValidationError("Barcode is required.", lblCode);
                return false;
            }

            if (string.IsNullOrWhiteSpace(lblProductName.Text))
            {
                ShowValidationError("Product name is required.", lblProductName);
                return false;
            }

            if (string.IsNullOrWhiteSpace(lblDescription.Text))
            {
                ShowValidationError("Description is required.", lblDescription);
                return false;
            }

            if (lblCategory.SelectedIndex < 0)
            {
                MessageBox.Show(
                    "Please select a category.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                lblCategory.Focus();
                return false;
            }

            if (!lblLocal.Checked && !lblAbroad.Checked)
            {
                MessageBox.Show(
                    "Please select the product origin.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                groupBox1.Focus();
                return false;
            }

            decimal cost;
            if (!TryReadDecimal(lblCost.Text, out cost) || cost < 0)
            {
                ShowValidationError("Cost must be a valid positive number.", lblCost);
                return false;
            }

            decimal price;
            if (!TryReadDecimal(textBox6.Text, out price) || price < 0)
            {
                ShowValidationError("Price must be a valid positive number.", textBox6);
                return false;
            }

            if (price < cost)
            {
                MessageBox.Show(
                    "Price cannot be lower than cost.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                textBox6.Focus();
                return false;
            }

            return true;
        }

        private void CalculateMarkup()
        {
            decimal cost;
            decimal price;

            if (!TryReadDecimal(lblCost.Text, out cost)
                || !TryReadDecimal(textBox6.Text, out price)
                || cost <= 0)
            {
                textBox7.Clear();
                return;
            }

            decimal markup = ((price - cost) / cost) * 100;
            textBox7.Text = markup.ToString("0.00", CultureInfo.CurrentCulture);
        }

        private bool TryReadDecimal(string value, out decimal number)
        {
            return decimal.TryParse(
                value,
                NumberStyles.Number,
                CultureInfo.CurrentCulture,
                out number);
        }

        private void ShowValidationError(string message, Control control)
        {
            MessageBox.Show(
                message,
                "Validation",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);

            control.Focus();
        }

        private void ClearForm()
        {
            lblCode.Clear();
            lblProductName.Clear();
            lblDescription.Clear();
            lblCategory.SelectedIndex = -1;

            lblLocal.Checked = true;
            lblAbroad.Checked = false;
            lblActive.Checked = true;

            lblCost.Clear();
            textBox6.Clear();
            textBox7.Clear();

            Text = "Product";
            lblCode.Focus();
        }

    }
}
