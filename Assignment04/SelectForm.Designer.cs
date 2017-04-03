namespace Assignment04
{
    partial class SelectForm
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
            this.CompDataGridView = new System.Windows.Forms.DataGridView();
            this.NextButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.ChoiceTextBox = new System.Windows.Forms.TextBox();
            this.ChoiceLabel = new System.Windows.Forms.Label();
            this.SelectFormLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CompDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // CompDataGridView
            // 
            this.CompDataGridView.AllowUserToAddRows = false;
            this.CompDataGridView.AllowUserToDeleteRows = false;
            this.CompDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CompDataGridView.Location = new System.Drawing.Point(25, 36);
            this.CompDataGridView.Name = "CompDataGridView";
            this.CompDataGridView.ReadOnly = true;
            this.CompDataGridView.RowTemplate.Height = 24;
            this.CompDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CompDataGridView.Size = new System.Drawing.Size(875, 396);
            this.CompDataGridView.TabIndex = 12;
            // 
            // NextButton
            // 
            this.NextButton.Enabled = false;
            this.NextButton.Location = new System.Drawing.Point(825, 452);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(75, 40);
            this.NextButton.TabIndex = 11;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(715, 453);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 40);
            this.CancelButton.TabIndex = 10;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // ChoiceTextBox
            // 
            this.ChoiceTextBox.Location = new System.Drawing.Point(122, 462);
            this.ChoiceTextBox.Name = "ChoiceTextBox";
            this.ChoiceTextBox.Size = new System.Drawing.Size(562, 22);
            this.ChoiceTextBox.TabIndex = 9;
            // 
            // ChoiceLabel
            // 
            this.ChoiceLabel.AutoSize = true;
            this.ChoiceLabel.Location = new System.Drawing.Point(22, 462);
            this.ChoiceLabel.Name = "ChoiceLabel";
            this.ChoiceLabel.Size = new System.Drawing.Size(93, 17);
            this.ChoiceLabel.TabIndex = 8;
            this.ChoiceLabel.Text = "Your Choice: ";
            // 
            // SelectFormLabel
            // 
            this.SelectFormLabel.AutoSize = true;
            this.SelectFormLabel.Location = new System.Drawing.Point(19, 15);
            this.SelectFormLabel.Name = "SelectFormLabel";
            this.SelectFormLabel.Size = new System.Drawing.Size(201, 17);
            this.SelectFormLabel.TabIndex = 7;
            this.SelectFormLabel.Text = "Dollar Computer Hardware List";
            // 
            // SelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 509);
            this.Controls.Add(this.CompDataGridView);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.ChoiceTextBox);
            this.Controls.Add(this.ChoiceLabel);
            this.Controls.Add(this.SelectFormLabel);
            this.Name = "SelectForm";
            this.Text = "SelectForm";
            ((System.ComponentModel.ISupportInitialize)(this.CompDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView CompDataGridView;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.TextBox ChoiceTextBox;
        private System.Windows.Forms.Label ChoiceLabel;
        private System.Windows.Forms.Label SelectFormLabel;
    }
}