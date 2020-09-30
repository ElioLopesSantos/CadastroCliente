using CadastroCliente.Models.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Models.Context
{
    public class ClienteContext :DbContext
    {
        public ClienteContext() :base("connectioDb")
        {

        }
        public DbSet<ClienteModel> ClienteModels { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}