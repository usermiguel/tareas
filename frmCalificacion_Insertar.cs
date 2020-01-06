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
    public partial class frmCalificacion_Insertar : Form
    {
        public frmCalificacion_Insertar()
        {
            InitializeComponent();
        }

        private void frmCalificacion_Insertar_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Calificacion e1;
            e1 = new Calificacion(69, txtDesc.Text,
                DateTime.Now, txtNB.Text,
                txtNC.Text);
            e1.Insertar();
            MessageBox.Show("Califiacion Registrada");
            
        }
    }
}
