﻿using MediatR;
using Microsoft.AspNetCore.Mvc;
using PoliceDepartment.Application.Handlers.CreatePoliceOfficer;
using PoliceDepartment.Application.Handlers.DeletePoliceOfficer;
using PoliceDepartment.Application.Services;
using PoliceDepartment.Core.Entities;

namespace PoliceDepartment.Api.Controllers;

[ApiController]
[Route("[controller]")]
public sealed class PoliceOfficersController(
    IPoliceOfficerService policeOfficersService,
    IMediator mediator)
    : ControllerBase
{
    [HttpGet]
    public async Task<ActionResult<IEnumerable<PoliceOfficer>>> Get()
    {
        return Ok(await policeOfficersService.GetAllAsync());
    }


    [HttpGet("{id:guid}")]
    public async Task<ActionResult<PoliceOfficer>> Get(Guid id)
        => Ok(await policeOfficersService.GetByGuidAsync(id));

    [HttpDelete("{id:guid}")]
    public async Task<ActionResult> Delete(Guid id)
    {
        await policeOfficersService.RemoveAsync(new DeletePoliceOfficerCommand(id));
        return NoContent();
    }

    [HttpPost]
    public async Task<ActionResult<PoliceOfficer>> Post(CreatePoliceOfficerCommand command) =>
         CreatedAtAction(nameof(Get), await mediator.Send(command));


    [HttpPut("{id:guid}")]
    public async Task<ActionResult> Put(PoliceOfficer policeOfficer, Guid id)
        => Ok(await policeOfficersService.Update(policeOfficer, id));
}