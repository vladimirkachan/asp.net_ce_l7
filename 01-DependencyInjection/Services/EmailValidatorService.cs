using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _01_DependencyInjection.Services
{
    public class EmailValidatorService : IEmailValidator
    {
        public bool IsValidEmail(string email)
        {
            return Regex.IsMatch(email, "\\w + ([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*");
        }
    }
}
