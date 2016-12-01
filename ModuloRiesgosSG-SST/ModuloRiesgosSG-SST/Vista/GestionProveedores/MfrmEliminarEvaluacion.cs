using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using ModuloRiesgosSG_SST.Entidades.Proveedores;
using ModuloRiesgosSG_SST.Logica.Proveedores;

namespace ModuloRiesgosSG_SST.Vista.GestionProveedores
{
    public partial class MfrmEliminarEvaluacion : MetroForm
    {
        public MfrmEliminarEvaluacion()
        {
            InitializeComponent();
        }
        LClEvaluacion objLEvaluacion = new LClEvaluacion();
        EClEvaluacion objEvaluacion = new EClEvaluacion();
        private void MfrmEliminarEvaluacion_Load(object sender, EventArgs e)
        {
            grillaEvaluacion.DataSource = objLEvaluacion.mtdListarEvaluacion();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            grillaEvaluacion.DataSource = objLEvaluacion.mtdListarNombre(mcmbProveedor.Text);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult Elim = MetroMessageBox.Show(Owner, "¿Desea eliminar la evaluacion?", "SGSST - Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            objEvaluacion.Nombre = mcmbProveedor.Text;

            if (Elim == DialogResult.OK)
            {


                int Eliminar = objLEvaluacion.mtdEliminarEvaluacion(mcmbProveedor.Text);

                if (Eliminar > 0)
                {

                    MetroMessageBox.Show(Owner, "La evaluacion fue eliminada exitosamente", "SGSST-Aviso",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);

                }
                else
                {
                    MetroMessageBox.Show(Owner, "No se logro eliminar el parametro deseado, por favor vuelva a intentarlo","SGSST-Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }

            }

            else
            {
                MetroMessageBox.Show(Owner, "Eliminacion cancelada exitosamente", "SGSST-Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            grillaEvaluacion.DataSource = objLEvaluacion.mtdListarEvaluacion();
        }


        private void mcmbProveedor_Click(object sender, EventArgs e)
        {
            mcmbProveedor.DataSource = objLEvaluacion.mtdCargarCombo();
            mcmbProveedor.DisplayMember = "Nombre";
            mcmbProveedor.ValueMember = "Nombre";
        }
    }
}
