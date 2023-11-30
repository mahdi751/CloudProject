using APICloud.Models;

namespace APICloud.Interfaces
{
    public interface IAccountRepository
    {
        public Task<bool> AddUser(User user);
        public Task<bool> Save();
    }
}
