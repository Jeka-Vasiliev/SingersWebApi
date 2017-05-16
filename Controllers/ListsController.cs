using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SingersWebApi.ViewModels;

namespace SingersWebApi.Controllers
{
    [Route("[controller]")]
    public class ListsController : Controller
    {
        private readonly ListsContext _context;

        public ListsController(ListsContext context)
        {
            _context = context;
        }

        // GET lists
        [HttpGet]
        public async Task<IEnumerable<Model.List>> Get()
        {
            return await _context.Lists
                .AsNoTracking()
                .ToArrayAsync();
        }

        // GET lists/1
        [HttpGet("{id}")]
        public Task<Model.List> Get(int id)
        {
            return _context.Lists
                .FindAsync(id);
        }

        // POST lists
        [HttpPost]
        public async Task<IActionResult> Post([FromBody]PostListViewModel value)
        {
            var newList = value.List;
            newList.Created = DateTime.Now;
            newList.Updated = DateTime.Now;
            await _context.AddAsync(newList);
            await _context.SaveChangesAsync();
            return Ok(newList);
        }

        // PUT lists/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody]PutListViewModel value)
        {
            var editedModel = await _context.Lists.FirstAsync(l => l.Id == id);
            editedModel.Name = value.List.Name;
            editedModel.Order = value.List.Order;
            editedModel.FirstName = value.List.FirstName;
            editedModel.LastName = value.List.LastName;
            editedModel.BirthDate = value.List.BirthDate;
            editedModel.IsAlive = value.List.IsAlive;
            editedModel.Updated = DateTime.Now;
            await _context.SaveChangesAsync();
            return Ok(editedModel);
        }

        // PUT lists/5
        [HttpPatch("{id}")]
        public async Task<IActionResult> Patch(int id, [FromBody]PatchListViewModel value)
        {
            var editedModel = await _context.Lists.FirstAsync(l => l.Id == id);
            editedModel.Name = value.List.Name;
            editedModel.Order = value.List.Order;
            editedModel.FirstName = value.List.FirstName;
            editedModel.LastName = value.List.LastName;
            editedModel.BirthDate = value.List.BirthDate;
            editedModel.IsAlive = value.List.IsAlive;
            editedModel.Updated = DateTime.Now;
            await _context.SaveChangesAsync();
            return Ok(editedModel);
        }

        // DELETE lists/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            var deletedModel = await _context.Lists.FirstAsync(l => l.Id == id);
            _context.Lists.Remove(deletedModel);
            await _context.SaveChangesAsync();
        }
    }
}
