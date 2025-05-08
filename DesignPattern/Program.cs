using DesignPattern.FactoryPattern;
using DesignPattern.Singleton;

//var singleton = Singleton.Instance;
var log = Log.Instance;
log.Save("Singleton");
log.Save("Singleton 2");
//Para comprobar que es el mismo objeto
var a = Singleton.Instance;
var z = Singleton.Instance;

Console.WriteLine(a == z);// -> True 
//SaleFactory -> Clase abstracta (Creador)
//new StoreSaleFactory(); -> Fabrica de objetos
SaleFactory storeSaleFactory = new StoreSaleFactory(10);
//new InternetSaleFactory(); -> Fabrica de objetos
SaleFactory internetSaleFactory = new InternetSaleFactory(5);

//Creacion de objetos con el uso de las fabricas
ISale sale1 = storeSaleFactory.GetSale();
sale1.Sell(15);

ISale sale2 = internetSaleFactory.GetSale();
sale2.Sell(15);
