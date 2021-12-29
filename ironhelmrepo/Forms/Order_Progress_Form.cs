using Iron_helm_order_mgt.Entities;
using Iron_helm_order_mgt.Factory;

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
    public partial class Order_Progress_Form : Form,IProcessOrderView
    {
        private Order order;
        private ProcessOrderPresenter presenter = null;

        Order IProcessOrderView.order
        {
            get { return order; }
            set { }
        }

        public Order_Progress_Form(Order order)
        {
            InitializeComponent();
            this.order = order;
            order_txt.Text = order.orderId.ToString();
            order_txt.Enabled = false;
            presenter = new ProcessOrderPresenter(this);
        }

        public void order_process()
        {
            presenter.initiateProduction();
        }

        private void start_btn_Click(object sender, EventArgs e)
        {
            string factory= presenter.progressOrder();
            MessageBox.Show("Order Production Started in "+factory+"... check the console for produced items and completed services");
            progressBar1.Value = 3;
            order_process();
            progressBar1.Value = 100;

            presenter.completeOrder();
            MessageBox.Show("Order completed!");
        }

        private void finish_btn_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void Order_Progress_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
