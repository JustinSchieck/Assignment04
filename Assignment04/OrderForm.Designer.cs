namespace Assignment04
{
    partial class OrderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.FinishButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.PriceGroupBox = new System.Windows.Forms.GroupBox();
            this.TotalTextbox = new System.Windows.Forms.TextBox();
            this.SalesTaxTextbox = new System.Windows.Forms.TextBox();
            this.PriceTextbox = new System.Windows.Forms.TextBox();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.SalesLabel = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.SystemGroupBox2 = new System.Windows.Forms.GroupBox();
            this.OSTextbox = new System.Windows.Forms.TextBox();
            this.WebcamTextbox = new System.Windows.Forms.TextBox();
            this.GPUTypeTextbox = new System.Windows.Forms.TextBox();
            this.HDDTextbox = new System.Windows.Forms.TextBox();
            this.CPUSpeedTextbox = new System.Windows.Forms.TextBox();
            this.CPUNumberTextbox = new System.Windows.Forms.TextBox();
            this.CPUTypeTextbox = new System.Windows.Forms.TextBox();
            this.CPUBrandTextbox = new System.Windows.Forms.TextBox();
            this.MemoryTextbox = new System.Windows.Forms.TextBox();
            this.LCDTextbox = new System.Windows.Forms.TextBox();
            this.OSLabel = new System.Windows.Forms.Label();
            this.WebcamLabel = new System.Windows.Forms.Label();
            this.GPUTypeLabel = new System.Windows.Forms.Label();
            this.HDDLabel = new System.Windows.Forms.Label();
            this.CPUSpeedLabel = new System.Windows.Forms.Label();
            this.CPUNumberLabel = new System.Windows.Forms.Label();
            this.CPUTypeLabel = new System.Windows.Forms.Label();
            this.CPUBrandLabel = new System.Windows.Forms.Label();
            this.MemoryLabel = new System.Windows.Forms.Label();
            this.LCDSizeLabel = new System.Windows.Forms.Label();
            this.SystemGroupBox = new System.Windows.Forms.GroupBox();
            this.ModelLabel = new System.Windows.Forms.Label();
            this.PlatformLabel = new System.Windows.Forms.Label();
            this.ManufacturerLabel = new System.Windows.Forms.Label();
            this.ConditionLabel = new System.Windows.Forms.Label();
            this.ModelTextbox = new System.Windows.Forms.TextBox();
            this.PlatformTextbox = new System.Windows.Forms.TextBox();
            this.ManufacturerTextbox = new System.Windows.Forms.TextBox();
            this.ConditionTextbox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PriceGroupBox.SuspendLayout();
            this.SystemGroupBox2.SuspendLayout();
            this.SystemGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // FinishButton
            // 
            this.FinishButton.Location = new System.Drawing.Point(1013, 541);
            this.FinishButton.Name = "FinishButton";
            this.FinishButton.Size = new System.Drawing.Size(90, 41);
            this.FinishButton.TabIndex = 15;
            this.FinishButton.Text = "Finish";
            this.FinishButton.UseVisualStyleBackColor = true;
            this.FinishButton.Click += new System.EventHandler(this._FinishButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(844, 541);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(90, 41);
            this.CancelButton.TabIndex = 14;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this._CancelButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(682, 541);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(90, 41);
            this.BackButton.TabIndex = 13;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this._BackButton_Click);
            // 
            // PriceGroupBox
            // 
            this.PriceGroupBox.Controls.Add(this.TotalTextbox);
            this.PriceGroupBox.Controls.Add(this.SalesTaxTextbox);
            this.PriceGroupBox.Controls.Add(this.PriceTextbox);
            this.PriceGroupBox.Controls.Add(this.TotalLabel);
            this.PriceGroupBox.Controls.Add(this.SalesLabel);
            this.PriceGroupBox.Controls.Add(this.PriceLabel);
            this.PriceGroupBox.Location = new System.Drawing.Point(653, 299);
            this.PriceGroupBox.Name = "PriceGroupBox";
            this.PriceGroupBox.Size = new System.Drawing.Size(484, 191);
            this.PriceGroupBox.TabIndex = 12;
            this.PriceGroupBox.TabStop = false;
            this.PriceGroupBox.Text = "Your Price";
            // 
            // TotalTextbox
            // 
            this.TotalTextbox.Location = new System.Drawing.Point(355, 149);
            this.TotalTextbox.Name = "TotalTextbox";
            this.TotalTextbox.ReadOnly = true;
            this.TotalTextbox.Size = new System.Drawing.Size(123, 22);
            this.TotalTextbox.TabIndex = 5;
            this.TotalTextbox.Text = "1,694.99";
            // 
            // SalesTaxTextbox
            // 
            this.SalesTaxTextbox.Location = new System.Drawing.Point(355, 103);
            this.SalesTaxTextbox.Name = "SalesTaxTextbox";
            this.SalesTaxTextbox.ReadOnly = true;
            this.SalesTaxTextbox.Size = new System.Drawing.Size(123, 22);
            this.SalesTaxTextbox.TabIndex = 4;
            this.SalesTaxTextbox.Text = "196.00";
            // 
            // PriceTextbox
            // 
            this.PriceTextbox.Location = new System.Drawing.Point(355, 29);
            this.PriceTextbox.Name = "PriceTextbox";
            this.PriceTextbox.ReadOnly = true;
            this.PriceTextbox.Size = new System.Drawing.Size(123, 22);
            this.PriceTextbox.TabIndex = 3;
            this.PriceTextbox.Text = "1,499.99";
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Location = new System.Drawing.Point(45, 152);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(40, 17);
            this.TotalLabel.TabIndex = 2;
            this.TotalLabel.Text = "Total";
            // 
            // SalesLabel
            // 
            this.SalesLabel.AutoSize = true;
            this.SalesLabel.Location = new System.Drawing.Point(45, 106);
            this.SalesLabel.Name = "SalesLabel";
            this.SalesLabel.Size = new System.Drawing.Size(112, 17);
            this.SalesLabel.TabIndex = 1;
            this.SalesLabel.Text = "Sales Tax (13%)";
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(45, 34);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(40, 17);
            this.PriceLabel.TabIndex = 0;
            this.PriceLabel.Text = "Price";
            // 
            // SystemGroupBox2
            // 
            this.SystemGroupBox2.BackColor = System.Drawing.Color.White;
            this.SystemGroupBox2.Controls.Add(this.OSTextbox);
            this.SystemGroupBox2.Controls.Add(this.WebcamTextbox);
            this.SystemGroupBox2.Controls.Add(this.GPUTypeTextbox);
            this.SystemGroupBox2.Controls.Add(this.HDDTextbox);
            this.SystemGroupBox2.Controls.Add(this.CPUSpeedTextbox);
            this.SystemGroupBox2.Controls.Add(this.CPUNumberTextbox);
            this.SystemGroupBox2.Controls.Add(this.CPUTypeTextbox);
            this.SystemGroupBox2.Controls.Add(this.CPUBrandTextbox);
            this.SystemGroupBox2.Controls.Add(this.MemoryTextbox);
            this.SystemGroupBox2.Controls.Add(this.LCDTextbox);
            this.SystemGroupBox2.Controls.Add(this.OSLabel);
            this.SystemGroupBox2.Controls.Add(this.WebcamLabel);
            this.SystemGroupBox2.Controls.Add(this.GPUTypeLabel);
            this.SystemGroupBox2.Controls.Add(this.HDDLabel);
            this.SystemGroupBox2.Controls.Add(this.CPUSpeedLabel);
            this.SystemGroupBox2.Controls.Add(this.CPUNumberLabel);
            this.SystemGroupBox2.Controls.Add(this.CPUTypeLabel);
            this.SystemGroupBox2.Controls.Add(this.CPUBrandLabel);
            this.SystemGroupBox2.Controls.Add(this.MemoryLabel);
            this.SystemGroupBox2.Controls.Add(this.LCDSizeLabel);
            this.SystemGroupBox2.Location = new System.Drawing.Point(13, 205);
            this.SystemGroupBox2.Name = "SystemGroupBox2";
            this.SystemGroupBox2.Size = new System.Drawing.Size(622, 377);
            this.SystemGroupBox2.TabIndex = 11;
            this.SystemGroupBox2.TabStop = false;
            // 
            // OSTextbox
            // 
            this.OSTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OSTextbox.Location = new System.Drawing.Point(114, 336);
            this.OSTextbox.Name = "OSTextbox";
            this.OSTextbox.ReadOnly = true;
            this.OSTextbox.Size = new System.Drawing.Size(480, 15);
            this.OSTextbox.TabIndex = 20;
            // 
            // WebcamTextbox
            // 
            this.WebcamTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.WebcamTextbox.Location = new System.Drawing.Point(114, 303);
            this.WebcamTextbox.Name = "WebcamTextbox";
            this.WebcamTextbox.ReadOnly = true;
            this.WebcamTextbox.Size = new System.Drawing.Size(480, 15);
            this.WebcamTextbox.TabIndex = 19;
            // 
            // GPUTypeTextbox
            // 
            this.GPUTypeTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GPUTypeTextbox.Location = new System.Drawing.Point(114, 271);
            this.GPUTypeTextbox.Name = "GPUTypeTextbox";
            this.GPUTypeTextbox.ReadOnly = true;
            this.GPUTypeTextbox.Size = new System.Drawing.Size(480, 15);
            this.GPUTypeTextbox.TabIndex = 18;
            // 
            // HDDTextbox
            // 
            this.HDDTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.HDDTextbox.Location = new System.Drawing.Point(114, 238);
            this.HDDTextbox.Name = "HDDTextbox";
            this.HDDTextbox.ReadOnly = true;
            this.HDDTextbox.Size = new System.Drawing.Size(480, 15);
            this.HDDTextbox.TabIndex = 17;
            // 
            // CPUSpeedTextbox
            // 
            this.CPUSpeedTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CPUSpeedTextbox.Location = new System.Drawing.Point(114, 206);
            this.CPUSpeedTextbox.Name = "CPUSpeedTextbox";
            this.CPUSpeedTextbox.ReadOnly = true;
            this.CPUSpeedTextbox.Size = new System.Drawing.Size(480, 15);
            this.CPUSpeedTextbox.TabIndex = 16;
            // 
            // CPUNumberTextbox
            // 
            this.CPUNumberTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CPUNumberTextbox.Location = new System.Drawing.Point(114, 165);
            this.CPUNumberTextbox.Name = "CPUNumberTextbox";
            this.CPUNumberTextbox.ReadOnly = true;
            this.CPUNumberTextbox.Size = new System.Drawing.Size(480, 15);
            this.CPUNumberTextbox.TabIndex = 15;
            // 
            // CPUTypeTextbox
            // 
            this.CPUTypeTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CPUTypeTextbox.Location = new System.Drawing.Point(114, 126);
            this.CPUTypeTextbox.Name = "CPUTypeTextbox";
            this.CPUTypeTextbox.ReadOnly = true;
            this.CPUTypeTextbox.Size = new System.Drawing.Size(480, 15);
            this.CPUTypeTextbox.TabIndex = 14;
            // 
            // CPUBrandTextbox
            // 
            this.CPUBrandTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CPUBrandTextbox.Location = new System.Drawing.Point(114, 89);
            this.CPUBrandTextbox.Name = "CPUBrandTextbox";
            this.CPUBrandTextbox.ReadOnly = true;
            this.CPUBrandTextbox.Size = new System.Drawing.Size(480, 15);
            this.CPUBrandTextbox.TabIndex = 13;
            // 
            // MemoryTextbox
            // 
            this.MemoryTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MemoryTextbox.Location = new System.Drawing.Point(114, 57);
            this.MemoryTextbox.Name = "MemoryTextbox";
            this.MemoryTextbox.ReadOnly = true;
            this.MemoryTextbox.Size = new System.Drawing.Size(480, 15);
            this.MemoryTextbox.TabIndex = 12;
            // 
            // LCDTextbox
            // 
            this.LCDTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LCDTextbox.Location = new System.Drawing.Point(114, 24);
            this.LCDTextbox.Name = "LCDTextbox";
            this.LCDTextbox.ReadOnly = true;
            this.LCDTextbox.Size = new System.Drawing.Size(480, 15);
            this.LCDTextbox.TabIndex = 11;
            // 
            // OSLabel
            // 
            this.OSLabel.AutoSize = true;
            this.OSLabel.Location = new System.Drawing.Point(57, 334);
            this.OSLabel.Name = "OSLabel";
            this.OSLabel.Size = new System.Drawing.Size(28, 17);
            this.OSLabel.TabIndex = 10;
            this.OSLabel.Text = "OS";
            // 
            // WebcamLabel
            // 
            this.WebcamLabel.AutoSize = true;
            this.WebcamLabel.Location = new System.Drawing.Point(27, 303);
            this.WebcamLabel.Name = "WebcamLabel";
            this.WebcamLabel.Size = new System.Drawing.Size(63, 17);
            this.WebcamLabel.TabIndex = 9;
            this.WebcamLabel.Text = "Webcam";
            // 
            // GPUTypeLabel
            // 
            this.GPUTypeLabel.AutoSize = true;
            this.GPUTypeLabel.Location = new System.Drawing.Point(16, 271);
            this.GPUTypeLabel.Name = "GPUTypeLabel";
            this.GPUTypeLabel.Size = new System.Drawing.Size(74, 17);
            this.GPUTypeLabel.TabIndex = 8;
            this.GPUTypeLabel.Text = "GPU Type";
            // 
            // HDDLabel
            // 
            this.HDDLabel.AutoSize = true;
            this.HDDLabel.Location = new System.Drawing.Point(47, 238);
            this.HDDLabel.Name = "HDDLabel";
            this.HDDLabel.Size = new System.Drawing.Size(38, 17);
            this.HDDLabel.TabIndex = 7;
            this.HDDLabel.Text = "HDD";
            // 
            // CPUSpeedLabel
            // 
            this.CPUSpeedLabel.AutoSize = true;
            this.CPUSpeedLabel.Location = new System.Drawing.Point(11, 206);
            this.CPUSpeedLabel.Name = "CPUSpeedLabel";
            this.CPUSpeedLabel.Size = new System.Drawing.Size(81, 17);
            this.CPUSpeedLabel.TabIndex = 6;
            this.CPUSpeedLabel.Text = "CPU Speed";
            // 
            // CPUNumberLabel
            // 
            this.CPUNumberLabel.AutoSize = true;
            this.CPUNumberLabel.Location = new System.Drawing.Point(3, 165);
            this.CPUNumberLabel.Name = "CPUNumberLabel";
            this.CPUNumberLabel.Size = new System.Drawing.Size(90, 17);
            this.CPUNumberLabel.TabIndex = 5;
            this.CPUNumberLabel.Text = "CPU Number";
            // 
            // CPUTypeLabel
            // 
            this.CPUTypeLabel.AutoSize = true;
            this.CPUTypeLabel.Location = new System.Drawing.Point(11, 128);
            this.CPUTypeLabel.Name = "CPUTypeLabel";
            this.CPUTypeLabel.Size = new System.Drawing.Size(72, 17);
            this.CPUTypeLabel.TabIndex = 4;
            this.CPUTypeLabel.Text = "CPU Type";
            // 
            // CPUBrandLabel
            // 
            this.CPUBrandLabel.AutoSize = true;
            this.CPUBrandLabel.Location = new System.Drawing.Point(14, 94);
            this.CPUBrandLabel.Name = "CPUBrandLabel";
            this.CPUBrandLabel.Size = new System.Drawing.Size(78, 17);
            this.CPUBrandLabel.TabIndex = 3;
            this.CPUBrandLabel.Text = "CPU Brand";
            // 
            // MemoryLabel
            // 
            this.MemoryLabel.AutoSize = true;
            this.MemoryLabel.Location = new System.Drawing.Point(32, 57);
            this.MemoryLabel.Name = "MemoryLabel";
            this.MemoryLabel.Size = new System.Drawing.Size(58, 17);
            this.MemoryLabel.TabIndex = 2;
            this.MemoryLabel.Text = "Memory";
            // 
            // LCDSizeLabel
            // 
            this.LCDSizeLabel.AutoSize = true;
            this.LCDSizeLabel.Location = new System.Drawing.Point(24, 24);
            this.LCDSizeLabel.Name = "LCDSizeLabel";
            this.LCDSizeLabel.Size = new System.Drawing.Size(66, 17);
            this.LCDSizeLabel.TabIndex = 1;
            this.LCDSizeLabel.Text = "LCD SIze";
            // 
            // SystemGroupBox
            // 
            this.SystemGroupBox.Controls.Add(this.ModelLabel);
            this.SystemGroupBox.Controls.Add(this.PlatformLabel);
            this.SystemGroupBox.Controls.Add(this.ManufacturerLabel);
            this.SystemGroupBox.Controls.Add(this.ConditionLabel);
            this.SystemGroupBox.Controls.Add(this.ModelTextbox);
            this.SystemGroupBox.Controls.Add(this.PlatformTextbox);
            this.SystemGroupBox.Controls.Add(this.ManufacturerTextbox);
            this.SystemGroupBox.Controls.Add(this.ConditionTextbox);
            this.SystemGroupBox.Location = new System.Drawing.Point(13, 72);
            this.SystemGroupBox.Name = "SystemGroupBox";
            this.SystemGroupBox.Size = new System.Drawing.Size(622, 135);
            this.SystemGroupBox.TabIndex = 10;
            this.SystemGroupBox.TabStop = false;
            this.SystemGroupBox.Text = "System Components";
            // 
            // ModelLabel
            // 
            this.ModelLabel.AutoSize = true;
            this.ModelLabel.Location = new System.Drawing.Point(364, 88);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(46, 17);
            this.ModelLabel.TabIndex = 7;
            this.ModelLabel.Text = "Model";
            // 
            // PlatformLabel
            // 
            this.PlatformLabel.AutoSize = true;
            this.PlatformLabel.Location = new System.Drawing.Point(350, 37);
            this.PlatformLabel.Name = "PlatformLabel";
            this.PlatformLabel.Size = new System.Drawing.Size(60, 17);
            this.PlatformLabel.TabIndex = 6;
            this.PlatformLabel.Text = "Platform";
            // 
            // ManufacturerLabel
            // 
            this.ManufacturerLabel.AutoSize = true;
            this.ManufacturerLabel.Location = new System.Drawing.Point(16, 88);
            this.ManufacturerLabel.Name = "ManufacturerLabel";
            this.ManufacturerLabel.Size = new System.Drawing.Size(92, 17);
            this.ManufacturerLabel.TabIndex = 5;
            this.ManufacturerLabel.Text = "Manufacturer";
            // 
            // ConditionLabel
            // 
            this.ConditionLabel.AutoSize = true;
            this.ConditionLabel.Location = new System.Drawing.Point(41, 39);
            this.ConditionLabel.Name = "ConditionLabel";
            this.ConditionLabel.Size = new System.Drawing.Size(67, 17);
            this.ConditionLabel.TabIndex = 4;
            this.ConditionLabel.Text = "Condition";
            // 
            // ModelTextbox
            // 
            this.ModelTextbox.Location = new System.Drawing.Point(416, 85);
            this.ModelTextbox.Name = "ModelTextbox";
            this.ModelTextbox.ReadOnly = true;
            this.ModelTextbox.Size = new System.Drawing.Size(146, 22);
            this.ModelTextbox.TabIndex = 3;
            // 
            // PlatformTextbox
            // 
            this.PlatformTextbox.Location = new System.Drawing.Point(416, 32);
            this.PlatformTextbox.Name = "PlatformTextbox";
            this.PlatformTextbox.ReadOnly = true;
            this.PlatformTextbox.Size = new System.Drawing.Size(146, 22);
            this.PlatformTextbox.TabIndex = 2;
            // 
            // ManufacturerTextbox
            // 
            this.ManufacturerTextbox.Location = new System.Drawing.Point(114, 85);
            this.ManufacturerTextbox.Name = "ManufacturerTextbox";
            this.ManufacturerTextbox.ReadOnly = true;
            this.ManufacturerTextbox.Size = new System.Drawing.Size(146, 22);
            this.ManufacturerTextbox.TabIndex = 1;
            // 
            // ConditionTextbox
            // 
            this.ConditionTextbox.Location = new System.Drawing.Point(115, 34);
            this.ConditionTextbox.Name = "ConditionTextbox";
            this.ConditionTextbox.ReadOnly = true;
            this.ConditionTextbox.Size = new System.Drawing.Size(146, 22);
            this.ConditionTextbox.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(653, 83);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(253, 196);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // MenuStrip
            // 
            this.MenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(1149, 28);
            this.MenuStrip.TabIndex = 8;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.printToolStripMenuItem.Text = "&Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this._printToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this._CancelButton_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.backToolStripMenuItem.Text = "&Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this._BackButton_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this._aboutToolStripMenuItem_Click);
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 606);
            this.Controls.Add(this.FinishButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.PriceGroupBox);
            this.Controls.Add(this.SystemGroupBox2);
            this.Controls.Add(this.SystemGroupBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.MenuStrip);
            this.Name = "OrderForm";
            this.Text = "OrderForm";
            this.PriceGroupBox.ResumeLayout(false);
            this.PriceGroupBox.PerformLayout();
            this.SystemGroupBox2.ResumeLayout(false);
            this.SystemGroupBox2.PerformLayout();
            this.SystemGroupBox.ResumeLayout(false);
            this.SystemGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button FinishButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.GroupBox PriceGroupBox;
        private System.Windows.Forms.TextBox TotalTextbox;
        private System.Windows.Forms.TextBox SalesTaxTextbox;
        private System.Windows.Forms.TextBox PriceTextbox;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.Label SalesLabel;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.GroupBox SystemGroupBox2;
        private System.Windows.Forms.TextBox OSTextbox;
        private System.Windows.Forms.TextBox WebcamTextbox;
        private System.Windows.Forms.TextBox GPUTypeTextbox;
        private System.Windows.Forms.TextBox HDDTextbox;
        private System.Windows.Forms.TextBox CPUSpeedTextbox;
        private System.Windows.Forms.TextBox CPUNumberTextbox;
        private System.Windows.Forms.TextBox CPUTypeTextbox;
        private System.Windows.Forms.TextBox CPUBrandTextbox;
        private System.Windows.Forms.TextBox MemoryTextbox;
        private System.Windows.Forms.TextBox LCDTextbox;
        private System.Windows.Forms.Label OSLabel;
        private System.Windows.Forms.Label WebcamLabel;
        private System.Windows.Forms.Label GPUTypeLabel;
        private System.Windows.Forms.Label HDDLabel;
        private System.Windows.Forms.Label CPUSpeedLabel;
        private System.Windows.Forms.Label CPUNumberLabel;
        private System.Windows.Forms.Label CPUTypeLabel;
        private System.Windows.Forms.Label CPUBrandLabel;
        private System.Windows.Forms.Label MemoryLabel;
        private System.Windows.Forms.Label LCDSizeLabel;
        private System.Windows.Forms.GroupBox SystemGroupBox;
        private System.Windows.Forms.Label ModelLabel;
        private System.Windows.Forms.Label PlatformLabel;
        private System.Windows.Forms.Label ManufacturerLabel;
        private System.Windows.Forms.Label ConditionLabel;
        private System.Windows.Forms.TextBox ModelTextbox;
        private System.Windows.Forms.TextBox PlatformTextbox;
        private System.Windows.Forms.TextBox ManufacturerTextbox;
        private System.Windows.Forms.TextBox ConditionTextbox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}