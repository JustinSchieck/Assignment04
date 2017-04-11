using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment04
{
    public partial class StartForm : Form
    {

        /// <summary>
        /// Program: Dollar Computers Assignment 3
        /// Name: Justin Schieck
        /// StudentID: 200328630
        /// App Creation Date: April 4th, 2017
        /// App Desc: Computer OrderForm 
        /// </summary>


        public StartForm()
        {
            InitializeComponent();
        }

        //button to start a new order
        private void _NewOrderButton_Click(object sender, EventArgs e)
        {
            SelectForm selectForm = new SelectForm();
            selectForm.PreviousForm = this;
            selectForm.Show();
            this.Hide();
        }
        //button for exit
        private void _CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //button for opening a saved order in Product.txt
        private void _SavedOrderButton_Click(object sender, EventArgs e)
        {
            ProductInfoForm productForm = new ProductInfoForm();
            productForm.Show();
            this.Hide();
        }
    }
}
