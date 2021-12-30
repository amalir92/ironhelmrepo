
namespace Iron_helm_order_mgt.Forms
{
    partial class Order_Progress_Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.start_btn = new System.Windows.Forms.Button();
            this.finish_btn = new System.Windows.Forms.Button();
            this.order_txt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Order in Production";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Order Progress";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(54, 131);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(457, 23);
            this.progressBar1.TabIndex = 2;
            // 
            // start_btn
            // 
            this.start_btn.Location = new System.Drawing.Point(54, 63);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(75, 23);
            this.start_btn.TabIndex = 3;
            this.start_btn.Text = "Start";
            this.start_btn.UseVisualStyleBackColor = true;
            this.start_btn.Click += new System.EventHandler(this.start_btn_Click);
            // 
            // finish_btn
            // 
            this.finish_btn.Location = new System.Drawing.Point(54, 170);
            this.finish_btn.Name = "finish_btn";
            this.finish_btn.Size = new System.Drawing.Size(75, 23);
            this.finish_btn.TabIndex = 4;
            this.finish_btn.Text = "Finish";
            this.finish_btn.UseVisualStyleBackColor = true;
            this.finish_btn.Click += new System.EventHandler(this.finish_btn_Click);
            // 
            // order_txt
            // 
            this.order_txt.Location = new System.Drawing.Point(156, 29);
            this.order_txt.Name = "order_txt";
            this.order_txt.Size = new System.Drawing.Size(100, 20);
            this.order_txt.TabIndex = 5;
            // 
            // Order_Progress_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 222);
            this.Controls.Add(this.order_txt);
            this.Controls.Add(this.finish_btn);
            this.Controls.Add(this.start_btn);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Order_Progress_Form";
            this.Text = "Order Progress Form";
            this.Load += new System.EventHandler(this.Order_Progress_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button start_btn;
        private System.Windows.Forms.Button finish_btn;
        private System.Windows.Forms.TextBox order_txt;
    }
}