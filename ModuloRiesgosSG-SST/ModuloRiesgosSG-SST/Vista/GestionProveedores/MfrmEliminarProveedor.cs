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
using MetroFramework.Forms;
using ModuloRiesgosSG_SST.Entidades.Proveedores;
using ModuloRiesgosSG_SST.Logica.Proveedores;

namespace ModuloRiesgosSG_SST.Vista.GestionProveedores
{
    public partial class MfrmEliminarProveedor : MetroForm
    {
        public MfrmEliminarProveedor()
        {
            InitializeComponent();
        }
        LClProveedores objLprov = new LClProveedores();
        int Busqueda = 0;
        private void MfrmEliminarProveedor_Load(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvProvEliminar.SelectedRows.Count == 1)
            {
                string Dlt = dgvProvEliminar.CurrentRow.Cells[0].Value.ToString();
                DialogResult Aviso = MetroMessageBox.Show(Owner, "Esta seguro que desea eliminar el registro seleccionado?", "SGSST-Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (Aviso == DialogResult.Yes)
                {
                    int Elim = objLprov.mtdEliminarProveedores(Dlt);

                    if (Elim > 0)
                    {
                        MetroMessageBox.Show(Owner, "Se elimino exitosamente", "SGSST-Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvProvEliminar.Rows.Clear();
                    }
                    else
                    {
                        MetroMessageBox.Show(Owner, "Fallo la eliminacion del registro solicitado", "SGSST-Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MetroMessageBox.Show(Owner, "Eliminacion cancelada exitosamente", "SGSST-Aviso", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }

            }
            else
            {
                MetroMessageBox.Show(Owner, "Seleccione un registro por favor", "SGSST-Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void metroCheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox2.Checked == true)
            {
                metroCheckBox1.Checked = false;
            }
        }

        private void metroCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox1.Checked == true)
            {
                metroCheckBox2.Checked = false;
            }
        }

        private void metroComboBox1_Click(object sender, EventArgs e)
        {
            if (Busqueda == 1)
            {
                mcbEliminar.DisplayMember = "Nit";
                mcbEliminar.ValueMember = "Nit";
                mcbEliminar.DataSource = objLprov.mtdCargarComboNit();
            }
            else if (Busqueda == 2)
            {
                mcbEliminar.DisplayMember = "Nombre";
                mcbEliminar.ValueMember = "Nombre";
                mcbEliminar.DataSource = objLprov.mtdCargarComboNombre();
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (Busqueda == 1)
            {
                IList<EClProveedores> ListPnit = new List<EClProveedores>();
                ListPnit = objLprov.mtdListNitBusqueda(mcbEliminar.Text);
                for (int i = 0; i < ListPnit.Count; i++)
                {
                    dgvProvEliminar.Rows.Clear();
                    dgvProvEliminar.Rows.Add();
                    dgvProvEliminar.Rows[i].Cells[0].Value = ListPnit[i].Nombre;
                    dgvProvEliminar.Rows[i].Cells[1].Value = ListPnit[i].Nit;
                    dgvProvEliminar.Rows[i].Cells[2].Value = ListPnit[i].Departamento;
                    dgvProvEliminar.Rows[i].Cells[3].Value = ListPnit[i].Ciudad;
                    dgvProvEliminar.Rows[i].Cells[4].Value = ListPnit[i].Direccion;
                    dgvProvEliminar.Rows[i].Cells[5].Value = ListPnit[i].Email;
                    dgvProvEliminar.Rows[i].Cells[6].Value = ListPnit[i].Telefono;
                    dgvProvEliminar.Rows[i].Cells[7].Value = ListPnit[i].PaginaWeb;
                }
            }
            else if (Busqueda == 2)
            {
                IList<EClProveedores> ListPNom = new List<EClProveedores>();
                ListPNom = objLprov.mtdListNombreBusqueda(mcbEliminar.Text);
                for (int i = 0; i < ListPNom.Count; i++)
                {
                    dgvProvEliminar.Rows.Clear();
                    dgvProvEliminar.Rows.Add();
                    dgvProvEliminar.Rows[i].Cells[0].Value = ListPNom[i].Nombre;
                    dgvProvEliminar.Rows[i].Cells[1].Value = ListPNom[i].Nit;
                    dgvProvEliminar.Rows[i].Cells[2].Value = ListPNom[i].Departamento;
                    dgvProvEliminar.Rows[i].Cells[3].Value = ListPNom[i].Ciudad;
                    dgvProvEliminar.Rows[i].Cells[4].Value = ListPNom[i].Direccion;
                    dgvProvEliminar.Rows[i].Cells[5].Value = ListPNom[i].Email;
                    dgvProvEliminar.Rows[i].Cells[6].Value = ListPNom[i].Telefono;
                    dgvProvEliminar.Rows[i].Cells[7].Value = ListPNom[i].PaginaWeb;
                }
            }
        }

        private void metroCheckBox2_Click(object sender, EventArgs e)
        {
            Busqueda = 1;
        }

        private void metroCheckBox1_Click(object sender, EventArgs e)
        {
            Busqueda = 2;
        }
    }
}
