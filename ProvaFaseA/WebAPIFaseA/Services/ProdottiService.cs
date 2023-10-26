using WebAPIFaseA.DTO;
using WebAPIFaseA.Entities;
using WebAPIFaseA.Repository;

namespace WebAPIFaseA.Services
{
    public class ProdottiService : IProdottiService
    {
        IRepository _repository;
        private ILogger<string> _logger;
        public ProdottiService(IRepository repository, ILogger<string> logger)
        => (_repository, _logger) = (repository, logger);
        public async Task<int> AddProdotto(Prodotto p)
        {
            try
            {
                return await _repository.CreaProdotto(p);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                throw;
            }
        }
    }
}
