using BagOfMarbles.DataContext;
using BagOfMarbles.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BagOfMarbles.Controllers
{

    public class MarbleController : ApiController
    {       
        // GET: api/Marble
        public IHttpActionResult Get()
        {
            return Ok(new MarbleContext().Marbles.ToList());
        }

        //get one marble
        public IHttpActionResult GetOne(int id)
        {
            Marble marble = new MarbleContext().Marbles.Find(id);
            return Ok(marble);
        }

        [HttpPost]
        public IHttpActionResult Add(Marble marble)
        {
            var db = new MarbleContext();
            db.Marbles.Add(marble);
            db.SaveChanges();
            return Ok(marble);
        }

    }
}
