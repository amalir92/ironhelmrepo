
namespace Iron_helm_order_mgt.Forms
{
    partial class Estimate_Order_Form
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
            this.ok_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.schedule_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.products_cmb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.hours_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cost_txt = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.deliveryCost_txt = new System.Windows.Forms.TextBox();
            this.packagingCost_txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.totalCost_txt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ok_btn
            // 
            this.ok_btn.Location = new System.Drawing.Point(9, 504);
            this.ok_btn.Name = "ok_btn";
            this.ok_btn.Size = new System.Drawing.Size(75, 23);
            this.ok_btn.TabIndex = 3;
            this.ok_btn.Text = "Add";
            this.ok_btn.UseVisualStyleBackColor = true;
            this.ok_btn.Click += new System.EventHandler(this.ok_btn_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.Location = new System.Drawing.Point(90, 504);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(75, 23);
            this.cancel_btn.TabIndex = 4;
            this.cancel_btn.Text = "Clear";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // schedule_btn
            // 
            this.schedule_btn.Location = new System.Drawing.Point(274, 504);
            this.schedule_btn.Name = "schedule_btn";
            this.schedule_btn.Size = new System.Drawing.Size(97, 23);
            this.schedule_btn.TabIndex = 5;
            this.schedule_btn.Text = "Submit Order";
            this.schedule_btn.UseVisualStyleBackColor = true;
            this.schedule_btn.Click += new System.EventHandler(this.schedule_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Order Product and Quantity";
            // 
            // products_cmb
            // 
            this.products_cmb.FormattingEnabled = true;
            this.products_cmb.Location = new System.Drawing.Point(160, 39);
            this.products_cmb.Name = "products_cmb";
            this.products_cmb.Size = new System.Drawing.Size(159, 21);
            this.products_cmb.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Number of Labour Hours";
            // 
            // hours_txt
            // 
            this.hours_txt.Location = new System.Drawing.Point(160, 74);
            this.hours_txt.Name = "hours_txt";
            this.hours_txt.Size = new System.Drawing.Size(100, 20);
            this.hours_txt.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Cost per Hour";
            // 
            // cost_txt
            // 
            this.cost_txt.Location = new System.Drawing.Point(160, 109);
            this.cost_txt.Name = "cost_txt";
            this.cost_txt.Size = new System.Drawing.Size(100, 20);
            this.cost_txt.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 135);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(356, 223);
            this.dataGridView1.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 377);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Delivery Cost";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 404);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Packaging Cost";
            // 
            // deliveryCost_txt
            // 
            this.deliveryCost_txt.Location = new System.Drawing.Point(160, 374);
            this.deliveryCost_txt.Name = "deliveryCost_txt";
            this.deliveryCost_txt.Size = new System.Drawing.Size(100, 20);
            this.deliveryCost_txt.TabIndex = 15;
            // 
            // packagingCost_txt
            // 
            this.packagingCost_txt.Location = new System.Drawing.Point(160, 401);
            this.packagingCost_txt.Name = "packagingCost_txt";
            this.packagingCost_txt.Size = new System.Drawing.Size(100, 20);
            this.packagingCost_txt.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 433);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Total Cost";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 463);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Estimated Completion Date";
            // 
            // totalCost_txt
            // 
            this.totalCost_txt.Location = new System.Drawing.Point(160, 430);
            this.totalCost_txt.Name = "totalCost_txt";
            this.totalCost_txt.Size = new System.Drawing.Size(100, 20);
            this.totalCost_txt.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(171, 504);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "Estimate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(160, 457);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 22;
            // 
            // Estimate_Order_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 539);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.totalCost_txt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.packagingCost_txt);
            this.Controls.Add(this.deliveryCost_txt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cost_txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.hours_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.products_cmb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.schedule_btn);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.ok_btn);
            this.Name = "Estimate_Order_Form";
            this.Text = "Estimate Order";
            this.Load += new System.EventHandler(this.Estimate_Order_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ok_btn;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Button schedule_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox products_cmb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox hours_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cost_txt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox deliveryCost_txt;
        private System.Windows.Forms.TextBox packagingCost_txt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox totalCost_txt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}