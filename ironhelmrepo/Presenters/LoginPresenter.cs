using Iron_helm_order_mgt;
using Iron_helm_order_mgt.Controls;
using Iron_helm_order_mgt.DAL;
using ironhelmrepo.IModels;
using ironhelmrepo.Views;
using System.Data;


namespace ironhelmrepo.Presenters
{
    public class LoginPresenter
    {
        private readonly ILoginView loginView;
        private IUser user;

        public LoginPresenter(ILoginView loginView,IUser user)
        {
            this.loginView = loginView;
            this.user = user;
        }
        
        public DataTable getUserByLoginId()
        {
            return user.getUserByLoginId(loginView.username, loginView.password);
        }
        public void getStateInfo()
        {
            ApplicationState state = ApplicationState.getState();
            state.userId = loginView.username;
        }
    }
}
