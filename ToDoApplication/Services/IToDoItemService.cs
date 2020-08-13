using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoApplication.Models;


namespace ToDoApplication.Services
{
    public interface IToDoItemService
    {
        Task<bool> AddItemAsync(ToDoItem newItem, IdentityUser user);
        Task<bool> MarkDoneAsync(Guid id, IdentityUser user);
        Task<ToDoItem[]> GetIncompleteItemsAsync(IdentityUser user);

    }
}





