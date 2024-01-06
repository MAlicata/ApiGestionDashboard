using ApiGestionDashboard.DataAccess;
using ApiGestionDashboard.Entities;
using ApiGestionDashboard.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Reflection;
using System.Security.Claims;
using System.Text;

namespace ApiGestionDashboard
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();


            //selector de swagger para poder realizar la api
            builder.Services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "ApiGestionDashboard", Version = "v1" });

                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xml = Path.Combine(AppContext.BaseDirectory, xmlFile);
                c.IncludeXmlComments(xml);

                c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    Description = "Autorizacion JWT",
                    Type = SecuritySchemeType.Http,
                    Scheme = "bearer"
                });



                c.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                    new OpenApiSecurityScheme
                    {
                        Reference = new OpenApiReference
                        {
                            Type = ReferenceType.SecurityScheme,
                            Id = "Bearer"
                        }
                    }, new string[]{}
                    }
                });

            });



            builder.Services.AddDbContext<ApplicationDbContext>(option =>
            {
                option.UseSqlServer("name=DefaultConnection");
            });

            builder.Services.AddDbContext<ApplicationDbContext>(option =>
            {
                option.UseSqlServer("name=DefaultConnection");
            });

            builder.Services.AddAuthorization(options =>
            {
                options.AddPolicy("Ceo", policy =>
                {
                    policy.RequireClaim(ClaimTypes.Role, Rol.Ceo.ToString());
                });
                options.AddPolicy("Gerente", policy =>
                {
                    policy.RequireClaim(ClaimTypes.Role, Rol.Gerente.ToString());
                });
            });

            builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            .AddJwtBearer(options => options.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters()
            {
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"])),
                ValidateIssuer = false,
                ValidateAudience = false
            });

            builder.Services.AddScoped<IUnitOfWork, UnitOfWorkService>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthentication();
            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}