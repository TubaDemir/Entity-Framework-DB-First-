namespace EF_DBFirst_SalesOrder
{
    partial class FormOrderHeaderDetail
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
            this.btnOrderUpdate = new System.Windows.Forms.Button();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtFreight = new System.Windows.Forms.TextBox();
            this.dtpRequiredDate = new System.Windows.Forms.DateTimePicker();
            this.dtpOrderDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbShipVia = new System.Windows.Forms.ComboBox();
            this.cmbEmployees = new System.Windows.Forms.ComboBox();
            this.cmbCustomers = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnInsertOrderDetail = new System.Windows.Forms.Button();
            this.btnUpdateOrderDetail = new System.Windows.Forms.Button();
            this.btnDeleteOrderDetail = new System.Windows.Forms.Button();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.cmbProducts = new System.Windows.Forms.ComboBox();
            this.btnOrderDelete = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOrderUpdate
            // 
            this.btnOrderUpdate.Location = new System.Drawing.Point(304, 166);
            this.btnOrderUpdate.Name = "btnOrderUpdate";
            this.btnOrderUpdate.Size = new System.Drawing.Size(107, 23);
            this.btnOrderUpdate.TabIndex = 29;
            this.btnOrderUpdate.Text = "Order Update";
            this.btnOrderUpdate.UseVisualStyleBackColor = true;
            this.btnOrderUpdate.Click += new System.EventHandler(this.btnOrderUpdate_Click);
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(125, 142);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(117, 20);
            this.txtCountry.TabIndex = 28;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(125, 44);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(117, 92);
            this.txtAddress.TabIndex = 27;
            // 
            // txtFreight
            // 
            this.txtFreight.Location = new System.Drawing.Point(585, 69);
            this.txtFreight.Name = "txtFreight";
            this.txtFreight.Size = new System.Drawing.Size(117, 20);
            this.txtFreight.TabIndex = 26;
            // 
            // dtpRequiredDate
            // 
            this.dtpRequiredDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpRequiredDate.Location = new System.Drawing.Point(351, 69);
            this.dtpRequiredDate.Name = "dtpRequiredDate";
            this.dtpRequiredDate.Size = new System.Drawing.Size(117, 20);
            this.dtpRequiredDate.TabIndex = 25;
            // 
            // dtpOrderDate
            // 
            this.dtpOrderDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpOrderDate.Location = new System.Drawing.Point(351, 17);
            this.dtpOrderDate.Name = "dtpOrderDate";
            this.dtpOrderDate.Size = new System.Drawing.Size(117, 20);
            this.dtpOrderDate.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(503, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Freight:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(503, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "ShipVia:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(266, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Employee:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(266, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Required Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(269, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "OrderDate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Customer:";
            // 
            // cmbShipVia
            // 
            this.cmbShipVia.FormattingEnabled = true;
            this.cmbShipVia.Location = new System.Drawing.Point(585, 17);
            this.cmbShipVia.Name = "cmbShipVia";
            this.cmbShipVia.Size = new System.Drawing.Size(117, 21);
            this.cmbShipVia.TabIndex = 17;
            // 
            // cmbEmployees
            // 
            this.cmbEmployees.FormattingEnabled = true;
            this.cmbEmployees.Location = new System.Drawing.Point(351, 120);
            this.cmbEmployees.Name = "cmbEmployees";
            this.cmbEmployees.Size = new System.Drawing.Size(117, 21);
            this.cmbEmployees.TabIndex = 16;
            // 
            // cmbCustomers
            // 
            this.cmbCustomers.FormattingEnabled = true;
            this.cmbCustomers.Location = new System.Drawing.Point(125, 17);
            this.cmbCustomers.Name = "cmbCustomers";
            this.cmbCustomers.Size = new System.Drawing.Size(117, 21);
            this.cmbCustomers.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Location = new System.Drawing.Point(12, 215);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(892, 31);
            this.panel1.TabIndex = 30;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 265);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(655, 147);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnInsertOrderDetail
            // 
            this.btnInsertOrderDetail.Location = new System.Drawing.Point(697, 325);
            this.btnInsertOrderDetail.Name = "btnInsertOrderDetail";
            this.btnInsertOrderDetail.Size = new System.Drawing.Size(75, 23);
            this.btnInsertOrderDetail.TabIndex = 31;
            this.btnInsertOrderDetail.Text = "INSERT";
            this.btnInsertOrderDetail.UseVisualStyleBackColor = true;
            this.btnInsertOrderDetail.Click += new System.EventHandler(this.btnInsertOrderDetail_Click);
            // 
            // btnUpdateOrderDetail
            // 
            this.btnUpdateOrderDetail.Location = new System.Drawing.Point(697, 354);
            this.btnUpdateOrderDetail.Name = "btnUpdateOrderDetail";
            this.btnUpdateOrderDetail.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateOrderDetail.TabIndex = 32;
            this.btnUpdateOrderDetail.Text = "UPDATE";
            this.btnUpdateOrderDetail.UseVisualStyleBackColor = true;
            this.btnUpdateOrderDetail.Click += new System.EventHandler(this.btnUpdateOrderDetail_Click);
            // 
            // btnDeleteOrderDetail
            // 
            this.btnDeleteOrderDetail.Location = new System.Drawing.Point(697, 383);
            this.btnDeleteOrderDetail.Name = "btnDeleteOrderDetail";
            this.btnDeleteOrderDetail.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteOrderDetail.TabIndex = 33;
            this.btnDeleteOrderDetail.Text = "DELETE";
            this.btnDeleteOrderDetail.UseVisualStyleBackColor = true;
            this.btnDeleteOrderDetail.Click += new System.EventHandler(this.btnDeleteOrderDetail_Click);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(774, 265);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(121, 20);
            this.txtQuantity.TabIndex = 34;
            // 
            // cmbProducts
            // 
            this.cmbProducts.FormattingEnabled = true;
            this.cmbProducts.Location = new System.Drawing.Point(774, 291);
            this.cmbProducts.Name = "cmbProducts";
            this.cmbProducts.Size = new System.Drawing.Size(121, 21);
            this.cmbProducts.TabIndex = 35;
            // 
            // btnOrderDelete
            // 
            this.btnOrderDelete.Location = new System.Drawing.Point(458, 166);
            this.btnOrderDelete.Name = "btnOrderDelete";
            this.btnOrderDelete.Size = new System.Drawing.Size(98, 23);
            this.btnOrderDelete.TabIndex = 36;
            this.btnOrderDelete.Text = "Order Delete";
            this.btnOrderDelete.UseVisualStyleBackColor = true;
            this.btnOrderDelete.Click += new System.EventHandler(this.btnOrderDelete_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 37;
            this.label7.Text = "Order ID:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(697, 272);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 38;
            this.label8.Text = "Quantity:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(697, 299);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 39;
            this.label9.Text = "Products:";
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Enabled = false;
            this.txtTotalAmount.Location = new System.Drawing.Point(114, 418);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.Size = new System.Drawing.Size(100, 20);
            this.txtTotalAmount.TabIndex = 40;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(35, 421);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 13);
            this.label10.TabIndex = 41;
            this.label10.Text = "Total Amount:";
            // 
            // txtOrderID
            // 
            this.txtOrderID.Enabled = false;
            this.txtOrderID.Location = new System.Drawing.Point(125, 173);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Size = new System.Drawing.Size(117, 20);
            this.txtOrderID.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(829, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 42;
            this.button1.Text = "BACK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormOrderHeaderDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtOrderID);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtTotalAmount);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnOrderDelete);
            this.Controls.Add(this.cmbProducts);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.btnDeleteOrderDetail);
            this.Controls.Add(this.btnUpdateOrderDetail);
            this.Controls.Add(this.btnInsertOrderDetail);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnOrderUpdate);
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
            this.Name = "FormOrderHeaderDetail";
            this.Text = "FormOrderHeaderDetail";
            this.Load += new System.EventHandler(this.FormOrderHeaderDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOrderUpdate;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtFreight;
        private System.Windows.Forms.DateTimePicker dtpRequiredDate;
        private System.Windows.Forms.DateTimePicker dtpOrderDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbShipVia;
        private System.Windows.Forms.ComboBox cmbEmployees;
        private System.Windows.Forms.ComboBox cmbCustomers;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnInsertOrderDetail;
        private System.Windows.Forms.Button btnUpdateOrderDetail;
        private System.Windows.Forms.Button btnDeleteOrderDetail;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.ComboBox cmbProducts;
        private System.Windows.Forms.Button btnOrderDelete;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.Button button1;
    }
}