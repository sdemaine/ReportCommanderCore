﻿using ReportCommander.Core;
using ReportCommander.Core.Entities;

namespace ReportCommander.Application
{
    public interface IConfigRepository : IRepository<Config>
    {
        ICollection<Config> GetAllConfigs();
        //ICollection<Config> GetListFromRequestDto(RequestDto requestDto);
    }
}