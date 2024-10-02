using DAL.EF;
using DAL.EF.TableModels;
using DAL.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repos;

internal class TokenRepo : Repo, IRepo<Token, string, Token>
{
    
    public TokenRepo(DbContextOptions<BContext> options) : base(options)
    {
    }
    
    public Token Create(Token obj)
    {
        db.Tokens.Add(obj);
        db.SaveChanges();
        return obj;
    }

    public bool Delete(string id)
    {
        var exobj = Get(id);
        db.Tokens.Remove(exobj);
        return db.SaveChanges() > 0;
    }

    public List<Token> Get()
    {
        return db.Tokens.ToList();
    }

    public Token Get(string id)
    {
        return db.Tokens.SingleOrDefault(x => x.Key.Equals(id));
    }

    public Token Update(Token obj)
    {
        var exobj = Get(obj.Key);
        exobj.ExpiredAt = obj.ExpiredAt;
        db.SaveChanges();
        return obj;
    }
}