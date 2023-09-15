using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace desafio1
{
    internal class Telefono
    {
        // Modelo string.
        // Marca string.
        // NumeroTelefonico string.
        // CodigoOperador int (1, 2 o 3).

        // Modelo: solo lectura.Es decir, solo get.
        // Marca: solo lectura.
        // NumeroTelefonico: lectura y escritura.
        // CodigoOperador: lectura y escritura.Validar escritura que solo admita 1, 2 o 3, caso contrario escribir un cero.


        private string modelo;
        private string marca;
        private string numeroTel;
        private int codigoOpe;

        public string Modelo
        {
            get { return modelo; }
        }

        public string Marca
        {
            get { return marca; }
        }

        public string NumeroTel
        {
            get { return numeroTel; }
            set { numeroTel = value; }
        }
        public int CodigoOpe
        {
            get { return codigoOpe; }
            set
            {
                if (value >= 1 && value <= 3)
                    codigoOpe = value;
                else
                    codigoOpe = 0;
            }
        }

        // Agregar Constructor que reciba Modelo y Marca.

        public Telefono(string modelo, string marca)
        {
            this.modelo = modelo;
            this.marca = marca;
        }

        //Agregar método Llamar() sin parámetros que devuelva un string con la leyenda "Realizando llamada...".
        //Sobrecargar el método Llamar(string contacto) para que reciba un contacto y devuelva un string con la leyenda "Llamando a " + contacto
        public string llamar()
        {
            return "Realizando llamda...";
        }
        public string llamar(string contacto)
        {
            return "Llamando a " + contacto;
        }


    }
}
