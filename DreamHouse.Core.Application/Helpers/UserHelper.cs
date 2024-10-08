﻿using DreamHouse.Core.Application.Dtos.Account;
using DreamHouse.Core.Application.Interfaces.Helpers;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamHouse.Core.Application.Helpers
{
    public class UserHelper : IUserHelper
    {
        private readonly string userKeySession = string.Empty;
        private readonly IHttpContextAccessor httpContextAccessor;
        private readonly IConfiguration config;

        public UserHelper(IHttpContextAccessor httpContextAccessor, IConfiguration config)
        {
            userKeySession = config.GetSection("SessionConfig").GetValue<string>("UserInfoKey")!;
            this.httpContextAccessor = httpContextAccessor;
            this.config = config;
        }

        public void SetUser(AuthenticationResponse user)
        {
            httpContextAccessor.HttpContext.Session.Set(userKeySession, user);
        }

        public AuthenticationResponse? GetUser()
        {
            return httpContextAccessor.HttpContext.Session.Get<AuthenticationResponse>(userKeySession);
        }

        public void RemoveUser()
        {
            httpContextAccessor.HttpContext.Session.Remove(userKeySession);
        }

        public bool HasUser()
        {
            return GetUser() != null;
        }
    }
}
