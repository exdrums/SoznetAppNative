using System;
using System.Collections.Generic;
using System.Text;

namespace NetMobile.Models
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string KnownAs { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastActive { get; set; }
        public string PhotoUrl { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Interests { get; set; }
        public string Introdiction { get; set; }
        public string LookingFor { get; set; }
        public IEnumerable<Photo> Photos { get; set; }
        public IEnumerable<string> Roles { get; set; }
    }
}
