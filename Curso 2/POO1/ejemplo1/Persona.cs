using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    internal class Persona
    {
        // Persona: edad, sueldo, nombre
        // ATRIBUTOS, O DATOS MIEMBRO DE LA CLASE,
        // variable que permite guardar la informacion

        private int edad;
        private float sueldo;
        private string nombre;

        //con METODOS

        public void setEdad(int e)
        {
            edad = e;
        }

        public int getEdad()
        {
            return edad; 
        }

        
    
    
    }
}
