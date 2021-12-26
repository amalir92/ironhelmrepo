namespace Iron_helm_order_mgt
{
    partial class Create_Order_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.product_lbl = new System.Windows.Forms.Label();
            this.product_cmb = new System.Windows.Forms.ComboBox();
            this.Quantity_lbl = new System.Windows.Forms.Label();
            this.quantity_txt = new System.Windows.Forms.TextBox();
            this.expected_date_lbl = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.add_order_btn = new System.Windows.Forms.Button();
            this.delete_order_btn = new System.Windows.Forms.Button();
            this.submit_order_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // product_lbl
            // 
            this.product_lbl.AutoSize = true;
            this.product_lbl.Location = new System.Drawing.Point(22, 42);
            this.product_lbl.Name = "product_lbl";
            this.product_lbl.Size = new System.Drawing.Size(44, 13);
            this.product_lbl.TabIndex = 0;
            this.product_lbl.Text = "Product";
            // 
            // product_cmb
            // 
            this.product_cmb.FormattingEnabled = true;
            this.product_cmb.Location = new System.Drawing.Point(111, 39);
            this.product_cmb.Name = "product_cmb";
            this.product_cmb.Size = new System.Drawing.Size(121, 21);
            this.product_cmb.TabIndex = 1;
            // 
            // Quantity_lbl
            // 
            this.Quantity_lbl.AutoSize = true;
            this.Quantity_lbl.Location = new System.Drawing.Point(22, 76);
            this.Quantity_lbl.Name = "Quantity_lbl";
            this.Quantity_lbl.Size = new System.Drawing.Size(46, 13);
            this.Quantity_lbl.TabIndex = 2;
            this.Quantity_lbl.Text = "Quantity";
            // 
            // quantity_txt
            // 
            this.quantity_txt.Location = new System.Drawing.Point(111, 73);
            this.quantity_txt.Name = "quantity_txt";
            this.quantity_txt.Size = new System.Drawing.Size(121, 20);
            this.quantity_txt.TabIndex = 3;
            this.quantity_txt.Text = "1";
            // 
            // expected_date_lbl
            // 
            this.expected_date_lbl.AutoSize = true;
            this.expected_date_lbl.Location = new System.Drawing.Point(22, 346);
            this.expected_date_lbl.Name = "expected_date_lbl";
            this.expected_date_lbl.Size = new System.Drawing.Size(131, 13);
            this.expected_date_lbl.TabIndex = 4;
            this.expected_date_lbl.Text = "Expected Completed Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(159, 340);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 140);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(472, 185);
            this.dataGridView1.TabIndex = 6;
            // 
            // add_order_btn
            // 
            this.add_order_btn.Location = new System.Drawing.Point(25, 111);
            this.add_order_btn.Name = "add_order_btn";
            this.add_order_btn.Size = new System.Drawing.Size(90, 23);
            this.add_order_btn.TabIndex = 7;
            this.add_order_btn.Text = "Add Order Item";
            this.add_order_btn.UseVisualStyleBackColor = true;
            this.add_order_btn.Click += new System.EventHandler(this.add_order_btn_Click);
            // 
            // delete_order_btn
            // 
            this.delete_order_btn.Location = new System.Drawing.Point(121, 111);
            this.delete_order_btn.Name = "delete_order_btn";
            this.delete_order_btn.Size = new System.Drawing.Size(98, 23);
            this.delete_order_btn.TabIndex = 8;
            this.delete_order_btn.Text = "Delete Order Item";
            this.delete_order_btn.UseVisualStyleBackColor = true;
            this.delete_order_btn.Click += new System.EventHandler(this.delete_order_btn_Click);
            // 
            // submit_order_btn
            // 
            this.submit_order_btn.Location = new System.Drawing.Point(25, 375);
            this.submit_order_btn.Name = "submit_order_btn";
            this.submit_order_btn.Size = new System.Drawing.Size(121, 23);
            this.submit_order_btn.TabIndex = 9;
            this.submit_order_btn.Text = "Submit Order Inquiry";
            this.submit_order_btn.UseVisualStyleBackColor = true;
            this.submit_order_btn.Click += new System.EventHandler(this.submit_order_btn_Click);
            // 
            // Create_Order_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 479);
            this.Controls.Add(this.submit_order_btn);
            this.Controls.Add(this.delete_order_btn);
            this.Controls.Add(this.add_order_btn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.expected_date_lbl);
            this.Controls.Add(this.quantity_txt);
            this.Controls.Add(this.Quantity_lbl);
            this.Controls.Add(this.product_cmb);
            this.Controls.Add(this.product_lbl);
            this.Name = "Create_Order_Form";
            this.Text = "Order Inquiry Form";
            this.Load += new System.EventHandler(this.Create_Order_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label product_lbl;
        private System.Windows.Forms.ComboBox product_cmb;
        private System.Windows.Forms.Label Quantity_lbl;
        private System.Windows.Forms.TextBox quantity_txt;
        private System.Windows.Forms.Label expected_date_lbl;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button add_order_btn;
        private System.Windows.Forms.Button delete_order_btn;
        private System.Windows.Forms.Button submit_order_btn;
    }
}