using System;

namespace ClassLibrary
{
    public class clsGame
    {
        public int GameId { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public DateTime ReleaseDate { get; set; }
        public bool IsEarlyAccess { get; set; }
    }
}