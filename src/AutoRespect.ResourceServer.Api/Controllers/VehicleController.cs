using System.Threading.Tasks;
using AutoRespect.ResourceServer.Design.Models;
using Microsoft.AspNetCore.Mvc;

namespace AutoRespect.ResourceServer.Api.Controllers
{
    public class VehicleController : Controller
    {
        [HttpPost]
        public async Task<IActionResult> Post(Vehicle vehicle)
        {
            return null;
        }
    }
}
