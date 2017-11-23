﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment2.Models
{
    public class SongList
    {
        private static List<Song> songList = new List<Song>()
        {
            new Song{SongID = 1, Title = "Nothing Compares 2 U", AlbumName = "Anal Bum Cover", Artist = "Prince", Genre = "Awesome"}
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