using Iron_helm_order_mgt.Controls;
using Iron_helm_order_mgt.Service;
using ironhelmrepo.Views;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ironhelmrepo.Presenters
{
    public class LoginPresenter
    {
        private readonly ILoginView loginView;
        private UserService userService;

        public LoginPresenter(ILoginView loginView)
        {
            this.loginView = loginView;
            userService = new UserService();

        }
        public DataTable getUserByLoginId()
        {
            DataTable dt = userService.getloginByUserNameAndPassword(loginView.username,loginView.password);
            return dt;
        }

        public void getStateInfo()
        {
            ApplicationState state = ApplicationState.getState();
            state.userId = loginView.username;
        }
    }
}
