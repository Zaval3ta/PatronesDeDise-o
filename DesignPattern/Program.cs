using DesignPattern.Singleton;

//var singleton = Singleton.Instance;
var log = Log.Instance;
log.Save("Singleton");
log.Save("Singleton 2");
//Para comprobar que es el mismo objeto
var a = Singleton.Instance;
var z = Singleton.Instance;

Console.WriteLine(a == z);// -> True