using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Iron_helm_order_mgt.Entities;

namespace Iron_helm_order_mgt.DAL
{
    public class UserDAL
    {
        IronHelmDbContext context;

        public UserDAL()
        {
            this.context = new IronHelmDbContext();
        }

        public DataTable loginByUserNameAndPassword(string username, string password)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("userId", typeof(string));
            dt.Columns.Add("userType", typeof(string));
            var query = from user in context.Users.AsEnumerable()
                        where user.userId == username
                        select dt.LoadDataRow(new object[] {
                            user.userId,
                            user.userType
                            }, false);
            query.CopyToDataTable();


            return dt;
        }
    }
}
