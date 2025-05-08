using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.FactoryPattern
{
    //Creador(factorizar nuestro factory)
    //Clase abstract para poder tener atributos. En una interface no se pueden utilizar atributos
    public abstract class SaleFactory
    {
        public abstract ISale GetSale();
    }

    //Fabrica del objeto que hereda la clase abstracta. De la clase creador 
    public class StoreSaleFactory : SaleFactory
    {
        private decimal _extra;
        public StoreSaleFactory(decimal extra)
        {
            _extra = extra;
        }
        public override ISale GetSale()
        {
            return new StoreSale(_extra);
        }
    }
    //Fabrica del objeto que hereda la clase abstracta. De la clase creador 
    public class InternetSaleFactory : SaleFactory
    {
        private decimal _discount;
        public InternetSaleFactory(decimal discount)
        {
            _discount = discount;
        }
        public override ISale GetSale()
        {
            return new InternetSale(_discount);
        }
    }
    //Producto concreto/real
    public class StoreSale : ISale
    {
        private decimal _extra;
        public StoreSale(decimal extra)
        {
            _extra = extra;
        }
        public void Sell(decimal total)
        {
            Console.WriteLine($"La venta en tienda tiene un total de {total + _extra}");
        } 
    }
    //Producto concreto/real
    public class InternetSale : ISale
    {
        private decimal _discount;
        public InternetSale(decimal discount)
        {
            _discount = discount;
        }
        public void Sell(decimal total)
        {
            Console.WriteLine($"La venta por internet tiene un total de {total - _discount}");
        }
    }



    //Producto(factorizar nuestro factory)
    public interface ISale
    {
        public void Sell(decimal total);
    }
}

