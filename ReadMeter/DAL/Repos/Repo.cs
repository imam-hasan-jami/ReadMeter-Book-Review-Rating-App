using DAL.EF;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repos;

internal class Repo
{
    protected BContext db;

    internal Repo(DbContextOptions<BContext> options)
    {
        db = new BContext(options);
    }
}