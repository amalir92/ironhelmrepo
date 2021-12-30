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
        int orderId_ = 0;
        string clientId_;
        public Order_Lines_Form(int orderId,string clientId)
        {
            InitializeComponent();
            this.orderId_ = orderId;
            this.clientId_ = clientId;
            presenter = new OrderLinesPresenter(this);
        }

        public int orderId 
        {
            get { return this.orderId_; }
            set {  }
        }
        public string clientId
        {
            get { return this.clientId_; }
            set { }
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
