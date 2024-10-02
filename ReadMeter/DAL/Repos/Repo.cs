using DAL.EF;

namespace DAL.Repos;

internal class Repo
{
    protected BContext db;

    internal Repo()
    {
        db = new BContext();
    }
}