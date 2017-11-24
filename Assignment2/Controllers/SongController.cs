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
        public Song Post([FromBody] Song newSong)
        {
            Song addedSong = SongList.AddSong(newSong);
            return addedSong;
        }

        // PUT: api/Songs/5
        public Song Put(int id, [FromBody] Song newSong)
        {
            Song updatedSong = SongList.UpdateSong(id, newSong);
            return updatedSong;
        }

        // DELETE: api/Songs/5
        public void Delete(int id)
        {
            SongList.DeleteSong(id);
        }
    }
}
