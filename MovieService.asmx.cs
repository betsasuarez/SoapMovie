using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace SoapMovie
{
    /// <summary>
    /// Descripción breve de MovieService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class MovieService : System.Web.Services.WebService
    {

        [WebMethod]

        public List<Movie> GetMovies()
        {
            List<Movie> movies = new List<Movie>
        {
            new Movie { Title = "El Exorcista", Genre = "Terror" },
            new Movie { Title = "Barbie", Genre = "Animación" },
            new Movie { Title = "El Conjuro", Genre = "Terror" },
            new Movie { Title = "Marte necesita mamás", Genre = "Ciencia ficción" }
        };

            return movies;
        }
    }
}

