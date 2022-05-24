﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileConfig.UIApiClient.HttpResults
{
    public class LoginResult:TokenResult
    {

        public List<string> CurrentAuthority { get; set; }
        public List<string> CurrentFunctions { get; set; }
    }
}
