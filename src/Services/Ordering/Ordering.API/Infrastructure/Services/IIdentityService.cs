﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VillageFight.Services.Ordering.API.Infrastructure.Services
{
    public interface IIdentityService
    {
        string GetUserIdentity();

        string GetUserName();
    }
}
