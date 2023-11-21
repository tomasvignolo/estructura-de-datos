namespace pryVignoloTp1
{
    partial class frmPila
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPila));
            this.dgvPila = new System.Windows.Forms.DataGridView();
            this.clmCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTramite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbEliminado = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtTramiteRO = new System.Windows.Forms.TextBox();
            this.txtNombreRO = new System.Windows.Forms.TextBox();
            this.lblCodigoRO = new System.Windows.Forms.Label();
            this.lblTramiteRO = new System.Windows.Forms.Label();
            this.txtCodigoRO = new System.Windows.Forms.TextBox();
            this.lblNombreRO = new System.Windows.Forms.Label();
            this.grbNuevo = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtTramite = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblTramite = new System.Windows.Forms.Label();
            this.grbListado = new System.Windows.Forms.GroupBox();
            this.lstPila = new System.Windows.Forms.ListBox();
            this.prbGrafico = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPila)).BeginInit();
            this.grbEliminado.SuspendLayout();
            this.grbNuevo.SuspendLayout();
            this.grbListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prbGrafico)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPila
            // 
            this.dgvPila.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPila.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCodigo,
            this.clmNombre,
            this.clmTramite});
            this.dgvPila.Location = new System.Drawing.Point(255, 19);
            this.dgvPila.Name = "dgvPila";
            this.dgvPila.Size = new System.Drawing.Size(444, 283);
            this.dgvPila.TabIndex = 15;
            // 
            // clmCodigo
            // 
            this.clmCodigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.clmCodigo.HeaderText = "Codigo";
            this.clmCodigo.Name = "clmCodigo";
            this.clmCodigo.Width = 65;
            // 
            // clmNombre
            // 
            this.clmNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmNombre.HeaderText = "Nombre";
            this.clmNombre.Name = "clmNombre";
            // 
            // clmTramite
            // 
            this.clmTramite.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmTramite.HeaderText = "Tramite";
            this.clmTramite.Name = "clmTramite";
            // 
            // grbEliminado
            // 
            this.grbEliminado.Controls.Add(this.btnEliminar);
            this.grbEliminado.Controls.Add(this.txtTramiteRO);
            this.grbEliminado.Controls.Add(this.txtNombreRO);
            this.grbEliminado.Controls.Add(this.lblCodigoRO);
            this.grbEliminado.Controls.Add(this.lblTramiteRO);
            this.grbEliminado.Controls.Add(this.txtCodigoRO);
            this.grbEliminado.Controls.Add(this.lblNombreRO);
            this.grbEliminado.Location = new System.Drawing.Point(520, 24);
            this.grbEliminado.Name = "grbEliminado";
            this.grbEliminado.Size = new System.Drawing.Size(200, 160);
            this.grbEliminado.TabIndex = 13;
            this.grbEliminado.TabStop = false;
            this.grbEliminado.Text = "Elemento Eliminado";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(6, 129);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(188, 23);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtTramiteRO
            // 
            this.txtTramiteRO.Enabled = false;
            this.txtTramiteRO.Location = new System.Drawing.Point(56, 96);
            this.txtTramiteRO.Name = "txtTramiteRO";
            this.txtTramiteRO.ReadOnly = true;
            this.txtTramiteRO.Size = new System.Drawing.Size(138, 20);
            this.txtTramiteRO.TabIndex = 11;
            // 
            // txtNombreRO
            // 
            this.txtNombreRO.Enabled = false;
            this.txtNombreRO.Location = new System.Drawing.Point(56, 63);
            this.txtNombreRO.Name = "txtNombreRO";
            this.txtNombreRO.ReadOnly = true;
            this.txtNombreRO.Size = new System.Drawing.Size(138, 20);
            this.txtNombreRO.TabIndex = 10;
            // 
            // lblCodigoRO
            // 
            this.lblCodigoRO.AutoSize = true;
            this.lblCodigoRO.Location = new System.Drawing.Point(6, 33);
            this.lblCodigoRO.Name = "lblCodigoRO";
            this.lblCodigoRO.Size = new System.Drawing.Size(43, 13);
            this.lblCodigoRO.TabIndex = 6;
            this.lblCodigoRO.Text = "Codigo:";
            // 
            // lblTramiteRO
            // 
            this.lblTramiteRO.AutoSize = true;
            this.lblTramiteRO.Location = new System.Drawing.Point(6, 99);
            this.lblTramiteRO.Name = "lblTramiteRO";
            this.lblTramiteRO.Size = new System.Drawing.Size(45, 13);
            this.lblTramiteRO.TabIndex = 8;
            this.lblTramiteRO.Text = "Tramite:";
            // 
            // txtCodigoRO
            // 
            this.txtCodigoRO.Enabled = false;
            this.txtCodigoRO.Location = new System.Drawing.Point(56, 30);
            this.txtCodigoRO.Name = "txtCodigoRO";
            this.txtCodigoRO.ReadOnly = true;
            this.txtCodigoRO.Size = new System.Drawing.Size(73, 20);
            this.txtCodigoRO.TabIndex = 9;
            // 
            // lblNombreRO
            // 
            this.lblNombreRO.AutoSize = true;
            this.lblNombreRO.Location = new System.Drawing.Point(6, 66);
            this.lblNombreRO.Name = "lblNombreRO";
            this.lblNombreRO.Size = new System.Drawing.Size(47, 13);
            this.lblNombreRO.TabIndex = 7;
            this.lblNombreRO.Text = "Nombre:";
            // 
            // grbNuevo
            // 
            this.grbNuevo.Controls.Add(this.btnAgregar);
            this.grbNuevo.Controls.Add(this.txtTramite);
            this.grbNuevo.Controls.Add(this.lblCodigo);
            this.grbNuevo.Controls.Add(this.txtNombre);
            this.grbNuevo.Controls.Add(this.lblNombre);
            this.grbNuevo.Controls.Add(this.txtCodigo);
            this.grbNuevo.Controls.Add(this.lblTramite);
            this.grbNuevo.Location = new System.Drawing.Point(292, 24);
            this.grbNuevo.Name = "grbNuevo";
            this.grbNuevo.Size = new System.Drawing.Size(200, 160);
            this.grbNuevo.TabIndex = 12;
            this.grbNuevo.TabStop = false;
            this.grbNuevo.Text = "Nuevo Elemento";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Enabled = false;
            this.btnAgregar.Location = new System.Drawing.Point(6, 129);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(188, 23);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtTramite
            // 
            this.txtTramite.Location = new System.Drawing.Point(56, 100);
            this.txtTramite.Name = "txtTramite";
            this.txtTramite.Size = new System.Drawing.Size(138, 20);
            this.txtTramite.TabIndex = 5;
            this.txtTramite.TextChanged += new System.EventHandler(this.txtTramite_TextChanged);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(6, 37);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Codigo:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(56, 67);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(138, 20);
            this.txtNombre.TabIndex = 4;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(6, 70);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(56, 34);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(73, 20);
            this.txtCodigo.TabIndex = 3;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            // 
            // lblTramite
            // 
            this.lblTramite.AutoSize = true;
            this.lblTramite.Location = new System.Drawing.Point(6, 103);
            this.lblTramite.Name = "lblTramite";
            this.lblTramite.Size = new System.Drawing.Size(45, 13);
            this.lblTramite.TabIndex = 2;
            this.lblTramite.Text = "Tramite:";
            // 
            // grbListado
            // 
            this.grbListado.Controls.Add(this.lstPila);
            this.grbListado.Controls.Add(this.dgvPila);
            this.grbListado.Location = new System.Drawing.Point(21, 217);
            this.grbListado.Name = "grbListado";
            this.grbListado.Size = new System.Drawing.Size(720, 316);
            this.grbListado.TabIndex = 17;
            this.grbListado.TabStop = false;
            this.grbListado.Text = "Listado en una Lista y una Grilla";
            this.grbListado.Enter += new System.EventHandler(this.grbListado_Enter);
            // 
            // lstPila
            // 
            this.lstPila.FormattingEnabled = true;
            this.lstPila.Location = new System.Drawing.Point(17, 25);
            this.lstPila.Name = "lstPila";
            this.lstPila.Size = new System.Drawing.Size(230, 277);
            this.lstPila.TabIndex = 16;
            // 
            // prbGrafico
            // 
            this.prbGrafico.Image = global::pryVignoloTp1.Properties.Resources.pila;
            this.prbGrafico.Location = new System.Drawing.Point(38, 16);
            this.prbGrafico.Name = "prbGrafico";
            this.prbGrafico.Size = new System.Drawing.Size(217, 182);
            this.prbGrafico.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.prbGrafico.TabIndex = 14;
            this.prbGrafico.TabStop = false;
            // 
            // frmPila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 559);
            this.Controls.Add(this.prbGrafico);
            this.Controls.Add(this.grbEliminado);
            this.Controls.Add(this.grbNuevo);
            this.Controls.Add(this.grbListado);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPila";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pila";
            this.Load += new System.EventHandler(this.frmPila_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPila)).EndInit();
            this.grbEliminado.ResumeLayout(false);
            this.grbEliminado.PerformLayout();
            this.grbNuevo.ResumeLayout(false);
            this.grbNuevo.PerformLayout();
            this.grbListado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.prbGrafico)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvPila;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTramite;
        private System.Windows.Forms.PictureBox prbGrafico;
        private System.Windows.Forms.GroupBox grbEliminado;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtTramiteRO;
        private System.Windows.Forms.TextBox txtNombreRO;
        private System.Windows.Forms.Label lblCodigoRO;
        private System.Windows.Forms.Label lblTramiteRO;
        private System.Windows.Forms.TextBox txtCodigoRO;
        private System.Windows.Forms.Label lblNombreRO;
        private System.Windows.Forms.GroupBox grbNuevo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtTramite;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblTramite;
        private System.Windows.Forms.GroupBox grbListado;
        private System.Windows.Forms.ListBox lstPila;
    }
}