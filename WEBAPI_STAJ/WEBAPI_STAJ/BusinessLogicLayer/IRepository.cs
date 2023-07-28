namespace WEBAPI_STAJ.BusinessLogicLayer
{
    public interface IRepository<TEntity>
    {
        TEntity FindById(params object[] values);
        IEnumerable<TEntity> FindAll();
        void Insert(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
    }
}
