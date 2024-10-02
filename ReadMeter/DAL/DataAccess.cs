using DAL.EF;
using DAL.EF.TableModels;
using DAL.Interfaces;
using DAL.Repos;
using Microsoft.EntityFrameworkCore;

namespace DAL;

public class DataAccess
{
    
    public static IRepo<User, string, User> UserData(DbContextOptions<BContext> options)
    {
        return new UserRepo(options);
    }

    public static IRepo<Author, int, Author> AuthorData(DbContextOptions<BContext> options)
    {
        return new AuthorRepo(options);
    }

    public static IRepo<Book, int, Book> BookData(DbContextOptions<BContext> options)
    {
        return new BookRepo(options);
    }

    public static IRepo<Review, int, Review> ReviewData(DbContextOptions<BContext> options)
    {
        return new ReviewRepo(options);
    }

    public static IRepo<ReviewVote, int, ReviewVote> ReviewVoteData(DbContextOptions<BContext> options)
    {
        return new ReviewVoteRepo(options);
    }

    public static IRepo<Recommendation, int, Recommendation> RecommendationData(DbContextOptions<BContext> options)
    {
        return new RecommendationRepo(options);
    }

    public static IAuth AuthData(DbContextOptions<BContext> options)
    {
        return new UserRepo(options);
    }

    public static IRepo<Token, string, Token> TokenData(DbContextOptions<BContext> options)
    {
        return new TokenRepo(options);
    }
}