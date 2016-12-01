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

namespace ModuloRiesgosSG_SST.Vista.GestionProveedores
{
    public partial class MfrmMenuModificacionEva : MetroForm
    {
        public MfrmMenuModificacionEva()
        {
            InitializeComponent();
        }

        private void MfrmMenuModificacion_Load(object sender, EventArgs e)
        {

        }

        private void btnEditEva_Click(object sender, EventArgs e)
        {
            MfrmEditarEvaluacion objEditEva = new MfrmEditarEvaluacion();
            if (objEditEva.IsDisposed == true)
            {
                objEditEva = new MfrmEditarEvaluacion();
            }
            objEditEva.Show();
        }

        private void btnElimEva_Click(object sender, EventArgs e)
        {
            MfrmEliminarEvaluacion objElimEva = new MfrmEliminarEvaluacion();
            if (objElimEva.IsDisposed == true)
            {
                objElimEva = new MfrmEliminarEvaluacion();
            }
            objElimEva.Show();    
        }

        private void MfrmMenuModificacion_FormClosed(object sender, FormClosedEventArgs e)
        {
 
        }
    }
}
