using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment2.Models
{
    public class Review
    {
        private int reviewID;
        private string message;
        private int rating;
        private int songId;

        public int ReviewID { get => reviewID; set => reviewID = value; }
        public string Message { get => message; set => message = value; }
        public int Rating { get => rating; set => rating = value; }
        public int SongId { get => songId; set => songId = value; }
    }
}