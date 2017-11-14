using System.Threading.Tasks;
using AutoRespect.ResourceServer.Design.Models;
using Microsoft.AspNetCore.Mvc;

namespace AutoRespect.ResourceServer.Api.Controllers
{
    public class LicencePlateController : Controller
    {
        [HttpPost]
        public async Task<IActionResult> Post(LicencePlate licencePlate)
        {
            return null;
        }


        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return null;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return null;
        }
    }
}
