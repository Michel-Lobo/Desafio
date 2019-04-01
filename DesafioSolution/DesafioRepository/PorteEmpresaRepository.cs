using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioRepository
{
    public class PorteEmpresaRepository: RepositoryBase<PorteEmpresa>, IPorteEmpresa
    {
        public PorteEmpresaRepository()
            :base(new DesafioDataBase.DesafioContext())
        {

        }

    }
}
