using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment04
{
    public partial class ProductInfoForm : Form
    {
        /// <summary>
        /// Program: Dollar Computers Assignment 3
        /// Name: Justin Schieck
        /// StudentID: 200328630
        /// App Creation Date: April 4th, 2017
        /// App Desc: Computer OrderForm 
        /// </summary>


        //public variables
        public SelectForm PreviousForm { get; set; }

        //private variables
        private StreamWriter _writer;
        private StreamReader _reader;
        private const char _DELIMETER = ',';


        public ProductInfoForm()
        {
            InitializeComponent();

        }


        /// <summary>
        /// fills textboxes as form loads
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _ProductInfoForm_Load(object sender, EventArgs e)
        {
            ProductIDTextbox.Text = Program.ChosenProduct.productID.ToString();
            ConditionTextbox.Text = Program.ChosenProduct.condition;
            CostTextbox.Text = Program.ChosenProduct.cost.ToString();
            PlatformTextBox.Text = Program.ChosenProduct.platform;
            ManufactuerTextbox.Text = Program.ChosenProduct.manufacturer;
            OSTextbox.Text = Program.ChosenProduct.OS;
            ModelTextBox.Text = Program.ChosenProduct.model;
            MemoryTextBox.Text = Program.ChosenProduct.RAM_size;
            LCDTextbox.Text = Program.ChosenProduct.screensize;
            HDDTextbox.Text = Program.ChosenProduct.HDD_size;
            CPUBrandTextbox.Text = Program.ChosenProduct.CPU_brand;
            CPUNumberTextbox.Text = Program.ChosenProduct.CPU_number;
            GPUTextbox.Text = Program.ChosenProduct.GPU_Type;
            CPUTypeTextbox.Text = Program.ChosenProduct.CPU_type;
            CPUSpeedTextbox.Text = Program.ChosenProduct.CPU_speed;
            WebcamTextbox.Text = Program.ChosenProduct.webcam;
        }


        private void _AnoutherProductButton_Click(object sender, EventArgs e)
        {
            this.PreviousForm.Show();
            this.Close();
        }

        private void _saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _SaveInfo();
        }

        private void _openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _ReadInfo();
        }

        //Method for reading
        private void _ReadInfo()
        {

            string fullProductString = "";
            try
            {
                _reader = new StreamReader("Product.txt");
                if (_reader.Peek() != -1)
                {
                    fullProductString = this._reader.ReadLine();

                    ProductIDTextbox.Text = fullProductString.Split(_DELIMETER)[0];
                    ConditionTextbox.Text = fullProductString.Split(_DELIMETER)[1];
                    CostTextbox.Text = fullProductString.Split(_DELIMETER)[2];
                    PlatformTextBox.Text = fullProductString.Split(_DELIMETER)[3];
                    ManufactuerTextbox.Text = fullProductString.Split(_DELIMETER)[4];
                    OSTextbox.Text = fullProductString.Split(_DELIMETER)[5];
                    ModelTextBox.Text = fullProductString.Split(_DELIMETER)[6];
                    MemoryTextBox.Text = fullProductString.Split(_DELIMETER)[7];
                    LCDTextbox.Text = fullProductString.Split(_DELIMETER)[8];
                    HDDTextbox.Text = fullProductString.Split(_DELIMETER)[9];
                    CPUBrandTextbox.Text = fullProductString.Split(_DELIMETER)[10];
                    CPUNumberTextbox.Text = fullProductString.Split(_DELIMETER)[11];
                    GPUTextbox.Text = fullProductString.Split(_DELIMETER)[12];
                    CPUTypeTextbox.Text = fullProductString.Split(_DELIMETER)[13];
                    CPUSpeedTextbox.Text = fullProductString.Split(_DELIMETER)[14];
                    WebcamTextbox.Text = fullProductString.Split(_DELIMETER)[15];

                }
                else
                {
                    MessageBox.Show("An Error Has Occured", "Error",
                         MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                this._reader.Close();
            }
            catch (Exception exception)
            {
                Debug.WriteLine(exception.Message);
                MessageBox.Show("Error Opening", "File Load Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this._reader.Close();
        }
        //Writing method
        private void _SaveInfo()
        {
            //makes sure user is ready to save
            DialogResult UserResult = MessageBox.Show("Are You Sure?", "Confirm", MessageBoxButtons.YesNo);
            if (UserResult == DialogResult.Yes)
            {
                // Open a writer and Write to the file
                _writer = new StreamWriter("Product.txt", true);
                _writer.WriteLine(ProductIDTextbox.Text + _DELIMETER +
                    ConditionTextbox.Text + _DELIMETER +
                    CostTextbox.Text + _DELIMETER +
                    PlatformTextBox.Text + _DELIMETER +
                    ManufactuerTextbox.Text + _DELIMETER +
                    OSTextbox.Text + _DELIMETER +
                    ModelTextBox + _DELIMETER +
                    MemoryTextBox.Text + _DELIMETER +
                    LCDTextbox.Text + _DELIMETER +
                    HDDTextbox.Text + _DELIMETER +
                    CPUBrandTextbox.Text + _DELIMETER +
                    CPUNumberTextbox.Text + _DELIMETER +
                    CPUSpeedTextbox.Text + _DELIMETER +
                    GPUTextbox.Text + _DELIMETER +
                    WebcamTextbox.Text);

                //Close the file
                _writer.Close();

                // Resets all boxes
                ProductIDTextbox.Clear();
                ConditionTextbox.Clear();
                CostTextbox.Clear();
                PlatformTextBox.Clear();
                ManufactuerTextbox.Clear();
                OSTextbox.Clear();
                ModelTextBox.Clear();
                MemoryTextBox.Clear();
                LCDTextbox.Clear();
                HDDTextbox.Clear();
                CPUBrandTextbox.Clear();
                CPUNumberTextbox.Clear();
                CPUTypeTextbox.Clear();
                GPUTextbox.Clear();
                CPUSpeedTextbox.Clear();
                WebcamTextbox.Clear();
            }

        }

        private void _StoreInfo()
        {
          //  Program.ChosenProduct.productID = Convert.ToInt16(ProductIDTextbox.Text);
            Program.ChosenProduct.condition = ConditionTextbox.Text;
          //  Program.ChosenProduct.cost = Convert.ToDecimal(CostTextbox.Text);
            Program.ChosenProduct.platform = PlatformTextBox.Text;
            Program.ChosenProduct.manufacturer = ManufactuerTextbox.Text;
            Program.ChosenProduct.OS = OSTextbox.Text;
            Program.ChosenProduct.model = ModelTextBox.Text;
            Program.ChosenProduct.RAM_size = MemoryTextBox.Text;
            Program.ChosenProduct.screensize = LCDTextbox.Text;
            Program.ChosenProduct.HDD_size = HDDTextbox.Text;
            Program.ChosenProduct.CPU_brand = CPUBrandTextbox.Text;
            Program.ChosenProduct.CPU_number = CPUNumberTextbox.Text;
            Program.ChosenProduct.GPU_Type = GPUTextbox.Text;
            Program.ChosenProduct.CPU_type = CPUTypeTextbox.Text;
            Program.ChosenProduct.CPU_speed = CPUSpeedTextbox.Text;
            Program.ChosenProduct.webcam = WebcamTextbox.Text;
        }

        private void _CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void _NextButton_Click(object sender, EventArgs e)
        {

            _StoreInfo();
            OrderForm orderform = new OrderForm();
            orderform.Show();
            this.Hide();
        }
    }
}
