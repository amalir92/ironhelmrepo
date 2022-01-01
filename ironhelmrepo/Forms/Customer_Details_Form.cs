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

namespace Iron_helm_order_mgt.Forms
{
    public partial class Customer_Details_Form : Form, ICustomerDetailsView
    {
        private String clientId;
        private ClientDetailsPresenter presenter = null;
        private ICustomer customer;
        string ICustomerDetailsView.clientId
        {
            get { return this.clientId; }
            set { }
        }
        public Customer_Details_Form(string clientId)
        {
            InitializeComponent();
            this.clientId = clientId;
            this.customer = new Customer(clientId);
            presenter = new ClientDetailsPresenter(this,customer);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Customer_Details_Form_Load(object sender, EventArgs e)
        {
            DataTable dt = presenter.getCustomerDetailsById();
            dataGridView1.DataSource = dt;
        }
    }
}
