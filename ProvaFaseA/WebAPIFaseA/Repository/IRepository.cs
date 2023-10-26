using WebAPIFaseA.Entities;

namespace WebAPIFaseA.Repository
{
    public interface IRepository
    {
        Task<List<Cliente>> RestituisciClienti();
        Task<Cliente> RestituisciCliente(int id);
        Task<int> AggiungiCliente(Cliente cliente);
        Task<int> AggiornaPassward(Cliente c);
        Task<int> CreaProdotto(Prodotto p);
        Task<int> AggiornaProdotto(Prodotto p);
        Task<int> AggiungiCarrrello(Carrello carrello);
        Task<List<Carrello>> RestituisciCarrello(int idCliente);
    }
}
