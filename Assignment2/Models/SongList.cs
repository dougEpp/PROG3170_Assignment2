using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment2.Models
{
    public class SongList
    {
        private static List<Song> songList = new List<Song>()
        {
            new Song{SongID = 1, Title = "Nothing Compares 2 U", AlbumName = "", Artist = "Sinead O'Connor", Genre = "Pop"},
            new Song{SongID = 2, Title = "One", AlbumName = "... And Justice for All", Artist = "Metallica", Genre = "Metal"},
            new Song{SongID = 3, Title = "One", AlbumName = "Achtung Baby", Artist = "U2", Genre = "Rock"},
            new Song{SongID = 4, Title = "Prophet Song", AlbumName = "A Night at the Opera", Artist = "Queen", Genre = "Prog Rock"},
            new Song{SongID = 5, Title = "Barbie Girl", AlbumName = "Aquarium", Artist = "Aqua", Genre = "Pop"},
            new Song{SongID = 6, Title = "Superman's Song", AlbumName = "The Ghosts that Haunt Me", Artist = "Crash Test Dummies", Genre = "Pop"},
            new Song{SongID = 7, Title = "Mary Ellen Carter", AlbumName = "Between the Breaks... Live!", Artist = "Stan Rogers", Genre = "Folk"},
            new Song{SongID = 8, Title = "Lose Yourself", AlbumName = "8 Mile", Artist = "Eminem", Genre = "Hip-Hop"}
        };


        public static Song AddSong(Song newSong)
        {
            newSong.SongID = songList.Max(s => s.SongID) + 1;
            songList.Add(newSong);
            return newSong;
        }

        public static List<Song> GetSongs()
        {
            return songList;
        }

        public static Song GetSong(int songId)
        {
            int songIndex = songList.FindIndex(s => s.SongID == songId);
            return (songIndex == -1) ? null : songList[songIndex];
        }

        public static Song UpdateSong(int songId, Song newSong)
        {
            int songIndex = songList.FindIndex(s => s.SongID == songId);
            if (songIndex != -1)
            {
                songList[songIndex] = newSong;
                return songList[songIndex];
            }
            return null;

        }

        public static bool DeleteSong(int songId)
        {
            int songIndex = songList.FindIndex(s => s.SongID == songId);
            if (songIndex != -1)
            {
                songList.RemoveAt(songIndex);
                return true;
            }
            return false;
        }
    }
}