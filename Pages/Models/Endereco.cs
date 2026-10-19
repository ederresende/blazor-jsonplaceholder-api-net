using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorUsersJsonPlaceHolderApi.Pages.Models
{
    public class Usuario
    {
        public string Name { get; set; } = "";

        public Endereco Address { get; set; } = new();

        public Empresa Company { get; set; } = new();
    }

    public class Endereco
    {
        public string City { get; set; } = "";
    }

    public class Empresa
    {
        public string Name { get; set; } = "";
    }
}