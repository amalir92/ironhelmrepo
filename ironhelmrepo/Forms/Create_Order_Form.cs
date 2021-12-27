using Iron_helm_order_mgt.Service;
using ironhelmrepo.Presenters;
using ironhelmrepo.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Iron_helm_order_mgt
{
    public partial class Create_Order_Form : Form,ICreateOrderView
    {
        String clientId;
        private CreateOrderPresenter presenter = null;
        DataTable dt = new DataTable();

        List<OrderLineItem> lines = new List<OrderLineItem>();

        string ICreateOrderView.clientId
        { 
            get { return clientId; }
            set { }
        }

        public DateTime expectedOrderCompletionDate 
        { 
            get { return dateTimePicker1.Value; }
            set { dateTimePicker1.Value = expectedOrderCompletionDate; }
        }
        public List<OrderLineItem> orderLines
        {
            get
            {
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    OrderLineItem item = new OrderLineItem();
                    item.quantity = Convert.ToInt32(dataGridView1.Rows[i].Cells["Quantity"].Value);
                    //ProductCatalog p = productService.getProductById();
                    item.productCode = dataGridView1.Rows[i].Cells["Product Code"].Value.ToString();
                    lines.Add(item);
                }
                return lines;
            }
            set { }
        }

        public Create_Order_Form(String clientId)
        {
            InitializeComponent();
            this.clientId = clientId;
            presenter = new CreateOrderPresenter(this);
        }

        private void Create_Order_Form_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("Product Code");
            dt.Columns.Add("Quantity");
            load_products();
        }

        private void load_products()
        {
            DataTable da = presenter.getAllProducts();
            product_cmb.DataSource = da;
            product_cmb.DisplayMember = "productName";
            product_cmb.ValueMember = "productId";
        }

        private void add_order_btn_Click(object sender, EventArgs e)
        {
            DataRowView oDataRowView = product_cmb.SelectedItem as DataRowView;
            string product_code = "";

            if (oDataRowView != null)
            {
                product_code = oDataRowView.Row["productId"] as string;
            }
                int quantity = int.Parse(quantity_txt.Text);
                dt.Rows.Add(product_code, quantity);
                dataGridView1.DataSource = dt;            
        }

        private void delete_order_btn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(row.Index);
            }
        }

        private void submit_order_btn_Click(object sender, EventArgs e)
        {

            DateTime expectedDate = dateTimePicker1.Value;
            if (dataGridView1.Rows.Count  == 0)
            {
                MessageBox.Show("Add an Order to submit!");
            }
            else
            {              
                int orderId =presenter.createOrder();
                MessageBox.Show("Order Submitted Successfully");
                this.Hide();
             }
                    
        }

        
       
    }
    }

