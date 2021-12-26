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
    public partial class Order_Lines_Form : Form
    {
        int orderTxt = 0;
        private OrderLineItemService orderLineItemService;
        public Order_Lines_Form(int orderId)
        {
            InitializeComponent();
            this.orderTxt = orderId;
            orderLineItemService = new OrderLineItemService();
        }

        private void Order_Lines_Form_Load(object sender, EventArgs e)
        {
            orderNo.Text = orderTxt.ToString();
            orderNo.Enabled = false;
            DataTable da = orderLineItemService.getOrderLinesByOrderId(orderTxt);

            orderLinesGrid.DataSource = da;
        }
    }
}
