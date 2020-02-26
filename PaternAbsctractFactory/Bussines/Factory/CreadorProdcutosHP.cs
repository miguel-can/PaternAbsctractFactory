using PaternFactory.Bussines.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaternFactory.Bussines.Factory
{
    public class CreadorProdcutosHP : IProductosFactory
    {
        public ILaptop CrearLaptop()
        {
            return new LaptopHP();
        }
        public ITablet CrearTablet()
        {
            return new TabletHP();
        }
    }
}
