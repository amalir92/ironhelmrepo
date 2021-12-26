using Iron_helm_order_mgt.Service;
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
    public partial class Create_Order_Form : Form
    {
        private ProductService productService;
        private OrderService orderService;
        private OrderLineItemService orderLineItemService;
        DataTable dt = new DataTable();
        private BindingSource bindingSource1 = new BindingSource();
        String clientId;

        public Create_Order_Form(String clientId)
        {
            productService = new ProductService();
            orderService = new OrderService();
            InitializeComponent();
            this.clientId = clientId;
        }

        private void Create_Order_Form_Load(object sender, EventArgs e)
        {
            load_products();

            dt.Columns.Add("Product Code");
            dt.Columns.Add("Quantity");


        }

        private void load_products()
        {
            DataTable da=productService.getAllProducts();
            //da.Rows.Add("Select Product");
            //set the combobox datasource 
            product_cmb.DataSource = da;
            product_cmb.DisplayMember = "productName";
            product_cmb.ValueMember = "productId";
            //product_cmb.SelectedValue = "Select Product";

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
                //DateTime expectedDate = dateTimePicker1.Value;

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
            string StrQuery;
            List<OrderLineItem> lines = new List<OrderLineItem>();
            OrderStatus n = OrderStatus.NEW;
            DateTime expectedDate = dateTimePicker1.Value;
            if (dataGridView1.Rows.Count  == 0)
            {
                MessageBox.Show("Add an Order to submit!");
            }
            else
            {
                
                for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
                {
                    OrderLineItem item = new OrderLineItem();
                    item.quantity = Convert.ToInt32(dataGridView1.Rows[i].Cells["Quantity"].Value);
                    //ProductCatalog p = productService.getProductById();
                   
                    item.productCode= dataGridView1.Rows[i].Cells["Product Code"].Value.ToString();
                    lines.Add(item);
                }
                int orderId = orderService.createOrder(clientId, expectedDate,lines);
                MessageBox.Show("Order Submitted Successfully");
                this.Hide();
              }
                    
        }

        
       
    }
    }

