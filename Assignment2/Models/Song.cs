using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment2.Models
{
    public class Song
    {
        private int songID;
        private string title;
        private string albumName;
        private string artist;
        private string genre;

        public int SongID { get => songID; set => songID = value; }
        public string Title { get => title; set => title = value; }
        public string AlbumName { get => albumName; set => albumName = value; }
        public string Artist { get => artist; set => artist = value; }
        public string Genre { get => genre; set => genre = value; }
    }
}