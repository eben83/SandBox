using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace OdeToFood.Data
{
    public class SqlRestarantData : IRestaurantData
    {
        private readonly OdeToFoodDbContext db;

        public SqlRestarantData(OdeToFoodDbContext db)
        {
            this.db = db;
        }

        public Restarant Add(Restarant newRestarant)
        {
            db.Add(newRestarant);
            return newRestarant;
        }

        public int Commit()
        {
            return db.SaveChanges();
        }

        public Restarant Delete(int id)
        {
            var restarant = GetById(id);
            if (restarant != null)
            {
                db.Restarants.Remove(restarant);
            }
            return restarant;
        }

        public Restarant GetById(int id)
        {
            return db.Restarants.Find(id);
        }

        public IEnumerable<Restarant> GetRestaurantsByName(string name)
        {
            var query = from r in db.Restarants
                        where r.Name.StartsWith(name) || string.IsNullOrEmpty(name)
                        orderby r.Name
                        select r;
            return query;
        }

        public Restarant Update(Restarant updatedRestarant)
        {
            var entity = db.Restarants.Attach(updatedRestarant);
            entity.State = EntityState.Modified;
            return updatedRestarant;
        }
    }
}
