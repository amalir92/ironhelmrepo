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
    public partial class Schedule_Order_Form : Form
    {
        private OrderService orderService;
        private Order order;
        public Schedule_Order_Form(Order order)
        {
            InitializeComponent();
            this.orderService = new OrderService();
            this.order = order;
        }

        private void ok_btn_Click(object sender, EventArgs e)
        {
            string status = orderService.scheduleOrder(order.orderStatus, order.orderId);
            if (status.Equals("SUCCESS"))
            {
                MessageBox.Show("Order scheduled succesfully");
                
            }
            else
            {
                MessageBox.Show("Order cannot be scheduled at this stage");
            }
            Hide();
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
