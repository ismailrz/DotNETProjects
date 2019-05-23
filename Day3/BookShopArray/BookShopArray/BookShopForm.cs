using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShopArray
{
    public partial class BookShopForm : Form
    {
        const int size = 10;
        int count = 0;

        public BookShopForm()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            
            string[] customerName = new string[size];
            int[] contactNumber = new int[size];
            string[] address = new string[size];
            string[] order = new string[size];
            int[] quantity = new int[size];
            int[] totalPrice = new int[size];


            customerName[count] = nameTextBox.Text;
            contactNumber[count] = Convert.ToInt32(contactTextBox.Text);
            address[count] = addressTextBox.Text;
            order[count] = orderComboBox.Text;
            quantity[count] = Convert.ToInt32(quantityTextBox.Text);

            count++;

            string message = "";
            for(int index=0;index<count;index++)
            {
                message += "Customer No: " + (index+1) + "\n";
                message += "Name: " + customerName[index] + "\n";
                message += "Contact Number: " + contactNumber[index] + "\n";
                message += "Address: " + address[index] + "\n";
                message += "Order: " + order[index] + "\n";
                message += "Quantity: " + quantity[index] + "\n";
                message += "Total Price: " + totalPrice[index] + "\n";
                
            }

            showRichTextBox.Text = message;






        }
    }
}
