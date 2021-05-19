using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebApplication6.Model
{
    public class SignUpModel
    {
        public string firstName { get; set; }
        public string lasttName { get; set; }
        public string day { get; set; }
        public string month { get; set; }
        public string year { get; set; }
        public string gender { get; set; }

        public string email { get; set; }

        public string password { get; set; }

        public string confirm { get; set; }
    }
}
