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
    public partial class OrderForm : Form
    {

        /// <summary>
        /// Program: Dollar Computers Assignment 3
        /// Name: Justin Schieck
        /// StudentID: 200328630
        /// App Creation Date: April 4th, 2017
        /// App Desc: Computer OrderForm 
        /// </summary>


        public ProductInfoForm PreviousForm { get; set; }

        public OrderForm()
        {
            InitializeComponent();


        }
        /// <summary>
        /// fills textboxs in form on loading the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _OrderForm_Load(object sender, EventArgs e)
        {
            ConditionTextbox.Text = Program.ChosenProduct.condition;
            PlatformTextbox.Text = Program.ChosenProduct.platform;
            ManufacturerTextbox.Text = Program.ChosenProduct.manufacturer;
            ModelTextbox.Text = Program.ChosenProduct.model;

            LCDTextbox.Text = Program.ChosenProduct.screensize;
            MemoryTextbox.Text = Program.ChosenProduct.RAM_size;
            CPUBrandTextbox.Text = Program.ChosenProduct.CPU_brand;
            CPUTypeTextbox.Text = Program.ChosenProduct.CPU_type;
            CPUNumberTextbox.Text = Program.ChosenProduct.CPU_number;
            CPUSpeedTextbox.Text = Program.ChosenProduct.CPU_speed;
            HDDTextbox.Text = Program.ChosenProduct.HDD_size;
            GPUTypeTextbox.Text = Program.ChosenProduct.GPU_Type;
            WebcamTextbox.Text = Program.ChosenProduct.webcam;
            OSTextbox.Text = Program.ChosenProduct.OS;

            PriceTextbox.Text = Program.ChosenProduct.cost.ToString();
            double Subtotal = Convert.ToDouble(Program.ChosenProduct.cost);
            double Tax = Subtotal * 0.13;
            SalesTaxTextbox.Text = Tax.ToString();
            TotalTextbox.Text = (Subtotal * 1.13).ToString();
        }

        //exits form
        private void _CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //closes form and says days till shipment
        private void _FinishButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you!" + "\n" + "\n" + "Your Items will be shipped in 7 to 10 days");
            Application.Exit();
        }

        //backbutton to go back to productinfo form
        private void _BackButton_Click(object sender, EventArgs e)
        {
            this.PreviousForm.Show();
            this.Close();
        }

        //about menu item
        private void _aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aboutbox = new AboutBox();
            aboutbox.ShowDialog();
        }

        //simulates a print message
        private void _printToolStripMenuItem_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Your item " + Program.ChosenProduct.manufacturer + Program.ChosenProduct.model + "is now being printed" + "\n" + "Please wait");
        }

        private void OrderForm_Activated(object sender, EventArgs e)
        {
            ConditionTextbox.Text = Program.ChosenProduct.condition;
            PlatformTextbox.Text = Program.ChosenProduct.platform;
            ManufacturerTextbox.Text = Program.ChosenProduct.manufacturer;
            ModelTextbox.Text = Program.ChosenProduct.model;

            LCDTextbox.Text = Program.ChosenProduct.screensize;
            MemoryTextbox.Text = Program.ChosenProduct.RAM_size;
            CPUBrandTextbox.Text = Program.ChosenProduct.CPU_brand;
            CPUTypeTextbox.Text = Program.ChosenProduct.CPU_type;
            CPUNumberTextbox.Text = Program.ChosenProduct.CPU_number;
            CPUSpeedTextbox.Text = Program.ChosenProduct.CPU_speed;
            HDDTextbox.Text = Program.ChosenProduct.HDD_size;
            GPUTypeTextbox.Text = Program.ChosenProduct.GPU_Type;
            WebcamTextbox.Text = Program.ChosenProduct.webcam;
            OSTextbox.Text = Program.ChosenProduct.OS;

            PriceTextbox.Text = Program.ChosenProduct.cost.ToString();
            double Subtotal = Convert.ToDouble(Program.ChosenProduct.cost);
            double Tax = Subtotal * 0.13;
            SalesTaxTextbox.Text = Tax.ToString();
            TotalTextbox.Text = (Subtotal * 1.13).ToString();
        }
    }
}
