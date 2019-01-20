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

        Task<IEnumerable<Photo>> GetPhotos();

        Task<IEnumerable<User>> GetUsers();

        Task<User> GetUser(int id);

        Task<Photo> GetPhoto(int id);

        Task<Photo> GetProfilePhotoForUser(int userId);
    }
}
