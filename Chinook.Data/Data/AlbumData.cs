using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chinook.Data
{
    public class AlbumData : DataRepository
    {
        public int GetCount()
        {
            using (var context = CreateContext())
                return context.Albums.Count();
        }

        public List<Album> GetAll()
        {
            using (var context = CreateContext())
                return context.Albums.ToList();
        }

        public Album GetByPK(int albumId)
        {
            using (var context = CreateContext())
                return context.Albums.Where(x => x.AlbumId == albumId).First();
        }

        public string Insert(Album album)
        {
            using (var context = CreateContext())
            {
                context.Albums.Add(album);

                int result = context.SaveChanges();

                if (result < 1)
                    return "Insert 실패함";
                else
                    return "Insert 완료";
            }
        }

        public string Update(Album album)
        {
            using (var context = CreateContext())
            {
                context.Entry(album).State = EntityState.Modified;
                int result = context.SaveChanges();

                if (result < 1)
                    return "Update 됨";
                else
                    return "Update 실패함";
            }
        }

        public string Delete(Album album)
        {
            using (var context = CreateContext())
            {
                context.Entry(album).State = EntityState.Deleted;
                int result = context.SaveChanges();

                if (result < 1)
                    return "Delete 됨";
                else
                    return "Delete 실패함";
            }
        }
    }
}
