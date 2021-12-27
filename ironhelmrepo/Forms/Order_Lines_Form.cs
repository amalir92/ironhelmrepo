using Iron_helm_order_mgt.Service;
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

namespace Iron_helm_order_mgt.Forms
{
    public partial class Order_Lines_Form : Form,IOrderLinesView
    {

        private OrderLinesPresenter presenter=null;
        int order_Id = 0;
        public Order_Lines_Form(int orderId)
        {
            InitializeComponent();
            this.order_Id = orderId;
            presenter = new OrderLinesPresenter(this);
        }

        public int orderId 
        {
            get { return order_Id; }
            set {  }
        }

        private void Order_Lines_Form_Load(object sender, EventArgs e)
        { 
            
            orderNo.Text = orderId.ToString();
            orderNo.Enabled = false;
            DataTable da = presenter.getOrderLines();
            orderLinesGrid.DataSource = da;
        }
    }
}
