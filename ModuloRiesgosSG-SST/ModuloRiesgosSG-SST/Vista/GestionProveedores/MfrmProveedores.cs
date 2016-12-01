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
using Transitions;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading;

namespace ModuloRiesgosSG_SST.Vista.GestionProveedores
{
    public partial class MfrmProveedores : MetroForm
    {
        public MfrmProveedores()
        {
            InitializeComponent();
        }

        EClProveedores objEprov = new EClProveedores();
        EClEvaluacion objEvaluacion = new EClEvaluacion();
        LClProveedores objLprov = new LClProveedores();
        LClEvaluacion objLEvaluacion = new LClEvaluacion();

        int FiltroProv;
        Boolean mark;
        int Busqueda;
        private void MfrmProveedores_Load(object sender, EventArgs e)
        {
            mtdListarEva();
            this.Opacity = 0.1;
            timer1.Start();
            mark = true;
            mtdListarProv();

            mcbDepartamento.Items.Add("Amazonas");
            mcbDepartamento.Items.Add("Antioquia");
            mcbDepartamento.Items.Add("Arauca");
            mcbDepartamento.Items.Add("Atlántico");
            mcbDepartamento.Items.Add("Bogotá D.C");
            mcbDepartamento.Items.Add("Bolívar");
            mcbDepartamento.Items.Add("Boyacá");
            mcbDepartamento.Items.Add("Caldas");
            mcbDepartamento.Items.Add("Caquetá");
            mcbDepartamento.Items.Add("Casanare");
            mcbDepartamento.Items.Add("Cauca");
            mcbDepartamento.Items.Add("Cesar");
            mcbDepartamento.Items.Add("Chocó");
            mcbDepartamento.Items.Add("Córdoba");
            mcbDepartamento.Items.Add("Cundinamarca");
            mcbDepartamento.Items.Add("Guainía");
            mcbDepartamento.Items.Add("Guaviare");
            mcbDepartamento.Items.Add("Huila");
            mcbDepartamento.Items.Add("La Guajira");
            mcbDepartamento.Items.Add("Magdalena");
            mcbDepartamento.Items.Add("Meta");
            mcbDepartamento.Items.Add("Nariño");
            mcbDepartamento.Items.Add("Norte de Santander");
            mcbDepartamento.Items.Add("Putumayo");
            mcbDepartamento.Items.Add("Quindio");
            mcbDepartamento.Items.Add("Risaralda");
            mcbDepartamento.Items.Add("San Andres y Providencia");
            mcbDepartamento.Items.Add("Santander");
            mcbDepartamento.Items.Add("Sucre");
            mcbDepartamento.Items.Add("Tolima");
            mcbDepartamento.Items.Add("Valle del Cauca");
            mcbDepartamento.Items.Add("Vaupés");
            mcbDepartamento.Items.Add("Vichada");
        }

        public void mtdListarProv()
        {
            dgvProveedores.Rows.Clear();
            IList<EClProveedores> Listp = new List<EClProveedores>();
            Listp = objLprov.mtdListProveedores();
            for (int i = 0; i < Listp.Count; i++)
            {
                dgvProveedores.Rows.Add();
                dgvProveedores.Rows[i].Cells[0].Value = Listp[i].Nombre;
                dgvProveedores.Rows[i].Cells[1].Value = Listp[i].Nit;
                dgvProveedores.Rows[i].Cells[2].Value = Listp[i].Departamento;
                dgvProveedores.Rows[i].Cells[3].Value = Listp[i].Ciudad;
                dgvProveedores.Rows[i].Cells[4].Value = Listp[i].Direccion;
                dgvProveedores.Rows[i].Cells[5].Value = Listp[i].Email;
                dgvProveedores.Rows[i].Cells[6].Value = Listp[i].Telefono;
                dgvProveedores.Rows[i].Cells[7].Value = Listp[i].PaginaWeb;
            }
        }
        private Boolean Email(String em)
        {
            String expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(em, expresion))
            {
                if (Regex.Replace(em, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text==""&&txtNit.Text==""&&mcbDepartamento.Text==""&&mcbCiudad.Text==""&&txtDireccion.Text==""&&txtEmail.Text==""&&txtTelefono.Text=="")
            {
                MetroMessageBox.Show(this, "Llene los campos por favor!", "SG-SST Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else if (txtNombre.Text == "")
            {
                MetroMessageBox.Show(this, "Ingrese un nombre!", "SG-SST Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtNit.Text == "")
            {
                MetroMessageBox.Show(this, "Ingrese un nit!", "SG-SST Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (mcbDepartamento.Text == "")
            {
                MetroMessageBox.Show(this, "Seleccione un departamento!", "SG-SST Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (mcbCiudad.Text == "")
            {
                MetroMessageBox.Show(this, "Seleccione una ciudad!", "SG-SST Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtDireccion.Text == "")
            {
                MetroMessageBox.Show(this, "Ingrese una direccion!", "SG-SST Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtEmail.Text == "")
            {
                MetroMessageBox.Show(this, "Ingrese un correo electronico!", "SG-SST Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (Email(txtEmail.Text) == false && txtEmail.Text != "")
            {
                MetroMessageBox.Show(this, "Ingrese una direccion de correo electronico valida!", "SG-SST Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (txtTelefono.Text == "")
            {
                MetroMessageBox.Show(this, "Ingrese un numero de telefono, fijo o movil!", "SG-SST Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                objEprov.Nombre = txtNombre.Text;
                objEprov.Nit = txtNit.Text;
                objEprov.Departamento = mcbDepartamento.Text;
                objEprov.Ciudad = mcbCiudad.Text;
                objEprov.Direccion = txtDireccion.Text;
                objEprov.Email = txtEmail.Text;
                objEprov.Telefono = txtTelefono.Text;
                objEprov.PaginaWeb = txtPagina.Text;
                int Message = objLprov.mtdTransDataProv(objEprov);

                if (Message > 0)
                {
                    MetroMessageBox.Show(Owner, "Proveedor registrado exitosamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNombre.Clear();
                    txtNit.Clear();
                    mcbDepartamento.SelectedItem = null;
                    mcbCiudad.DataSource = null;
                    txtDireccion.Clear();
                    txtEmail.Clear();
                    txtTelefono.Clear();
                    txtPagina.Clear();
                }
                else
                {
                    MetroMessageBox.Show(Owner, "Ocurrio un error al momento de realizar el registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                mtdListarProv();
            }
        }
   


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (FiltroProv == 1)
            {
                IList<EClProveedores> ListPNt = new List<EClProveedores>();
                ListPNt = objLprov.mtdListNitBusqueda(mcmbProveedores.Text);
                for (int i = 0; i < ListPNt.Count; i++)
                {
                    dgvProveedores.Rows.Clear();
                    dgvProveedores.Rows.Add();
                    dgvProveedores.Rows[i].Cells[0].Value = ListPNt[i].Nombre;
                    dgvProveedores.Rows[i].Cells[1].Value = ListPNt[i].Nit;
                    dgvProveedores.Rows[i].Cells[2].Value = ListPNt[i].Departamento;
                    dgvProveedores.Rows[i].Cells[3].Value = ListPNt[i].Ciudad;
                    dgvProveedores.Rows[i].Cells[4].Value = ListPNt[i].Direccion;
                    dgvProveedores.Rows[i].Cells[5].Value = ListPNt[i].Email;
                    dgvProveedores.Rows[i].Cells[6].Value = ListPNt[i].Telefono;
                    dgvProveedores.Rows[i].Cells[7].Value = ListPNt[i].PaginaWeb;
                }
            }
            else if (FiltroProv == 2)
            {
                IList<EClProveedores> ListPNom = new List<EClProveedores>();
                ListPNom = objLprov.mtdListNombreBusqueda(mcmbProveedores.Text);
                for (int i = 0; i < ListPNom.Count; i++)
                {
                    dgvProveedores.Rows.Clear();
                    dgvProveedores.Rows.Add();
                    dgvProveedores.Rows[i].Cells[0].Value = ListPNom[i].Nombre;
                    dgvProveedores.Rows[i].Cells[1].Value = ListPNom[i].Nit;
                    dgvProveedores.Rows[i].Cells[2].Value = ListPNom[i].Departamento;
                    dgvProveedores.Rows[i].Cells[3].Value = ListPNom[i].Ciudad;
                    dgvProveedores.Rows[i].Cells[4].Value = ListPNom[i].Direccion;
                    dgvProveedores.Rows[i].Cells[5].Value = ListPNom[i].Email;
                    dgvProveedores.Rows[i].Cells[6].Value = ListPNom[i].Telefono;
                    dgvProveedores.Rows[i].Cells[7].Value = ListPNom[i].PaginaWeb;
                }
            }
        }

        private void mcmbProveedores_Click(object sender, EventArgs e)
        {
            if (FiltroProv==1)
            {
                mcmbProveedores.ValueMember = "Nit";
                mcmbProveedores.DisplayMember = "Nit";
                mcmbProveedores.DataSource = objLprov.mtdCargarComboNit();
             
            }
            else if (FiltroProv==2)
            {
                mcmbProveedores.ValueMember = "Nombre";
                mcmbProveedores.DisplayMember = "Nombre";
                mcmbProveedores.DataSource = objLprov.mtdCargarComboNombre();               
            }
        }

        private void mcbNit_Click(object sender, EventArgs e)
        {
            FiltroProv = 1;
        }

        private void mcbNombre_Click(object sender, EventArgs e)
        {
            FiltroProv = 2;
        }

        private void mcbNit_CheckedChanged(object sender, EventArgs e)
        {
            if (mcbNit.Checked == true)
            {
                mcbNombre.Checked = false;
            }
        }

        private void mcbNombre_CheckedChanged(object sender, EventArgs e)
        {
            if (mcbNombre.Checked == true)
            {
                mcbNit.Checked = false;
            }
        }


        private void metroCheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox3.Checked == true)
            {
                metroCheckBox4.Checked = false;
            }
        }

        private void metroCheckBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox4.Checked == true)
            {
                metroCheckBox3.Checked = false;
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            objEvaluacion.Nombre = cmbProveedor.SelectedValue.ToString();
            objEvaluacion.FechaInicio = Convert.ToDateTime(dttmInicio.Text);
            objEvaluacion.FechaFin = Convert.ToDateTime(dttmFin.Text);
            objEvaluacion.FechaCiclo = Convert.ToDateTime(dttmCiclo.Text);
            objEvaluacion.Puntaje = int.Parse(txtPuntaje.Text);
            objEvaluacion.Descripcion = txtDescripcion.Text;

            int Registro = objLEvaluacion.mtdRegistroEvaluacion(objEvaluacion);

            if (Registro > 0)
            {
                MetroMessageBox.Show(Owner, "La Evaluacion se ingreso exitosamente", "SGSST - Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo registrar ", "SGSST-Evaluacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            mtdListarEva();
            txtDescripcion.Clear();
            cmbProveedor.Text = "";
            txtPuntaje.Clear();
        }

        private void mtdListarEva()
        {
            IList<EClEvaluacion> ListEv = new List<EClEvaluacion>();
            ListEv = objLEvaluacion.mtdListarEvaluacion();
            for (int i = 0; i < ListEv.Count; i++)
            {
                dgvEvaluacion.Rows.Add();
                dgvEvaluacion.Rows[i].Cells[0].Value = ListEv[i].Nombre;
                dgvEvaluacion.Rows[i].Cells[1].Value = ListEv[i].FechaInicio;
                dgvEvaluacion.Rows[i].Cells[2].Value = ListEv[i].FechaFin;
                dgvEvaluacion.Rows[i].Cells[3].Value = ListEv[i].FechaCiclo;
                dgvEvaluacion.Rows[i].Cells[4].Value = ListEv[i].Puntaje;
                dgvEvaluacion.Rows[i].Cells[5].Value = ListEv[i].Descripcion;
            }
        }

        private void cmbProveedor_Click(object sender, EventArgs e)
        {
            cmbProveedor.DataSource = objLEvaluacion.mtdComboProveedor();
            cmbProveedor.DisplayMember = "Nombre";
            cmbProveedor.ValueMember = "Nombre";
        }

        private void btnBuscarEvaluacion_Click(object sender, EventArgs e)
        {
            if (Busqueda == 1)
            {

                dgvEvaluacion.DataSource = objLEvaluacion.mtdListarNombre(cmbBuscar.Text);


            }
            else if (Busqueda == 2)
            {
                dgvEvaluacion.DataSource = objLEvaluacion.mtdListarPuntaje(cmbBuscar.Text);
            }

            cmbBuscar.Text = "";
        }

        private void metroCheckBox3_Click(object sender, EventArgs e)
        {
            Busqueda = 1;
        }

        private void metroCheckBox4_Click(object sender, EventArgs e)
        {
            Busqueda = 2;
        }

        private void cmbBuscar_Click(object sender, EventArgs e)
        {

            if (Busqueda == 1)
            {
                cmbBuscar.DataSource = objLEvaluacion.mtdCargarCombo();
                cmbBuscar.ValueMember = "Nombre";
                cmbBuscar.DisplayMember = "Nombre";
            }
            else if (Busqueda == 2)
            {
                cmbBuscar.DataSource = objLEvaluacion.mtdCargarCombo();
                cmbBuscar.ValueMember = "Puntaje";
                cmbBuscar.DisplayMember = "Puntaje";
            }
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            MfrmMenuModificacionEva objMenuM = new MfrmMenuModificacionEva();
            if (objMenuM.IsDisposed == true)
            {
                objMenuM = new MfrmMenuModificacionEva();
            }
            objMenuM.Show();
        }

        private void mbtnModificarProv_Click(object sender, EventArgs e)
        {
            MfrmMenuModificacionProv objMenProv = new MfrmMenuModificacionProv();
            if (objMenProv.IsDisposed == true)
            {
                objMenProv = new MfrmMenuModificacionProv();
            }
            objMenProv.Show();
        }

        private void mbtnRefreshProv_Click(object sender, EventArgs e)
        {  
            mtdListarProv();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (mark)
            {
                if (this.Opacity <= 1.1)
                {
                    this.Opacity += 0.095;
                }
                else
                {
                    timer1.Stop();
                }
            }
            else
            {
                if (this.Opacity >= 0.0)
                {
                    this.Opacity -= 0.095;
                }
                else
                {
                    timer1.Stop();
                    this.Close();
                }
            }
        }
    
        private void mlBackP_Click(object sender, EventArgs e)
        {
            MfrmPrincipalMenu mfrmM = new MfrmPrincipalMenu();
            if (mfrmM.IsDisposed == true)
            {
                 mfrmM = new MfrmPrincipalMenu();
            }
            mfrmM.Show();
            this.Close();
            timer1.Start();
            mark = false;
        }

        private void mtcProveedores_MouseHover(object sender, EventArgs e)
        {
            Cursor.Tag = Handle;  
        }
        
        private void mbAll_Click(object sender, EventArgs e)
        {
            mtcProveedores.SelectTab(metroTabPage4);
        }

        private void mcbCiudad_Click_1(object sender, EventArgs e)
        {
            if (mcbDepartamento.Text == "Amazonas")
            {
                List<string> ListCity = new List<string>();
                ListCity.Add("El Encanto");
                ListCity.Add("La Chorrera");
                ListCity.Add("La Pedrera");
                ListCity.Add("Leticia");
                ListCity.Add("Miriti-Parana");
                ListCity.Add("Puerto Santander");
                ListCity.Add("Puerto Nariño");
                ListCity.Add("Tarapaca");
                mcbCiudad.DataSource = ListCity;

            }
            else if (mcbDepartamento.Text == "Antioquia")
            {
                List<string> ListCity = new List<string>();
                ListCity.Add("Abejorral");
                ListCity.Add("Abriaquí");
                ListCity.Add("Alejandría");
                ListCity.Add("Amagá");
                ListCity.Add("Amalfi");
                ListCity.Add("Andes");
                ListCity.Add("Angelópolis");
                ListCity.Add("Angostura");
                ListCity.Add("Anorí");
                ListCity.Add("Anzá");
                ListCity.Add("Apartadó");
                ListCity.Add("Arboletes");
                ListCity.Add("Argelia");
                ListCity.Add("Armenia");
                ListCity.Add("Barbosa");
                ListCity.Add("Bello");
                ListCity.Add("Belmira");
                ListCity.Add("Betania");
                ListCity.Add("Betulia");
                ListCity.Add("Briceño");
                ListCity.Add("Buriticá");
                ListCity.Add("Cáceres");
                ListCity.Add("Caicedo");
                ListCity.Add("Caldas");
                ListCity.Add("Campamento");
                ListCity.Add("Cañasgordas");
                ListCity.Add("Caracolí");
                ListCity.Add("Caramanta");
                ListCity.Add("Carepa");
                ListCity.Add("Carolina del Príncipe");
                ListCity.Add("Caucasia");
                ListCity.Add("Chigorodó");
                ListCity.Add("Cisneros");
                ListCity.Add("Ciudad Bolívar");
                ListCity.Add("Cocorná");
                ListCity.Add("Concepción");
                ListCity.Add("Concordia");
                ListCity.Add("Copacabana");
                ListCity.Add("Dabeiba");
                ListCity.Add("Donmatías");
                ListCity.Add("Ebéjico");
                ListCity.Add("El Bagre");
                ListCity.Add("El Carmen de Viboral");
                ListCity.Add("El Peñol");
                ListCity.Add("El Retiro");
                ListCity.Add("El Santuario");
                ListCity.Add("Entrerríos");
                ListCity.Add("Envigado");
                ListCity.Add("Fredonia");
                ListCity.Add("Frontino");
                ListCity.Add("Giraldo");
                ListCity.Add("Girardota");
                ListCity.Add("Gómez Plata");
                ListCity.Add("Granada");
                ListCity.Add("Guadalupe");
                ListCity.Add("Guarne");
                ListCity.Add("Guatapé");
                ListCity.Add("Heliconia");
                ListCity.Add("Hispania");
                ListCity.Add("Itagüí");
                ListCity.Add("Ituango");
                ListCity.Add("Jardín");
                ListCity.Add("Jericó");
                ListCity.Add("La Ceja");
                ListCity.Add("La Estrella");
                ListCity.Add("La Pintada");
                ListCity.Add("La Unión");
                ListCity.Add("Liborina");
                ListCity.Add("Maceo");
                ListCity.Add("Marinilla");
                ListCity.Add("Medellín");
                ListCity.Add("Montebello");
                ListCity.Add("Murindó");
                ListCity.Add("Mutatá");
                ListCity.Add("Nariño");
                ListCity.Add("Nechí");
                ListCity.Add("Necoclí");
                ListCity.Add("Olaya");
                ListCity.Add("Peque");
                ListCity.Add("Pueblorrico");
                ListCity.Add("Puerto Berrío");
                ListCity.Add("Puerto Nare");
                ListCity.Add("Puerto Triunfo");
                ListCity.Add("Remedios");
                ListCity.Add("Rionegro");
                ListCity.Add("Sabanalarga");
                ListCity.Add("Sabaneta");
                ListCity.Add("Salgar");
                ListCity.Add("San Andrés de Cuerquia");
                ListCity.Add("San Carlos");
                ListCity.Add("San Francisco");
                ListCity.Add("San Jerónimo");
                ListCity.Add("San José de la Montaña");
                ListCity.Add("San Juan de Urabá");
                ListCity.Add("San Luis");
                ListCity.Add("San Pedro de los Milagros");
                ListCity.Add("San Pedro de Urabá");
                ListCity.Add("San Rafael");
                ListCity.Add("San Roque");
                ListCity.Add("San Vicente");
                ListCity.Add("Santa Bárbara");
                ListCity.Add("Santa Rosa de Osos");
                ListCity.Add("Santa Fe de Antioquia");
                ListCity.Add("Santo Domingo");
                ListCity.Add("Segovia");
                ListCity.Add("Sonsón");
                ListCity .Add("Sopetrán");
                ListCity.Add("Támesis");
                ListCity.Add("Tarazá");
                ListCity.Add("Tarso");
                ListCity.Add("Titiribí");
                ListCity.Add("Toledo");
                ListCity.Add("Turbo");
                ListCity.Add("Uramita");
                ListCity.Add("Urrao");
                ListCity.Add("Valdivia");
                ListCity.Add("Valparaíso");
                ListCity.Add("Vegachí");
                ListCity.Add("Venecia");
                ListCity.Add("Vigía del Fuerte");
                ListCity.Add("Yalí");
                ListCity.Add("Yarumal");
                ListCity.Add("Yolombó");
                ListCity.Add("Yondó");
                ListCity.Add("Zaragoza");
                mcbCiudad.DataSource = ListCity;
            }
            else if (mcbDepartamento.Text == "Arauca")
            {
                List<string> ListCity = new List<string>();
                ListCity.Add("Arauca");
                ListCity.Add("Arauquita");
                ListCity.Add("Cravo Norte");
                ListCity.Add("Frortul");
                ListCity.Add("Puerto Rondón");
                ListCity.Add("Saravena");
                ListCity.Add("Tame");
                mcbCiudad.DataSource = ListCity;
            }
            else if (mcbDepartamento.Text == "Atlántico")
            {
                List<string> ListCity = new List<string>();
                ListCity.Add("Baranoa");
                ListCity.Add("Barranquilla");
                ListCity.Add("Campo de la cruz");
                ListCity.Add("Candelaria");
                ListCity.Add("Galapa");
                ListCity.Add("Juan de Acosta");
                ListCity.Add("Lurucao");
                ListCity.Add("Malomba");
                ListCity.Add("Manatí");
                ListCity.Add("Palmar de Varela");
                ListCity.Add("Piojo");
                ListCity.Add("Polonuevo");
                ListCity.Add("Ponedera");
                ListCity.Add("Puerto Colombia");
                ListCity.Add("Repelón");
                ListCity.Add("Sabana Grande");
                ListCity.Add("Sabana Larga");
                ListCity.Add("Santa Lucía");
                ListCity.Add("Santo Tomas");
                ListCity.Add("Soledad");
                ListCity.Add("Suan");
                ListCity.Add("Tubará");
                ListCity.Add("Usiacurí");
                mcbCiudad.DataSource = ListCity;
            }
            else if (mcbDepartamento.Text == "Bogotá D.C")
            {
                List<string> ListCity = new List<string>();
                ListCity.Add("Bogotá");
                mcbCiudad.DataSource = ListCity;
            }
            else if (mcbDepartamento.Text == "Bolívar")
            {
                List<string> ListCity = new List<string>();
                ListCity.Add("Achí");
                ListCity.Add("Altos del Rosario");
                ListCity.Add("Arenal");
                ListCity.Add("Arjona");
                ListCity.Add("Arroyohondo");
                ListCity.Add("Barranco de Loba");
                ListCity.Add("Calamar");
                ListCity.Add("Cantagallo");
                ListCity.Add("Cartagena");
                ListCity.Add("Cicuco");
                ListCity.Add("Clemencia");
                ListCity.Add("Córdoba");
                ListCity.Add("El Carmen de Bolívar");
                ListCity.Add("El Guamo");
                ListCity.Add("El Peñón");
                ListCity.Add("Hatillo de Loba");
                ListCity.Add("Magangué");
                ListCity.Add("Mahates");
                ListCity.Add("Margarita");
                ListCity.Add("María la Baja");
                ListCity.Add("Mompós");
                ListCity.Add("Montecristo");
                ListCity.Add("Morales");
                ListCity.Add("Pinillos");
                ListCity.Add("Regidor");
                ListCity.Add("Rio Viejo");
                ListCity.Add("San Cristóbal");
                ListCity.Add("San Estanislao");
                ListCity.Add("San Fernando");
                ListCity.Add("San Jacinto");
                ListCity.Add("San Jacinto del Cauca");
                ListCity.Add("San Juan Nepomuceno");
                ListCity.Add("San Martín de Loba");
                ListCity.Add("San Pablo");
                ListCity.Add("Santa Catalina");
                ListCity.Add("Santa Rosa");
                ListCity.Add("Santa Rosa del Sur");
                ListCity.Add("Simití");
                ListCity.Add("Soplaviento");
                ListCity.Add("Talaigua Nuevo");
                ListCity.Add("Tiquisio");
                ListCity.Add("Turbaco");
                ListCity.Add("Turbana");
                ListCity.Add("Villanueva");
                ListCity.Add("Zambrano");
                mcbCiudad.DataSource = ListCity;
            }
            else if (mcbDepartamento.Text == "Boyacá")
            {
                List<string> ListCity = new List<string>();
                ListCity.Add("Almeida");
                ListCity.Add("Aquitania");
                ListCity.Add("Arcabuco");
                ListCity.Add("Belén");
                ListCity.Add("Berbeo");
                ListCity.Add("Betéitiva");
                ListCity.Add("Boavita");
                ListCity.Add("Boyacá");
                ListCity.Add("Briceño");
                ListCity.Add("Buenavista");
                ListCity.Add("Busbanzá");
                ListCity.Add("Caldas");
                ListCity.Add("Campohermoso");
                ListCity.Add("Cerinza");
                ListCity.Add("Chinavita");
                ListCity.Add("Chiquinquirá");
                ListCity.Add("Chíquiza");
                ListCity.Add("Chiscas");
                ListCity.Add("Chita");
                ListCity.Add("Chitaraque");
                ListCity.Add("Chivatá");
                ListCity.Add("Chivor");
                ListCity.Add("Ciénega");
                ListCity.Add("Cómbita");
                ListCity.Add("Coper");
                ListCity.Add("Corrales");
                ListCity.Add("Covarachía");
                ListCity.Add("Cubará");
                ListCity.Add("Cucaita");
                ListCity.Add("Cuítiva");
                ListCity.Add("Duitama");
                ListCity.Add("El Cocuy");
                ListCity.Add("El Espino");
                ListCity.Add("Firavitoba");
                ListCity.Add("Floresta");
                ListCity.Add("Gachantivá");
                ListCity.Add("Gámeza");
                ListCity.Add("Garagoa");
                ListCity.Add("Guacamayas");
                ListCity.Add("Guateque");
                ListCity.Add("Guayatá");
                ListCity.Add("Guicán");
                ListCity.Add("Iza");
                ListCity.Add("Jenesano");
                ListCity.Add("Jericó");
                ListCity.Add("La Capilla");
                ListCity.Add("La Uvita");
                ListCity.Add("La Victoria");
                ListCity.Add("Labranzagrande");
                ListCity.Add("Macanal");
                ListCity.Add("Maripi");
                ListCity.Add("Miraflores");
                ListCity.Add("Mongua");
                ListCity.Add("Monguí");
                ListCity.Add("Moniquirá");
                ListCity.Add("Motavita");
                ListCity.Add("Muzo");
                ListCity.Add("Nobsa");
                ListCity.Add("Nuevo Colón");
                ListCity.Add("Oicatá");
                ListCity.Add("Otanche");
                ListCity.Add("Pachavita");
                ListCity.Add("Páez");
                ListCity.Add("Paipa");
                ListCity.Add("Pajarito");
                ListCity.Add("Panqueba");
                ListCity.Add("Pauna");
                ListCity.Add("Paya");
                ListCity.Add("Paz de Rio");
                ListCity.Add("Pesca");
                ListCity.Add("Pisba");
                ListCity.Add("Puerto Boyacá");
                ListCity.Add("Quípama");
                ListCity.Add("Ramiriquí");
                ListCity.Add("Ráquira");
                ListCity.Add("Rondón");
                ListCity.Add("Saboya");
                ListCity.Add("Sachicá");
                ListCity.Add("Samacá");
                ListCity.Add("San Eduardo");
                ListCity.Add("San José de Pare");
                ListCity.Add("San Luis de Gaceno");
                ListCity.Add("San Mateo");
                ListCity.Add("San Miguel de Sema");
                ListCity.Add("San Pablo Borbur");
                ListCity.Add("San Rosa Viterbo");
                ListCity.Add("Santa María");
                ListCity.Add("Santa Sofía");
                ListCity.Add("Santana");
                ListCity.Add("Sativanorte");
                ListCity.Add("Sativasur");
                ListCity.Add("Siachoque");
                ListCity.Add("Soatá");
                ListCity.Add("Socha");
                ListCity.Add("Socotá");
                ListCity.Add("Sogamoso");
                ListCity.Add("Somondoco");
                ListCity.Add("Sora");
                ListCity.Add("Soracá");
                ListCity.Add("Sotaquirá");
                ListCity.Add("Susacón");
                ListCity.Add("Sutamarchán");
                ListCity.Add("Sutatenza");
                ListCity.Add("Tasco");
                ListCity.Add("Tenza");
                ListCity.Add("Tibaná");
                ListCity.Add("Tibasosa");
                ListCity.Add("Tinjacá");
                ListCity.Add("Tipacoque");
                ListCity.Add("Toca");
                ListCity.Add("Toguí");
                ListCity.Add("Tópaga");
                ListCity.Add("Tota");
                ListCity.Add("Tunja");
                ListCity.Add("Tununguá");
                ListCity.Add("Turmequé");
                ListCity.Add("Tuta");
                ListCity.Add("Tutazá");
                ListCity.Add("Umbita");
                ListCity.Add("Ventaquemada");
                ListCity.Add("Villa de Leyva");
                ListCity.Add("Viracachá");
                ListCity.Add("Zetaquirá");
                mcbCiudad.DataSource = ListCity;
            }
            else if (mcbDepartamento.Text == "Caldas")
            {
                List<string> ListCity = new List<string>();
                ListCity.Add("Aguadas");
                ListCity.Add("Anserma");
                ListCity.Add("Aranzazu");
                ListCity.Add("Belalcázar");
                ListCity.Add("Chinchiná");
                ListCity.Add("Filadelfia");
                ListCity.Add("La Dorada");
                ListCity.Add("La Merced");
                ListCity.Add("Manizales");
                ListCity.Add("Manzanares");
                ListCity.Add("Marmato");
                ListCity.Add("Marquetalia");
                ListCity.Add("Marulanda");
                ListCity.Add("Neira");
                ListCity.Add("Norcasia");
                ListCity.Add("Pácora");
                ListCity.Add("Palestina");
                ListCity.Add("Pensilvania");
                ListCity.Add("Riosucio");
                ListCity.Add("Risaralda");
                ListCity.Add("Salamina");
                ListCity.Add("Samaná");
                ListCity.Add("San José");
                ListCity.Add("Supía");
                ListCity.Add("Victoria");
                ListCity.Add("Villamaría");
                ListCity.Add("Viterbo");
                mcbCiudad.DataSource = ListCity;
            }
            else if (mcbDepartamento.Text == "Caquetá")
            {
                List<string> ListCity = new List<string>();
                ListCity.Add("Albania");
                ListCity.Add("Belén de los Andaquíes");
                ListCity.Add("Cartagena del Chairá");
                ListCity.Add("Currillo");
                ListCity.Add("El Doncello");
                ListCity.Add("El Paujil");
                ListCity.Add("Florencia");
                ListCity.Add("La Montañita");
                ListCity.Add("Milán");
                ListCity.Add("Morelia");
                ListCity.Add("Puerto Rico");
                ListCity.Add("San José de la Fragua");
                ListCity.Add("San Vicente del Caguán");
                ListCity.Add("Solano");
                ListCity.Add("Solita");
                ListCity.Add("Valparaíso");
                mcbCiudad.DataSource = ListCity;
            }
            else if (mcbDepartamento.Text == "Casanare")
            {
                List<string> ListCity = new List<string>();
                ListCity.Add("Aguazul");
                ListCity.Add("Chameza");
                ListCity.Add("Hato Corozal");
                ListCity.Add("La Salina");
                ListCity.Add("Maní");
                ListCity.Add("Monterrey");
                ListCity.Add("Nunchía");
                ListCity.Add("Orocué");
                ListCity.Add("Paz de Ariporo");
                ListCity.Add("Pore");
                ListCity.Add("Recetor");
                ListCity.Add("Sabanalarga");
                ListCity.Add("Sácama");
                ListCity.Add("San Luis de Palenque");
                ListCity.Add("Támara");
                ListCity.Add("Tauramena");
                ListCity.Add("Trinidad");
                ListCity.Add("Villanueva");
                ListCity.Add("Yopal");
                mcbCiudad.DataSource = ListCity;
            }
            else if (mcbDepartamento.Text == "Cauca")
            {
                List<string> ListCity = new List<string>();
                ListCity.Add("Almaguer");
                ListCity.Add("Argelia");
                ListCity.Add("Balboa");
                ListCity.Add("Bolívar");
                ListCity.Add("Buenos Aires");
                ListCity.Add("Cajibio");
                ListCity.Add("Caldono");
                ListCity.Add("Caloto");
                ListCity.Add("Corinto");
                ListCity.Add("El Tambo");
                ListCity.Add("Florencia");
                ListCity.Add("Guachené");
                ListCity.Add("Guapi");
                ListCity.Add("Inzá");
                ListCity.Add("Jambaló");
                ListCity.Add("La Sierra");
                ListCity.Add("La Vega");
                ListCity.Add("López");
                ListCity.Add("Mercaderes");
                ListCity.Add("Miranda");
                ListCity.Add("Morales");
                ListCity.Add("Padilla");
                ListCity.Add("Páez");
                ListCity.Add("Patía");
                ListCity.Add("Piamonte");
                ListCity.Add("Piendamó");
                ListCity.Add("Popayán");
                ListCity.Add("Puerto Tejada");
                ListCity.Add("Puracé");
                ListCity.Add("Rosas");
                ListCity.Add("San Sebastián");
                ListCity.Add("Santa Rosa");
                ListCity.Add("Santander de Quilichao");
                ListCity.Add("Silvia");
                ListCity.Add("Sotara");
                ListCity.Add("Suárez");
                ListCity.Add("Sucre");
                ListCity.Add("Timbío");
                ListCity.Add("Timbiquí");
                ListCity.Add("Toribio");
                ListCity.Add("Totoró");
                ListCity.Add("Villa Rica");
                mcbCiudad.DataSource = ListCity;
            }
            else if (mcbDepartamento.Text == "Cesar")
            {
                List<string> ListCity = new List<string>();
                ListCity.Add("Aguachica");
                ListCity.Add("Agustín Codazzi");
                ListCity.Add("Astrea");
                ListCity.Add("Becerril");
                ListCity.Add("Bosconia");
                ListCity.Add("Chimichagua");
                ListCity.Add("Chiriguaná");
                ListCity.Add("Curumaní");
                ListCity.Add("El Copey");
                ListCity.Add("El Paso");
                ListCity.Add("Gamarra");
                ListCity.Add("González");
                ListCity.Add("La Gloria");
                ListCity.Add("La Jagua de Ibirico");
                ListCity.Add("La Paz");
                ListCity.Add("Manaure");
                ListCity.Add("Pailitas");
                ListCity.Add("Pelaya");
                ListCity.Add("Pueblo Bello");
                ListCity.Add("Río de Oro");
                ListCity.Add("San Alberto");
                ListCity.Add("San Diego");
                ListCity.Add("San Martín");
                ListCity.Add("Tamalameque");
                ListCity.Add("Valledupar");
                mcbCiudad.DataSource = ListCity;
            }
            else if (mcbDepartamento.Text == "Chocó")
            {
                List<string> ListCity = new List<string>();
                ListCity.Add("Acandí");
                ListCity.Add("Alto Baudó");
                ListCity.Add("Atrato");
                ListCity.Add("Bagadó");
                ListCity.Add("Bahía Solano");
                ListCity.Add("Bajo Baudó");
                ListCity.Add("Belen de Bajira");
                ListCity.Add("Bojayá");
                ListCity.Add("Cantón de San Pablo");
                ListCity.Add("Carmen del Darién");
                ListCity.Add("Cértegui");
                ListCity.Add("Condoto");
                ListCity.Add("El Carmen de Atrato");
                ListCity.Add("El Litoral del San Juan");
                ListCity.Add("Itsmina");
                ListCity.Add("Jurado");
                ListCity.Add("Lloró");
                ListCity.Add("Medio Atrato");
                ListCity.Add("Medio Baudó");
                ListCity.Add("Medio San Juan");
                ListCity.Add("Nóvita");
                ListCity.Add("Nuquí");
                ListCity.Add("Quibdó");
                ListCity.Add("Río Iro");
                ListCity.Add("Río Quito");
                ListCity.Add("Riosucio");
                ListCity.Add("San José del Palmar");
                ListCity.Add("Sipí");
                ListCity.Add("Tadó");
                ListCity.Add("Unguía");
                ListCity.Add("Unión Panamericana");
                mcbCiudad.DataSource = ListCity;
            }
            else if (mcbDepartamento.Text == "Córdoba")
            {
                List<string> ListCity = new List<string>();
                ListCity.Add("Ayapel");
                ListCity.Add("Buenavista");
                ListCity.Add("Canalete");
                ListCity.Add("Cereté");
                ListCity.Add("Chimá");
                ListCity.Add("Chinú");
                ListCity.Add("Ciénaga de Oro");
                ListCity.Add("Cotorra");
                ListCity.Add("La Apartada");
                ListCity.Add("Lorica");
                ListCity.Add("Los Córdobas");
                ListCity.Add("Momil");
                ListCity.Add("Moñitos");
                ListCity.Add("Montelíbano");
                ListCity.Add("Montería");
                ListCity.Add("Planeta Rica");
                ListCity.Add("Pueblo Nuevo");
                ListCity.Add("Puerto Escondido");
                ListCity.Add("Puerto Libertador");
                ListCity.Add("Purísima");
                ListCity.Add("Sahagún");
                ListCity.Add("San Andrés de Sotavento");
                ListCity.Add("San Antero");
                ListCity.Add("San Bernardo del Viento");
                ListCity.Add("San Carlos");
                ListCity.Add("San José de Uré");
                ListCity.Add("San Pelayo");
                ListCity.Add("Tierralta");
                ListCity.Add("Tuchín");
                ListCity.Add("Valencia");
                mcbCiudad.DataSource = ListCity;
            }
            else if (mcbDepartamento.Text == "Cundinamarca")
            {
                List<string> ListCity = new List<string>();
                ListCity.Add("Agua de Dios");
                ListCity.Add("Albán");
                ListCity.Add("Anapoima");
                ListCity.Add("Anolaima");
                ListCity.Add("Apulo");
                ListCity.Add("Arbeláez");
                ListCity.Add("Beltrán");
                ListCity.Add("Bituima");
                ListCity.Add("Bojacá");
                ListCity.Add("Cabrera");
                ListCity.Add("Cachipay");
                ListCity.Add("Cajicá");
                ListCity.Add("Caparrapí");
                ListCity.Add("Cáqueza");
                ListCity.Add("Carmen de Carupa");
                ListCity.Add("Chaguaní");
                ListCity.Add("Chía");
                ListCity.Add("Chipaque");
                ListCity.Add("Choachí");
                ListCity.Add("Chocontá");
                ListCity.Add("Cogua");
                ListCity.Add("Cota");
                ListCity.Add("Cucunubá");
                ListCity.Add("El Colegio");
                ListCity.Add("El Peñón");
                ListCity.Add("El Rosal");
                ListCity.Add("Facatativá");
                ListCity.Add("Fómeque");
                ListCity.Add("Fosca");
                ListCity.Add("Funza");
                ListCity.Add("Fúquene");
                ListCity.Add("Fusagasugá");
                ListCity.Add("Gachalá");
                ListCity.Add("Gachancipá");
                ListCity.Add("Gachetá");
                ListCity.Add("Gama");
                ListCity.Add("Girardot");
                ListCity.Add("Granada");
                ListCity.Add("Guachetá");
                ListCity.Add("Guaduas");
                ListCity.Add("Guasca");
                ListCity.Add("Guataquí");
                ListCity.Add("Guatavita");
                ListCity.Add("Guayabal de Síquima");
                ListCity.Add("Guayabetal");
                ListCity.Add("Gutiérrez");
                ListCity.Add("Jerusalén");
                ListCity.Add("Junín");
                ListCity.Add("La Calera");
                ListCity.Add("La Mesa");
                ListCity.Add("La Palma");
                ListCity.Add("La Peña");
                ListCity.Add("La Vega");
                ListCity.Add("Lenguazaque");
                ListCity.Add("Machetá");
                ListCity.Add("Madrid");
                ListCity.Add("Manta");
                ListCity.Add("Medina");
                ListCity.Add("Mosquera");
                ListCity.Add("Nariño");
                ListCity.Add("Nemocón");
                ListCity.Add("Nilo");
                ListCity.Add("Nimaima");
                ListCity.Add("Nocaima");
                ListCity.Add("Pacho");
                ListCity.Add("Paime");
                ListCity.Add("Pandi");
                ListCity.Add("Paratebueno");
                ListCity.Add("Pasca");
                ListCity.Add("Puerto Salgar");
                ListCity.Add("Pulí");
                ListCity.Add("Quebradanegra");
                ListCity.Add("Quetame");
                ListCity.Add("Quipile");
                ListCity.Add("Ricaurte");
                ListCity.Add("San Antonio de Tequendama");
                ListCity.Add("San Bernardo");
                ListCity.Add("San Cayetano");
                ListCity.Add("San Francisco");
                ListCity.Add("San Juan de Río Seco");
                ListCity.Add("Sasaima");
                ListCity.Add("Sesquilé");
                ListCity.Add("Sibaté");
                ListCity.Add("Silvania");
                ListCity.Add("Simijaca");
                ListCity.Add("Soacha");
                ListCity.Add("Sopó");
                ListCity.Add("Subachoque");
                ListCity.Add("Suesca");
                ListCity.Add("Supatá");
                ListCity.Add("Susa");
                ListCity.Add("Sutatausa");
                ListCity.Add("Tabio");
                ListCity.Add("Tausa");
                ListCity.Add("Tena");
                ListCity.Add("Tenjo");
                ListCity.Add("Tibacuy");
                ListCity.Add("Tibirita");
                ListCity.Add("Tocaima");
                ListCity.Add("Tocancipá");
                ListCity.Add("Topaipí");
                ListCity.Add("Ubalá");
                ListCity.Add("Ubaque");
                ListCity.Add("Ubaté");
                ListCity.Add("Une");
                ListCity.Add("Útica");
                ListCity.Add("Venecia");
                ListCity.Add("Vergara");
                ListCity.Add("Vianí");
                ListCity.Add("Villagómez");
                ListCity.Add("Villapinzón");
                ListCity.Add("Villeta");
                ListCity.Add("Viotá");
                ListCity.Add("Yacopí");
                ListCity.Add("Zipacón");
                ListCity.Add("Zipaquirá");
                mcbCiudad.DataSource = ListCity;
            }
            else if (mcbDepartamento.Text == "Guainía")
            {
                List<string> ListCity = new List<string>();
                ListCity.Add("Inírida");
                mcbCiudad.DataSource = ListCity;
            }
            else if (mcbDepartamento.Text == "Guaviare")
            {
                List<string> ListCity = new List<string>();
                ListCity.Add("Calamar");
                ListCity.Add("El Retorno");
                ListCity.Add("Miraflores");
                ListCity.Add("San José del Guaviare");
                mcbCiudad.DataSource = ListCity;
            }
            else if (mcbDepartamento.Text == "Huila")
            {
                List<string> ListCity = new List<string>();
                ListCity.Add("Acevedo");
                ListCity.Add("Agrado");
                ListCity.Add("Aipe");
                ListCity.Add("Algeciras");
                ListCity.Add("Altamira");
                ListCity.Add("Baraya");
                ListCity.Add("Campoalegre");
                ListCity.Add("Colombia");
                ListCity.Add("Elías");
                ListCity.Add("Garzón");
                ListCity.Add("Gigante");
                ListCity.Add("Guadalupe");
                ListCity.Add("Hobo");
                ListCity.Add("Iquira");
                ListCity.Add("Isnos");
                ListCity.Add("La Argentina");
                ListCity.Add("La Plata");
                ListCity.Add("Nátaga");
                ListCity.Add("Neiva");
                ListCity.Add("Oporapa");
                ListCity.Add("Paicol");
                ListCity.Add("Palermo");
                ListCity.Add("Palestina");
                ListCity.Add("Pital");
                ListCity.Add("Pitalito");
                ListCity.Add("Rivera");
                ListCity.Add("Saladoblanco");
                ListCity.Add("San Agustín");
                ListCity.Add("Santa María");
                ListCity.Add("Suaza");
                ListCity.Add("Tarqui");
                ListCity.Add("Tello");
                ListCity.Add("Teruel");
                ListCity.Add("Tesalia");
                ListCity.Add("Timaná");
                ListCity.Add("Villavieja");
                ListCity.Add("Yaguará");
                mcbCiudad.DataSource = ListCity;
            }
            else if (mcbDepartamento.Text == "La Guajira")
            {
                List<string> ListCity = new List<string>();
                ListCity.Add("Albania");
                ListCity.Add("Barrancas");
                ListCity.Add("Dibulla");
                ListCity.Add("Distracción");
                ListCity.Add("El Molino");
                ListCity.Add("Fonseca");
                ListCity.Add("Hatonuevo");
                ListCity.Add("La Jagua del Pilar");
                ListCity.Add("Maicao");
                ListCity.Add("Manaure");
                ListCity.Add("Riohacha");
                ListCity.Add("San Juan del Cesar");
                ListCity.Add("Uribia");
                ListCity.Add("Urumita");
                ListCity.Add("Villanueva");
                mcbCiudad.DataSource = ListCity;
            }
            else if (mcbDepartamento.Text == "Magdalena")
            {
                List<string> ListCity = new List<string>();
                ListCity.Add("Algarrobo");
                ListCity.Add("Aracataca");
                ListCity.Add("Ariguaní");
                ListCity.Add("Cerro San Antonio");
                ListCity.Add("Chivolo");
                ListCity.Add("Ciénaga");
                ListCity.Add("Concordia");
                ListCity.Add("El Banco");
                ListCity.Add("El Piñon");
                ListCity.Add("El Retén");
                ListCity.Add("Fundación");
                ListCity.Add("Guamal");
                ListCity.Add("Nueva Granada");
                ListCity.Add("Pedraza");
                ListCity.Add("Pijiño del Carmen");
                ListCity.Add("Pivijay");
                ListCity.Add("Plato");
                ListCity.Add("Puebloviejo");
                ListCity.Add("Remolino");
                ListCity.Add("Sabanas de San Ángel");
                ListCity.Add("Salamina");
                ListCity.Add("San Sebastián de Buenavista");
                ListCity.Add("San Zenón");
                ListCity.Add("Santa Ana");
                ListCity.Add("Santa Bárbara de Pinto");
                ListCity.Add("Santa Marta");
                ListCity.Add("Sitionuevo");
                ListCity.Add("Tenerife");
                ListCity.Add("Zapayán");
                ListCity.Add("Zona Bananera");
                mcbCiudad.DataSource = ListCity;
            }
            else if (mcbDepartamento.Text == "Meta")
            {
                List<string> ListCity = new List<string>();
                ListCity.Add("Acacías");
                ListCity.Add("Barranca de Upía");
                ListCity.Add("Cabuyaro");
                ListCity.Add("Castilla la Nueva");
                ListCity.Add("Cumaral");
                ListCity.Add("El Calvario");
                ListCity.Add("El Castillo");
                ListCity.Add("El Dorado");
                ListCity.Add("Fuente de Oro");
                ListCity.Add("Granada");
                ListCity.Add("Guamal");
                ListCity.Add("La Macarena");
                ListCity.Add("La Uribe");
                ListCity.Add("Lejanías");
                ListCity.Add("Mapiripán");
                ListCity.Add("Mesetas");
                ListCity.Add("Puerto Concordia");
                ListCity.Add("Puerto Gaitán");
                ListCity.Add("Puerto Lleras");
                ListCity.Add("Puerto López");
                ListCity.Add("Puerto Rico");
                ListCity.Add("Restrepo");
                ListCity.Add("San Carlos de Guaroa");
                ListCity.Add("San Juan de Arama");
                ListCity.Add("San Juanito");
                ListCity.Add("San Luis de Cubarral");
                ListCity.Add("San Martín");
                ListCity.Add("Villavicencio");
                ListCity.Add("Vista Hermosa");
                mcbCiudad.DataSource = ListCity;
            }
            else if (mcbDepartamento.Text == "Nariño")
            {
                List<string> ListCity = new List<string>();
                ListCity.Add("Albán");
                ListCity.Add("Aldana");
                ListCity.Add("Ancuya");
                ListCity.Add("Arboleda");
                ListCity.Add("Barbacoas");
                ListCity.Add("Belén");
                ListCity.Add("Buesaco");
                ListCity.Add("Chachagui");
                ListCity.Add("Colón");
                ListCity.Add("Consacá");
                ListCity.Add("Contadero");
                ListCity.Add("Córdoba");
                ListCity.Add("Cuaspud");
                ListCity.Add("Cumbal");
                ListCity.Add("Cumbitara");
                ListCity.Add("El Charco");
                ListCity.Add("El Peñol");
                ListCity.Add("El Rosario");
                ListCity.Add("El Tablón de Gómez");
                ListCity.Add("El Tambo");
                ListCity.Add("Francisco Pizarro");
                ListCity.Add("Funes");
                ListCity.Add("Guachucal");
                ListCity.Add("Guaitarilla");
                ListCity.Add("Gualmatán");
                ListCity.Add("Iles");
                ListCity.Add("Imués");
                ListCity.Add("Ipiales");
                ListCity.Add("La Cruz");
                ListCity.Add("La Florida");
                ListCity.Add("La Llanada");
                ListCity.Add("La Tola");
                ListCity.Add("La Unión");
                ListCity.Add("Leiva");
                ListCity.Add("Linares");
                ListCity.Add("Los Andes");
                ListCity.Add("Magüi");
                ListCity.Add("Mallama");
                ListCity.Add("Mosquera");
                ListCity.Add("Olaya Herrera");
                ListCity.Add("Ospina");
                ListCity.Add("Pasto");
                ListCity.Add("Policarpa");
                ListCity.Add("Potosi");
                ListCity.Add("Providencia");
                ListCity.Add("Puerres");
                ListCity.Add("Pupiales");
                ListCity.Add("Ricaurte");
                ListCity.Add("Roberto Payán");
                ListCity.Add("Samaniego");
                ListCity.Add("San Bernardo");
                ListCity.Add("San Lorenzo");
                ListCity.Add("San Pablo");
                ListCity.Add("San Pedro de Cartago");
                ListCity.Add("Sandoná");
                ListCity.Add("Santa Bárbara");
                ListCity.Add("Santacruz");
                ListCity.Add("Sapuyes");
                ListCity.Add("Taminango");
                ListCity.Add("Tangua");
                ListCity.Add("Tumaco");
                ListCity.Add("Túquerres");
                ListCity.Add("Yacuanquer");
                mcbCiudad.DataSource = ListCity;
            }
            else if (mcbDepartamento.Text == "Norte de Santander")
            {
                List<string> ListCity = new List<string>();
                ListCity.Add("Abrego");
                ListCity.Add("Arboledas");
                ListCity.Add("Bochalema");
                ListCity.Add("Bucarasica");
                ListCity.Add("Cáchira");
                ListCity.Add("Cácota");
                ListCity.Add("Chinácota");
                ListCity.Add("Chitagá");
                ListCity.Add("Convención");
                ListCity.Add("Cúcuta");
                ListCity.Add("Cucutilla");
                ListCity.Add("Duranía");
                ListCity.Add("El Carmen");
                ListCity.Add("El Tarra");
                ListCity.Add("El Zulia");
                ListCity.Add("Gramalote");
                ListCity.Add("Hacarí");
                ListCity.Add("Herrán");
                ListCity.Add("La Esperanza");
                ListCity.Add("La Playa");
                ListCity.Add("Labateca");
                ListCity.Add("Los Patios");
                ListCity.Add("Lourdes");
                ListCity.Add("Mutiscua");
                ListCity.Add("Ocaña");
                ListCity.Add("Pamplona");
                ListCity.Add("Pamplonita");
                ListCity.Add("Puerto Santander");
                ListCity.Add("Ragonvalia");
                ListCity.Add("Salazar");
                ListCity.Add("San Calixto");
                ListCity.Add("San Cayetano");
                ListCity.Add("Santiago");
                ListCity.Add("Sardinata");
                ListCity.Add("Silos");
                ListCity.Add("Teorama");
                ListCity.Add("Tibú");
                ListCity.Add("Toledo");
                ListCity.Add("Villa Caro");
                ListCity.Add("Villa del Rosario");
                mcbCiudad.DataSource = ListCity;
            }
            else if (mcbDepartamento.Text == "Putumayo")
            {
                List<string> ListCity = new List<string>();
                ListCity.Add("Colón");
                ListCity.Add("Mocoa");
                ListCity.Add("Orito");
                ListCity.Add("Puerto Asís");
                ListCity.Add("Puerto Caicedo");
                ListCity.Add("Puerto Guzmán");
                ListCity.Add("Puerto Leguízamo");
                ListCity.Add("San Francisco");
                ListCity.Add("San Miguel");
                ListCity.Add("Santiago");
                ListCity.Add("Sibundoy");
                ListCity.Add("Valle del Guamuez");
                ListCity.Add("Villagarzón");
                mcbCiudad.DataSource = ListCity;
            }
            else if (mcbDepartamento.Text == "Quindio")
            {
                List<string> ListCity = new List<string>();
                ListCity.Add("Armenia");
                ListCity.Add("Buenavista");
                ListCity.Add("Calarcá");
                ListCity.Add("Circasia");
                ListCity.Add("Córdoba");
                ListCity.Add("Génova");
                ListCity.Add("La Tebaida");
                ListCity.Add("Montenegro");
                ListCity.Add("Pijao");
                ListCity.Add("Quimbaya");
                ListCity.Add("Salento");
                mcbCiudad.DataSource = ListCity;
            }
            else if (mcbDepartamento.Text == "Risaralda")
            {
                List<string> ListCity = new List<string>();
                ListCity.Add("Apía");
                ListCity.Add("Balboa");
                ListCity.Add("Belén de Umbría");
                ListCity.Add("Dos Quebradas");
                ListCity.Add("Guática");
                ListCity.Add("La Celia");
                ListCity.Add("La Virginia");
                ListCity.Add("Marsella");
                ListCity.Add("Mistrató");
                ListCity.Add("Pereira");
                ListCity.Add("Pueblo Rico");
                ListCity.Add("Quinchía");
                ListCity.Add("Santa Rosa de Cabal");
                ListCity.Add("Santuario");
                mcbCiudad.DataSource = ListCity;
            }
            else if (mcbDepartamento.Text == "San Andres y Providencia")
            {
                List<string> ListCity = new List<string>();
                ListCity.Add("Providencia y Santa Catalina");
                mcbCiudad.DataSource = ListCity;
            }
            else if (mcbDepartamento.Text == "Santander")
            {
                List<string> ListCity = new List<string>();
                ListCity.Add("Aguada");
                ListCity.Add("Albania");
                ListCity.Add("Aratoca");
                ListCity.Add("Barbosa");
                ListCity.Add("Barichara");
                ListCity.Add("Barrancabermeja");
                ListCity.Add("Betulia");
                ListCity.Add("Bolivar");
                ListCity.Add("Bucaramanga");
                ListCity.Add("Cabrera");
                ListCity.Add("California");
                ListCity.Add("Capitanejo");
                ListCity.Add("Carcasí");
                ListCity.Add("Cepitá");
                ListCity.Add("Cerrito");
                ListCity.Add("Charalá");
                ListCity.Add("Charta");
                ListCity.Add("Chima");
                ListCity.Add("Chipata");
                ListCity.Add("Cimitarra");
                ListCity.Add("Concepción");
                ListCity.Add("Confines");
                ListCity.Add("Contratación");
                ListCity.Add("Coromoro");
                ListCity.Add("Curití");
                ListCity.Add("El Carmen de Chucurí");
                ListCity.Add("El Florián");
                ListCity.Add("El Guacamayo");
                ListCity.Add("El Peñón");
                ListCity.Add("El Playón");
                ListCity.Add("Encino");
                ListCity.Add("Enciso");
                ListCity.Add("Floridablanca");
                ListCity.Add("Galán");
                ListCity.Add("Gámbita");
                ListCity.Add("Girón");
                ListCity.Add("Guaca");
                ListCity.Add("Guadalupe");
                ListCity.Add("Guapotá");
                ListCity.Add("Guavatá");
                ListCity.Add("Guepsa");
                ListCity.Add("Hato");
                ListCity.Add("Jesús María");
                ListCity.Add("Jordán");
                ListCity.Add("La Belleza");
                ListCity.Add("La Paz");
                ListCity.Add("Landázuri");
                ListCity.Add("Lebrija");
                ListCity.Add("Los Santos");
                ListCity.Add("Macaravita");
                ListCity.Add("Málaga");
                ListCity.Add("Matanza");
                ListCity.Add("Mogotes");
                ListCity.Add("Molagavita");
                ListCity.Add("Ocamonte");
                ListCity.Add("Oiba");
                ListCity.Add("Onzaga");
                ListCity.Add("Palmar");
                ListCity.Add("Palmas del Socorro");
                ListCity.Add("Páramo");
                ListCity.Add("Piedecuesta");
                ListCity.Add("Pinchote");
                ListCity.Add("Puente Nacional");
                ListCity.Add("Puerto Parra");
                ListCity.Add("Puerto Wilches");
                ListCity.Add("Rionegro");
                ListCity.Add("Sabana de Torres");
                ListCity.Add("San Andrés");
                ListCity.Add("San Benito");
                ListCity.Add("San Gil");
                ListCity.Add("San Joaquín");
                ListCity.Add("San José de Miranda");
                ListCity.Add("San Miguel");
                ListCity.Add("San Vicente de Chucurí");
                ListCity.Add("Santa Bárbara");
                ListCity.Add("Santa Helena del Opón");
                ListCity.Add("Simacota");
                ListCity.Add("Socorro");
                ListCity.Add("Suaita");
                ListCity.Add("Sucre");
                ListCity.Add("Suratá");
                ListCity.Add("Tona");
                ListCity.Add("Valle de San José");
                ListCity.Add("Vélez");
                ListCity.Add("Vetas");
                ListCity.Add("Villanueva");
                ListCity.Add("Zapatoca");
                mcbCiudad.DataSource = ListCity;
            }
            else if (mcbDepartamento.Text == "Sucre")
            {
                List<string> ListCity = new List<string>();
                ListCity.Add("Buenavista");
                ListCity.Add("Caimito");
                ListCity.Add("Chalán");
                ListCity.Add("Colosó");
                ListCity.Add("Corozal");
                ListCity.Add("Coveñas");
                ListCity.Add("El Roble");
                ListCity.Add("Galeras");
                ListCity.Add("Guaranda");
                ListCity.Add("La Unión");
                ListCity.Add("Los Palmitos");
                ListCity.Add("Majagual");
                ListCity.Add("Morroa");
                ListCity.Add("Ovejas");
                ListCity.Add("Palmito");
                ListCity.Add("Sampués");
                ListCity.Add("San Benito Abad");
                ListCity.Add("San Juan Betulia");
                ListCity.Add("San Marcos");
                ListCity.Add("San Onofre");
                ListCity.Add("San Pedro");
                ListCity.Add("Sincé");
                ListCity.Add("Sincelejo");
                ListCity.Add("Sucre");
                ListCity.Add("Tolú");
                ListCity.Add("Toluviejo");
                mcbCiudad.DataSource = ListCity;
            }
            else if (mcbDepartamento.Text == "Tolima")
            {
                List<string> ListCity = new List<string>();
                ListCity.Add("Alpujarra");
                ListCity.Add("Alvarado");
                ListCity.Add("Ambalema");
                ListCity.Add("Anzoátegui");
                ListCity.Add("Armero");
                ListCity.Add("Ataco");
                ListCity.Add("Cajamarca");
                ListCity.Add("Carmen de Apicalá");
                ListCity.Add("Casabianca");
                ListCity.Add("Chaparral");
                ListCity.Add("Coello");
                ListCity.Add("Coyaima");
                ListCity.Add("Cunday");
                ListCity.Add("Dolores");
                ListCity.Add("Espinal");
                ListCity.Add("Falan");
                ListCity.Add("Flandes");
                ListCity.Add("Fresno");
                ListCity.Add("Guamo");
                ListCity.Add("Herveo");
                ListCity.Add("Honda");
                ListCity.Add("Ibagué");
                ListCity.Add("Icononzo");
                ListCity.Add("Lérida");
                ListCity.Add("Líbano");
                ListCity.Add("Mariquita");
                ListCity.Add("Melgar");
                ListCity.Add("Murillo");
                ListCity.Add("Natagaima");
                ListCity.Add("Ortega");
                ListCity.Add("Palocabildo");
                ListCity.Add("Piedras");
                ListCity.Add("Planadas");
                ListCity.Add("Prado");
                ListCity.Add("Purificación");
                ListCity.Add("Rioblanco");
                ListCity.Add("Roncesvalles");
                ListCity.Add("Rovira");
                ListCity.Add("Saldaña");
                ListCity.Add("San Antonio");
                ListCity.Add("San Luis");
                ListCity.Add("Santa Isabel");
                ListCity.Add("Suárez");
                ListCity.Add("Valle de San Juan");
                ListCity.Add("Venadillo");
                ListCity.Add("Villahermosa");
                ListCity.Add("Villarrica");
                mcbCiudad.DataSource = ListCity;
            }
            else if (mcbDepartamento.Text == "Valle del Cauca")
            {
                List<string> ListCity = new List<string>();
                ListCity.Add("Alcalá");
                ListCity.Add("Andalucia");
                ListCity.Add("Ansermanuevo");
                ListCity.Add("Argelia");
                ListCity.Add("Bolívar");
                ListCity.Add("Buenaventura");
                ListCity.Add("Buga");
                ListCity.Add("Bugalagrande");
                ListCity.Add("Caicedonia");
                ListCity.Add("Cali");
                ListCity.Add("Calima");
                ListCity.Add("Candelaria");
                ListCity.Add("Cartago");
                ListCity.Add("Dagua");
                ListCity.Add("El Águila");
                ListCity.Add("El Cairo");
                ListCity.Add("El Cerrito");
                ListCity.Add("El Dovio");
                ListCity.Add("Florida");
                ListCity.Add("Ginebra");
                ListCity.Add("Guacarí");
                ListCity.Add("Jamundí");
                ListCity.Add("La Cumbre");
                ListCity.Add("La Unión");
                ListCity.Add("La Victoria");
                ListCity.Add("Obando");
                ListCity.Add("Palmira");
                ListCity.Add("Pradera");
                ListCity.Add("Restrepo");
                ListCity.Add("Riofrío");
                ListCity.Add("Roldanillo");
                ListCity.Add("San Pedro");
                ListCity.Add("Sevilla");
                ListCity.Add("Toro");
                ListCity.Add("Trujillo");
                ListCity.Add("Tuluá");
                ListCity.Add("Ulloa");
                ListCity.Add("Versalles");
                ListCity.Add("Vijes");
                ListCity.Add("Yotoco");
                ListCity.Add("Yumbo");
                ListCity.Add("Zarzal");
                mcbCiudad.DataSource = ListCity;
            }
            else if (mcbDepartamento.Text == "Vaupés")
            {
                List<string> ListCity = new List<string>();
                ListCity.Add("Carurú");
                ListCity.Add("Mitú");
                ListCity.Add("Taraira");
                mcbCiudad.DataSource = ListCity;
            }
            else if (mcbDepartamento.Text == "Vichada")
            {
                List<string> ListCity = new List<string>();
                ListCity.Add("Cumaribo");
                ListCity.Add("La Primavera");
                ListCity.Add("Puerto Carreño");
                ListCity.Add("Santa Rosalía");
                mcbCiudad.DataSource = ListCity;
            }
        }

        private void mbFiltro_Click(object sender, EventArgs e)
        {
            IList<EClProveedores> ListProv = new List<EClProveedores>();
            ListProv = objLprov.mtdListProvMega(txtFiltro.Text);
            for (int i = 0; i < ListProv.Count; i++)
            {
                dgvProveedores.Rows.Clear();
                dgvProveedores.Rows.Add();
                dgvProveedores.Rows[i].Cells[0].Value = ListProv[i].Nombre;
                dgvProveedores.Rows[i].Cells[1].Value = ListProv[i].Nit;
                dgvProveedores.Rows[i].Cells[2].Value = ListProv[i].Departamento;
                dgvProveedores.Rows[i].Cells[3].Value = ListProv[i].Ciudad;
                dgvProveedores.Rows[i].Cells[4].Value = ListProv[i].Direccion;
                dgvProveedores.Rows[i].Cells[5].Value = ListProv[i].Email;
                dgvProveedores.Rows[i].Cells[5].Value = ListProv[i].Telefono;
                dgvProveedores.Rows[i].Cells[5].Value = ListProv[i].PaginaWeb;
            }
        }
    }
}
