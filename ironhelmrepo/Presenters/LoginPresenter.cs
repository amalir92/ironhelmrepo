using Iron_helm_order_mgt;
using Iron_helm_order_mgt.Controls;
using Iron_helm_order_mgt.DAL;
using ironhelmrepo.Views;
using System.Data;


namespace ironhelmrepo.Presenters
{
    public class LoginPresenter
    {
        private readonly ILoginView loginView;
        private User user;

        public LoginPresenter(ILoginView loginView)
        {
            this.loginView = loginView;
            
        }
        
        public DataTable getUserByLoginId()
        {
            user = new User(loginView.username, loginView.password);
            return user.getUserByLoginId();
        }
        public void getStateInfo()
        {
            ApplicationState state = ApplicationState.getState();
            state.userId = loginView.username;
        }
    }
}
