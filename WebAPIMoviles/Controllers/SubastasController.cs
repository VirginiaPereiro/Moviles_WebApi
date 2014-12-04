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
    public class SubastasController : ApiController
    {
        private IRepositorio<SubastasViewModel, Subastas> repo =
            new Repositorio<SubastasViewModel, Subastas>
                (new VentaTelefonoEntities());

        // GET: api/Subastas
        public IEnumerable<SubastasViewModel> Get()
        {
            var data = repo.Get();
            return data;
        }

        // GET: api/Subastas/5
        public SubastasViewModel Get(int id)
        {
            return repo.Get(id);
        }

        // POST: api/Subastas
        public void Post([FromBody]SubastasViewModel value)
        {
            repo.Add(value);
        }

        // PUT: api/Subastas/5
        public void Put(int id, [FromBody]SubastasViewModel value)
        {
            repo.Actualizar(value);
        }

        // DELETE: api/Subastas/5
        public void Delete(int id)
        {
            repo.Borrar(id);
        }
    }
}
