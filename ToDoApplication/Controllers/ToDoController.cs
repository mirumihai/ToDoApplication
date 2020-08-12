using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoApplication.Services;
using ToDoApplication.Models;

namespace ToDoApplication.Controllers
{
    public class ToDoController : Controller
    {

        private readonly IToDoItemService _todoItemService;

        public ToDoController(IToDoItemService todoItemService)
        {
            _todoItemService = todoItemService;
        }

        public async Task<IActionResult> Index()
        {
            var items = await _todoItemService.GetIncompleteItemsAsync();
            var model = new ToDoViewModel()
            {
                Items = items
            };

            return View(model);

        }
    }
}