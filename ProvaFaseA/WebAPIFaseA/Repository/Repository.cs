using Microsoft.EntityFrameworkCore;
using WebAPIFaseA.DataSource;
using WebAPIFaseA.Entities;

namespace WebAPIFaseA.Repository
{
    public class Repository : IRepository
    {
        ProvaAContext _prova;
        public Repository(ProvaAContext prova)
        => _prova = prova;
        public async Task<int> AggiornaPassward(Cliente c)
        {
            int numeroRecordsInseriti = 0;
            try
            {
                _prova.Entry(c).State = EntityState.Modified;
                numeroRecordsInseriti = await _prova.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw;
            }
            return numeroRecordsInseriti;
        }

        public async Task<int> AggiornaProdotto(Prodotto p)
        {
            int numeroRecordsInseriti = 0;
            try
            {
                _prova.Entry(p).State = EntityState.Modified;
                numeroRecordsInseriti = await _prova.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw;
            }
            return numeroRecordsInseriti;
        }

        public async Task<int> AggiungiCarrrello(Carrello carrello)
        {
            _prova.Entry(carrello).State = EntityState.Added;
            try
            {
                int numeroRecordsInseriti = await _prova.SaveChangesAsync();
                if (numeroRecordsInseriti != 1)
                {
                    string messaggioErrore = "Operazione di inerimento non effettuata";
                    throw new Exception(messaggioErrore);
                }
                return numeroRecordsInseriti;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<int> AggiungiCliente(Cliente cliente)
        {
            _prova.Entry(cliente).State = EntityState.Added;
            try
            {
                int numeroRecordsInseriti = await _prova.SaveChangesAsync();
                if (numeroRecordsInseriti != 1)
                {
                    string messaggioErrore = "Operazione di inerimento non effettuata";
                    throw new Exception(messaggioErrore);
                }
                return numeroRecordsInseriti;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<int> CreaProdotto(Prodotto p)
        {
            _prova.Entry(p).State = EntityState.Added;
            try
            {
                int numeroRecordsInseriti = await _prova.SaveChangesAsync();
                if (numeroRecordsInseriti != 1)
                {
                    string messaggioErrore = "Operazione di inerimento non effettuata";
                    throw new Exception(messaggioErrore);
                }
                return numeroRecordsInseriti;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<List<Carrello>> RestituisciCarrello(int idCliente)
        {
            try
            {
                var cliente = await _prova.Carrelli.Where(c => c.IdCliente == idCliente).ToListAsync();
                return cliente;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Cliente> RestituisciCliente(int id)
        {
            try
            {
                var cliente = await _prova.Clienti.FindAsync(id);
                return cliente;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<List<Cliente>> RestituisciClienti()
        {
            try
            {
                var lista = await _prova.Clienti.ToListAsync();
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
