using ironhelmrepo.Presenters;
using ironhelmrepo.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Iron_helm_order_mgt.Forms
{
    public partial class Estimate_Order_Form : Form,IEstimateOrderView
    {
        private EstimateOrderPresenter presenter = null;
        private Order order;
        DataTable dt;

        public int orderId
        {
            get { return order.orderId; }
            set { }
        }
        public string orderStatus
        {
            get { return order.orderStatus; }
            set { order.orderStatus = value; }
        }
        public DateTime estimatedDate
        {
            get { return dateTimePicker1.Value; }
            set { dateTimePicker1.Value = value; }
        }
        public double totalCost
        { 
            get { return Convert.ToDouble(totalCost_txt.Text); }
            set { totalCost_txt.Text = value.ToString(); }
        }

        public double packageCost
        { 
          get { return Convert.ToDouble(packagingCost_txt.Text); }
          set { packagingCost_txt.Text = value.ToString(); }
        }
        public double deliveryCost 
        {
            get{ return Convert.ToDouble(deliveryCost_txt.Text); }
            set { deliveryCost_txt.Text = value.ToString(); }
        }

        public Estimate_Order_Form(Order order)
        {
            InitializeComponent();
            this.order = order;
            dt = new DataTable();
            presenter = new EstimateOrderPresenter(this);
        }

        private void Estimate_Order_Form_Load(object sender, EventArgs e)
        {
            load_products();
            
            dt.Columns.Add("Product Code");
            dt.Columns.Add("Quantity");
            dt.Columns.Add("Number of hours");
            dt.Columns.Add("Cost per hour");


        }

        private void load_products()
        {
            List<OrderLineItem> lines = presenter.getOrderLines();
            foreach(OrderLineItem l in lines)
            {
                products_cmb.Items.Add(l.productCode + "-" + l.quantity);
               
            }
            

        }

        private void ok_btn_Click(object sender, EventArgs e)
        {
            if (products_cmb.SelectedIndex != -1)
            {
                dt.Rows.Add(products_cmb.SelectedItem.ToString().Split('-')[0],
                    Convert.ToInt32(products_cmb.SelectedItem.ToString().Split('-')[1]),
                    Convert.ToInt32(hours_txt.Text),
                    Convert.ToDouble(cost_txt.Text));
                dataGridView1.DataSource = dt;
                products_cmb.SelectedIndex = -1;
                hours_txt.Text = "";
                cost_txt.Text = "";
            }
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(row.Index);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Double cost = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                cost = cost + Convert.ToInt32(row.Cells[1].Value) * Convert.ToInt32(row.Cells[2].Value) * Convert.ToDouble(row.Cells[3].Value);
                
            }
            Double tcost = cost + Convert.ToDouble(deliveryCost_txt.Text) + Convert.ToDouble(packagingCost_txt.Text);
            totalCost_txt.Text = tcost.ToString();
        }

        private void schedule_btn_Click(object sender, EventArgs e)
        {
            presenter.updateOrder();
            string status = presenter.estimateOrder();
            if (status.Equals("SUCCESS"))
            {
                MessageBox.Show("Order estimated succesfully");
            }
            else
            {
                MessageBox.Show("Order coud not be estimated");
            }
            Hide();
        }

    }
}
