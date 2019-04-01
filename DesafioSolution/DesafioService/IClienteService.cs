using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioService
{
    public interface IClienteService: IServiceBase<Cliente>
    {
        void Update(Cliente cliente);
    }
}
