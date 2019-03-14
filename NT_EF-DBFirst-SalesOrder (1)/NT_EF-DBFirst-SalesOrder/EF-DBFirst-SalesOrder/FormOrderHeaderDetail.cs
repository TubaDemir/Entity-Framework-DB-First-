using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EF_DBFirst_SalesOrder
{
    public partial class FormOrderHeaderDetail : Form
    {
        NorthwindEntitiesConnectionString db = ClassDbSingleTone.GetInstance();
        private int girilenID;
        private Order gelenOrder;
        private Order_Detail secilenOrderDet;
        private int secilenProductID;
        public FormOrderHeaderDetail(int secilenID)
        {
            InitializeComponent();
            girilenID = secilenID;
            gelenOrder = db.Orders.Find(girilenID);
        }

        public FormOrderHeaderDetail()
        {
            InitializeComponent();

        }

        private void btnOrderUpdate_Click(object sender, EventArgs e)
        {
            gelenOrder.CustomerID = cmbCustomers.SelectedValue.ToString();
            gelenOrder.EmployeeID = (int)cmbEmployees.SelectedValue;
            gelenOrder.OrderDate = dtpOrderDate.Value;
            gelenOrder.RequiredDate = dtpRequiredDate.Value;
            gelenOrder.ShipVia = (int)cmbShipVia.SelectedValue;
            gelenOrder.Freight = Convert.ToDecimal(txtFreight.Text);
            db.SaveChanges();
            MessageBox.Show("Order has been Updated.");
            OrderDoldur();
            ComboDoldur();

        }

        private void btnOrderDelete_Click(object sender, EventArgs e)
        {
            try
            {
                db.Orders.Remove(gelenOrder);
                db.SaveChanges();
                MessageBox.Show("Order has ben deleted.");
                this.Hide();
            }
            catch (Exception)
            {

                MessageBox.Show("Delete details for this Order.");
            }
        }

        private void btnInsertOrderDetail_Click(object sender, EventArgs e)
        {
            Order_Detail od = new Order_Detail();
            od.OrderID = Convert.ToInt32(txtOrderID.Text);
            od.ProductID = (int)cmbProducts.SelectedValue;
            od.Quantity = Convert.ToInt16(txtQuantity.Text);
            Product p = db.Products.Find(od.ProductID);
            od.UnitPrice = (decimal)p.UnitPrice;
            db.Order_Details.Add(od);
            od.Discount = 0;
            db.SaveChanges();

            OrderDetDoldur();
            MessageBox.Show("Inserts");
        }

        private void btnUpdateOrderDetail_Click(object sender, EventArgs e)
        {
            db.Order_Details.Remove(secilenOrderDet);
            Order_Detail od = new Order_Detail();
            od.OrderID = Convert.ToInt32(txtOrderID.Text);
            od.ProductID = (int)cmbProducts.SelectedValue;
            od.Quantity = Convert.ToInt16(txtQuantity.Text);
            Product p = db.Products.Find(od.ProductID);
            od.UnitPrice = (decimal)p.UnitPrice;
            db.Order_Details.Add(od);
            od.Discount = 0;
            db.SaveChanges();

            OrderDetDoldur();
            MessageBox.Show("Updates");
        }

        private void btnDeleteOrderDetail_Click(object sender, EventArgs e)
        {
            db.Order_Details.Remove(secilenOrderDet);
            db.SaveChanges();
            MessageBox.Show("Deletes");
            OrderDetDoldur();
        }

        private void FormOrderHeaderDetail_Load(object sender, EventArgs e)
        {
            ComboDoldur();
            OrderDoldur();
            OrderDetDoldur();

        }

        private void ComboDoldur()
        {
            var clist = db.Customers.Select(x => new
            {
                x.CustomerID,
                x.CompanyName
            }).ToList();
            cmbCustomers.DataSource = clist;
            cmbCustomers.DisplayMember = "CompanyName";
            cmbCustomers.ValueMember = "CustomerID";
            cmbCustomers.SelectedValue = gelenOrder.CustomerID;

            var elist = db.Employees.Select(x => new
            {
                FullName = x.FirstName + x.LastName,
                x.EmployeeID
            }).ToList();

            cmbEmployees.DataSource = elist;
            cmbEmployees.DisplayMember = "FullName";
            cmbEmployees.ValueMember = "EmployeeID";
            cmbEmployees.SelectedValue = gelenOrder.EmployeeID;

            var shlist = db.Shippers.ToList();
            cmbShipVia.DataSource = shlist;
            cmbShipVia.DisplayMember = "CompanyName";
            cmbShipVia.ValueMember = "ShipperID";
            cmbShipVia.SelectedValue = gelenOrder.ShipVia;
        }

        private void OrderDoldur()
        {
            txtOrderID.Text = girilenID.ToString();
            txtFreight.Text = gelenOrder.Freight.ToString();
            txtAddress.Text = gelenOrder.Customer.Address;
            txtCountry.Text = gelenOrder.Customer.City + " " + gelenOrder.Customer.Country;
            dtpOrderDate.Value = gelenOrder.OrderDate.Value;
            dtpRequiredDate.Value = gelenOrder.RequiredDate.Value;

        }

        private void OrderDetDoldur()
        {
            var odList = db.Order_Details.Select(x => new
            {
                x.OrderID,
                x.ProductID,
                x.Product.ProductName,
                x.UnitPrice,
                x.Quantity,
                Total = x.Quantity * x.UnitPrice
            }).Where(x => x.OrderID == girilenID).ToList();

            dataGridView1.DataSource = odList;
            txtTotalAmount.Text = odList.Sum(x => x.Total).ToString();

            var plist = db.Products.Select(x => new
            {
                x.ProductID,
                x.ProductName
            }).ToList();

            cmbProducts.DataSource = plist;
            cmbProducts.DisplayMember = "ProductName";
            cmbProducts.ValueMember = "ProductID";



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            secilenProductID = (int)dataGridView1.CurrentRow.Cells[1].Value;

            secilenOrderDet = db.Order_Details.Find(girilenID, secilenProductID);

            txtQuantity.Text = secilenOrderDet.Quantity.ToString();

            cmbProducts.SelectedValue = secilenProductID;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frn2 = new Form1();
            frn2.Show();
        }
    }
}
