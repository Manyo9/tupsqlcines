using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineBackend.Acceso_a_Datos
{
    class Parametro
    {
        public string Nombre { get; set; }
        public string Valor { get; set; }
        public Parametro(string nombre, string valor)
        {
            Nombre = nombre;
            Valor = valor;
        }
        public Parametro()
        {
        }
    }
}
