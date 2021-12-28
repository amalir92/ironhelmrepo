using Iron_helm_order_mgt.Controls;
using Iron_helm_order_mgt.DAL;
using ironhelmrepo.Views;
using System.Data;


namespace ironhelmrepo.Presenters
{
    public class LoginPresenter
    {
        private readonly ILoginView loginView;
        private UserDAL userDal;

        public LoginPresenter(ILoginView loginView)
        {
            this.loginView = loginView;
            userDal = new UserDAL();

        }
        public DataTable getUserByLoginId()
        {
            DataTable dt = userDal.loginByUserNameAndPassword(loginView.username,loginView.password);
            return dt;
        }

        public void getStateInfo()
        {
            ApplicationState state = ApplicationState.getState();
            state.userId = loginView.username;
        }
    }
}
