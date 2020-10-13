using Jaydo.Data.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Jaydo.Data.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int RoleId { get; set; }
        public string Email { get; set; }
        public Status Status { get; set; }
        public DateTime LastLogout { get; set; }
    }
}
