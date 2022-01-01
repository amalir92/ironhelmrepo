using Iron_helm_order_mgt.Controls;
using Iron_helm_order_mgt.Forms;
using ironhelmrepo.IModels;
using ironhelmrepo.Presenters;
using ironhelmrepo.Views;
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
    public partial class Admin_Portal_Frm : Form, IPortalView
    {

        private AdminPortalPresenter presenter = null;
        private IOrder order;
        private ApplicationState state = null;

        public int orderId
        {
            get { return Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Order Id"].Value); }
            set { }
        }

        public string clientId
        {
            get { return dataGridView1.SelectedRows[0].Cells["Client Id"].Value.ToString(); }
            set { }
        }

        public string orderStatus
        {
            get { return dataGridView1.SelectedRows[0].Cells["Order Status"].Value.ToString(); }
            set { }
        }

        public Admin_Portal_Frm()
        {
            InitializeComponent();
            order = new Order();
            presenter = new AdminPortalPresenter(this,order);
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
            DisplayData();
            dataGridView1.Columns.Add(new DataGridViewButtonColumn()
            {
                Text = "View Client Source",
                //Tag = (Action<Order>)ClickHandler,
                UseColumnTextForButtonValue = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None
            });
        }

        private void process_btn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                Order order = presenter.getOrderById();
                if (orderStatus == "NEW")
                {
                    
                    Estimate_Order_Form estimateForm = new Estimate_Order_Form(order);
                    estimateForm.Show();
                }
                if (orderStatus == "ACCEPTED")
                {
                    Schedule_Order_Form sceduleOrderForm = new Schedule_Order_Form(order);
                    sceduleOrderForm.Show();
                }

                if (orderStatus == "SCHEDULED" || orderStatus == "PROGRESSING")
                {
                    Order_Progress_Form progressForm = new Order_Progress_Form(order);
                    progressForm.Show();
                }

                if (orderStatus == "CANCELLED")
                {
                    MessageBox.Show("Cannot process a Cancelled Order!");
                }
                if (orderStatus == "ESTIMATED")
                {
                    MessageBox.Show("Order needs to be accepted by Customer!");
                }

            }
        }

        private void DisplayData()
        {
            DataTable dt = presenter.DisplayAllOrderData();
            dataGridView1.DataSource = dt;
            

        }

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = null;
            //dataGridView1.Update();
            //dataGridView1.Refresh();
            DisplayData();
            this.state = ApplicationState.getState();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {

                if (state.orderStatuses.ContainsKey(Convert.ToInt32(row.Cells["Order Id"].Value)))
                {
                    row.Cells["Order Status"].Value = state.orderStatuses[Convert.ToInt32(row.Cells["Order Id"].Value)].orderStatus;
                    row.Cells["Order Status Changed Date"].Value = state.orderStatuses[Convert.ToInt32(row.Cells["Order Id"].Value)].orderStatusChangedDate;
                    row.Cells["Estimated Order Completion Date"].Value = state.orderStatuses[Convert.ToInt32(row.Cells["Order Id"].Value)].estimatedCompletionDate;
                    row.Cells["Total Cost"].Value = state.orderStatuses[Convert.ToInt32(row.Cells["Order Id"].Value)].TotalOrderPrice;
                }

            }


        }
    }
}
