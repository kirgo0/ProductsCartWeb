namespace Data.Repository
{
    public class BaseRepository<T, TId> : IRepository<T, TId> where T : class
    {
        public virtual Task<T> GetAsync(TId id)
        {
            throw new NotImplementedException();
        }

        public virtual Task<List<T>> GetRangeAsync(List<TId> ids)
        {
            throw new NotImplementedException();
        }

        public virtual Task<List<T>> GetAllAsync()
        {
            throw new NotImplementedException();
        }
    }
}
