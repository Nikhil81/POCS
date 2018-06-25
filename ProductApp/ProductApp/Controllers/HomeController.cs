using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProductApp.Controllers
{
    public class HomeController : ApiController
    {

        static List<string> values = new List<string>
        {
            "values0",
            "values1",
            "values2"
        };

        //GET api/Home
        public IHttpActionResult GetProducts()
        {
            return Ok(values);
        }
        //GET api/Home/1
        public IHttpActionResult GetProducts(int id)
        {
            return Ok(values[id]);
        }

        //POST api/home/
        public IHttpActionResult Post([FromBody]string value)
        {
            values.Add(value);
            return Ok();
        }

        //PUT api/home/
        public IHttpActionResult Put([FromBody]string value, int id)
        {
            values[id] = value;
            return Ok();
        }

        //Delete api/home
        public IHttpActionResult Delete(int id)
        {
            values.RemoveAt(id);
            return Ok();
        }
       
    }
}
