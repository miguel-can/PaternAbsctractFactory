using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaternFactory.Bussines.Interface
{
    public interface ITablet
    {
        string GeneraRequisicion(double _dCantidad, string _cProveedor);

        string GeneraCotizacion(double _dCantidad, double _dPrecio, double _dIva);
    }
}
