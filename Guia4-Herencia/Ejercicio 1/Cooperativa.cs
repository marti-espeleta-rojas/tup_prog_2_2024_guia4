using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    public class Cooperativa
    {
        public string Nombre { get; private set; }
        ArrayList clientes = new ArrayList();
        public Cooperativa(string nombre)
        {
            Nombre = nombre;
        }

        public Cliente BuscarCliente(int nroServicio)
        {
            Cliente c = null; //en el código de papel me faltó declarar acá la variable de refe
            for (int i = 0; i < clientes.Count; i++)
            {
                c = (Cliente)clientes[i]; //necesito castear para poder hacer la conversión
                if (c.Medidor.NumeroServicio == nroServicio)
                {
                    return c;
                }
            }
            return null;
        }

        public Cliente AgregarCliente(int dni, string nombre, string direccion, Medidor medidor)
        {
            Cliente cliente = new Cliente(nombre, direccion, dni, medidor);
            clientes.Add(cliente);
            return cliente;
        }
    }
}
