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
    public partial class MfrmMenuModificacionProv : MetroForm
    {
        public MfrmMenuModificacionProv()
        {
            InitializeComponent();
        }

        private void MfrmMenuModificacionProv_Load(object sender, EventArgs e)
        {

        }

        private void mtbnActProveedor_Click(object sender, EventArgs e)
        {
            MfrmEditarProveedor objEditProv = new MfrmEditarProveedor();
            if (objEditProv.IsDisposed == true)
            {
                objEditProv = new MfrmEditarProveedor();
            }
            objEditProv.Show();
        }

        private void mtbnEliminarProv_Click(object sender, EventArgs e)
        {
            MfrmEliminarProveedor objElimProv = new MfrmEliminarProveedor();
            if (objElimProv.IsDisposed == true)
            {
                objElimProv = new MfrmEliminarProveedor();
            }
            objElimProv.Show();
        }
    }
}
