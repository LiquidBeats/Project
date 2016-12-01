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
using ModuloRiesgosSG_SST.Vista.GestionProveedores;
using System.Threading;

namespace ModuloRiesgosSG_SST.Vista
{
    public partial class MfrmPrincipalMenu : MetroForm
    {
        public MfrmPrincipalMenu()
        {
           /* Thread t = new Thread(new ThreadStart(Loading));
            t.Start();
            Thread.Sleep(4000);*/
            InitializeComponent();
            //t.Abort();
        }

        /*public void Loading()
        {
            Application.Run(new frmLoad());
        }*/
   

        private void MfrmPrincipalMenu_Load(object sender, EventArgs e)
        {
            mtGestionR.TabStop = false;
            mtGestionRH.TabStop = false;
            mtGestionP.TabStop = false;
            mtGestionProgramas.TabStop = false;
            mtGestionProducto.TabStop = false;
        }

        private void mtGestionP_Click(object sender, EventArgs e)
        {
            MfrmProveedores objProv = new MfrmProveedores();
            if (objProv.IsDisposed == true)
            {
                objProv = new MfrmProveedores();
            }
            objProv.StyleManager = this.msmMenu;
            objProv.Show();
            this.Hide();
        }

        private void mtGestionRH_Click(object sender, EventArgs e)
        {
          
        }

        private void salidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void mlOptionsMenu_Click(object sender, EventArgs e)
        {
            mcmOptionsMenu.Show(mlOptionsMenu, 0, mlOptionsMenu.Height);
        }

        private void oscuroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            msmMenu.Theme = MetroFramework.MetroThemeStyle.Dark;
        }

        private void blancoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            msmMenu.Theme = MetroFramework.MetroThemeStyle.Light;
        }

        private void mlOff_Click(object sender, EventArgs e)
        {
           
        }

        private void mtGestionP_MouseHover(object sender, EventArgs e)
        {
            this.tmSlide.Enabled = true;
        }

        private void mtGestionProgramas_Click(object sender, EventArgs e)
        {

        }

        private void MfrmPrincipalMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult Exit = MetroMessageBox.Show(this, "Desea salir de la aplicacion?", "SG-SST Advertencia",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (Exit == DialogResult.Yes)
            {
               
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void tmSlide_Tick(object sender, EventArgs e)
        {
          
        }
    }
}
