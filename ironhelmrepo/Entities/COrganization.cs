using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iron_helm_order_mgt
{
    public class COrganization : Customer
    {
        public COrganization() { }
        public COrganization(string companyName, string industryType, string contactPersonName, string corpAccDetails)
        { 
            this.companyName = companyName;
            this.industryType = industryType;
            this.contactPersonName = contactPersonName;
            this.corpAccDetails = corpAccDetails;
        }

        public String companyName { get; set; }
        public String industryType { get; set; }
        public String contactPersonName { get; set; }

        public String corpAccDetails { get; set; }


    }
}
