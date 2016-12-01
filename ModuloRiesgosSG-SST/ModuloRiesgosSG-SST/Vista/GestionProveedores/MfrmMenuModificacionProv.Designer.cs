namespace ModuloRiesgosSG_SST.Vista.GestionProveedores
{
    partial class MfrmMenuModificacionProv
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MfrmMenuModificacionProv));
            this.mtbnActProveedor = new MetroFramework.Controls.MetroButton();
            this.mtbnEliminarProv = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // mtbnActProveedor
            // 
            this.mtbnActProveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mtbnActProveedor.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.mtbnActProveedor.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.mtbnActProveedor.Location = new System.Drawing.Point(45, 88);
            this.mtbnActProveedor.Name = "mtbnActProveedor";
            this.mtbnActProveedor.Size = new System.Drawing.Size(152, 59);
            this.mtbnActProveedor.TabIndex = 0;
            this.mtbnActProveedor.Text = "Actualizar proveedor";
            this.mtbnActProveedor.UseSelectable = true;
            this.mtbnActProveedor.Click += new System.EventHandler(this.mtbnActProveedor_Click);
            // 
            // mtbnEliminarProv
            // 
            this.mtbnEliminarProv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mtbnEliminarProv.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.mtbnEliminarProv.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.mtbnEliminarProv.Location = new System.Drawing.Point(214, 88);
            this.mtbnEliminarProv.Name = "mtbnEliminarProv";
            this.mtbnEliminarProv.Size = new System.Drawing.Size(144, 59);
            this.mtbnEliminarProv.TabIndex = 1;
            this.mtbnEliminarProv.Text = "Eliminar proveedor";
            this.mtbnEliminarProv.UseSelectable = true;
            this.mtbnEliminarProv.Click += new System.EventHandler(this.mtbnEliminarProv_Click);
            // 
            // MfrmMenuModificacionProv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 210);
            this.Controls.Add(this.mtbnEliminarProv);
            this.Controls.Add(this.mtbnActProveedor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MfrmMenuModificacionProv";
            this.Text = "¿Que accion desea realizar?";
            this.Load += new System.EventHandler(this.MfrmMenuModificacionProv_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton mtbnActProveedor;
        private MetroFramework.Controls.MetroButton mtbnEliminarProv;
    }
}