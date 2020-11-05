using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WebApiEntityFramework.Code.Interfaces;

namespace WebApiEntityFramework.Controllers
{
    [Route("[controller]/api")]
    public class UserController : ControllerBase
    {
        [HttpGet("{iduser}")]
        [AllowAnonymous]
        public async Task<IActionResult> Get(
            uint idUser,
            [FromServices] IUserQueries userQueries)
            => Ok(await userQueries.ReturnUser(idUser));
    }
}
