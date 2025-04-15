using clinica.Infrastructure;
using clinica.Application;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using clinica.Infrastructure.DataAccess;

namespace clinica.API;

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

		builder.Services.AddRouting(options => options.LowercaseUrls = true);

		builder.Services.AddInfrastructure(builder.Configuration);
		builder.Services.AddInstrastructure_Application();

		

		builder.Services.AddAuthentication(config =>
		{
			config.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
			config.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;

		}).AddJwtBearer(config =>
		{
			config.TokenValidationParameters = new TokenValidationParameters
			{
				ValidateIssuer = false,
				ValidateAudience = false,
				ClockSkew = new TimeSpan(0),
				IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration.GetValue<string>("Settings:Jwt:SigningKey")!))

			};
		});

	
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

		var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

		_ = new ClinicaDbContext(connectionString!);

		app.MapControllers();

		app.Run();
	}
}
