using Iron_helm_order_mgt.Forms;
using Iron_helm_order_mgt.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Iron_helm_order_mgt
{
    public partial class ClientPortal_Frm : Form
    {
        String username;
        SqlDataAdapter dataAdapter;
        SqlCommand cmd;
        private OrderService orderService;
        private OrderLineItemService orderLineItemService;

        public ClientPortal_Frm(String clientId)
        {
            InitializeComponent();
            this.username = clientId;
            orderService = new OrderService();
            orderLineItemService = new OrderLineItemService();
        }


        private void create_order_btn_Click(object sender, EventArgs e)
        {
            Create_Order_Form createOrderFrm = new Create_Order_Form(username);
            createOrderFrm.Show();
        }

        private void ClientPortal_Frm_Load(object sender, EventArgs e)
        {

            DisplayData();
            OrderDataGrid.Columns.Add(new DataGridViewButtonColumn()
            {
                Text = "View Order Lines",
                //Tag = (Action<Order>)ClickHandler,
                UseColumnTextForButtonValue = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None
            });

        }

        public void ClickHandler(Order order)
        {
            MessageBox.Show($"Hi {order.orderId}");
        }
        private void DisplayData()
        {
            DataTable dt=orderService.getCustomerByUseId(username);
            
            OrderDataGrid.DataSource = dt;
           

        }

        private void calcel_order_btn_Click(object sender, EventArgs e)
        {
             foreach (DataGridViewRow row in OrderDataGrid.SelectedRows)
             {
                string status=orderService.cancelOrder(row.Cells["Order Status"].Value.ToString(),Convert.ToInt32(row.Cells["Order Id"].Value));
                if (status.Equals("SUCCESS"))
                {
                    MessageBox.Show("Order cancelled succesfully");
                    DisplayData();
                }
                else
                {
                    MessageBox.Show("Order cannot be cancelled at this stage");
                }
             }
            
        }

        private void accept_order_btn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in OrderDataGrid.SelectedRows)
            {
                    string status = orderService.acceptOrder(row.Cells["Order Status"].Value.ToString(), Convert.ToInt32(row.Cells["Order Id"].Value));
                    if (status.Equals("SUCCESS"))
                    {
                        MessageBox.Show("Order accepted succesfully");
                        DisplayData();
                    }
                    else
                    {
                        MessageBox.Show("Order cannot be accepted at this stage");
                    }
                
            }
            
        }

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void OrderDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                int orderId = Convert.ToInt32(OrderDataGrid.CurrentRow.Cells["Order Id"].FormattedValue);
                Order_Lines_Form orderLinesFrm = new Order_Lines_Form(orderId);
                orderLinesFrm.Show();
            }

        }
    }
}
