using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    internal class Botella
    {
        public Botella(string color, string material)
        {
            this.color = color;
            this.material = material;
            capacidad = 100;
            cantidadActual = 0;
        }
        // sobrecargar el constructor, el contructor vacio
        public Botella() { }

        //destructor
        ~Botella()
        {
            //la lógica
        }

        //Botella: Capacidad, color, material

        private int capacidad;
        private string color;
        private string material;
        private int cantidadActual;

        public int Capacidad
        {
            get { return capacidad; }
        }
        public int CantidadActual
        {
            get { return cantidadActual; }
        }

        public string Material
        {
            get { return material;  }
        }

        //PROPIEDAD
  //      public int Capacidad
  //      {
  //          get { return capacidad; }
  //          set { capacidad = value; }
  //      }

        //Metodos
        public float recargar()
        {
            if(cantidadActual > 0)
            {
                int dif = capacidad - cantidadActual;
                float monto = dif * 50 / 100;
                cantidadActual += dif;
                return monto;
            }
            cantidadActual = 100;
            return 50;
        }

    }
}
