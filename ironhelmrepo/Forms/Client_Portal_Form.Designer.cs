
namespace Iron_helm_order_mgt
{
    partial class ClientPortal_Frm
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
            this.create_order_btn = new System.Windows.Forms.Button();
            this.OrderDataGrid = new System.Windows.Forms.DataGridView();
            this.calcel_order_btn = new System.Windows.Forms.Button();
            this.accept_order_btn = new System.Windows.Forms.Button();
            this.refresh_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // create_order_btn
            // 
            this.create_order_btn.Location = new System.Drawing.Point(12, 40);
            this.create_order_btn.Name = "create_order_btn";
            this.create_order_btn.Size = new System.Drawing.Size(111, 30);
            this.create_order_btn.TabIndex = 0;
            this.create_order_btn.Text = "Create New Order";
            this.create_order_btn.UseVisualStyleBackColor = true;
            this.create_order_btn.Click += new System.EventHandler(this.create_order_btn_Click);
            // 
            // OrderDataGrid
            // 
            this.OrderDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderDataGrid.Location = new System.Drawing.Point(12, 76);
            this.OrderDataGrid.Name = "OrderDataGrid";
            this.OrderDataGrid.Size = new System.Drawing.Size(754, 375);
            this.OrderDataGrid.TabIndex = 6;
            this.OrderDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OrderDataGrid_CellContentClick);
            // 
            // calcel_order_btn
            // 
            this.calcel_order_btn.Location = new System.Drawing.Point(12, 472);
            this.calcel_order_btn.Name = "calcel_order_btn";
            this.calcel_order_btn.Size = new System.Drawing.Size(111, 30);
            this.calcel_order_btn.TabIndex = 3;
            this.calcel_order_btn.Text = "Cancel Order";
            this.calcel_order_btn.UseVisualStyleBackColor = true;
            this.calcel_order_btn.Click += new System.EventHandler(this.calcel_order_btn_Click);
            // 
            // accept_order_btn
            // 
            this.accept_order_btn.Location = new System.Drawing.Point(129, 472);
            this.accept_order_btn.Name = "accept_order_btn";
            this.accept_order_btn.Size = new System.Drawing.Size(111, 30);
            this.accept_order_btn.TabIndex = 4;
            this.accept_order_btn.Text = "Accept Order";
            this.accept_order_btn.UseVisualStyleBackColor = true;
            this.accept_order_btn.Click += new System.EventHandler(this.accept_order_btn_Click);
            // 
            // refresh_btn
            // 
            this.refresh_btn.Location = new System.Drawing.Point(129, 40);
            this.refresh_btn.Name = "refresh_btn";
            this.refresh_btn.Size = new System.Drawing.Size(85, 30);
            this.refresh_btn.TabIndex = 5;
            this.refresh_btn.Text = "Refresh";
            this.refresh_btn.UseVisualStyleBackColor = true;
            this.refresh_btn.Click += new System.EventHandler(this.refresh_btn_Click);
            // 
            // ClientPortal_Frm
            // 
            this.ClientSize = new System.Drawing.Size(786, 557);
            this.Controls.Add(this.refresh_btn);
            this.Controls.Add(this.accept_order_btn);
            this.Controls.Add(this.calcel_order_btn);
            this.Controls.Add(this.OrderDataGrid);
            this.Controls.Add(this.create_order_btn);
            this.Name = "ClientPortal_Frm";
            this.Text = "Client Portal";
            this.Load += new System.EventHandler(this.ClientPortal_Frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OrderDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button create_order_btn;
        private System.Windows.Forms.DataGridView OrderDataGrid;
        private System.Windows.Forms.Button calcel_order_btn;
        private System.Windows.Forms.Button accept_order_btn;
        private System.Windows.Forms.Button refresh_btn;
    }
}