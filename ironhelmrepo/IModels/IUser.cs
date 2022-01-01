using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ironhelmrepo.IModels
{
    public interface IUser
    {
        DataTable getUserByLoginId(string username, string passwordr);
    }
}
