namespace ModuloRiesgosSG_SST.Vista.GestionProveedores
{
    partial class MfrmEliminarEvaluacion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MfrmEliminarEvaluacion));
            this.btnEliminar = new MetroFramework.Controls.MetroButton();
            this.btnBuscarElim = new MetroFramework.Controls.MetroButton();
            this.grillaEvaluacion = new MetroFramework.Controls.MetroGrid();
            this.label1 = new System.Windows.Forms.Label();
            this.mcmbProveedor = new MetroFramework.Controls.MetroComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.grillaEvaluacion)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnEliminar.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnEliminar.Location = new System.Drawing.Point(434, 62);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(83, 29);
            this.btnEliminar.TabIndex = 14;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseSelectable = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnBuscarElim
            // 
            this.btnBuscarElim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarElim.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnBuscarElim.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnBuscarElim.Location = new System.Drawing.Point(345, 62);
            this.btnBuscarElim.Name = "btnBuscarElim";
            this.btnBuscarElim.Size = new System.Drawing.Size(83, 29);
            this.btnBuscarElim.TabIndex = 13;
            this.btnBuscarElim.Text = "Buscar";
            this.btnBuscarElim.UseSelectable = true;
            this.btnBuscarElim.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // grillaEvaluacion
            // 
            this.grillaEvaluacion.AllowUserToResizeRows = false;
            this.grillaEvaluacion.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grillaEvaluacion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grillaEvaluacion.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grillaEvaluacion.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grillaEvaluacion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grillaEvaluacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grillaEvaluacion.DefaultCellStyle = dataGridViewCellStyle2;
            this.grillaEvaluacion.EnableHeadersVisualStyles = false;
            this.grillaEvaluacion.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grillaEvaluacion.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grillaEvaluacion.Location = new System.Drawing.Point(23, 118);
            this.grillaEvaluacion.Name = "grillaEvaluacion";
            this.grillaEvaluacion.ReadOnly = true;
            this.grillaEvaluacion.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grillaEvaluacion.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grillaEvaluacion.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grillaEvaluacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grillaEvaluacion.Size = new System.Drawing.Size(538, 188);
            this.grillaEvaluacion.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Proveedor";
            // 
            // mcmbProveedor
            // 
            this.mcmbProveedor.FormattingEnabled = true;
            this.mcmbProveedor.ItemHeight = 23;
            this.mcmbProveedor.Location = new System.Drawing.Point(202, 63);
            this.mcmbProveedor.Name = "mcmbProveedor";
            this.mcmbProveedor.Size = new System.Drawing.Size(121, 29);
            this.mcmbProveedor.TabIndex = 15;
            this.mcmbProveedor.UseSelectable = true;
            this.mcmbProveedor.Click += new System.EventHandler(this.mcmbProveedor_Click);
            // 
            // MfrmEliminarEvaluacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 368);
            this.Controls.Add(this.mcmbProveedor);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnBuscarElim);
            this.Controls.Add(this.grillaEvaluacion);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MfrmEliminarEvaluacion";
            this.Text = "Eliminar evaluaciones";
            this.Load += new System.EventHandler(this.MfrmEliminarEvaluacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillaEvaluacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnEliminar;
        private MetroFramework.Controls.MetroButton btnBuscarElim;
        private MetroFramework.Controls.MetroGrid grillaEvaluacion;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroComboBox mcmbProveedor;
    }
}