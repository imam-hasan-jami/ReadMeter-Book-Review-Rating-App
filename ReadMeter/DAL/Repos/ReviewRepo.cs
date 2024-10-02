using DAL.EF;
using DAL.EF.TableModels;
using DAL.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repos;

internal class ReviewRepo : Repo, IRepo<Review, int, Review>
{
    
    public ReviewRepo(DbContextOptions<BContext> options) : base(options)
    {
    }
    
    public Review Create(Review obj)
    {
        db.Reviews.Add(obj);
        db.SaveChanges();
        return obj;
    }

    public bool Delete(int id)
    {
        var exobj = Get(id);
        db.Reviews.Remove(exobj);
        return db.SaveChanges() > 0;
    }

    public List<Review> Get()
    {
        return db.Reviews.ToList();
    }

    public Review Get(int id)
    {
        return db.Reviews.Find(id);
    }

    public Review Update(Review obj)
    {
        var exobj = Get(obj.ReviewId);
        obj.ReviewDate = exobj.ReviewDate;
        obj.UpdatedDate = DateTime.Now;
        db.Entry(exobj).CurrentValues.SetValues(obj);
        db.SaveChanges();
        return obj;
    }
}