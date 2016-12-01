namespace ModuloRiesgosSG_SST.Vista.GestionProveedores
{
    partial class MfrmMenuModificacionEva
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MfrmMenuModificacionEva));
            this.btnEditEva = new MetroFramework.Controls.MetroButton();
            this.btnElimEva = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // btnEditEva
            // 
            this.btnEditEva.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditEva.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnEditEva.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnEditEva.Location = new System.Drawing.Point(48, 82);
            this.btnEditEva.Name = "btnEditEva";
            this.btnEditEva.Size = new System.Drawing.Size(137, 57);
            this.btnEditEva.TabIndex = 0;
            this.btnEditEva.Text = "Editar evaluacion";
            this.btnEditEva.UseSelectable = true;
            this.btnEditEva.Click += new System.EventHandler(this.btnEditEva_Click);
            // 
            // btnElimEva
            // 
            this.btnElimEva.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnElimEva.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnElimEva.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnElimEva.Location = new System.Drawing.Point(206, 82);
            this.btnElimEva.Name = "btnElimEva";
            this.btnElimEva.Size = new System.Drawing.Size(142, 57);
            this.btnElimEva.TabIndex = 1;
            this.btnElimEva.Text = "Eliminar evaluacion";
            this.btnElimEva.UseSelectable = true;
            this.btnElimEva.Click += new System.EventHandler(this.btnElimEva_Click);
            // 
            // MfrmMenuModificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 204);
            this.Controls.Add(this.btnElimEva);
            this.Controls.Add(this.btnEditEva);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MfrmMenuModificacion";
            this.Text = "¿Que accion desea realizar?";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MfrmMenuModificacion_FormClosed);
            this.Load += new System.EventHandler(this.MfrmMenuModificacion_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnEditEva;
        private MetroFramework.Controls.MetroButton btnElimEva;
    }
}