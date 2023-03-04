using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Aula1AspNetMVC.Models;

namespace Aula1AspNetMVC.Context
{
    public class Aula1Context : DbContext
    {
        public Aula1Context() : base("Aula1Context") // É o mesmo configurado no Web.config <connectionStrings>
        {

        }

        public DbSet<Cliente> Cliente { get; set; } //EntityFramework usa para acessar campos da tabela
    }
}