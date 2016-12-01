namespace ModuloRiesgosSG_SST.Vista
{
    partial class MfrmPrincipalMenu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MfrmPrincipalMenu));
            this.mtGestionProgramas = new MetroFramework.Controls.MetroTile();
            this.mtGestionProducto = new MetroFramework.Controls.MetroTile();
            this.mtGestionP = new MetroFramework.Controls.MetroTile();
            this.mtGestionRH = new MetroFramework.Controls.MetroTile();
            this.mtGestionR = new MetroFramework.Controls.MetroTile();
            this.mlOptionsMenu = new MetroFramework.Controls.MetroLink();
            this.mcmOptionsMenu = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.temasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oscuroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blancoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msmMenu = new MetroFramework.Components.MetroStyleManager(this.components);
            this.tmSlide = new System.Windows.Forms.Timer(this.components);
            this.mcmOptionsMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.msmMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // mtGestionProgramas
            // 
            this.mtGestionProgramas.ActiveControl = null;
            this.mtGestionProgramas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mtGestionProgramas.Location = new System.Drawing.Point(510, 74);
            this.mtGestionProgramas.Name = "mtGestionProgramas";
            this.mtGestionProgramas.Size = new System.Drawing.Size(204, 247);
            this.mtGestionProgramas.Style = MetroFramework.MetroColorStyle.Red;
            this.mtGestionProgramas.TabIndex = 9;
            this.mtGestionProgramas.Text = "Gestion de Programas";
            this.mtGestionProgramas.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mtGestionProgramas.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtGestionProgramas.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.mtGestionProgramas.UseSelectable = true;
            this.mtGestionProgramas.Click += new System.EventHandler(this.mtGestionProgramas_Click);
            // 
            // mtGestionProducto
            // 
            this.mtGestionProducto.ActiveControl = null;
            this.mtGestionProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mtGestionProducto.Location = new System.Drawing.Point(314, 74);
            this.mtGestionProducto.Name = "mtGestionProducto";
            this.mtGestionProducto.PaintTileCount = false;
            this.mtGestionProducto.Size = new System.Drawing.Size(190, 120);
            this.mtGestionProducto.Style = MetroFramework.MetroColorStyle.Orange;
            this.mtGestionProducto.TabIndex = 8;
            this.mtGestionProducto.Text = "Gestion de Equipos";
            this.mtGestionProducto.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mtGestionProducto.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtGestionProducto.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.mtGestionProducto.UseSelectable = true;
            // 
            // mtGestionP
            // 
            this.mtGestionP.ActiveControl = null;
            this.mtGestionP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mtGestionP.Location = new System.Drawing.Point(234, 200);
            this.mtGestionP.Name = "mtGestionP";
            this.mtGestionP.PaintTileCount = false;
            this.mtGestionP.Size = new System.Drawing.Size(270, 121);
            this.mtGestionP.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtGestionP.TabIndex = 7;
            this.mtGestionP.Text = "Gestion de Proveedores";
            this.mtGestionP.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mtGestionP.TileImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.mtGestionP.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtGestionP.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.mtGestionP.UseSelectable = true;
            this.mtGestionP.UseStyleColors = true;
            this.mtGestionP.UseTileImage = true;
            this.mtGestionP.Click += new System.EventHandler(this.mtGestionP_Click);
            this.mtGestionP.MouseHover += new System.EventHandler(this.mtGestionP_MouseHover);
            // 
            // mtGestionRH
            // 
            this.mtGestionRH.ActiveControl = null;
            this.mtGestionRH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mtGestionRH.Location = new System.Drawing.Point(37, 74);
            this.mtGestionRH.Name = "mtGestionRH";
            this.mtGestionRH.Size = new System.Drawing.Size(271, 120);
            this.mtGestionRH.Style = MetroFramework.MetroColorStyle.Silver;
            this.mtGestionRH.TabIndex = 6;
            this.mtGestionRH.Text = "Gestion de Recursos Humanos";
            this.mtGestionRH.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtGestionRH.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtGestionRH.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtGestionRH.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.mtGestionRH.UseSelectable = true;
            this.mtGestionRH.UseTileImage = true;
            this.mtGestionRH.Click += new System.EventHandler(this.mtGestionRH_Click);
            // 
            // mtGestionR
            // 
            this.mtGestionR.ActiveControl = null;
            this.mtGestionR.BackColor = System.Drawing.Color.Black;
            this.mtGestionR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mtGestionR.Location = new System.Drawing.Point(37, 200);
            this.mtGestionR.Name = "mtGestionR";
            this.mtGestionR.Size = new System.Drawing.Size(191, 121);
            this.mtGestionR.Style = MetroFramework.MetroColorStyle.Lime;
            this.mtGestionR.TabIndex = 5;
            this.mtGestionR.Text = "Gestion de Riesgos";
            this.mtGestionR.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mtGestionR.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtGestionR.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.mtGestionR.UseSelectable = true;
            this.mtGestionR.UseTileImage = true;
            // 
            // mlOptionsMenu
            // 
            this.mlOptionsMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mlOptionsMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mlOptionsMenu.Image = ((System.Drawing.Image)(resources.GetObject("mlOptionsMenu.Image")));
            this.mlOptionsMenu.ImageSize = 40;
            this.mlOptionsMenu.Location = new System.Drawing.Point(697, 337);
            this.mlOptionsMenu.Name = "mlOptionsMenu";
            this.mlOptionsMenu.Size = new System.Drawing.Size(64, 49);
            this.mlOptionsMenu.TabIndex = 10;
            this.mlOptionsMenu.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mlOptionsMenu.UseSelectable = true;
            this.mlOptionsMenu.Click += new System.EventHandler(this.mlOptionsMenu_Click);
            // 
            // mcmOptionsMenu
            // 
            this.mcmOptionsMenu.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mcmOptionsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.temasToolStripMenuItem,
            this.salidaToolStripMenuItem});
            this.mcmOptionsMenu.Name = "mcmOptionsMenu";
            this.mcmOptionsMenu.Size = new System.Drawing.Size(123, 52);
            // 
            // temasToolStripMenuItem
            // 
            this.temasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oscuroToolStripMenuItem,
            this.blancoToolStripMenuItem});
            this.temasToolStripMenuItem.Name = "temasToolStripMenuItem";
            this.temasToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.temasToolStripMenuItem.Text = "Temas";
            // 
            // oscuroToolStripMenuItem
            // 
            this.oscuroToolStripMenuItem.Name = "oscuroToolStripMenuItem";
            this.oscuroToolStripMenuItem.Size = new System.Drawing.Size(131, 24);
            this.oscuroToolStripMenuItem.Text = "Oscuro";
            this.oscuroToolStripMenuItem.Click += new System.EventHandler(this.oscuroToolStripMenuItem_Click);
            // 
            // blancoToolStripMenuItem
            // 
            this.blancoToolStripMenuItem.Name = "blancoToolStripMenuItem";
            this.blancoToolStripMenuItem.Size = new System.Drawing.Size(131, 24);
            this.blancoToolStripMenuItem.Text = "Blanco";
            this.blancoToolStripMenuItem.Click += new System.EventHandler(this.blancoToolStripMenuItem_Click);
            // 
            // salidaToolStripMenuItem
            // 
            this.salidaToolStripMenuItem.Name = "salidaToolStripMenuItem";
            this.salidaToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.salidaToolStripMenuItem.Text = "Estilos";
            this.salidaToolStripMenuItem.Click += new System.EventHandler(this.salidaToolStripMenuItem_Click);
            // 
            // msmMenu
            // 
            this.msmMenu.Owner = null;
            // 
            // tmSlide
            // 
            this.tmSlide.Tick += new System.EventHandler(this.tmSlide_Tick);
            // 
            // MfrmPrincipalMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 386);
            this.Controls.Add(this.mlOptionsMenu);
            this.Controls.Add(this.mtGestionProgramas);
            this.Controls.Add(this.mtGestionProducto);
            this.Controls.Add(this.mtGestionP);
            this.Controls.Add(this.mtGestionRH);
            this.Controls.Add(this.mtGestionR);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MfrmPrincipalMenu";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Style = MetroFramework.MetroColorStyle.Yellow;
            this.Text = "SGSST - Inicio";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MfrmPrincipalMenu_FormClosing);
            this.Load += new System.EventHandler(this.MfrmPrincipalMenu_Load);
            this.mcmOptionsMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.msmMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile mtGestionProgramas;
        private MetroFramework.Controls.MetroTile mtGestionProducto;
        private MetroFramework.Controls.MetroTile mtGestionP;
        private MetroFramework.Controls.MetroTile mtGestionRH;
        private MetroFramework.Controls.MetroTile mtGestionR;
        private MetroFramework.Controls.MetroLink mlOptionsMenu;
        private MetroFramework.Controls.MetroContextMenu mcmOptionsMenu;
        private System.Windows.Forms.ToolStripMenuItem temasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oscuroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blancoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salidaToolStripMenuItem;
        private MetroFramework.Components.MetroStyleManager msmMenu;
        private System.Windows.Forms.Timer tmSlide;
    }
}