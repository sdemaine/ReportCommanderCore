using Ardalis.ApiEndpoints;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ReportCommander.Application;
using ReportCommander.Core;
using ReportCommander.Core.Entities;
using Swashbuckle.AspNetCore.Annotations;
using System.Collections.Generic;

namespace ReportCommander.API.Endpoints;

public class List : EndpointBaseAsync
    .WithRequest<RequestDto>
    .WithActionResult<IEnumerable<ConfigListResult>>
{

    readonly IConfiguration configuration;
    readonly IUnitOfWork unitOfWork;
    readonly IMapper mapper;
    

    public List(IUnitOfWork unitOfWork, IMapper mapper, IConfiguration configuration)
    {
        this.unitOfWork = unitOfWork;
        this.mapper = mapper;
        this.configuration = configuration;

    }

    [HttpGet("api/Configs")]
    [ProducesResponseType(200)]
    [ProducesResponseType(204)]
    [ProducesResponseType(400)]
    [ProducesResponseType(404)]
    [SwaggerOperation(
        Summary = "List",
        //Description = "Config Records",
        OperationId = "Configs.List",
        Tags = new[] { "Configs" })
    ]
    //[Authorize]
    public override async Task<ActionResult<IEnumerable<ConfigListResult>>> HandleAsync(RequestDto configRequestDto, CancellationToken cancellationToken = default)
    {
        var configListResult = unitOfWork.ConfigRepository.GetListFromRequestDto(configRequestDto);
        return Ok(mapper.Map<IEnumerable<ConfigListResult>>(configListResult));
    }
}