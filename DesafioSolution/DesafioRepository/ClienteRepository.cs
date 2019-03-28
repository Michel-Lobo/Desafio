using DesafioDataBase;
using Entities;

namespace DesafioRepository
{
    public class ClienteRepository: RepositoryBase<Cliente>, IClienteRepository
    {
         public ClienteRepository()
            :base(new DesafioContext())
        {

        }
    }
}
