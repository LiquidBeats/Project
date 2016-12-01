namespace ModuloRiesgosSG_SST.Vista.GestionProveedores
{
    partial class MfrmEditarEvaluacion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MfrmEditarEvaluacion));
            this.btnBuscar = new MetroFramework.Controls.MetroButton();
            this.mlProveedor = new MetroFramework.Controls.MetroLabel();
            this.mlFechaInicio = new MetroFramework.Controls.MetroLabel();
            this.mlFechaFin = new MetroFramework.Controls.MetroLabel();
            this.mlFechaCiclo = new MetroFramework.Controls.MetroLabel();
            this.mlPuntaje = new MetroFramework.Controls.MetroLabel();
            this.mlDescripcion = new MetroFramework.Controls.MetroLabel();
            this.mcmbProveedor = new MetroFramework.Controls.MetroComboBox();
            this.mtxtPuntaje = new MetroFramework.Controls.MetroTextBox();
            this.mtxtDescripcion = new MetroFramework.Controls.MetroTextBox();
            this.mbtnModificar = new MetroFramework.Controls.MetroButton();
            this.mdtInicio = new MetroFramework.Controls.MetroDateTime();
            this.mdtFin = new MetroFramework.Controls.MetroDateTime();
            this.mdtCiclo = new MetroFramework.Controls.MetroDateTime();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.Location = new System.Drawing.Point(351, 89);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(39, 24);
            this.btnBuscar.TabIndex = 27;
            this.btnBuscar.Text = "...";
            this.btnBuscar.UseSelectable = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // mlProveedor
            // 
            this.mlProveedor.AutoSize = true;
            this.mlProveedor.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mlProveedor.Location = new System.Drawing.Point(95, 92);
            this.mlProveedor.Name = "mlProveedor";
            this.mlProveedor.Size = new System.Drawing.Size(90, 25);
            this.mlProveedor.TabIndex = 29;
            this.mlProveedor.Text = "Proveedor";
            // 
            // mlFechaInicio
            // 
            this.mlFechaInicio.AutoSize = true;
            this.mlFechaInicio.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mlFechaInicio.Location = new System.Drawing.Point(94, 138);
            this.mlFechaInicio.Name = "mlFechaInicio";
            this.mlFechaInicio.Size = new System.Drawing.Size(125, 25);
            this.mlFechaInicio.TabIndex = 30;
            this.mlFechaInicio.Text = "Fecha de Inicio";
            // 
            // mlFechaFin
            // 
            this.mlFechaFin.AutoSize = true;
            this.mlFechaFin.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mlFechaFin.Location = new System.Drawing.Point(95, 188);
            this.mlFechaFin.Name = "mlFechaFin";
            this.mlFechaFin.Size = new System.Drawing.Size(107, 25);
            this.mlFechaFin.TabIndex = 31;
            this.mlFechaFin.Text = "Fecha de Fin";
            // 
            // mlFechaCiclo
            // 
            this.mlFechaCiclo.AutoSize = true;
            this.mlFechaCiclo.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mlFechaCiclo.Location = new System.Drawing.Point(95, 235);
            this.mlFechaCiclo.Name = "mlFechaCiclo";
            this.mlFechaCiclo.Size = new System.Drawing.Size(122, 25);
            this.mlFechaCiclo.TabIndex = 32;
            this.mlFechaCiclo.Text = "Fecha de Ciclo";
            // 
            // mlPuntaje
            // 
            this.mlPuntaje.AutoSize = true;
            this.mlPuntaje.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mlPuntaje.Location = new System.Drawing.Point(95, 286);
            this.mlPuntaje.Name = "mlPuntaje";
            this.mlPuntaje.Size = new System.Drawing.Size(69, 25);
            this.mlPuntaje.TabIndex = 33;
            this.mlPuntaje.Text = "Puntaje";
            // 
            // mlDescripcion
            // 
            this.mlDescripcion.AutoSize = true;
            this.mlDescripcion.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mlDescripcion.Location = new System.Drawing.Point(94, 338);
            this.mlDescripcion.Name = "mlDescripcion";
            this.mlDescripcion.Size = new System.Drawing.Size(100, 25);
            this.mlDescripcion.TabIndex = 34;
            this.mlDescripcion.Text = "Descripcion";
            // 
            // mcmbProveedor
            // 
            this.mcmbProveedor.FormattingEnabled = true;
            this.mcmbProveedor.ItemHeight = 23;
            this.mcmbProveedor.Location = new System.Drawing.Point(225, 89);
            this.mcmbProveedor.Name = "mcmbProveedor";
            this.mcmbProveedor.Size = new System.Drawing.Size(121, 29);
            this.mcmbProveedor.TabIndex = 35;
            this.mcmbProveedor.UseSelectable = true;
            this.mcmbProveedor.Click += new System.EventHandler(this.mcmbProveedor_Click);
            // 
            // mtxtPuntaje
            // 
            // 
            // 
            // 
            this.mtxtPuntaje.CustomButton.Image = null;
            this.mtxtPuntaje.CustomButton.Location = new System.Drawing.Point(141, 1);
            this.mtxtPuntaje.CustomButton.Name = "";
            this.mtxtPuntaje.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtxtPuntaje.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtPuntaje.CustomButton.TabIndex = 1;
            this.mtxtPuntaje.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtPuntaje.CustomButton.UseSelectable = true;
            this.mtxtPuntaje.CustomButton.Visible = false;
            this.mtxtPuntaje.Lines = new string[0];
            this.mtxtPuntaje.Location = new System.Drawing.Point(227, 286);
            this.mtxtPuntaje.MaxLength = 32767;
            this.mtxtPuntaje.Name = "mtxtPuntaje";
            this.mtxtPuntaje.PasswordChar = '\0';
            this.mtxtPuntaje.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtPuntaje.SelectedText = "";
            this.mtxtPuntaje.SelectionLength = 0;
            this.mtxtPuntaje.SelectionStart = 0;
            this.mtxtPuntaje.ShortcutsEnabled = true;
            this.mtxtPuntaje.Size = new System.Drawing.Size(163, 23);
            this.mtxtPuntaje.TabIndex = 39;
            this.mtxtPuntaje.UseSelectable = true;
            this.mtxtPuntaje.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtPuntaje.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtxtDescripcion
            // 
            // 
            // 
            // 
            this.mtxtDescripcion.CustomButton.Image = null;
            this.mtxtDescripcion.CustomButton.Location = new System.Drawing.Point(115, 2);
            this.mtxtDescripcion.CustomButton.Name = "";
            this.mtxtDescripcion.CustomButton.Size = new System.Drawing.Size(45, 45);
            this.mtxtDescripcion.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtDescripcion.CustomButton.TabIndex = 1;
            this.mtxtDescripcion.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtDescripcion.CustomButton.UseSelectable = true;
            this.mtxtDescripcion.CustomButton.Visible = false;
            this.mtxtDescripcion.Lines = new string[0];
            this.mtxtDescripcion.Location = new System.Drawing.Point(227, 338);
            this.mtxtDescripcion.MaxLength = 32767;
            this.mtxtDescripcion.Multiline = true;
            this.mtxtDescripcion.Name = "mtxtDescripcion";
            this.mtxtDescripcion.PasswordChar = '\0';
            this.mtxtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtDescripcion.SelectedText = "";
            this.mtxtDescripcion.SelectionLength = 0;
            this.mtxtDescripcion.SelectionStart = 0;
            this.mtxtDescripcion.ShortcutsEnabled = true;
            this.mtxtDescripcion.Size = new System.Drawing.Size(163, 50);
            this.mtxtDescripcion.TabIndex = 40;
            this.mtxtDescripcion.UseSelectable = true;
            this.mtxtDescripcion.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtDescripcion.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mbtnModificar
            // 
            this.mbtnModificar.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.mbtnModificar.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.mbtnModificar.Location = new System.Drawing.Point(153, 429);
            this.mbtnModificar.Name = "mbtnModificar";
            this.mbtnModificar.Size = new System.Drawing.Size(202, 54);
            this.mbtnModificar.TabIndex = 41;
            this.mbtnModificar.Text = "Modificar";
            this.mbtnModificar.UseSelectable = true;
            this.mbtnModificar.Click += new System.EventHandler(this.mbtnModificar_Click);
            // 
            // mdtInicio
            // 
            this.mdtInicio.Location = new System.Drawing.Point(227, 138);
            this.mdtInicio.MinimumSize = new System.Drawing.Size(0, 29);
            this.mdtInicio.Name = "mdtInicio";
            this.mdtInicio.Size = new System.Drawing.Size(165, 29);
            this.mdtInicio.TabIndex = 42;
            // 
            // mdtFin
            // 
            this.mdtFin.Location = new System.Drawing.Point(227, 188);
            this.mdtFin.MinimumSize = new System.Drawing.Size(0, 29);
            this.mdtFin.Name = "mdtFin";
            this.mdtFin.Size = new System.Drawing.Size(165, 29);
            this.mdtFin.TabIndex = 43;
            // 
            // mdtCiclo
            // 
            this.mdtCiclo.Location = new System.Drawing.Point(227, 235);
            this.mdtCiclo.MinimumSize = new System.Drawing.Size(0, 29);
            this.mdtCiclo.Name = "mdtCiclo";
            this.mdtCiclo.Size = new System.Drawing.Size(165, 29);
            this.mdtCiclo.TabIndex = 44;
            // 
            // MfrmEditarEvaluacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 528);
            this.Controls.Add(this.mdtCiclo);
            this.Controls.Add(this.mdtFin);
            this.Controls.Add(this.mdtInicio);
            this.Controls.Add(this.mbtnModificar);
            this.Controls.Add(this.mtxtDescripcion);
            this.Controls.Add(this.mtxtPuntaje);
            this.Controls.Add(this.mcmbProveedor);
            this.Controls.Add(this.mlDescripcion);
            this.Controls.Add(this.mlPuntaje);
            this.Controls.Add(this.mlFechaCiclo);
            this.Controls.Add(this.mlFechaFin);
            this.Controls.Add(this.mlFechaInicio);
            this.Controls.Add(this.mlProveedor);
            this.Controls.Add(this.btnBuscar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MfrmEditarEvaluacion";
            this.Text = "Editar evaluacion del proveedor";
            this.Load += new System.EventHandler(this.MfrmEditarEvaluacion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroButton btnBuscar;
        private MetroFramework.Controls.MetroLabel mlProveedor;
        private MetroFramework.Controls.MetroLabel mlFechaInicio;
        private MetroFramework.Controls.MetroLabel mlFechaFin;
        private MetroFramework.Controls.MetroLabel mlFechaCiclo;
        private MetroFramework.Controls.MetroLabel mlPuntaje;
        private MetroFramework.Controls.MetroLabel mlDescripcion;
        private MetroFramework.Controls.MetroComboBox mcmbProveedor;
        private MetroFramework.Controls.MetroTextBox mtxtPuntaje;
        private MetroFramework.Controls.MetroTextBox mtxtDescripcion;
        private MetroFramework.Controls.MetroButton mbtnModificar;
        private MetroFramework.Controls.MetroDateTime mdtInicio;
        private MetroFramework.Controls.MetroDateTime mdtFin;
        private MetroFramework.Controls.MetroDateTime mdtCiclo;
    }
}