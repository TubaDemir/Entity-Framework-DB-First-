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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        NorthwindEntitiesConnectionString db = ClassDbSingleTone.GetInstance();
        Label lblOrderId = new Label();
        TextBox txtOrdersID = new TextBox();
        Button btnGonder = new Button();
        public int secilenID;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void OrderCheck()
        {
            
            try
            {
                secilenID = Convert.ToInt32(txtOrdersID.Text);


             //   List<Order_Detail> od_List = db.Order_Details.Where(x => secilenID == x.OrderID).ToList();
                List<Order> odList2 = db.Orders.Where(x => secilenID == x.OrderID).ToList();
                if (odList2.Count==0)
                {
                    MessageBox.Show(secilenID + "nolu siparis yok.");
                }
                else
                {
                    FormOrderHeaderDetail frmOrdHeadDet = new FormOrderHeaderDetail(secilenID);
                    

                    frmOrdHeadDet.Show();
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Girilen siparis icin veri okuma yapilamadi.");
            }
        }

        private void siparişGörüntülemeDüzeltmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblOrderId.Text = "Order No:";
            btnGonder.Text = "Open Order";
            flowLayoutPanel1.Controls.Add(lblOrderId);
            flowLayoutPanel1.Controls.Add(txtOrdersID);
            flowLayoutPanel1.Controls.Add(btnGonder);
            btnGonder.Click += new EventHandler(btnGonder_Click);
            //btnGonder.Click += btnGonder_Click; //Bu türlü de event eklenir sorun olmaz.
        }

        private void btnGonder_Click(object sender , EventArgs e)
        {
            OrderCheck();
        }

        private void siparişGirişToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGiris frmGiris = new FormGiris();
            frmGiris.Show();
        }
    }
}
