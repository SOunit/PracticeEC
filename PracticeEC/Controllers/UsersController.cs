using Entities;
using Microsoft.AspNetCore.Mvc;
using PracticeEC.Models;

namespace PracticeEC.Controllers
{
    public class UsersController : Controller
    {
        [Route("users")]
        public IActionResult Index()
        {
            var users = new List<User>
            {
                new User {
                    Id = new Guid ("6d7bbae9-d104-4daf-9a40-dcbf29167267"),
                    Name = "Jack"
                },
                new User {
                    Id = new Guid ("bdf9940d-4361-4cfc-93d5-24871d161414"),
                    Name = "Becca"
                },
            };

            var vm = new UsersViewModel
            {
                Users = users
            };

            return View(vm);
        }
    }
}
