﻿using Auth.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auth.Interfaces
{
    interface IAuthProvider
    {
        bool Authenticate(string userName, string password);
    }
}
