using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using mvcReact.Models;

namespace mvcReact.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private readonly biblioteca_gelimContext _dbContext;

        public UserController(biblioteca_gelimContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        [Route("GetUsers")]
        public IActionResult GetUsers()
        {
            List<Usuario> list = _dbContext.Usuarios.ToList();

            return StatusCode(StatusCodes.Status200OK, list);
        }
    }
}
