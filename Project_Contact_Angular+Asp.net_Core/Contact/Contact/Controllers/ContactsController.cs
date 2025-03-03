﻿using Contact.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Contact.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        private readonly Context db;
        public ContactsController(Context db)
        {
            this.db = db;
        }
        [HttpGet]
        public async Task<IEnumerable<Contacts>> GetAll() 
        {
            return await db.Contacts.ToArrayAsync();
        }
        [HttpPost]
        public async Task<Contacts> AddContacts([FromBody]Contacts obj)
        {
            await db.AddAsync(obj);
            await db.SaveChangesAsync();
            return obj;
        }
        [HttpPut]
        [Route("{id:long}")]
        public async Task<Contacts> UpdateContacts([FromBody] Contacts obj)
        {
            db.Entry(obj).State = EntityState.Modified;
            await db.SaveChangesAsync();
            return obj;
        }
        [HttpDelete]
        [Route("{id:long}")]
        public async Task<IActionResult> DeleteContact([FromRoute] long id)
        {
            var c = await db.Contacts.FindAsync(id);
            if (c != null)
            {
                db.Contacts.Remove(c);
                db.SaveChanges();
                return Ok(c);
            }
            return NotFound("Contact Not Found");
        }
    }
}
