using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
        public async Task Post([FromBody]Model.List value)
        {
            value.Created = DateTime.Now;
            value.Updated = DateTime.Now;
            await _context.AddAsync(value);
            await _context.SaveChangesAsync();
        }

        // PUT lists/5
        [HttpPut("{id}")]
        public async Task Put(int id, [FromBody]Model.List value)
        {
            var editedModel = await _context.Lists.FirstAsync(l => l.Id == id);
            editedModel.Name = value.Name;
            editedModel.Order = value.Order;
            editedModel.FirstName = value.FirstName;
            editedModel.LastName = value.LastName;
            editedModel.BirthDate = value.BirthDate;
            editedModel.IsAlive = value.IsAlive;
            editedModel.Updated = DateTime.Now;
            await _context.SaveChangesAsync();
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
