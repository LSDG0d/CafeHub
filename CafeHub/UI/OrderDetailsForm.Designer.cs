
namespace CafeHub.UI
{
    partial class OrderDetailsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonAddOrder = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.numericUpDownTableNumber = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownWaiterNumber = new System.Windows.Forms.NumericUpDown();
            this.comboBoxPaymentStatus = new System.Windows.Forms.ComboBox();
            this.richTextBoxOrderItems = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTableNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWaiterNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Table Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Waiter number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Payment status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "OrderItems";
            // 
            // buttonAddOrder
            // 
            this.buttonAddOrder.Location = new System.Drawing.Point(460, 339);
            this.buttonAddOrder.Name = "buttonAddOrder";
            this.buttonAddOrder.Size = new System.Drawing.Size(136, 51);
            this.buttonAddOrder.TabIndex = 4;
            this.buttonAddOrder.Text = "AddOrder";
            this.buttonAddOrder.UseVisualStyleBackColor = true;
            this.buttonAddOrder.Click += new System.EventHandler(this.buttonAddOrder_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 339);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 51);
            this.button2.TabIndex = 5;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // numericUpDownTableNumber
            // 
            this.numericUpDownTableNumber.Location = new System.Drawing.Point(147, 51);
            this.numericUpDownTableNumber.Name = "numericUpDownTableNumber";
            this.numericUpDownTableNumber.Size = new System.Drawing.Size(204, 27);
            this.numericUpDownTableNumber.TabIndex = 6;
            // 
            // numericUpDownWaiterNumber
            // 
            this.numericUpDownWaiterNumber.Location = new System.Drawing.Point(147, 84);
            this.numericUpDownWaiterNumber.Name = "numericUpDownWaiterNumber";
            this.numericUpDownWaiterNumber.Size = new System.Drawing.Size(204, 27);
            this.numericUpDownWaiterNumber.TabIndex = 7;
            // 
            // comboBoxPaymentStatus
            // 
            this.comboBoxPaymentStatus.FormattingEnabled = true;
            this.comboBoxPaymentStatus.Items.AddRange(new object[] {
            "Accepted",
            "Paid"});
            this.comboBoxPaymentStatus.Location = new System.Drawing.Point(147, 118);
            this.comboBoxPaymentStatus.Name = "comboBoxPaymentStatus";
            this.comboBoxPaymentStatus.Size = new System.Drawing.Size(204, 27);
            this.comboBoxPaymentStatus.TabIndex = 8;
            // 
            // richTextBoxOrderItems
            // 
            this.richTextBoxOrderItems.Location = new System.Drawing.Point(147, 159);
            this.richTextBoxOrderItems.Name = "richTextBoxOrderItems";
            this.richTextBoxOrderItems.Size = new System.Drawing.Size(449, 162);
            this.richTextBoxOrderItems.TabIndex = 9;
            this.richTextBoxOrderItems.Text = "";
            // 
            // OrderDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 418);
            this.Controls.Add(this.richTextBoxOrderItems);
            this.Controls.Add(this.comboBoxPaymentStatus);
            this.Controls.Add(this.numericUpDownWaiterNumber);
            this.Controls.Add(this.numericUpDownTableNumber);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonAddOrder);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "OrderDetailsForm";
            this.Text = "OrderDetailsForm";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTableNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWaiterNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonAddOrder;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown numericUpDownTableNumber;
        private System.Windows.Forms.NumericUpDown numericUpDownWaiterNumber;
        private System.Windows.Forms.ComboBox comboBoxPaymentStatus;
        private System.Windows.Forms.RichTextBox richTextBoxOrderItems;
    }
}