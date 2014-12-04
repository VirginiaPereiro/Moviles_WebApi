using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPIMoviles.Models.ViewModel
{
    public class DispositivoViewModel:IViewModel<Dispositivo>
    {
        public int id { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }
        public string foto { get; set; }
        public string descripcion { get; set; }

        public virtual ICollection<Subastas> Subastas { get; set; }



        public Dispositivo ToBaseDatos()
        {
            var model = new Dispositivo()
            {
                id = id,
                marca = marca,
                modelo=modelo,
                foto=foto,
                descripcion = descripcion
            };
            return model;
        }

        public void FromBaseDatos(Dispositivo model)
        {
            id = model.id;
            marca = model.marca;
            modelo = model.modelo;
            foto = model.foto;
            descripcion = model.descripcion;
        }

        public void UpdateBaseDatos(Dispositivo model)
        {
            model.id = id;
            model.marca = marca;
            model.modelo = modelo;
            model.foto = foto;
            model.descripcion = descripcion;
        }

        public int[] GetPk()
        {
            return new[] { id };
        }
    }
}