﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTRAVI.core.Entities
{
    public class Passenger : User
    {
        public Passenger(string userName, string phoneNumber, string email, Address adress, string cns) : base(userName, phoneNumber, email, adress)
        {
            CNS = cns;
            TripList = new List<Trip>();
        }

        public string CNS { get; private set; }
        public List<Trip> TripList { get; private set; }
    }
}
