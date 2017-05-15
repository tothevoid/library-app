﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    // Supported types: XML, SQL;

    interface IDataLoader
    {
        void AddNewUser(string fn, string ln, string log, string pass, int? ph, int? pid, int? ps);
        void CreateNew();
    }
}
