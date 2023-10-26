using WebAPIFaseA.Entities;

namespace WebAPIFaseA.Services
{
    public interface IClienteService
    {
        //crud
        Task<List<Cliente>> ReadTuttiIClienti();
        Task<Cliente> ReadSingoloCliente(int id);
        Task UpdatePasswordCliente(Cliente p);

        Task RegistraCliente(Cliente cliente);
       

    }
}
