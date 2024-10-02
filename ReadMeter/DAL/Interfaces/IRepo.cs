namespace DAL.Interfaces;

public interface IRepo<CLASS, ID, RET>
{
    RET Create (CLASS obj);
    List<CLASS> Get();
    CLASS Get(ID id);
    RET Update(CLASS obj);
    bool Delete(ID id);
}