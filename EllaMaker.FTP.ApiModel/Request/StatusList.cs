﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EllaMaker.Api.Request
{
    public class StatusList
    {
        public List<string> UserList { get; set; } = new List<string>();

        public List<string> DeptList { get; set; } = new List<string>();
    }
}
