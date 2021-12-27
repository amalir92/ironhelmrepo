﻿using Iron_helm_order_mgt.Controls;
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
    public partial class Login_frm : Form, ILoginView
    {
        private LoginPresenter presenter = null;


        string ILoginView.username { get { return username.Text; } set { } }
        string ILoginView.password { get { return password.Text; } set { } }

        public Login_frm()
        {
            InitializeComponent();
            password.PasswordChar = '*';
            presenter = new LoginPresenter(this);
            getStateInfo();
        }

        private void initalize_dbTables()
        {
            DatabaseInitializer.databaseInitialize();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            DataTable dt = presenter.getUserByLoginId();
            if (dt.Rows.Count == 1)
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

        private void getStateInfo()
        {
            presenter.getStateInfo();
        }
    }

}