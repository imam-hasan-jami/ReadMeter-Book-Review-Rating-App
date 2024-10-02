using DAL.EF.TableModels;
using DAL.Interfaces;
using DAL.Repos;

namespace DAL;

public class DataAccess
{
    public static IRepo<User, string, User> UserData()
    {
        return new UserRepo();
    }

    public static IRepo<Author, int, Author> AuthorData()
    {
        return new AuthorRepo();
    }

    public static IRepo<Book, int, Book> BookData()
    {
        return new BookRepo();
    }

    public static IRepo<Review, int, Review> ReviewData()
    {
        return new ReviewRepo();
    }

    public static IRepo<ReviewVote, int, ReviewVote> ReviewVoteData()
    {
        return new ReviewVoteRepo();
    }

    public static IRepo<Recommendation, int, Recommendation> RecommendationData()
    {
        return new RecommendationRepo();
    }

    public static IAuth AuthData()
    {
        return new UserRepo();
    }

    public static IRepo<Token, string, Token> TokenData()
    {
        return new TokenRepo();
    }
}