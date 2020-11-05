using System.Threading.Tasks;
using WebApiEntityFramework.Reponse;

namespace WebApiEntityFramework.Code.Interfaces
{
    public interface IUserQueries
    {
        Task<ServerResponse> ReturnUser(uint idUser);
    }
}
