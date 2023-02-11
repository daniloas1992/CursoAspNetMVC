using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Aula1AspNetMVC.Models
{
    public class Cliente
    {

        public int Id { get; set; }
        public String Nome { get; set; }
        public String Sobrenome { get; set; }
        public DateTime DataCadastro { get; set; }

    }
}