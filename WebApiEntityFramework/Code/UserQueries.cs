using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using WebApiEntityFramework.Code.Interfaces;
using WebApiEntityFramework.Entities.ContextConfig;
using WebApiEntityFramework.Reponse;

namespace WebApiEntityFramework.Code
{
    public class UserQueries : IUserQueries
    {
        public readonly Context _context;

        public UserQueries(Context context)
        {
            _context = context;
        }

        public async Task<ServerResponse> ReturnUser(uint idUser)
        {
            var user = await _context.tblUsuario.Where(x => x.IdUsuario == idUser).AsTracking().SingleOrDefaultAsync();

            return new ServerResponse { Data = user };
        }
    }
}
