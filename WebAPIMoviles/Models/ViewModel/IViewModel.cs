using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPIMoviles.Models.ViewModel
{
    public interface IViewModel<TModelo> where TModelo:class 
    {
        TModelo ToBaseDatos();
        void FromBaseDatos(TModelo model);
        void UpdateBaseDatos(TModelo model);
        int[] GetPk();
    }
}
