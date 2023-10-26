using WebAPIFaseA.DTO;
using WebAPIFaseA.Entities;

namespace WebAPIFaseA.Services
{
    public interface IClientiService
    {
        Task<List<Cliente>> GetClienti();
        Task<RestituisciClienteDto> GetCliente(int id);
        Task<int> AddCliente(Cliente cliente);
        Task<int> UpdatePassward(int id, ModificaPasswardDto passward);
    }
}
