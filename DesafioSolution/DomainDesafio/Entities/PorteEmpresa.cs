using System.Collections.Generic;

namespace Entities
{
    public class PorteEmpresa : BaseEntity
    {
        public int IDPorteEmpresa { get; set; }
        public string NomePorteEmpresa { get; set; }
        public ICollection<Cliente> Clientes { get; set; }
    }
}