using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Filmes.Models
{
    public class Login
    {
        public Login()
        {
            LoginId = Guid.NewGuid();
        }
        public Guid LoginId { get; set; }
        public string UsuarioLogin { get; set; }
        public string UsuarioSenha { get; set; }
    }
}