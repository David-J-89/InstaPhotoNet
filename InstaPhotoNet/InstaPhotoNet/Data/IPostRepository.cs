using InstaPhotoNet.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace InstaPhotoNet.Data
{
    public interface IPostRepository
    {
        void Add<T>(T entity) where T : class;

        void Delete<T>(T entity) where T : class;

        Task<bool> SaveAll();

        Task<IEnumerable<Post>> GetPosts();

        Task<User> GetUser(int id);

        Task<Post> GetPost(int id);

        Task<Post> GetProfilePhotoForUser(int userId);
    }
}
