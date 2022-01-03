using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * This singleton class implementatin referenced from https://www.c-sharpcorner.com/UploadFile/8911c4/singleton-design-pattern-in-C-Sharp/
 */
namespace Iron_helm_order_mgt.Controls
{
    public class ApplicationState
    {
        private static ApplicationState instance = null;

        public string userId { get; set; }

        public Dictionary<int,Order> orderStatuses { get; set; }

        private ApplicationState() { }

        private static object lockThis = new object();
        public static ApplicationState getState()
        {
            lock (lockThis)
            {
                if (ApplicationState.instance == null)
                {
                    instance = new ApplicationState();
                    instance.orderStatuses= new Dictionary<int, Order>();
                }
                return instance;
            }
        }
    }
}
