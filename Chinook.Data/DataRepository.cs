using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chinook.Data
{
    class DataRepository
    {
        protected static ChinookEntities CreateContext()
        {
            ChinookEntities context = new ChinookEntities();
            context.Database.Log = PrintToConsoleWindow;
            return context;
        }

        private static void PrintToConsoleWindow(string log)
        {
            Console.WriteLine(log);
        }

        static DataRepository()
        {
            Playlist = new PlaylistData();
        }

        private static AlbumData Album { get; }

        public static PlaylistData Playlist { get; }
    }
}
