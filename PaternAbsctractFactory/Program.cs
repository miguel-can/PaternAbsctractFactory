using PaternFactory.Bussines.Factory;
using PaternFactory.Bussines.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaternAbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {

            int iProveedor = 0, iProducto = 0;
            double dCantidad = 0;
            string cProveedor = string.Empty;
            string cRequisicion = string.Empty, cCotizacion = string.Empty;
            double dPrecio = 0, dIva = 0;

            IProductosFactory svrProductosFactory = null;
            ILaptop svrLaptop = null;
            ITablet svrTablet = null;


            Console.WriteLine("**** Sistema de Compras *****");
            Console.WriteLine("Proporcione el NÚMERO que corresponde al Proveedor:");
            Console.WriteLine("HP: 1");
            Console.WriteLine("DELL: 2");
            int.TryParse(Console.ReadLine(), out iProveedor);                
            Console.WriteLine("Proporcione el NÚMERO que corresponde al Producto:");
            Console.WriteLine("LAPTOP: 1");
            Console.WriteLine("TABLET: 2");
            int.TryParse(Console.ReadLine(), out iProducto);
            Console.WriteLine("Proporcione la cantidad del Producto");
            double.TryParse(Console.ReadLine(), out dCantidad);            


            switch (iProveedor)
            {
                case 1:
                    svrProductosFactory = new CreadorProdcutosHP();
                    cProveedor = "HP";
                    dPrecio = 5700;
                    dIva = 16;
                    break;
                case 2:
                    svrProductosFactory = new CreadorProductosDEL();
                    cProveedor = "DELL";
                    dPrecio = 6150;
                    dIva = 15;
                    break;
                default:
                    Console.WriteLine("Indique un Proveedor correcto");
                    break;
            }

            if (svrProductosFactory != null)
            {
                switch (iProducto)
                {
                    case 1:
                        svrLaptop = svrProductosFactory.CrearLaptop();
                        cRequisicion = svrLaptop.GeneraRequisicion(dCantidad, cProveedor);
                        cCotizacion = svrLaptop.GeneraCotizacion(dCantidad, dPrecio, dIva);
                        break;
                    case 2:
                        svrTablet = svrProductosFactory.CrearTablet();
                        cRequisicion = svrTablet.GeneraRequisicion(dCantidad, cProveedor);
                        cCotizacion = svrTablet.GeneraCotizacion(dCantidad, dPrecio, dIva);
                        break;
                    default:
                        Console.WriteLine("Indique un Producto correcto");
                        break;
                }

                Console.WriteLine(cRequisicion);
                Console.WriteLine(cCotizacion);
            }

            Console.Write("Presiona cualquier tecla para salir del programa...");
            Console.ReadKey();
        }
    }
}
