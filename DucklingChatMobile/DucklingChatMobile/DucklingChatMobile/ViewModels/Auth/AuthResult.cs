﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DucklingChatMobile.ViewModels.Auth
{
    class AuthResult
    {
        public string Message { get; set; }
        public Dictionary<string, string> JwtTokens { get; set; }
        public int StatusCode { get; set; }

    }
}
