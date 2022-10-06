using Ardalis.ApiEndpoints;
using AutoMapper;
using ReportCommander.Application;
using Microsoft.AspNetCore.Mvc;
using ReportCommander.Core.Entities;
using Swashbuckle.AspNetCore.Annotations;

namespace ReportCommander.API.Endpoints;

public class Create : EndpointBaseAsync
    .WithRequest<ConfigCreateRequest>
    .WithActionResult<ConfigCreateResult>
{

    readonly IConfiguration configuration;
    readonly IUnitOfWork unitOfWork;
    readonly IMapper mapper;
    

    public Create(IUnitOfWork unitOfWork, IMapper mapper, IConfiguration configuration)
    {
        this.unitOfWork = unitOfWork;
        this.mapper = mapper;
        this.configuration = configuration;

    }

    [HttpPost("api/Configs")]
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
    public override async Task<ActionResult<ConfigCreateResult>> HandleAsync(ConfigCreateRequest requestObject, CancellationToken cancellationToken = default)
    {
        var configToCreate = mapper.Map<Config>(requestObject);
        
        unitOfWork.Repository<Config>().Add(configToCreate);
        
        await unitOfWork.CompleteAsync(cancellationToken);
        
        return new CreatedResult($"\\Configs\\{configToCreate.Id}", mapper.Map<ConfigCreateResult>(configToCreate));
    }
}