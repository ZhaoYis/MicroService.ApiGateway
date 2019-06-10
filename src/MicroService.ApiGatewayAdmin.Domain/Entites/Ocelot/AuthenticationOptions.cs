﻿using System.Collections.Generic;
using Volo.Abp.Domain.Entities;

namespace MicroService.ApiGateway.Entites.Ocelot
{
    public class AuthenticationOptions : Entity<int>
    {
        public virtual long ReRouteId { get; private set; }
        public virtual string AuthenticationProviderKey { get; private set; }
        public virtual string AllowedScopes { get; set; }

        protected AuthenticationOptions()
        {

        }
        public AuthenticationOptions(long rerouteId)
        {
            ReRouteId = rerouteId;
        }

        public void ApplyAuthOptions(string key, List<string> allowScopes)
        {
            AuthenticationProviderKey = key;
            SetAllowScopes(allowScopes);
        }

        public void SetAllowScopes(List<string> allowScopes)
        {
            AllowedScopes = allowScopes.JoinAsString(",");
        }
    }
}