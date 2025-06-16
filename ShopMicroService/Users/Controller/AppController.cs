using Microsoft.AspNetCore.Mvc;

[Controller]
[Route("api")]
public class AppController: ControllerBase
{
    private readonly Users _users;

    public AppController(Users users)
    {
        _users = users;
    }

    [HttpGet("users")]
    public IActionResult GetUser()
    {
        return Ok(_users.GetUsers());
    }

    [HttpPost("user")]
    public IActionResult AddUser(UserInfo user)
    {
        bool isUerExists = _users.GetUsers().Any(u => u.name == user.name);
        if (isUerExists)
        {
            return Ok("User already exists");
        }
        _users.AddUser(user);
        return Ok("User has been added");
    }
}

