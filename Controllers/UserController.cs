using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using dotnet_test.entities;

namespace dotnet_test.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly AppDbContext _context;

        public UserController(AppDbContext context){
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> getUsers(){
            return await _context.Users.ToListAsync();
        }
    }
}