using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using RecipesDoctor.API.Medicine.Application.Internal.CommandServices;
using RecipesDoctor.API.Medicine.Application.Internal.QueryServices;
using RecipesDoctor.API.Medicine.Domain.Repositories;
using RecipesDoctor.API.Medicine.Domain.Services;
using RecipesDoctor.API.Medicine.Infrastructure.Persistence.EFC.Repositories;
using RecipesDoctor.API.Shared.Infrastructure.Interfaces.ASP.Configuration;
using RecipesDoctor.API.Shared.Infrastructure.Persistence.EFC.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers(options => options.Conventions.Add(new KebabCaseRouteNamingConvention()));

#region Database Configuration
// Add Database Connection
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

// Configure Database Context and Logging Levels
builder.Services.AddDbContext<AppDbContext>(
    options =>
    {
        if (connectionString != null)
            if (builder.Environment.IsDevelopment())
                options.UseMySQL(connectionString)
                    .LogTo(Console.WriteLine, LogLevel.Information)
                    .EnableSensitiveDataLogging()
                    .EnableDetailedErrors();
            else if (builder.Environment.IsProduction())
                options.UseMySQL(connectionString)
                    .LogTo(Console.WriteLine, LogLevel.Error)
                    .EnableDetailedErrors();
    });

#endregion

#region OPENAPI Configuration
// Configure Lowercase URLs
builder.Services.AddRouting(options => options.LowercaseUrls = true);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(
    c =>
    {
        c.SwaggerDoc("v1",
            new OpenApiInfo
            {
                Title = "Recipes Doctor 2024 API",
                Version = "v1",
                Description = "Recipes Doctor 2024 API",
                TermsOfService = new Uri("https://acme-learning.com/tos"),
                Contact = new OpenApiContact
                {
                    Name = "Recipes Doctor 2024 Studios",
                    Email = "contact@swm.com"
                },
                License = new OpenApiLicense
                {
                    Name = "Apache 2.0",
                    Url = new Uri("https://www.apache.org/licenses/LICENSE-2.0.html")
                }
            });
        c.EnableAnnotations();
    });

#endregion


#region

// Medicine Bounded Context Injection Configuration

builder.Services.AddScoped<IDoctorDetailRepository, DoctorDetailRepository>();

builder.Services.AddScoped<IDoctorDetailCommandService, DoctorDetailCommandService>();

builder.Services.AddScoped<IDoctorDetailQueryService, DoctorDetailQueryService>();


#endregion

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();


// Configuration cors
app.UseCors(
    b => b.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin()
);

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();