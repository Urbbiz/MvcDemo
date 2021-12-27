using Microsoft.AspNetCore.Mvc;
using MvcDemo.Models;

namespace MvcDemo.Controllers
{
    public class TodosController : Controller
    {
        public IActionResult Index()
        {
            var todos = new List<TodoItem>()
            {
                new TodoItem()
                {
                    Id = 1,
                    Description = "TodoItem1"
                },
                new TodoItem()
                {
                    Id = 2,
                    Description = "TodoItem2"
                },
                new TodoItem()
                {
                    Id = 2,
                    Description = "TodoItem2"
                },

            };

            return View(todos);
        }
    }
}
