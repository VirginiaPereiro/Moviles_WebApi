using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPIMoviles.Models.ViewModel
{
    public class SubastasViewModel:IViewModel<Subastas>
    {
        public int idSubasta { get; set; }
        public int idDispositivo { get; set; }
        public decimal precioInicial { get; set; }
        public System.DateTime fin { get; set; }

        public virtual Dispositivo Dispositivo { get; set; }
        public virtual ICollection<Pujas> Pujas { get; set; }

        public Subastas ToBaseDatos()
        {
            var model = new Subastas()
            {
                idSubasta = idSubasta,
                idDispositivo = idDispositivo,
                precioInicial = precioInicial,
                fin = fin
            };
            return model;
        }

        public void FromBaseDatos(Subastas model)
        {
            idSubasta = model.idSubasta;
            idDispositivo = model.idDispositivo;
            precioInicial = model.precioInicial;
            fin = model.fin;
        }

        public void UpdateBaseDatos(Subastas model)
        {
            model.idSubasta = idSubasta;
            model.idDispositivo = idDispositivo;
            model.precioInicial = precioInicial;
            model.fin = fin;
        }

        public int[] GetPk()
        {
            return new[] { idSubasta };
        }
    }
}