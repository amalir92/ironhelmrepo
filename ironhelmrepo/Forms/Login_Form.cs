using Iron_helm_order_mgt.Controls;
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
    public partial class Login_frm : Form
    {
        private UserService userService;
        private string userId;
        private string userType;

        public Login_frm()
        {
            InitializeComponent();
            password.PasswordChar = '*';
           // initalize_dbTables();
            userService = new UserService();
            this.userId = username.Text;
            getStateInfo(userId);
        }

        private void initalize_dbTables()
        {
            DatabaseInitializer.databaseInitialize();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            DataTable dt = userService.getloginByUserNameAndPassword(username.Text, password.Text);
            if (dt.Rows.Count==1)
            {
                this.Hide();
                if (dt.Rows[0][1].ToString() == "Client")
                {
                    new ClientPortal_Frm(username.Text).Show();
                }
                else
                {
                    new Admin_Portal_Frm().Show();
                }
            }
            else
                MessageBox.Show("Invalid username or password");
        }

        private void getStateInfo(String userId)
        {
            ApplicationState state = ApplicationState.getState();
            state.userId = userId;
        }
    }

}