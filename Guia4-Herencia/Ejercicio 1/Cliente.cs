using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    public class Cliente : IComparable
    {
        public Medidor Medidor { get; private set; }
        public int DNI { get; private set; }
        public string Nombre { get; private set; }
        public string Direccion { get; private set; }

        public Cliente(string nombre, string direccion, int dni, Medidor medidor)
        {
            Nombre = nombre;
            Direccion = direccion;
            DNI = dni;
            Medidor = medidor;
        }

        public int CompareTo(object obj)
        {
            Cliente c = obj as Cliente;
            if (c!=null)
            {
                return Medidor.NumeroServicio.CompareTo(c.Medidor.NumeroServicio);
            }
            return 1;
        }
    }
}
