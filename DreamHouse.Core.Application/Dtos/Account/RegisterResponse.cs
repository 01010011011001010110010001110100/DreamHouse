﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamHouse.Core.Application.Dtos.Account
{
    public class RegisterResponse
    {
        public string? Id { get; set; }
        public bool HasError { get; set; }
        public string? ErrorDescription { get; set; }
    }
}
