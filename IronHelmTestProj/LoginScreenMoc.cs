using ironhelmrepo.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IronHelmTest
{
    public class LoginScreenMoc : ILoginView
    {
        public string username { get; set; } 
        public string password { get; set; } 
    }
}
