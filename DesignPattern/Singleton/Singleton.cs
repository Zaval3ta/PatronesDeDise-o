using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Singleton
{
    public class Singleton
    {
        //readonly -> Solo se puede leer(get). No se puede modificar(set).
        //static -> Pertenece a la clase NO al objeto.
        // = new Singleton() -> Se crea el objeto al momento que se compila el proyecto.
        private readonly static Singleton _instance = new Singleton();
        //Propiedad para acceder al unico objeto de la clase
        public static Singleton Instance
        {
            get { return _instance; }
        }

        //Constructor privado para que no se puedan crear objetos.
        private Singleton() { } 
        
    }
}
