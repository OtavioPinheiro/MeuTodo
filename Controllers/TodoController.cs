using System.Collections.Generic;
using MeuTodo.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeuTodo.Controllers
{
    [ApiController]
    [Route("v1")]
    public class TodoController : ControllerBase
    {
        [HttpGet]
        [Route("todos")]
        public List<Todo> Get()
        {
            return new List<Todo>();
        }
    }
}