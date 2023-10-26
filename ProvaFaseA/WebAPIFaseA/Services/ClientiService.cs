using WebAPIFaseA.DTO;
using WebAPIFaseA.Entities;
using WebAPIFaseA.Repository;

namespace WebAPIFaseA.Services
{
    public class ClientiService : IClientiService
    {
        IRepository _repository;
        private ILogger<string> _logger;
        public ClientiService(IRepository repository, ILogger<string> logger)
        => (_repository, _logger) = (repository, logger);
        public async Task<int> AddCliente(Cliente cliente)
        {
            try
            {
                return await _repository.AggiungiCliente(cliente);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                throw;
            }
        }

        public async Task<RestituisciClienteDto> GetCliente(int id)
        {
            try
            {
                var c = await _repository.RestituisciCliente(id);
                return new RestituisciClienteDto { Nome=c.Nome, Cognome=c.Cognome, DataDiNascita=c.DataDiNascita, Email=c.Email, IdCliente=c.IdCliente };
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                throw;
            }
        }

        public async Task<List<Cliente>> GetClienti()
        {
            try
            {
                return await _repository.RestituisciClienti();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                throw;
            }
        }

        public async Task<int> UpdatePassward(int id, ModificaPasswardDto passward)
        {
            try
            {
                Cliente c = await _repository.RestituisciCliente(id);
                c.Passward = passward.Passward;
                return await _repository.AggiornaPassward(c);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                throw;
            }
        }
    }
}
