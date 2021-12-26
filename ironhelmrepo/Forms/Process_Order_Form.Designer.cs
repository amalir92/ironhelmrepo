
namespace Iron_helm_order_mgt.Forms
{
    partial class Process_Order_Form
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.order_lbl = new System.Windows.Forms.Label();
            this.next_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 86);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(729, 75);
            this.dataGridView1.TabIndex = 0;
            // 
            // order_lbl
            // 
            this.order_lbl.AutoSize = true;
            this.order_lbl.Location = new System.Drawing.Point(12, 59);
            this.order_lbl.Name = "order_lbl";
            this.order_lbl.Size = new System.Drawing.Size(68, 13);
            this.order_lbl.TabIndex = 1;
            this.order_lbl.Text = "Order Details";
            // 
            // next_btn
            // 
            this.next_btn.Location = new System.Drawing.Point(12, 178);
            this.next_btn.Name = "next_btn";
            this.next_btn.Size = new System.Drawing.Size(88, 23);
            this.next_btn.TabIndex = 2;
            this.next_btn.Text = "Estimate Order";
            this.next_btn.UseVisualStyleBackColor = true;
            this.next_btn.Click += new System.EventHandler(this.next_btn_Click);
            // 
            // Process_Order_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 261);
            this.Controls.Add(this.next_btn);
            this.Controls.Add(this.order_lbl);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Process_Order_Form";
            this.Text = "Process Order";
            this.Load += new System.EventHandler(this.Process_Order_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label order_lbl;
        private System.Windows.Forms.Button next_btn;
    }
}