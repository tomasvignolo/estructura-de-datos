namespace pryVignoloTp1
{
    partial class frmArbolBinario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmArbolBinario));
            this.grpListar = new System.Windows.Forms.GroupBox();
            this.rdbDes = new System.Windows.Forms.RadioButton();
            this.rdbAsc = new System.Windows.Forms.RadioButton();
            this.grbEliminado = new System.Windows.Forms.GroupBox();
            this.cmbCodigo = new System.Windows.Forms.ComboBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblCodigoRO = new System.Windows.Forms.Label();
            this.grbBusqueda = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtTramiteBUS = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtNombreBUS = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtCodigoBUS = new System.Windows.Forms.TextBox();
            this.lblTramite = new System.Windows.Forms.Label();
            this.grbListado = new System.Windows.Forms.GroupBox();
            this.lstArbolBinario = new System.Windows.Forms.ListBox();
            this.dgvArbolBinario = new System.Windows.Forms.DataGridView();
            this.clmCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTramite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trvArbolBinario = new System.Windows.Forms.TreeView();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnEquilibrar = new System.Windows.Forms.Button();
            this.grpOrden = new System.Windows.Forms.GroupBox();
            this.rdbPostOrder = new System.Windows.Forms.RadioButton();
            this.rdbPreOrder = new System.Windows.Forms.RadioButton();
            this.rdbInOrder = new System.Windows.Forms.RadioButton();
            this.grbNuevo = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtTramite = new System.Windows.Forms.TextBox();
            this.lblCodigoA = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombreA = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblTramiteA = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.grpListar.SuspendLayout();
            this.grbEliminado.SuspendLayout();
            this.grbBusqueda.SuspendLayout();
            this.grbListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArbolBinario)).BeginInit();
            this.grpOrden.SuspendLayout();
            this.grbNuevo.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpListar
            // 
            this.grpListar.Controls.Add(this.rdbDes);
            this.grpListar.Controls.Add(this.rdbAsc);
            this.grpListar.Location = new System.Drawing.Point(731, 133);
            this.grpListar.Name = "grpListar";
            this.grpListar.Size = new System.Drawing.Size(197, 78);
            this.grpListar.TabIndex = 34;
            this.grpListar.TabStop = false;
            this.grpListar.Text = "Listar datos";
            // 
            // rdbDes
            // 
            this.rdbDes.AutoSize = true;
            this.rdbDes.Location = new System.Drawing.Point(15, 51);
            this.rdbDes.Name = "rdbDes";
            this.rdbDes.Size = new System.Drawing.Size(89, 17);
            this.rdbDes.TabIndex = 1;
            this.rdbDes.TabStop = true;
            this.rdbDes.Text = "Descendente";
            this.rdbDes.UseVisualStyleBackColor = true;
            this.rdbDes.CheckedChanged += new System.EventHandler(this.rdbDes_CheckedChanged);
            // 
            // rdbAsc
            // 
            this.rdbAsc.AutoSize = true;
            this.rdbAsc.Location = new System.Drawing.Point(15, 28);
            this.rdbAsc.Name = "rdbAsc";
            this.rdbAsc.Size = new System.Drawing.Size(82, 17);
            this.rdbAsc.TabIndex = 0;
            this.rdbAsc.TabStop = true;
            this.rdbAsc.Text = "Ascendente";
            this.rdbAsc.UseVisualStyleBackColor = true;
            this.rdbAsc.CheckedChanged += new System.EventHandler(this.rdbAsc_CheckedChanged);
            // 
            // grbEliminado
            // 
            this.grbEliminado.Controls.Add(this.cmbCodigo);
            this.grbEliminado.Controls.Add(this.btnEliminar);
            this.grbEliminado.Controls.Add(this.lblCodigoRO);
            this.grbEliminado.Location = new System.Drawing.Point(257, 18);
            this.grbEliminado.Name = "grbEliminado";
            this.grbEliminado.Size = new System.Drawing.Size(200, 99);
            this.grbEliminado.TabIndex = 31;
            this.grbEliminado.TabStop = false;
            this.grbEliminado.Text = "Elemento Eliminado";
            // 
            // cmbCodigo
            // 
            this.cmbCodigo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCodigo.FormattingEnabled = true;
            this.cmbCodigo.Location = new System.Drawing.Point(55, 30);
            this.cmbCodigo.Name = "cmbCodigo";
            this.cmbCodigo.Size = new System.Drawing.Size(139, 21);
            this.cmbCodigo.TabIndex = 12;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(6, 60);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(188, 23);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
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
            // grbBusqueda
            // 
            this.grbBusqueda.Controls.Add(this.btnBuscar);
            this.grbBusqueda.Controls.Add(this.txtTramiteBUS);
            this.grbBusqueda.Controls.Add(this.lblCodigo);
            this.grbBusqueda.Controls.Add(this.txtNombreBUS);
            this.grbBusqueda.Controls.Add(this.lblNombre);
            this.grbBusqueda.Controls.Add(this.txtCodigoBUS);
            this.grbBusqueda.Controls.Add(this.lblTramite);
            this.grbBusqueda.Location = new System.Drawing.Point(488, 26);
            this.grbBusqueda.Name = "grbBusqueda";
            this.grbBusqueda.Size = new System.Drawing.Size(200, 160);
            this.grbBusqueda.TabIndex = 30;
            this.grbBusqueda.TabStop = false;
            this.grbBusqueda.Text = "Búsqueda";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(6, 129);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(188, 23);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtTramiteBUS
            // 
            this.txtTramiteBUS.Location = new System.Drawing.Point(56, 100);
            this.txtTramiteBUS.Name = "txtTramiteBUS";
            this.txtTramiteBUS.ReadOnly = true;
            this.txtTramiteBUS.Size = new System.Drawing.Size(138, 20);
            this.txtTramiteBUS.TabIndex = 5;
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
            // txtNombreBUS
            // 
            this.txtNombreBUS.Location = new System.Drawing.Point(56, 67);
            this.txtNombreBUS.Name = "txtNombreBUS";
            this.txtNombreBUS.ReadOnly = true;
            this.txtNombreBUS.Size = new System.Drawing.Size(138, 20);
            this.txtNombreBUS.TabIndex = 4;
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
            // txtCodigoBUS
            // 
            this.txtCodigoBUS.Location = new System.Drawing.Point(56, 34);
            this.txtCodigoBUS.Name = "txtCodigoBUS";
            this.txtCodigoBUS.ReadOnly = true;
            this.txtCodigoBUS.Size = new System.Drawing.Size(86, 20);
            this.txtCodigoBUS.TabIndex = 3;
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
            this.grbListado.Controls.Add(this.lstArbolBinario);
            this.grbListado.Controls.Add(this.dgvArbolBinario);
            this.grbListado.Location = new System.Drawing.Point(21, 209);
            this.grbListado.Name = "grbListado";
            this.grbListado.Size = new System.Drawing.Size(636, 292);
            this.grbListado.TabIndex = 33;
            this.grbListado.TabStop = false;
            this.grbListado.Text = "Listado en una Lista y una Grilla";
            // 
            // lstArbolBinario
            // 
            this.lstArbolBinario.FormattingEnabled = true;
            this.lstArbolBinario.Location = new System.Drawing.Point(17, 34);
            this.lstArbolBinario.Name = "lstArbolBinario";
            this.lstArbolBinario.Size = new System.Drawing.Size(207, 251);
            this.lstArbolBinario.TabIndex = 22;
            // 
            // dgvArbolBinario
            // 
            this.dgvArbolBinario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArbolBinario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCodigo,
            this.clmNombre,
            this.clmTramite});
            this.dgvArbolBinario.Location = new System.Drawing.Point(236, 34);
            this.dgvArbolBinario.Name = "dgvArbolBinario";
            this.dgvArbolBinario.Size = new System.Drawing.Size(400, 258);
            this.dgvArbolBinario.TabIndex = 21;
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
            // trvArbolBinario
            // 
            this.trvArbolBinario.Location = new System.Drawing.Point(681, 228);
            this.trvArbolBinario.Name = "trvArbolBinario";
            this.trvArbolBinario.Size = new System.Drawing.Size(285, 230);
            this.trvArbolBinario.TabIndex = 35;
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(261, 133);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(188, 23);
            this.btnExportar.TabIndex = 36;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // btnEquilibrar
            // 
            this.btnEquilibrar.Location = new System.Drawing.Point(261, 163);
            this.btnEquilibrar.Name = "btnEquilibrar";
            this.btnEquilibrar.Size = new System.Drawing.Size(188, 23);
            this.btnEquilibrar.TabIndex = 37;
            this.btnEquilibrar.Text = "Equilibrar";
            this.btnEquilibrar.UseVisualStyleBackColor = true;
            this.btnEquilibrar.Click += new System.EventHandler(this.btnEquilibrar_Click);
            // 
            // grpOrden
            // 
            this.grpOrden.Controls.Add(this.rdbPostOrder);
            this.grpOrden.Controls.Add(this.rdbPreOrder);
            this.grpOrden.Controls.Add(this.rdbInOrder);
            this.grpOrden.Location = new System.Drawing.Point(731, 18);
            this.grpOrden.Name = "grpOrden";
            this.grpOrden.Size = new System.Drawing.Size(197, 99);
            this.grpOrden.TabIndex = 38;
            this.grpOrden.TabStop = false;
            this.grpOrden.Text = "Orden de búsqueda";
            // 
            // rdbPostOrder
            // 
            this.rdbPostOrder.AutoSize = true;
            this.rdbPostOrder.Location = new System.Drawing.Point(15, 74);
            this.rdbPostOrder.Name = "rdbPostOrder";
            this.rdbPostOrder.Size = new System.Drawing.Size(78, 17);
            this.rdbPostOrder.TabIndex = 2;
            this.rdbPostOrder.TabStop = true;
            this.rdbPostOrder.Text = "Post-Orden";
            this.rdbPostOrder.UseVisualStyleBackColor = true;
            this.rdbPostOrder.CheckedChanged += new System.EventHandler(this.rdbPostOrder_CheckedChanged);
            // 
            // rdbPreOrder
            // 
            this.rdbPreOrder.AutoSize = true;
            this.rdbPreOrder.Location = new System.Drawing.Point(15, 51);
            this.rdbPreOrder.Name = "rdbPreOrder";
            this.rdbPreOrder.Size = new System.Drawing.Size(73, 17);
            this.rdbPreOrder.TabIndex = 1;
            this.rdbPreOrder.TabStop = true;
            this.rdbPreOrder.Text = "Pre-Orden";
            this.rdbPreOrder.UseVisualStyleBackColor = true;
            this.rdbPreOrder.CheckedChanged += new System.EventHandler(this.rdbPreOrder_CheckedChanged);
            // 
            // rdbInOrder
            // 
            this.rdbInOrder.AutoSize = true;
            this.rdbInOrder.Location = new System.Drawing.Point(15, 28);
            this.rdbInOrder.Name = "rdbInOrder";
            this.rdbInOrder.Size = new System.Drawing.Size(66, 17);
            this.rdbInOrder.TabIndex = 0;
            this.rdbInOrder.TabStop = true;
            this.rdbInOrder.Text = "In-Orden";
            this.rdbInOrder.UseVisualStyleBackColor = true;
            this.rdbInOrder.CheckedChanged += new System.EventHandler(this.rdbInOrder_CheckedChanged);
            // 
            // grbNuevo
            // 
            this.grbNuevo.Controls.Add(this.btnAgregar);
            this.grbNuevo.Controls.Add(this.txtTramite);
            this.grbNuevo.Controls.Add(this.lblCodigoA);
            this.grbNuevo.Controls.Add(this.txtNombre);
            this.grbNuevo.Controls.Add(this.lblNombreA);
            this.grbNuevo.Controls.Add(this.txtCodigo);
            this.grbNuevo.Controls.Add(this.lblTramiteA);
            this.grbNuevo.Location = new System.Drawing.Point(21, 18);
            this.grbNuevo.Name = "grbNuevo";
            this.grbNuevo.Size = new System.Drawing.Size(200, 168);
            this.grbNuevo.TabIndex = 39;
            this.grbNuevo.TabStop = false;
            this.grbNuevo.Text = "Nuevo Nodo";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(6, 138);
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
            // lblCodigoA
            // 
            this.lblCodigoA.AutoSize = true;
            this.lblCodigoA.Location = new System.Drawing.Point(6, 37);
            this.lblCodigoA.Name = "lblCodigoA";
            this.lblCodigoA.Size = new System.Drawing.Size(43, 13);
            this.lblCodigoA.TabIndex = 0;
            this.lblCodigoA.Text = "Codigo:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(56, 67);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(138, 20);
            this.txtNombre.TabIndex = 4;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // lblNombreA
            // 
            this.lblNombreA.AutoSize = true;
            this.lblNombreA.Location = new System.Drawing.Point(6, 70);
            this.lblNombreA.Name = "lblNombreA";
            this.lblNombreA.Size = new System.Drawing.Size(47, 13);
            this.lblNombreA.TabIndex = 1;
            this.lblNombreA.Text = "Nombre:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(56, 34);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 3;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            // 
            // lblTramiteA
            // 
            this.lblTramiteA.AutoSize = true;
            this.lblTramiteA.Location = new System.Drawing.Point(6, 103);
            this.lblTramiteA.Name = "lblTramiteA";
            this.lblTramiteA.Size = new System.Drawing.Size(45, 13);
            this.lblTramiteA.TabIndex = 2;
            this.lblTramiteA.Text = "Tramite:";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(731, 478);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(188, 23);
            this.btnLimpiar.TabIndex = 40;
            this.btnLimpiar.Text = "Limpiar todo";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // frmArbolBinario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 523);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.grbNuevo);
            this.Controls.Add(this.grpOrden);
            this.Controls.Add(this.btnEquilibrar);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.trvArbolBinario);
            this.Controls.Add(this.grpListar);
            this.Controls.Add(this.grbEliminado);
            this.Controls.Add(this.grbBusqueda);
            this.Controls.Add(this.grbListado);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmArbolBinario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arbol Binario";
            this.Load += new System.EventHandler(this.frmArbolBinario_Load);
            this.grpListar.ResumeLayout(false);
            this.grpListar.PerformLayout();
            this.grbEliminado.ResumeLayout(false);
            this.grbEliminado.PerformLayout();
            this.grbBusqueda.ResumeLayout(false);
            this.grbBusqueda.PerformLayout();
            this.grbListado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArbolBinario)).EndInit();
            this.grpOrden.ResumeLayout(false);
            this.grpOrden.PerformLayout();
            this.grbNuevo.ResumeLayout(false);
            this.grbNuevo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpListar;
        private System.Windows.Forms.RadioButton rdbDes;
        private System.Windows.Forms.RadioButton rdbAsc;
        private System.Windows.Forms.GroupBox grbEliminado;
        private System.Windows.Forms.ComboBox cmbCodigo;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblCodigoRO;
        private System.Windows.Forms.GroupBox grbBusqueda;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtTramiteBUS;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtNombreBUS;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtCodigoBUS;
        private System.Windows.Forms.Label lblTramite;
        private System.Windows.Forms.GroupBox grbListado;
        private System.Windows.Forms.DataGridView dgvArbolBinario;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTramite;
        private System.Windows.Forms.TreeView trvArbolBinario;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Button btnEquilibrar;
        private System.Windows.Forms.GroupBox grpOrden;
        private System.Windows.Forms.RadioButton rdbPostOrder;
        private System.Windows.Forms.RadioButton rdbPreOrder;
        private System.Windows.Forms.RadioButton rdbInOrder;
        private System.Windows.Forms.ListBox lstArbolBinario;
        private System.Windows.Forms.GroupBox grbNuevo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtTramite;
        private System.Windows.Forms.Label lblCodigoA;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombreA;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblTramiteA;
        private System.Windows.Forms.Button btnLimpiar;
    }
}