﻿using System;
using System.Collections.Generic;
using System.Text;

namespace myHomework._17HelpModel
{
    [Flags]
    public enum Token
    {
        SuperAdmin = 1,
        Admin = 2,
        Blogger = 4,
        Newbie = 8,
        Registered = 16
    }
}
