using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chinook.Data.Data
{
    public class TrackData : DataRepository
    {
        public List<Track> GetTop5Tracks(int artistId)
        {
            using (var context = DataRepository.CreateContext())
            {
                var album
                    = context.Albums.First(x => x.ArtistId == artistId);

                return context.Tracks.Where(track => track.AlbumId == (album.AlbumId)).Take(5).ToList();
            }

        }
    }
}
