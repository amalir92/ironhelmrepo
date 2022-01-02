using Iron_helm_order_mgt.DAL;
using ironhelmrepo.Controls;
using ironhelmrepo.IModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iron_helm_order_mgt
{
    public class User : IUser
    {
        private UserDAL userDal;
        EncryptDecrypt crypto = null;
        public User() {
            crypto = EncryptDecrypt.Instance;
        }

        public User(string username,string password)
        {
            this.userDal = new UserDAL();
            crypto = EncryptDecrypt.Instance;
        }

        [Key]
        public String userId { get; set; }

        public String userType { get; set; }

        public String password { get; set; }

        public DataTable getUserByLoginId(string username,string password)
        {
            password = encryptPassword(password);
            Console.WriteLine(password);
            DataTable dt = this.userDal.loginByUserNameAndPassword(username, password);
            return dt;
        }

        public string encryptPassword(string password)
        {
            return this.crypto.EncryptText(password);
        }

    }

}
