using ReportCommander.Infrastructure;
using Microsoft.EntityFrameworkCore;
using ReportCommander.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportCommander.Application
{
    public class ConfigRepository : Repository<Config>
    {
        private readonly IApplicationDbContext _context;

        public ConfigRepository(IApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public ICollection<Config> GetAllConfigs()
        {
            return _context.Set<Config>().ToList();
        }
    }
}
