﻿using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using ProjectPet.Core.Options;

namespace ProjectPet.Framework.Authorization;
public class TokenValidationParametersFactory
{
    private readonly OptionsTokens _tokenOptions;

    public TokenValidationParametersFactory(IOptions<OptionsTokens> tokenOptions)
    {
        _tokenOptions = tokenOptions.Value;
    }

    public TokenValidationParameters Create(RsaSecurityKey key, bool validateLifeTime = true)
        => Create(_tokenOptions, key, validateLifeTime);

    public static TokenValidationParameters Create(OptionsTokens _tokenOptions, RsaSecurityKey key, bool validateLifetime = true)
    {
        return new TokenValidationParameters
        {
            ValidateIssuer = false,
            ValidateAudience = false,

            IssuerSigningKey = key,

            ValidateLifetime = validateLifetime,

            ClockSkew = TimeSpan.Zero,
        };
    }

}
