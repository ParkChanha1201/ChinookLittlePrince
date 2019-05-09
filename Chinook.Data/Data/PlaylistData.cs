using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chinook.Data
{
    public class PlaylistData : DataRepository
    {
        public int GetCount()
        {
            using (var context = CreateContext())
                return context.Playlists.Count();
        }

        public List<Playlist> GetAll()
        {
            using (var context = CreateContext())
                return context.Playlists.ToList();
        }

        public Playlist GetByPK(int playlistId)
        {
            using (var context = CreateContext())
                return context.Playlists.Where(x => x.PlaylistId == playlistId).First();
        }

        public string Insert(Playlist playlist)
        {
            using (var context = CreateContext())
            {
                context.Entry(playlist).State = EntityState.Added;
                int result = context.SaveChanges();

                if (result < 1)
                    return "Insert 실패함";
                else
                    return "Insert 완료";
            }
        }
        public string Update(Playlist playlist)
        {
            using (var context = CreateContext())
            {
                context.Entry(playlist).State = EntityState.Modified;

                int result = context.SaveChanges();

                if (result < 1)
                    return "Update 됨";
                else
                    return "Update 실패함";
            }
        }
        public string Delete(Playlist playlist)
        {
            using (var context = CreateContext())
            {
                context.Entry(playlist).State = EntityState.Deleted;

                int result = context.SaveChanges();

                if (result < 1)
                    return "Delete 됨";
                else
                    return "Delete 실패함";
            }
        }

        
    }
}
