using ReportCommander.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportCommander.Application.Specifications
{
    public class ConfigsForUserSpecification : BaseSpecification<Config>
    {
        public ConfigsForUserSpecification(int userId) : base(x => x.ReportOwnerUserID == userId)
        {

        }
    }
}
