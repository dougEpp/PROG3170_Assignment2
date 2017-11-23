using Assignment2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment2.Controllers
{
    public class SongController : ApiController
    {
        // GET: api/Songs
        public IEnumerable<Song> Get()
        {
            return SongList.GetSongs();
        }

        // GET: api/Songs/5
        public Song Get(int id)
        {
            return SongList.GetSong(id);
        }

        // POST: api/Songs
        public void Post([FromBody] Song newSong)
        {
            SongList.AddSong(newSong);
        }

        // PUT: api/Songs/5
        public void Put(int id, [FromBody] Song newSong)
        {
            SongList.UpdateSong(id, newSong);
        }

        // DELETE: api/Songs/5
        public void Delete(int id)
        {
            SongList.DeleteSong(id);
        }
    }
}
