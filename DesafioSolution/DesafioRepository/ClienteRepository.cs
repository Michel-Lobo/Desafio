using DesafioDataBase;
using Entities;
using System.Configuration;
using System.Data.SqlClient;
namespace DesafioRepository
{
    public class ClienteRepository: RepositoryBase<Cliente>, IClienteRepository
    {
         public ClienteRepository()
            :base(new DesafioContext())
        {

        }

        public void Update(Cliente cliente)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["DBDesafio"].ConnectionString; ;
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "update cliente set nomecliente = '" + cliente.NomeCliente +
                "', idporteempresa = " + cliente.IDPorteEmpresa + " where idcliente = " + cliente.IDCliente;
            conn.Open();
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            
        }

        
    }
}
