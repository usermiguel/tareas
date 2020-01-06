using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea1TPD
{
    public partial class frmCalificacion_Listar : Form
    {
        public frmCalificacion_Listar()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            lstDatos.Items.Clear();
            int contador = 0;
            foreach (Calificacion elemento in Calificacion.Listar())
            {
                lstDatos.Items.Add(Convert.ToString(contador + 1));
                lstDatos.Items[contador].SubItems.Add(Convert.ToString(elemento.Codigo));
                lstDatos.Items[contador].SubItems.Add(elemento.NombreCompleto);
                lstDatos.Items[contador].SubItems.Add(elemento.NombreBreve);
                lstDatos.Items[contador].SubItems.Add(elemento.Descripcion);
                lstDatos.Items[contador].SubItems.Add(Convert.ToString(elemento.FechaHoraRegistro));
            contador+=1;
            }

        }

        private void frmCalificacion_Listar_Load(object sender, EventArgs e)
        {

        }

        private void lstDatos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
