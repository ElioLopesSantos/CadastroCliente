using CadastroCliente.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CadastroCliente.Models.Repository.Cliente
{
    public class ClienteRepository: Repository<ClienteModel>,IClienteRepository
    {
    }
}