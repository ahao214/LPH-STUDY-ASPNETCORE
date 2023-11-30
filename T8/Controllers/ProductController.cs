using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using T8.Models;

namespace T8.Controllers
{
    public class ProductController : ApiController
    {
        FreshLiveDB db = new FreshLiveDB();
        // GET: api/Product
        public IEnumerable<ProductClass> Get()
        {
            return db.ProductClass.ToList();
        }

        // GET: api/Product/5
        public ProductClass Get(int id)
        {
            return db.ProductClass.FirstOrDefault(x => x.Id == id);
        }

        // POST: api/Product
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Product/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/Product/5
        public void Delete(int id)
        {
        }
    }
}
