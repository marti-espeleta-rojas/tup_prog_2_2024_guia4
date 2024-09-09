using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    public class Medidor
    {
        public int NumeroServicio { get; private set; }
        public double LecturaAnterior { get; private set; }
        public double LecturaActual { get; private set; }
        public int CantidadConsumos { get; private set; }
        public int PeriodoActual { get; private set; }
        ArrayList consumos = new ArrayList();

        public Medidor(int nroServi)
        {
            NumeroServicio = nroServi;
        }

        public double ConsumoActual()
        {
            return LecturaActual - LecturaAnterior;
        }

        public void Medicion(double lecturaActual)
        {
            LecturaActual = lecturaActual;
            LecturaAnterior = (double)consumos[CantidadConsumos-1];
        }

        public void RegistrarConsumo(double medicion)
        {

            consumos.Add(medicion);
            CantidadConsumos++;
        }

        public double LeerConsumo(int pos)
        {
            double consumo = (double)consumos[pos];
            return consumo;
        }
    }
}
