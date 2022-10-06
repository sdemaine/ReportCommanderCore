using Ardalis.ApiEndpoints;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ReportCommander.Application;
using ReportCommander.Core.Entities;
using Swashbuckle.AspNetCore.Annotations;

namespace ReportCommander.API.Endpoints;

public class Delete : EndpointBaseAsync
    .WithRequest<int>
    .WithActionResult
{

    readonly IConfiguration configuration;
    readonly IUnitOfWork unitOfWork;
    readonly IMapper mapper;


    public Delete(IUnitOfWork unitOfWork, IMapper mapper, IConfiguration configuration)
    {
        this.unitOfWork = unitOfWork;
        this.mapper = mapper;
        this.configuration = configuration;

    }

    [HttpDelete("api/Configs/{id}")]
    [ProducesResponseType(200)]
    [ProducesResponseType(400)]
    [ProducesResponseType(404)]
    [SwaggerOperation(
        Summary = "Delete",
        //Description = "Config Records",
        OperationId = "Configs.Delete",
        Tags = new[] { "Configs" })
    ]
    //[Authorize]
    public override async Task<ActionResult> HandleAsync(int id, CancellationToken cancellationToken = default)
    {
        var configToDelete = unitOfWork.Repository<Config>().FindById(id);
        if (configToDelete == null) return NotFound();

        unitOfWork.Repository<Config>().Remove(configToDelete);
        unitOfWork.Complete();

        return Ok();
    }
}
