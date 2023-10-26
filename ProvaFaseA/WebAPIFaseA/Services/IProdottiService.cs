using WebAPIFaseA.DTO;
using WebAPIFaseA.Entities;

namespace WebAPIFaseA.Services
{
    public interface IProdottiService
    {
        Task<int> AddProdotto(Prodotto p);
    }
}
