using DesafioRepository;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioService
{
    public class ClienteService : ServiceBase<Cliente>, IClienteService
    {
       private ClienteRepository _clienteRepository;
        public ClienteService()
        {
            _clienteRepository = new ClienteRepository();
        }
        public void Update(Cliente cliente)
        {
            _clienteRepository.Update(cliente);
        }
    }
}
