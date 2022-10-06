using Ardalis.ApiEndpoints;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ReportCommander.Application;
using ReportCommander.Core.Entities;
using Swashbuckle.AspNetCore.Annotations;

namespace ReportCommander.API.Endpoints;

public class Update : EndpointBaseAsync
.WithRequest<ConfigUpdateRequest>
.WithActionResult<ConfigCreateResult>
{

    readonly IConfiguration configuration;
    readonly IUnitOfWork unitOfWork;
    readonly IMapper mapper;


    public Update(IUnitOfWork unitOfWork, IMapper mapper, IConfiguration configuration)
    {
        this.unitOfWork = unitOfWork;
        this.mapper = mapper;
        this.configuration = configuration;

    }

    [HttpPut("api/Configs")]
    [ProducesResponseType(200)]
    [ProducesResponseType(204)]
    [ProducesResponseType(400)]
    [ProducesResponseType(404)]
    [SwaggerOperation(
        Summary = "Update",
        //Description = "Config Records",
        OperationId = "Configs.Update",
        Tags = new[] { "Configs" })
    ]
    //[Authorize]
    public override async Task<ActionResult<ConfigCreateResult>> HandleAsync(ConfigUpdateRequest requestObject, CancellationToken cancellationToken = default)
    {
        var configToUpdate = mapper.Map<Config>(requestObject);

        if (configToUpdate == null) return NotFound();

        configToUpdate = mapper.Map(requestObject, configToUpdate);
        unitOfWork.Repository<Config>().Update(configToUpdate);

        await unitOfWork.CompleteAsync(cancellationToken);

        return Ok(configToUpdate);
    }
}
