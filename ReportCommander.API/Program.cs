using ReportCommander.API.MappingProfiles;
using ReportCommander.Application;
using ReportCommander.Domain;
using ReportCommander.Infrastructure;
using Microsoft.EntityFrameworkCore;

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

// Add services to the container.
builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();


builder.Services.AddTransient<IApplicationDbContext, ApplicationDbContext>();
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


app.UseAuthorization();

app.UseCors(MyAllowSpecificOrigins);


//app.UseAuthorization();
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

app.Run();