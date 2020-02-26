using PaternFactory.Bussines.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaternFactory.Bussines.Factory
{
    public interface IProductosFactory
    {
        ILaptop CrearLaptop();
        ITablet CrearTablet();
    }
}
