using WebAPIFaseA.Entities;

namespace WebAPIFaseA.Services
{
    public interface ICarrelloService
    {
        Task<int> UpdateProdotto(int id);
        Task<int> AddCarrrello(Carrello carrello);
        Task<List<Carrello>> GetCarrello(int idCliente);
    }
}
