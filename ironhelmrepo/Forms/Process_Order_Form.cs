using Iron_helm_order_mgt.Controls;
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

namespace Iron_helm_order_mgt.Forms
{
    public partial class Process_Order_Form : Form
    {
        private Order order;
        private OrderService orderService;
        

        public Process_Order_Form(Order selectedOrder)
        {
            this.order = selectedOrder;
            this.orderService = new OrderService();
            InitializeComponent();
        }

        private void Process_Order_Form_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
           // int orderId = order.orderId;
           // dt = orderService.getOrderById(orderId);
           // dt.Columns.Add("")
        }

        private void previous_btn_Click(object sender, EventArgs e)
        {

        }

        private void next_btn_Click(object sender, EventArgs e)
        {

        }

    }
}
