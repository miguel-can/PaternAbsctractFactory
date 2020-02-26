using PaternFactory.Bussines.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaternFactory.Bussines
{
    public class LaptopHP : ILaptop
    {
        public string GeneraRequisicion(double _dCantidad, string _cProveedor)
        {
            return string.Format("Requisición: Compra de {0} {1} con {2}", _dCantidad, "Laptop", _cProveedor);
        }

        public string GeneraCotizacion(double _dCantidad, double _dPrecio, double _dIva)
        {
            double dCotizacion = 0, dImporte = 0, dIva = 0;
            dImporte = CalculaImporte(_dCantidad, _dPrecio);
            dIva = CalculaIva(dImporte, _dIva);
            dCotizacion = dImporte + dIva;
            return string.Format("Cotización: La compra tendría un importe de {0} con el {1} porciento de IVA aplicado ", dCotizacion, _dIva);
        }

        private double CalculaImporte(double _dCantidad, double _dPrecio)
        {
            return (_dCantidad * _dPrecio);
        }
        private double CalculaIva(double _dImporte, double _dIva)
        {
            return _dImporte * (_dIva / 100);
        }
    }
}
