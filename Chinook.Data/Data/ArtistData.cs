using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chinook.Data
{
    public class ArtistData : DataRepository
    {
        public int GetCount()
        {
            using (var context = CreateContext())
                return context.Artists.Count();
        }

        public List<Artist> GetAll()
        {
            using (var context = CreateContext())
                return context.Artists.ToList();
        }

        public Artist GetByPK(int artistId)
        {
            using (var context = CreateContext())
                return context.Artists.First(x => x.ArtistId == artistId);
        }

        public string Insert(Artist artist)
        {
            using (var context = CreateContext())
            {
                context.Entry(artist).State = EntityState.Added;
                int result = context.SaveChanges();

                return result < 1 ? "Insert 실패함" : "Insert 완료";
            }
        }
        public string Update(Artist artist)
        {
            using (var context = CreateContext())
            {
                context.Entry(artist).State = EntityState.Modified;

                var result = context.SaveChanges();

                return result < 1 ? "Update 됨" : "Update 실패함";
            }
        }
        public string Delete(Artist artist)
        {
            using (var context = CreateContext())
            {
                context.Entry(artist).State = EntityState.Deleted;

                var result = context.SaveChanges();

                return result < 1 ? "Delete 됨" : "Delete 실패함";
            }
        }
    }
}
