using Repositories;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using ViewModel;

namespace APIBookStore.Controllers
{
    public class BookStoreController : ApiController
    {
        IBookStoreDetails dt = new BookStoreDetails(); //access to repository

        [HttpGet]
        [Route("api/BookStore/Get")]
        [ResponseType(typeof(BookStoreM))]
        public IEnumerable<BookStoreM> Get()
        {
            var details = dt.GetAll();
            return details;
        }
    }
}
