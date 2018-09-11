using System;
using System.Collections.Generic;
using System.Text;

namespace NetMobile.Models
{
    public class AuthUser
    {
        public string TokenString { get; set; }
        public User User { get; set; }
    }
}
