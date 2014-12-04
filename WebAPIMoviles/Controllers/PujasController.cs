using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Repositorio;
using WebAPIMoviles.Models;
using WebAPIMoviles.Models.ViewModel;
using WebAPIMoviles.Repositorio;

namespace WebAPIMoviles.Controllers
{
    public class PujasController : ApiController
    {
        private IRepositorio<PujasViewModel, Pujas> repo =
            new Repositorio<PujasViewModel, Pujas>
                (new VentaTelefonoEntities());

        // GET: api/Pujas
        public IEnumerable<PujasViewModel> Get()
        {
            var data = repo.Get();
            return data;
        }

        // GET: api/Pujas/5
        public PujasViewModel Get(int id)
        {
            return repo.Get(id);
        }

        // POST: api/Pujas
        public void Post([FromBody]PujasViewModel value)
        {
            repo.Add(value);
        }

        // PUT: api/Pujas/5
        public void Put(int id, [FromBody]PujasViewModel value)
        {
            repo.Actualizar(value);
        }

        // DELETE: api/Pujas/5
        public void Delete(int id)
        {
            repo.Borrar(id);
        }
    }
}
