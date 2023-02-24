namespace CarInventory
{
    partial class Form1
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
            this.yearInput = new System.Windows.Forms.TextBox();
            this.makeInput = new System.Windows.Forms.TextBox();
            this.colourInput = new System.Windows.Forms.TextBox();
            this.mileageInput = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.removeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // yearInput
            // 
            this.yearInput.Location = new System.Drawing.Point(129, 41);
            this.yearInput.Margin = new System.Windows.Forms.Padding(4);
            this.yearInput.Name = "yearInput";
            this.yearInput.Size = new System.Drawing.Size(168, 22);
            this.yearInput.TabIndex = 0;
            // 
            // makeInput
            // 
            this.makeInput.Location = new System.Drawing.Point(129, 73);
            this.makeInput.Margin = new System.Windows.Forms.Padding(4);
            this.makeInput.Name = "makeInput";
            this.makeInput.Size = new System.Drawing.Size(168, 22);
            this.makeInput.TabIndex = 1;
            // 
            // colourInput
            // 
            this.colourInput.Location = new System.Drawing.Point(129, 105);
            this.colourInput.Margin = new System.Windows.Forms.Padding(4);
            this.colourInput.Name = "colourInput";
            this.colourInput.Size = new System.Drawing.Size(168, 22);
            this.colourInput.TabIndex = 2;
            // 
            // mileageInput
            // 
            this.mileageInput.Location = new System.Drawing.Point(129, 137);
            this.mileageInput.Margin = new System.Windows.Forms.Padding(4);
            this.mileageInput.Name = "mileageInput";
            this.mileageInput.Size = new System.Drawing.Size(168, 22);
            this.mileageInput.TabIndex = 3;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(129, 177);
            this.addButton.Margin = new System.Windows.Forms.Padding(4);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 28);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.BackColor = System.Drawing.Color.White;
            this.outputLabel.Location = new System.Drawing.Point(49, 236);
            this.outputLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(400, 170);
            this.outputLabel.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Year";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Make";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 108);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Colour";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 140);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Mileage";
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(222, 177);
            this.removeButton.Margin = new System.Windows.Forms.Padding(4);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 28);
            this.removeButton.TabIndex = 10;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 450);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.mileageInput);
            this.Controls.Add(this.colourInput);
            this.Controls.Add(this.makeInput);
            this.Controls.Add(this.yearInput);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Car Inventory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox yearInput;
        private System.Windows.Forms.TextBox makeInput;
        private System.Windows.Forms.TextBox colourInput;
        private System.Windows.Forms.TextBox mileageInput;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button removeButton;
    }
}

