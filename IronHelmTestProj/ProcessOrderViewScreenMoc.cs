﻿using ironhelmrepo.IModels;
using ironhelmrepo.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IronHelmTestProj
{
    class ProcessOrderViewScreenMoc : IProcessOrderView
    {
        public IOrder order { get ; set ; }
    }
}
