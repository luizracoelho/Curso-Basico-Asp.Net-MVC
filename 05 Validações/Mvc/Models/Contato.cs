using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Mvc.Models
{
	public class Contato
	{
        public int ContatoId { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required, Range(0,99)]
        public int Idade { get; set; }
        
        [Required, DataType(DataType.PhoneNumber)]
        public string Telefone { get; set; }

        [Required, Display(Name = "E-Mail"), DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}