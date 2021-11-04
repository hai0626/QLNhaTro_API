using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using QLNhaTro_API.Models;

namespace QLNhaTro_API.Controllers
{
    public class PhongController : ApiController
    {
        DBQLNhaTro db = new DBQLNhaTro();
        // GET: api/Phong
        public IEnumerable<Phong> Get()
        {
            return db.Phongs.ToList();
        }

        // GET: api/Phong/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Phong
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Phong/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Phong/5
        public void Delete(int id)
        {
        }
    }
}
