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
    public partial class Schedule_Order_Form : Form,IProcessOrderView
    {
        private Order order;
        private ProcessOrderPresenter presenter = null;

        Order IProcessOrderView.order
        {
            get { return order; }
            set { }
        }

        public Schedule_Order_Form(Order order)
        {
            InitializeComponent();
            this.order = order;
            presenter = new ProcessOrderPresenter(this);
        }

        private void ok_btn_Click(object sender, EventArgs e)
        {
            string status = presenter.scheduleOrder();
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
