using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models.ViewModels
{
    public class LoginViewModel
    {
        public string? AccessToken { get; set; }
        public UserViewModel? User { get; set; }
    }
}
