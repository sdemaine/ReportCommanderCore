using ReportCommander.Infrastructure;
using Microsoft.EntityFrameworkCore;
using ReportCommander.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReportCommander.Core;

namespace ReportCommander.Application
{
    public class ConfigRepository : Repository<Config>, IConfigRepository
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

        public ICollection<Config> GetListFromRequestDto(RequestDto requestDto)
        {
            var query = _context.Set<Config>().AsQueryable();

            if (requestDto.ActiveOnly)
            {
                query = query.Where(x => x.IsDeleted == false);
            }

            if (requestDto.UserId != 0)
            {
                query = query.Where(x => x.ReportOwnerUserID == requestDto.UserId);
            }

            if (requestDto.LoadChildren == true)
            {
                query = query.Include(x => x.DatabaseConnection);
            }

            if (!string.IsNullOrEmpty(requestDto.SearchString))
            {
                query = query.Where(x => x.Name.ToUpper().Contains(requestDto.SearchString.ToUpper())
                    || x.Description.ToUpper().Contains(requestDto.SearchString.ToUpper()));
            }

            return query.ToList();
        }
    }
}
