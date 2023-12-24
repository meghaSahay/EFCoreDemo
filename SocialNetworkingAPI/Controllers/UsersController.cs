
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;
using MediatR;
using Application;

namespace SocialNetworkingAPI.Controllers;

public class UsersController : BaseApiController
{
    private readonly IMediator _mediator;
    public UsersController(IMediator mediator)
    {
        _mediator = mediator;
        
    }
    [HttpGet]
    public async Task<ActionResult<List<User>>> GetUsers()
    {
        return await _mediator.Send(new ListUsers.Query());
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<User>> GetUser(Guid id)
    {
        return Ok();
    }
        
}
