using Iron_helm_order_mgt.Forms;
using Iron_helm_order_mgt.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Iron_helm_order_mgt
{
    public partial class Admin_Portal_Frm : Form
    {
        private OrderService orderService;
        public Admin_Portal_Frm()
        {
            this.orderService = new OrderService();
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                string clientId = dataGridView1.CurrentRow.Cells["Client Id"].FormattedValue.ToString();
                Customer_Details_Form customerDetailsForm = new Customer_Details_Form(clientId);
                customerDetailsForm.Show();
            }
        }

        private void Admin_Portal_Frm_Load(object sender, EventArgs e)
        {
            DataTable dt = orderService.getOrders();
            dataGridView1.DataSource = dt;
            dataGridView1.Columns.Add(new DataGridViewButtonColumn()
            {
                Text = "View Client Details",
                //Tag = (Action<Order>)ClickHandler,
                UseColumnTextForButtonValue = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None
            });
        }

        private void process_btn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                Order order = orderService.getOrderById(Convert.ToInt32(row.Cells[0].Value));
                if (order.orderStatus == "NEW")
                {
                    Estimate_Order_Form estimateForm = new Estimate_Order_Form(order);
                    estimateForm.Show();
                }
                if (order.orderStatus == "ACCEPTED")
                {
                    Schedule_Order_Form sceduleOrderForm = new Schedule_Order_Form(order);
                    sceduleOrderForm.Show();
                }

                if (order.orderStatus == "SCHEDULED"|| order.orderStatus == "PROGRESSING")
                {
                    Order_Progress_Form progressForm = new Order_Progress_Form(order);
                    progressForm.Show();
                }

                if (order.orderStatus == "CANCELLED")
                {
                    MessageBox.Show("Cannot process a Cancelled Order!");
                }
                if (order.orderStatus == "ESTIMATED")
                {
                    MessageBox.Show("Order needs to be accepted by Customer!");
                }

            }
        }

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            DataTable dt = orderService.getOrders();
            BindingSource bs = new BindingSource();

            bs.DataSource = dt;
            dataGridView1.DataSource = bs;
            
           
        }
    }
}
