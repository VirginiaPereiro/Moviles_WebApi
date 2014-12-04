using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPIMoviles.Models.ViewModel
{
    public class PujasViewModel:IViewModel<Pujas>
    {
        public int idPuja { get; set; }
        public int idSubasta { get; set; }
        public decimal valor { get; set; }

        public virtual Subastas Subastas { get; set; }


        public Pujas ToBaseDatos()
        {
            var model = new Pujas()
            {
                idPuja = idPuja,
                idSubasta = idSubasta,
                valor = valor
            };

            return model;
        }

        public void FromBaseDatos(Pujas model)
        {
            idPuja = model.idPuja;
            idSubasta = model.idSubasta;
            valor = model.valor;
        }

        public void UpdateBaseDatos(Pujas model)
        {
            model.idPuja = idPuja;
            model.idSubasta = idSubasta;
            model.valor = valor;
        }

        public int[] GetPk()
        {
            return new[] { idPuja };
        }
    }
}