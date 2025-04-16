﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTRAVI.core.Entities
{
    public class Admin : User
    {
        public Admin(string userName, string phoneNumber, string email, Address adress, string password) : base(userName, phoneNumber, email, adress)
        {
            Password = password;
        }

        public string Password { get; private set; }
    }
}
