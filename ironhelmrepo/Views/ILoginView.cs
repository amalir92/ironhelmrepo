﻿using ironhelmrepo.Presenters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ironhelmrepo.Views
{
    public interface ILoginView
    {
        string username { get; set; }
        string password { get; set; }
    }
}
