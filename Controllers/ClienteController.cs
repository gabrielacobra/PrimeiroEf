using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using PrimeiroEf.Dados;
using PrimeiroEf.Models;

namespace PrimeiroEf.Controllers
{
    [Route("api/[controller]")]
    public class ClienteController:Controller
    { 
        Cliente cliente = new Cliente();
        
        readonly ClienteContexto contexto; //por motivos de segurança, não será possível incluir nada no contexto

        public ClienteController(ClienteContexto contexto){
            this.contexto = contexto;
        }

        [HttpGet]
        public IEnumerable<Cliente> Listar(){
        
        return contexto.ClienteBase.ToList();  //listando todos          
        }

        [HttpGet("{id}")]
        public Cliente Listar(int id){
            return contexto.ClienteBase.Where(x=>x.Id==id).FirstOrDefault(); //listando um único cliente, por id
        }

        [HttpPost]
        public void Cadastrar([FromBody]Cliente cli){
            contexto.ClienteBase.Add(cli);
            contexto.SaveChanges();
        }
    }
}