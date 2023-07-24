﻿using Localize.Domain.ExternalServices;
using Localize.Domain.Interfaces.ExternalServices;
using Localize.Domain.Interfaces.Repositories;
using Localize.Domain.Interfaces.Services;
using Localize.Domain.Services;
using Localize.InfraData.Data;
using Localize.InfraData.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Gateway.CrossCutting.DI
{
    public static class DependencyInjection
    {
        public static void AddDependencyInjection(this WebApplicationBuilder builder)
        {
            // HTTP
            builder.Services.AddHttpClient();

            builder.Services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy", builder => builder
                    .WithOrigins("http://localhost:4200")
                    .AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader());
            });

            builder.Services.AddScoped<IRevenueExternalService, RevenueExternalService>();
            builder.Services.AddScoped<IRevenueService, RevenueService>();
            builder.Services.AddScoped<IRevenueRepository, RevenueRepository>();

            builder.Services.AddScoped<IAccountService, AccountService>();
            builder.Services.AddScoped<IAccountRepository, AccountRepository>();
            builder.Services.AddScoped<ITokenService, TokenService>();

            builder.Services.AddDbContext<AppDbContext>(opt =>
            {
                opt.UseSqlServer(builder.Configuration["DbConnection"]);
            });
        }
    }
}
