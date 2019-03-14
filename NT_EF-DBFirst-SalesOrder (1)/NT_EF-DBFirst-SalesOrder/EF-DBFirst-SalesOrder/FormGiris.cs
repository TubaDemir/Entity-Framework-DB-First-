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
    public partial class FormGiris : Form
    {
        public FormGiris()
        {
            InitializeComponent();
        }
        NorthwindEntitiesConnectionString db = ClassDbSingleTone.GetInstance();
        private void Doldur()
        {
            cmbCustomers.DisplayMember = "CustomerName";
            cmbCustomers.ValueMember = "CustomerID";
            cmbCustomers.DataSource = db.Customers.ToList();

            var elist=db.Employees.Select(x=>new
                {
                    FullName = x.FirstName + x.LastName,
                    x.EmployeeID
            }).ToList();

            cmbEmployees.DataSource = elist;
            cmbEmployees.DisplayMember = "FullName";
            cmbEmployees.ValueMember = "EmployeeID";

            cmbShipVia.DataSource = db.Shippers.ToList();
            cmbShipVia.DisplayMember = "CompanyName";
            cmbShipVia.ValueMember = "ShipperID";

            if (cmbCustomers.SelectedIndex!=-1)
            {
                Customer secilenCustomer = db.Customers.Find(cmbCustomers.SelectedValue);
                txtAddress.Text = secilenCustomer.Address;
                txtCountry.Text = secilenCustomer.City + " " + secilenCustomer.Country;
             

            }



        }

        private void cmbCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Customer secilenCustomer = db.Customers.Find(cmbCustomers.SelectedValue);
                txtAddress.Text = secilenCustomer.Address.ToString();
                txtCountry.Text = secilenCustomer.City + " " + secilenCustomer.Country.ToString();
            }
            catch (Exception)
            {

                
            }
        }

        private void FormGiris_Load(object sender, EventArgs e)
        {
            Doldur();
        }

        private void btnCreateOrder_Click(object sender, EventArgs e)
        {
            Order ord = new Order();
            ord.CustomerID = cmbCustomers.SelectedValue.ToString();
            ord.EmployeeID = (int)cmbEmployees.SelectedValue;
            ord.OrderDate = dtpOrderDate.Value;
            ord.RequiredDate = dtpRequiredDate.Value;
            ord.ShipVia =(int)cmbShipVia.SelectedValue;
            ord.Freight =Convert.ToDecimal(txtFreight.Text);
            ord.ShipCountry = txtCountry.Text;
            ord.ShipAddress = txtAddress.Text;

            db.Orders.Add(ord);
            db.SaveChanges();
            FormOrderHeaderDetail frm2 = new FormOrderHeaderDetail(ord.OrderID);
          //  frm2.Show();
            MessageBox.Show("Ekleme yapıldı");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frn = new Form1();
            frn.Show();
        }
    }
}
