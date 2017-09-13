using System.Web.Services;
using Trabalho.Dominio.Classes;
using Trabalho.Dominio.Requests;
using Trabalho.Dominio.Responses;

namespace Trabalho
{
    /// <summary>
    /// Descrição resumida de TopGearService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/API/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que esse serviço da web seja chamado a partir do script, usando ASP.NET AJAX, remova os comentários da linha a seguir. 
    // [System.Web.Script.Services.ScriptService]
    public class TopGearService : System.Web.Services.WebService
    {

        [WebMethod]
        public CategoriaResponse ObterCategorias(CategoriaRequest req)
        {
            CategoriaResponse resp = new CategoriaResponse();

            if (req == null)
            {
                resp.Categorias.Add(new Categoria { Id = 0, Descricao = "Erro" });

                return resp;
            }
            else
            {
                resp.Categorias.Add(new Categoria { Id = 1, Descricao = "Luxo" });
                resp.Categorias.Add(new Categoria { Id = 2, Descricao = "Esporte" });
                resp.Categorias.Add(new Categoria { Id = 3, Descricao = "Popular" });
                resp.Categorias.Add(new Categoria { Id = 4, Descricao = "Vans" });

                return resp;
            }
        }
    }
}
