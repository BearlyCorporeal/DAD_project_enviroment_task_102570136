using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using EFdemoAPI.Models;

namespace EFdemoAPI.Controllers
{
    public class student0136Controller : ApiController
    {
        private DADEntities db = new DADEntities();

        // GET: api/student0136
        public IQueryable<student0136> Getstudent0136()
        {
            return db.student0136;
        }

        // GET: api/student0136/5
        [ResponseType(typeof(student0136))]
        public IHttpActionResult Getstudent0136(int id)
        {
            student0136 student0136 = db.student0136.Find(id);
            if (student0136 == null)
            {
                return NotFound();
            }

            return Ok(student0136);
        }

        // PUT: api/student0136/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Putstudent0136(int id, student0136 student0136)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != student0136.StudentId)
            {
                return BadRequest();
            }

            db.Entry(student0136).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!student0136Exists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/student0136
        [ResponseType(typeof(student0136))]
        public IHttpActionResult Poststudent0136(student0136 student0136)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.student0136.Add(student0136);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (student0136Exists(student0136.StudentId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = student0136.StudentId }, student0136);
        }

        // DELETE: api/student0136/5
        [ResponseType(typeof(student0136))]
        public IHttpActionResult Deletestudent0136(int id)
        {
            student0136 student0136 = db.student0136.Find(id);
            if (student0136 == null)
            {
                return NotFound();
            }

            db.student0136.Remove(student0136);
            db.SaveChanges();

            return Ok(student0136);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool student0136Exists(int id)
        {
            return db.student0136.Count(e => e.StudentId == id) > 0;
        }

    }
}