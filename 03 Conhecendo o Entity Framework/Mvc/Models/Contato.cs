using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mvc.Models
{
	public class Contato
	{
        public int ContatoId { get; set; }

        public string Nome { get; set; }

        public int Idade { get; set; }
        
        public string Telefone { get; set; }

        public string Email { get; set; }
    }
}