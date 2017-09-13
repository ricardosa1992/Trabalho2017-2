using System;
using System.Collections.Generic;
using System.Text;
using Trabalho.Dominio.Classes;

namespace Trabalho.Dominio.Responses
{
    public class CategoriaResponse
    {
        public CategoriaResponse()
        {
            Categorias = new List<Categoria>();
        }

        public List<Categoria> Categorias { get; set; }
    }
}
