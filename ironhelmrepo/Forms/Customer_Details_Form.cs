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
    public partial class Customer_Details_Form : Form
    {
        private String clientId;
        private CustomerService customerService;
        public Customer_Details_Form(string clientId)
        {
            InitializeComponent();
            this.clientId = clientId;
            this.customerService = new CustomerService();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Customer_Details_Form_Load(object sender, EventArgs e)
        {
            DataTable dt = customerService.getCustomerDetailsById(clientId);
            dataGridView1.DataSource = dt;
        }
    }
}
