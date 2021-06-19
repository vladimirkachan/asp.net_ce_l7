using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_DependencyInjection.Services
{
    public interface IEmailValidator
    {
        bool IsValidEmail(string email);
    }
}
