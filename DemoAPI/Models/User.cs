using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoAPI.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public bool Baned { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public string Email { get; set; }
        public bool VerifiedEmail { get; set; }
        public DateTime Birthday { get; set; }
    }
}
