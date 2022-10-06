using Ardalis.ApiEndpoints;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ReportCommander.Application;
using ReportCommander.Core.Entities;
using Swashbuckle.AspNetCore.Annotations;

namespace ReportCommander.API.Endpoints;

public class GetById : EndpointBaseAsync
    .WithRequest<int>
    .WithActionResult<ConfigGetResult>
{

    readonly IConfiguration configuration;
    readonly IUnitOfWork unitOfWork;
    readonly IMapper mapper;
    

    public GetById(IUnitOfWork unitOfWork, IMapper mapper, IConfiguration configuration)
    {
        this.unitOfWork = unitOfWork;
        this.mapper = mapper;
        this.configuration = configuration;

    }

    [HttpGet("api/Configs/{id}")]
    [ProducesResponseType(200)]
    [ProducesResponseType(204)]
    [ProducesResponseType(400)]
    [ProducesResponseType(404)]
    [SwaggerOperation(
        Summary = "Create",
        //Description = "Config Records",
        OperationId = "Configs.Create",
        Tags = new[] { "Configs" })
    ]
    //[Authorize]
    public override async Task<ActionResult<ConfigGetResult>> HandleAsync(int id, CancellationToken cancellationToken = default)
    {
        var configById = unitOfWork.Repository<Config>().FindById(id, new[] { "DatabaseConnection" });
        return Ok(configById);
    }
}