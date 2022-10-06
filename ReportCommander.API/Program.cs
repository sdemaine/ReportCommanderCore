using ReportCommander.API.MappingProfiles;
using ReportCommander.Application;
using ReportCommander.Domain;
using ReportCommander.Infrastructure;
using Microsoft.EntityFrameworkCore;
using ReportCommander.Application.Repositories;
using Microsoft.AspNetCore.Server.IISIntegration;
using System.Text.Json;
using Microsoft.AspNetCore.Authentication.Negotiate;

var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
var builder = WebApplication.CreateBuilder(args);



builder.Services.AddAutoMapper(typeof(MappingProfiles));


builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
        policy =>
        {
            policy.WithOrigins("http://localhost:4200");
        });
});

// enable windows auth
builder.Services.AddAuthentication(NegotiateDefaults.AuthenticationScheme)
   .AddNegotiate();

builder.Services.AddAuthorization(options =>
{
    options.FallbackPolicy = options.DefaultPolicy;
});



// Add services to the container.
//builder.Services.AddControllers();

// TODO: is this needed??
builder.Services.AddControllers().AddJsonOptions(option =>
        option.JsonSerializerOptions
              .PropertyNamingPolicy = JsonNamingPolicy.CamelCase);

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();


builder.Services.AddTransient<IApplicationDbContext, ApplicationDbContext>();
builder.Services.AddTransient<IConfigRepository, ConfigRepository>();
builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();
//builder.Services.AddTransient<IRepository<Ingredient>, Repository<Ingredient>>();
//builder.Services.AddTransient<IRepository<Recipe>, Repository<Recipe>>();
//builder.Services.AddTransient<IRepository<User>, Repository<User>>();

// builder.Services.AddDbContext
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer($"Data Source=.\\SQL2019;Initial Catalog=ReportCommanderDB;Integrated Security=True"));

var app = builder.Build();



//// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.UseCors(MyAllowSpecificOrigins);



app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

app.Run();