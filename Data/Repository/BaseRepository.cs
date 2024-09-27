namespace Data.Repository
{
    public class BaseRepository<T> : IRepository<T> where T : class
    {
        public virtual Task<T> GetAsync(string id)
        {
            throw new NotImplementedException();
        }

        public virtual Task<List<T>> GetRangeAsync(List<string> ids)
        {
            throw new NotImplementedException();
        }

        public virtual Task<List<T>> GetAllAsync()
        {
            throw new NotImplementedException();
        }
    }
}
