using Repositories;
using Service;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using ViewModel;

namespace BookStoreAPIS.Controllers
{
    public class BookController : ApiController
    {
        IBook dt = new BookDetails();
        [HttpGet]
        [Route("api/BookStore/Get")]
        [ResponseType(typeof(Book))]
        public IHttpActionResult Get()
        {
            var details = dt.GetAll();
            return Ok(details);
        }
        [HttpPost]
        [Route("api/BookStore/Post")]
        [ResponseType(typeof(Book))]
        public IHttpActionResult PostBook([FromBody]Book book)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    dt.Insert(book);
                    dt.Save();
                    return Ok(book);
                }
                else
                {
                    return BadRequest("Error plz check");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message.ToString());
            }
        }

        [HttpPut]
        [Route("api/BookStore/Put/{id}")]
        [ResponseType(typeof(Book))]
        public IHttpActionResult PutBook(Book book, int id)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    dt.Update(book, id);
                    dt.Save();
                    return Ok(book);
                }
                else
                {
                    return BadRequest("Error plz check");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message.ToString());
            }
        }

        [HttpDelete]
        [Route("api/BookStore/Delete/{id}")]
        [ResponseType(typeof(Book))]
        public IHttpActionResult DeleteBook(int id)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    dt.Delete(id);
                    dt.Save();
                    return Ok("Deleted");
                }
                else
                {
                    return BadRequest("Error plz check");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message.ToString());
            }
        }
    }
}
