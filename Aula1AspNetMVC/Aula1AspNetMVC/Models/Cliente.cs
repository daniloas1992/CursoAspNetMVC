using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Aula1AspNetMVC.Models
{
    public class Cliente
    {

        [Key]
        public int Id { get; set; }

        [MaxLength(150, ErrorMessage = "Máximo de caracteres excedido!")]
        [MinLength(2, ErrorMessage= "Mínimo de 2 caracteres!")]
        [Display(Name = "Nome do Cliente")]
        [Required(ErrorMessage="É necessário preencher o campo Nome!")]
        public String Nome { get; set; }


        [MaxLength(150, ErrorMessage = "Máximo de caracteres excedido!")]
        [MinLength(2, ErrorMessage = "Mínimo de 2 caracteres!")]
        [Display(Name = "Sobrenome do Cliente")]
        [Required(ErrorMessage = "É necessário preencher o campo Sobrenome!")]
        public String Sobrenome { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }

        [MaxLength(150, ErrorMessage = "Máximo de caracteres excedido!")]
        [MinLength(2, ErrorMessage = "Mínimo de 2 caracteres!")]
        [Display(Name = "Email do Cliente")]
        [Required(ErrorMessage = "É necessário preencher o campo Email!")]
        [EmailAddress(ErrorMessage = "E-mail em formato inválido!")]
        public String Email { get; set; }

    }
}