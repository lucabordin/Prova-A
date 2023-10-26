using WebAPIFaseA.DataSource;
using WebAPIFaseA.Entities;
using WebAPIFaseA.Repository;

namespace WebAPIFaseA.Services
{
    public class CarrelloService: ICarrelloService
    {
        IRepository _repository;
        private ILogger<string> _logger;
        private ProvaAContext _prova;
        public CarrelloService(IRepository repository, ILogger<string> logger, ProvaAContext prova)
        => (_repository, _logger, _prova) = (repository, logger, prova);
        public async Task<int> AddCarrrello(Carrello carrello)
        {
            try
            {
                return await _repository.AggiungiCarrrello(carrello);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                throw;
            }
        }

        public async Task<List<Carrello>> GetCarrello(int idCliente)
        {
            try
            {
                return await _repository.RestituisciCarrello(idCliente);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                throw;
            }
        }

        public async Task<int> UpdateProdotto(int id)
        {
            try
            {
                Carrello c = await _prova.Carrelli.FindAsync(id);
                Prodotto p = await _prova.Prodotti.FindAsync(c.IdProdotto);
                p.Giacenza = p.Giacenza-c.QuantitaProdotto;
                return await _repository.AggiornaProdotto(p);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                throw;
            }
        }
    }
}
