namespace EF_DBFirst_SalesOrder
{
    partial class FormGiris
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
            this.cmbCustomers = new System.Windows.Forms.ComboBox();
            this.cmbEmployees = new System.Windows.Forms.ComboBox();
            this.cmbShipVia = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpOrderDate = new System.Windows.Forms.DateTimePicker();
            this.dtpRequiredDate = new System.Windows.Forms.DateTimePicker();
            this.txtFreight = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.btnCreateOrder = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbCustomers
            // 
            this.cmbCustomers.FormattingEnabled = true;
            this.cmbCustomers.Location = new System.Drawing.Point(120, 25);
            this.cmbCustomers.Name = "cmbCustomers";
            this.cmbCustomers.Size = new System.Drawing.Size(117, 21);
            this.cmbCustomers.TabIndex = 0;
            this.cmbCustomers.SelectedIndexChanged += new System.EventHandler(this.cmbCustomers_SelectedIndexChanged);
            // 
            // cmbEmployees
            // 
            this.cmbEmployees.FormattingEnabled = true;
            this.cmbEmployees.Location = new System.Drawing.Point(120, 81);
            this.cmbEmployees.Name = "cmbEmployees";
            this.cmbEmployees.Size = new System.Drawing.Size(117, 21);
            this.cmbEmployees.TabIndex = 1;
            // 
            // cmbShipVia
            // 
            this.cmbShipVia.FormattingEnabled = true;
            this.cmbShipVia.Location = new System.Drawing.Point(120, 220);
            this.cmbShipVia.Name = "cmbShipVia";
            this.cmbShipVia.Size = new System.Drawing.Size(117, 21);
            this.cmbShipVia.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Customer:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "OrderDate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Required Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Employee:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "ShipVia:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Freight:";
            // 
            // dtpOrderDate
            // 
            this.dtpOrderDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpOrderDate.Location = new System.Drawing.Point(120, 129);
            this.dtpOrderDate.Name = "dtpOrderDate";
            this.dtpOrderDate.Size = new System.Drawing.Size(117, 20);
            this.dtpOrderDate.TabIndex = 9;
            // 
            // dtpRequiredDate
            // 
            this.dtpRequiredDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpRequiredDate.Location = new System.Drawing.Point(120, 174);
            this.dtpRequiredDate.Name = "dtpRequiredDate";
            this.dtpRequiredDate.Size = new System.Drawing.Size(117, 20);
            this.dtpRequiredDate.TabIndex = 10;
            // 
            // txtFreight
            // 
            this.txtFreight.Location = new System.Drawing.Point(120, 273);
            this.txtFreight.Name = "txtFreight";
            this.txtFreight.Size = new System.Drawing.Size(117, 20);
            this.txtFreight.TabIndex = 11;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(267, 25);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(171, 168);
            this.txtAddress.TabIndex = 12;
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(267, 223);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(171, 20);
            this.txtCountry.TabIndex = 13;
            // 
            // btnCreateOrder
            // 
            this.btnCreateOrder.Location = new System.Drawing.Point(267, 270);
            this.btnCreateOrder.Name = "btnCreateOrder";
            this.btnCreateOrder.Size = new System.Drawing.Size(171, 23);
            this.btnCreateOrder.TabIndex = 14;
            this.btnCreateOrder.Text = "Create Order";
            this.btnCreateOrder.UseVisualStyleBackColor = true;
            this.btnCreateOrder.Click += new System.EventHandler(this.btnCreateOrder_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(363, 333);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "BACK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCreateOrder);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtFreight);
            this.Controls.Add(this.dtpRequiredDate);
            this.Controls.Add(this.dtpOrderDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbShipVia);
            this.Controls.Add(this.cmbEmployees);
            this.Controls.Add(this.cmbCustomers);
            this.Name = "FormGiris";
            this.Text = "FormGiris";
            this.Load += new System.EventHandler(this.FormGiris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCustomers;
        private System.Windows.Forms.ComboBox cmbEmployees;
        private System.Windows.Forms.ComboBox cmbShipVia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpOrderDate;
        private System.Windows.Forms.DateTimePicker dtpRequiredDate;
        private System.Windows.Forms.TextBox txtFreight;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Button btnCreateOrder;
        private System.Windows.Forms.Button button1;
    }
}