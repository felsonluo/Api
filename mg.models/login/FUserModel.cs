using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace mg.models
{
    [DataContract]
    public class User
    {
        [DataMember(Name = "email")]
        public string Email { get; set; }
        [DataMember(Name = "password")]
        public string Password { get; set; }
        [DataMember(Name = "userName")]
        public string UserName { get; set; }
    }
}
