﻿using Microsoft.Extensions.DependencyInjection;
using Saritasa.RedMan.UseCases.Users.AuthenticateUser;

namespace Saritasa.RedMan.Web.Infrastructure.DependencyInjection;

/// <summary>
/// Register AutoMapper dependencies.
/// </summary>
public class AutoMapperModule
{
    /// <summary>
    /// Register dependencies.
    /// </summary>
    /// <param name="services">Services.</param>
    public static void Register(IServiceCollection services)
    {
        services.AddAutoMapper(
            typeof(TokenModel).Assembly);
    }
}
