using PaternFactory.Bussines.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaternFactory.Bussines.Factory
{
    public class CreadorProductosDEL : IProductosFactory
    {
        public ILaptop CrearLaptop()
        {
            return new LaptopDEL();
        }
        public ITablet CrearTablet()
        {
            return new TabletDEL();
        }
    }
}
