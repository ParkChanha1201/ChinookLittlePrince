using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Chinook.Data.Data
{
    public class TrackData : DataRepository
    {
        /// <summary>
        /// Artist의 ArtistId를 검색해 해당 Artist의 Track 중 5개의 Name을 표시한다.
        /// </summary>
        /// <param name="artistId"></param>
        /// <returns>List of 5 tracks matches conditions.</returns>
        public List<Track> GetTop5Tracks(int artistId)
        {
            using (var context = DataRepository.CreateContext())
            {

                var album = context.Albums.FirstOrDefault(al => al.ArtistId == artistId);

                return context.Tracks.Where(track => track.AlbumId == (album.AlbumId)).Take(5).ToList();


/*
                return context.Tracks
                    .Where(tr => tr.AlbumId == (context.Albums.FirstOrDefault(al => al.ArtistId == artistId).AlbumId))
                    .Take(5).ToList();
*/
            }

        }

        public List<IQueryable> OrderByGenre(int artistId)
        {
            using (var context = DataRepository.CreateContext())
            {
                var albums = context.Albums.Where(x => x.ArtistId == artistId);
                //var genre = context.Tracks.Where(tr=>albums.Where(albumid=>albumid.AlbumId==tr.AlbumId));

                var query1 = from tr in context.Tracks
                             join al in albums on tr.AlbumId equals al.AlbumId
                             group tr by tr.GenreId;
                return null;
            }
        }


    }
}
