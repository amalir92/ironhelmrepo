
namespace Iron_helm_order_mgt
{
    partial class Login_frm
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
            this.username_lbl = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.passwod_lbl = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.Login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // username_lbl
            // 
            this.username_lbl.AutoSize = true;
            this.username_lbl.Location = new System.Drawing.Point(57, 54);
            this.username_lbl.Name = "username_lbl";
            this.username_lbl.Size = new System.Drawing.Size(58, 13);
            this.username_lbl.TabIndex = 0;
            this.username_lbl.Text = "User name";
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(145, 51);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(142, 20);
            this.username.TabIndex = 1;
            // 
            // passwod_lbl
            // 
            this.passwod_lbl.AutoSize = true;
            this.passwod_lbl.Location = new System.Drawing.Point(57, 105);
            this.passwod_lbl.Name = "passwod_lbl";
            this.passwod_lbl.Size = new System.Drawing.Size(53, 13);
            this.passwod_lbl.TabIndex = 2;
            this.passwod_lbl.Text = "Password";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(145, 102);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(142, 20);
            this.password.TabIndex = 3;
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(145, 156);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(75, 23);
            this.Login.TabIndex = 4;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // Login_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 223);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.password);
            this.Controls.Add(this.passwod_lbl);
            this.Controls.Add(this.username);
            this.Controls.Add(this.username_lbl);
            this.Name = "Login_frm";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label username_lbl;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label passwod_lbl;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button Login;
    }
}

