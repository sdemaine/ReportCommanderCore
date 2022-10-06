// See https://aka.ms/new-console-template for more information
using ReportCommander.Application;
using ReportCommander.Application.Specifications;
using ReportCommander.ConsoleUI;
using ReportCommander.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ReportCommander.Core.Entities;

var host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services => {
        services.AddTransient<MyService>();
        services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer($"Data Source=.\\SQL2019;Initial Catalog=ReportCommanderDB;Integrated Security=True"));
        services.AddTransient<IApplicationDbContext, ApplicationDbContext>();
        services.AddTransient<IUnitOfWork, UnitOfWork>();
    })
    .Build();
var my = host.Services.GetRequiredService<MyService>();
await my.ExecuteAsync();

var _unitOfWork = host.Services.GetRequiredService<IUnitOfWork>();

var configsForUser = _unitOfWork.Repository<Config>().Find(new ConfigsForUserSpecification(7));

Console.ReadKey();
// CreateDatabaseConnections(_unitOfWork);
// CreateConfigs(_unitOfWork);
// CreateDeliveries(_unitOfWork);



void CreateDatabaseConnections(IUnitOfWork unitOfWork)
{
    var databaseConnections = new List<DatabaseConnection>();

    for (int i = 0; i < 3; i++)
    {
        databaseConnections.Add(new DatabaseConnection()
        {
            ConnectionName = $"Connection {i}",
            CreatedByUserId = 0,
            CreatedDate = DateTime.Now,
            DatabaseName = $"Database_{i}",
            DatabaseServer = $"DatabaseServer_{i}",
            SqlUsername = "Username",
            SqlPassword = "Password"
        });
    }

    unitOfWork.Repository<DatabaseConnection>().AddRange(databaseConnections);
    unitOfWork.Complete();
}





void CreateConfigs(IUnitOfWork unitOfWork)
{
    var configs = new List<Config>();

    for (int i = 0; i < 10; i++)
    {
        configs.Add(new Config()
        {
            Name = $"Name_{i}",
            Description = $"Config description {i}",
            CreatedDate = DateTime.Now,
            CreatedByUserId = 0,
            CommandTimeout = 0,
            DatabaseConnectionId = (int)new Random().NextInt64(1, 3),
            Filename = $"File_{i}.csv",
            StoredProcedureName = $"StoredProcedure_{i}"
        });
    }

    unitOfWork.Repository<Config>().AddRange(configs);
    unitOfWork.Complete();


}

void CreateDeliveries(IUnitOfWork unitOfWork)
{
    var Deliveries = new List<Delivery>();

    for (int i = 0; i < 10; i++)
    {
        Deliveries.Add(new Delivery() {
            Name = "",
            Description = "Delivery>{i}",
            BlankReportEmailRecipient = "none@none.net",
            CreatedByUserId = 0,
            CreatedDate = DateTime.Now,
            Delimiter = ",",
            EmailAttachmentMessage = "Email attachment message",
            EmailBodyRowCountLimit = 100,
            EmailDelimitedFile = new Random().Next(0, 1) == 0 ? false : true,
            EmailExcelFile = new Random().Next(0, 1) == 0 ? false : true,
            FreezeTopRow = new Random().Next(0, 1) == 0 ? false : true,
            HighPriority = new Random().Next(0, 1) == 0 ? false : true,
            RecipientEmailAddressList = "sdemaine@spragueenergy.com",
            FTPHost = $"FtpHost_{i}",
            FTPUsername = $"FtpUsername_{i}",
            FTPPassword = $"FtpPassword_{i}",
            RenderInBody = new Random().Next(0, 1) == 0 ? false : true
        });
    }

    unitOfWork.Repository<Delivery>().AddRange(Deliveries);
    unitOfWork.Complete();
}