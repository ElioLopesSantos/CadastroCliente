using CadastroCliente.Models.Model;
using CadastroCliente.Models.Repository;
using CadastroCliente.Models.Repository.Cliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CadastroCliente.Models.Negocio
{
    public class ClienteNegocio
    {
        IClienteRepository repository;

        public ClienteNegocio()
        {
            repository = new ClienteRepository();
        }
        public List<ClienteModel> GetAllClientes()
        {
            return repository.GetTodos().ToList();
        }
        public void SalvarCliente(ClienteModel model)
        {
            repository.Adicionar(model);
            repository.Commit();

        }
        public void DeletarCliente(ClienteModel model)
        {
            repository.Deletar(x=>x == model);
            repository.Commit();
        }
        public void AlterarCliente(ClienteModel model)
        {
            repository.Atualizar(model);
            repository.Commit();
        }
        public ClienteModel GetClienteModelById (int ClienteId)
        {
           return repository.First(x => x.ClienteId == ClienteId);
           
        }
    }
}