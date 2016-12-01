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
    public partial class MfrmEditarEvaluacion : MetroForm
    {
        public MfrmEditarEvaluacion()
        {
            InitializeComponent();
        }

        LClEvaluacion objLEvaluacion = new LClEvaluacion();
        private void MfrmEditarEvaluacion_Load(object sender, EventArgs e)
        {

        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            List<EClEvaluacion> ListaActualizar = new List<EClEvaluacion>();
            ListaActualizar = objLEvaluacion.mtdListarNombre(mcmbProveedor.Text);

            mdtInicio.Text = ListaActualizar[0].FechaInicio.ToString();
            mdtFin.Text = ListaActualizar[0].FechaFin.ToString();
            mdtCiclo.Text = ListaActualizar[0].FechaCiclo.ToString();
            mtxtPuntaje.Text = ListaActualizar[0].Puntaje.ToString();
            mtxtDescripcion.Text = ListaActualizar[0].Descripcion.ToString();
        }

        private void mcmbProveedor_Click(object sender, EventArgs e)
        {
            mcmbProveedor.DataSource = objLEvaluacion.mtdCargarCombo();
            mcmbProveedor.ValueMember = "Nombre";
            mcmbProveedor.DisplayMember = "Nombre";
        }

        private void mbtnModificar_Click(object sender, EventArgs e)
        {

            EClEvaluacion objEevaluacion = new EClEvaluacion();
            objEevaluacion.FechaInicio = Convert.ToDateTime(mdtInicio);
            objEevaluacion.FechaFin = Convert.ToDateTime(mdtFin);
            objEevaluacion.FechaCiclo = Convert.ToDateTime(mdtCiclo);
            objEevaluacion.Descripcion = mtxtDescripcion.Text;
            objEevaluacion.Puntaje = int.Parse(mtxtPuntaje.Text);


            int Update = objLEvaluacion.mtdActualizar(objEevaluacion, mcmbProveedor.Text);

            if (Update > 0)
            {
                MetroMessageBox.Show(Owner, "La evaluacion se actualizo exitosamente", "SGSST-Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MetroMessageBox.Show(Owner, "Ocurrio un error al momento de realizar la actualizacion, por favor vuelva a intentarlo", "SGSST-Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
