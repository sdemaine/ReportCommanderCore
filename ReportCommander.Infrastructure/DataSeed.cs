using ReportCommander.Core.Entities;

namespace ReportCommander.Infrastructure;

public class DataSeed
{
    public static void SeedDatabase()
    {
        var _context = new ApplicationDbContext(options =>
        {
            
        });

        _context.Notes.Add(new Note()
        {
            Content = "Sample note"
        });


    }
}
