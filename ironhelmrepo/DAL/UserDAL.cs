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
       
        public DataTable loginByUserNameAndPassword(string username,string password)
        {
            using (var context = new IronHelmDbContext())
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("userId", typeof(string));
                dt.Columns.Add("userType", typeof(string));
                var query = from user in context.Users.AsEnumerable().ToList()
                            where user.userId == username
                            && user.password == password
                            select dt.LoadDataRow(new object[] {
                            user.userId,
                            user.userType
                            }, false);
                if (query != null && query.Any())
                {
                    query?.CopyToDataTable();
                }


                return dt;
            }
        }
    }
}
