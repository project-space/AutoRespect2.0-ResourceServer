using System.Threading.Tasks;
using AutoRespect.ResourceServer.Design.Models;

namespace AutoRespect.ResourceServer.Design.Interfaces.DataAccess
{
    public interface ILicencePlateSaver
    {
        Task<int> Save (LicencePlate )
    }
}
