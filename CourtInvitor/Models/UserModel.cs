using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace CourtInvitor.Models
{
    internal abstract class UserModel
    {
        public bool IsRegistered => !(string.IsNullOrWhiteSpace(Name) && !string.IsNullOrWhiteSpace(Email) && !string.IsNullOrWhiteSpace(Pass));
        public string Name { get; set; } = string.Empty;
        public string Pass { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public abstract void Register();
        public string UserName { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public abstract bool Login();
    }
}
