using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chirag_Nayak_Ex_01
{
    public partial class Products : Form
    {
        string Message = "";
        string Message2 = "";
        string Message3 = "";
        public Products()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Message3 += listOfProductsComboBox.SelectedItem.ToString();
            listrichTextBox.Text = Message3;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text == string.Empty)
            {
                MessageBox.Show("Name Can not be Empty", "Errors", MessageBoxButtons.OK);
            }
            else if(addressTextBox.Text == string.Empty)
            {
                MessageBox.Show("Address Can not be Empty", "Errors", MessageBoxButtons.OK);
            }
            else if (emailTextBox.Text == string.Empty)
            {
                MessageBox.Show("Email Can not be Empty", "Errors", MessageBoxButtons.OK);
            }
            else if (phoneTextBox.Text == string.Empty)
            {
                MessageBox.Show("Phone Number Can not be Empty", "Errors", MessageBoxButtons.OK);
            }
            else if (listrichTextBox.Text == string.Empty)
            {
                MessageBox.Show("List of Products Can not be empty", "Errors", MessageBoxButtons.OK);
            }

            if (elecradioButton.Checked)
            {
                Message += elecradioButton.Text;
            }
            else if (compradioButton.Checked)
            {
                Message += compradioButton.Text;
            } 
            if (pickupradioButton.Checked)
            {
                Message2 += pickupradioButton.Text; 
            }
            else if (deliveryradioButton.Checked)
            {
                Message2 += deliveryradioButton.Text;
            }
            
            summarylistBox.Items.Add(nameTextBox.Text +"   "+ emailTextBox.Text +"   "+Message + "  -  " + Message2 +"  -  "+Message3);  


            nameTextBox.Clear();
            addressTextBox.Clear();
            emailTextBox.Clear();
            phoneTextBox.Clear();
            compradioButton.Checked = false;
            elecradioButton.Checked = false;
            pickupradioButton.Checked=false;
            deliveryradioButton.Checked=false;
        }

        private void clearProductsButton_Click(object sender, EventArgs e)
        {
            compradioButton.Checked = false;
            elecradioButton.Checked = false;
            pickupradioButton.Checked = false;
            deliveryradioButton.Checked = false;
            listrichTextBox.Clear();
            listOfProductsComboBox.Items.Clear();   
        }

        private void elecradioButton_CheckedChanged(object sender, EventArgs e)
        {
            if(elecradioButton.Checked == true)
            {
                listOfProductsComboBox.Items.Clear();
                listOfProductsComboBox.Items.Add("TVs");
                listOfProductsComboBox.Items.Add("Video Games");
                listOfProductsComboBox.Items.Add("Digital Cameras");
                listOfProductsComboBox.Items.Add("Home Audio");
            }
            if (compradioButton.Checked == true)
            {
                listOfProductsComboBox.Items.Clear();
                listOfProductsComboBox.Items.Add("Desktops");
                listOfProductsComboBox.Items.Add("Laptops");
                listOfProductsComboBox.Items.Add("Monitors");
                listOfProductsComboBox.Items.Add("Printers");
            }
        }

       
    }
}
