﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSA.Shared.Models.User
{
    public class UserModel
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Role { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int EmployeeNo { get; set; }
        public string Trade { get; set; }
        public string? Password { get; set; }
    }
}
