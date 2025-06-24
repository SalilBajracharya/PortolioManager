﻿using Microsoft.Extensions.Primitives;

namespace PortfolioManager.Api.Common.Models
{
    public class JwtSettings
    {
        public string Issuer { get; set; } = string.Empty;
        public string Audience { get; set; } = string.Empty;
        public string Key { get; set; } = string.Empty;
        public int ExpirationMinutes { get; set; }
    }
}
