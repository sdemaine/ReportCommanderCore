using AutoMapper;
using ReportCommander.Application;
using ReportCommander.Application.Dtos;
using ReportCommander.Application.Specifications;
using ReportCommander.Domain;
using ReportCommander.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ReportCommander.Core.Entities;

namespace ReportCommander.API.Controllers;

[ApiController]
[Route("api/users")]
public class UsersController : ControllerBase
{
    private readonly IUnitOfWork _unitOfWork;
    public readonly IMapper _mapper;

    public UsersController(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    // GET: api/Users
    [HttpGet]
    public async Task<ActionResult<IEnumerable<UserProfileDto>>> GetUsers()
    {
        // DataSeeder.Initialize(_dbContext);

        _unitOfWork.Repository<UserProfile>().Update(new UserProfile()
        {
            Id = 1,
            DarkModeEnabled = true,
            FirstName = "Steve",
            IsAdmin = true
        });
        await _unitOfWork.CompleteAsync(new CancellationToken());
        var adminUsers = _unitOfWork.Repository<UserProfile>().Find(new UsersWithAdminCapabilitiesSpecification());

        return Ok(_mapper.Map<IEnumerable<UserProfileDto>>(adminUsers));
    }

    // GET: api/Users/5
    [HttpGet("{id}")]
    public ActionResult<User> GetUser(int id)
    {
        var user = _unitOfWork.Repository<User>().Find(new UsersWithRecipesAndIngredientsSpecification(id)).SingleOrDefault();

        if (user == null)
        {
            return NotFound();
        }

        return user;
    }

    //// PUT: api/Users/5
    [HttpPut("{id}")]
    public IActionResult PutUser(int id, User user)
    {
        if (id != user.Id)
        {
            return BadRequest();
        }

        _unitOfWork.Repository<User>().Update(user);

        try
        {
            _unitOfWork.Complete();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_unitOfWork.Repository<User>().Contains(x => x.Id == id))
            {
                return NotFound();
            }
            else
            {
                throw;
            }
        }

        return NoContent();
    }

    // POST: api/Users
    [HttpPost]
    public ActionResult<User> PostUser(User user)
    {
        _unitOfWork.Repository<User>().Add(user);
        _unitOfWork.Complete();

        return CreatedAtAction("GetUser", new { id = user.Id }, user);
    }

    // DELETE: api/Users/5
    [HttpDelete("{id}")]
    public ActionResult<User> DeleteUser(int id)
    {
        var user = _unitOfWork.Repository<User>().FindById(id);
        if (user == null)
        {
            return NotFound();
        }

        _unitOfWork.Repository<User>().Remove(user);
        _unitOfWork.Complete();

        return user;
    }
}
