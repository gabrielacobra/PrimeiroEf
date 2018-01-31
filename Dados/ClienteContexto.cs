using Microsoft.EntityFrameworkCore;
using PrimeiroEf.Models;

namespace PrimeiroEf.Dados
{
    public class ClienteContexto:DbContext
    {
        public ClienteContexto(DbContextOptions<ClienteContexto> options):base(options){}
        
        public DbSet<Cliente> ClienteBase { get ; set ;} 
        //criando uma tabela 
        //de dados virtual e dizendo qual tipo de dados 
        //são aceitos (Cliente, neste caso). 
        //Aqui é onde são incluídos os dados
        
    }
}