using System;
using System.Collections.Generic;
using System.Security.Claims;
using Microsoft.AspNetCore.Http;

namespace ContaFacil.WebAPI.Core.User
{
    public interface IAspNetUser
    {
        string Name { get; }
        Guid GetUserId();
        string GetUserEmail();
        string GetUserToken();
        bool IsAuthenticate();
        bool CanRole(string role);
        IEnumerable<Claim> GetClaims();
        HttpContext GetHttpContext();
    }
}
