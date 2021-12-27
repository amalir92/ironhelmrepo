
namespace Iron_helm_order_mgt.Forms
{
    partial class Order_Lines_Form
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
            this.orderNo = new System.Windows.Forms.TextBox();
            this.order_lbl = new System.Windows.Forms.Label();
            this.orderLinesGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.orderLinesGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // orderNo
            // 
            this.orderNo.Location = new System.Drawing.Point(72, 29);
            this.orderNo.Name = "orderNo";
            this.orderNo.Size = new System.Drawing.Size(100, 20);
            this.orderNo.TabIndex = 0;
            // 
            // order_lbl
            // 
            this.order_lbl.AutoSize = true;
            this.order_lbl.Location = new System.Drawing.Point(12, 32);
            this.order_lbl.Name = "order_lbl";
            this.order_lbl.Size = new System.Drawing.Size(50, 13);
            this.order_lbl.TabIndex = 1;
            this.order_lbl.Text = "Order No";
            // 
            // orderLinesGrid
            // 
            this.orderLinesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderLinesGrid.Location = new System.Drawing.Point(12, 67);
            this.orderLinesGrid.Name = "orderLinesGrid";
            this.orderLinesGrid.Size = new System.Drawing.Size(385, 313);
            this.orderLinesGrid.TabIndex = 2;
            // 
            // Order_Lines_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 405);
            this.Controls.Add(this.orderLinesGrid);
            this.Controls.Add(this.order_lbl);
            this.Controls.Add(this.orderNo);
            this.Name = "Order_Lines_Form";
            this.Text = "Order Lines Form";
            this.Load += new System.EventHandler(this.Order_Lines_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orderLinesGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox orderNo;
        private System.Windows.Forms.Label order_lbl;
        private System.Windows.Forms.DataGridView orderLinesGrid;
    }
}