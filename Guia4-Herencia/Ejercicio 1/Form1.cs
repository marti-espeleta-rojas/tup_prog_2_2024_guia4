using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Cooperativa cop = null;
        Medidor m1 = null;
        Cliente c1 = null;

        private void btnIniciarCoperativa_Click(object sender, EventArgs e)
        {
            cop = new Cooperativa(tbCooperativa.Text);
            btnIniciarCoperativa.Enabled = false;
        }

        private void btnCargaClientes_Click(object sender, EventArgs e)
        {
            DatosDelCliente datos = new DatosDelCliente();
            if (datos.ShowDialog() == DialogResult.OK)
            {
                string nombre = datos.tbNombre.Text;
                string direccion = datos.tbDireccion.Text;
                int dni = Convert.ToInt32(datos.tbDNI.Text);
                m1 = new Medidor(Convert.ToInt32(datos.tbNumeroServicio.Text));
                cop.AgregarCliente(dni, nombre, direccion, m1);
                MessageBox.Show($"Servicio N° {m1.NumeroServicio}");
            }
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            c1 = cop.BuscarCliente(Convert.ToInt32(tbNroServicio.Text));
            lbCliente.Text = $"{c1.Nombre},{c1.DNI},{c1.Direccion}";
        }

        private void btnCargarConsumo_Click(object sender, EventArgs e)
        {
            m1.RegistrarConsumo(Convert.ToDouble(tbCargarConsumo.Text));
            tbCargarConsumo.Clear();
        }

        private void btnVerConsumo_Click(object sender, EventArgs e)
        {
            Resultados res = new Resultados();
            for (int i = 0; i < m1.CantidadConsumos; i++)
            {
                res.lbxResultados.Items.Add(m1.ConsumoActual());
            }
            res.Show();
            btnIniciarCoperativa.Enabled = true;
        }
    }
}
