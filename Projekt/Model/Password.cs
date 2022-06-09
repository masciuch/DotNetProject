using PasswordMeter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Model
{
    public class Password
    {
        public string serviceName { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public string passwordStrength { get; set; }
    }
}
