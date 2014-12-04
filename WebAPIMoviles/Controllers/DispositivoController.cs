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
    public class DispositivoController : ApiController
    {
        private IRepositorio<DispositivoViewModel, Dispositivo> repo =
            new Repositorio<DispositivoViewModel, Dispositivo>
                (new VentaTelefonoEntities());

        // GET: api/Dispositivo
        public IEnumerable<DispositivoViewModel> Get()
        {
            var data = repo.Get();
            return data;
        }

        // GET: api/Dispositivo/5
        public DispositivoViewModel Get(int id)
        {
            return repo.Get(id);
        }

        // POST: api/Dispositivo
        public void Post([FromBody]DispositivoViewModel value)
        {
            repo.Add(value);
        }

        // PUT: api/Dispositivo/5
        public void Put(int id, [FromBody]DispositivoViewModel value)
        {
            repo.Actualizar(value);
        }

        // DELETE: api/Dispositivo/5
        public void Delete(int id)
        {
            repo.Borrar(id);
        }
    }
}
