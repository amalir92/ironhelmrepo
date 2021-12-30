using Iron_helm_order_mgt.Controls;
using Iron_helm_order_mgt.Forms;
using ironhelmrepo.Presenters;
using ironhelmrepo.Views;
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
    public partial class ClientPortal_Frm : Form, IClientPortalView
    {
        String username;
        private ClientPortalPresenter presenter = null;
        private ApplicationState state = null;
        public string clientId
        {
            get { return username; }
            set { username = value; }
        }
        public string orderStatus
        {
            get { return OrderDataGrid.SelectedRows[0].Cells["Order Status"].Value.ToString(); }
            set { }
        }
        public int orderId
        {
            get { return Convert.ToInt32(OrderDataGrid.SelectedRows[0].Cells["Order Id"].Value); }
            set { }
        }

        public ClientPortal_Frm(String clientId)
        {
            InitializeComponent();
            this.username = clientId;

            presenter = new ClientPortalPresenter(this);
            
        }


        private void create_order_btn_Click(object sender, EventArgs e)
        {
            Create_Order_Form createOrderFrm = new Create_Order_Form(username);
            createOrderFrm.Show();
        }

        private void ClientPortal_Frm_Load(object sender, EventArgs e)
        {

            OrderDataGrid.DataSource = presenter.DisplayClientOrderData();
            OrderDataGrid.Columns.Add(new DataGridViewButtonColumn()
            {
                Text = "View Order Lines",
                UseColumnTextForButtonValue = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None
            });

        }


        private void calcel_order_btn_Click(object sender, EventArgs e)
        {
            string status = presenter.CancelOrder();
            if (status.Equals("SUCCESS"))
            {
                MessageBox.Show("Order cancelled succesfully");
                OrderDataGrid.DataSource = presenter.DisplayClientOrderData();
            }
            else
            {
                MessageBox.Show("Order cannot be cancelled at this stage");
            }


        }

        private void accept_order_btn_Click(object sender, EventArgs e)
        {
            string status = presenter.AcceptOrder();
            if (status.Equals("SUCCESS"))
            {
                MessageBox.Show("Order accepted succesfully");
                OrderDataGrid.DataSource = presenter.DisplayClientOrderData();
            }
            else
            {
                MessageBox.Show("Order cannot be accepted at this stage");
            }
        }

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            OrderDataGrid.DataSource = presenter.DisplayClientOrderData();
            this.state = ApplicationState.getState();
            foreach (DataGridViewRow row in OrderDataGrid.Rows)
            {

                if (state.orderStatuses.ContainsKey(Convert.ToInt32(row.Cells["Order Id"].Value)))
                {
                    row.Cells["Order Status"].Value = state.orderStatuses[Convert.ToInt32(row.Cells["Order Id"].Value)];
                }

            }
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
