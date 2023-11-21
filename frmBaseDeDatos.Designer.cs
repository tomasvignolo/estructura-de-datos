namespace pryVignoloTp1
{
    partial class frmBaseDeDatos
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnDiferencia = new System.Windows.Forms.Button();
            this.btnIntersección = new System.Windows.Forms.Button();
            this.btnUnion = new System.Windows.Forms.Button();
            this.grpSelección = new System.Windows.Forms.GroupBox();
            this.btnSeleccConv = new System.Windows.Forms.Button();
            this.btnSeleccionMult = new System.Windows.Forms.Button();
            this.btnSeleccionSimple = new System.Windows.Forms.Button();
            this.dgvSQL = new System.Windows.Forms.DataGridView();
            this.gbProyeccion = new System.Windows.Forms.GroupBox();
            this.btnJuntar = new System.Windows.Forms.Button();
            this.btnPrMult = new System.Windows.Forms.Button();
            this.btnPrSimple = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.grpSelección.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSQL)).BeginInit();
            this.gbProyeccion.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnDiferencia);
            this.groupBox3.Controls.Add(this.btnIntersección);
            this.groupBox3.Controls.Add(this.btnUnion);
            this.groupBox3.Location = new System.Drawing.Point(634, 376);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(225, 115);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Operaciones en BDD";
            // 
            // btnDiferencia
            // 
            this.btnDiferencia.Location = new System.Drawing.Point(6, 80);
            this.btnDiferencia.Name = "btnDiferencia";
            this.btnDiferencia.Size = new System.Drawing.Size(202, 21);
            this.btnDiferencia.TabIndex = 3;
            this.btnDiferencia.Text = "Diferencia";
            this.btnDiferencia.UseVisualStyleBackColor = true;
            this.btnDiferencia.Click += new System.EventHandler(this.btnDiferencia_Click);
            // 
            // btnIntersección
            // 
            this.btnIntersección.Location = new System.Drawing.Point(6, 53);
            this.btnIntersección.Name = "btnIntersección";
            this.btnIntersección.Size = new System.Drawing.Size(202, 21);
            this.btnIntersección.TabIndex = 2;
            this.btnIntersección.Text = "Intersección";
            this.btnIntersección.UseVisualStyleBackColor = true;
            this.btnIntersección.Click += new System.EventHandler(this.btnIntersección_Click);
            // 
            // btnUnion
            // 
            this.btnUnion.Location = new System.Drawing.Point(6, 26);
            this.btnUnion.Name = "btnUnion";
            this.btnUnion.Size = new System.Drawing.Size(202, 21);
            this.btnUnion.TabIndex = 1;
            this.btnUnion.Text = "Unión";
            this.btnUnion.UseVisualStyleBackColor = true;
            this.btnUnion.Click += new System.EventHandler(this.btnUnion_Click);
            // 
            // grpSelección
            // 
            this.grpSelección.Controls.Add(this.btnSeleccConv);
            this.grpSelección.Controls.Add(this.btnSeleccionMult);
            this.grpSelección.Controls.Add(this.btnSeleccionSimple);
            this.grpSelección.Location = new System.Drawing.Point(334, 376);
            this.grpSelección.Name = "grpSelección";
            this.grpSelección.Size = new System.Drawing.Size(225, 115);
            this.grpSelección.TabIndex = 9;
            this.grpSelección.TabStop = false;
            this.grpSelección.Text = "Operaciones de Selección";
            // 
            // btnSeleccConv
            // 
            this.btnSeleccConv.Location = new System.Drawing.Point(6, 80);
            this.btnSeleccConv.Name = "btnSeleccConv";
            this.btnSeleccConv.Size = new System.Drawing.Size(202, 21);
            this.btnSeleccConv.TabIndex = 3;
            this.btnSeleccConv.Text = "Selección por convolusión";
            this.btnSeleccConv.UseVisualStyleBackColor = true;
            this.btnSeleccConv.Click += new System.EventHandler(this.btnSeleccConv_Click);
            // 
            // btnSeleccionMult
            // 
            this.btnSeleccionMult.Location = new System.Drawing.Point(6, 53);
            this.btnSeleccionMult.Name = "btnSeleccionMult";
            this.btnSeleccionMult.Size = new System.Drawing.Size(202, 21);
            this.btnSeleccionMult.TabIndex = 2;
            this.btnSeleccionMult.Text = "Seleccion multiatributo";
            this.btnSeleccionMult.UseVisualStyleBackColor = true;
            this.btnSeleccionMult.Click += new System.EventHandler(this.btnSeleccionMult_Click);
            // 
            // btnSeleccionSimple
            // 
            this.btnSeleccionSimple.Location = new System.Drawing.Point(6, 26);
            this.btnSeleccionSimple.Name = "btnSeleccionSimple";
            this.btnSeleccionSimple.Size = new System.Drawing.Size(202, 21);
            this.btnSeleccionSimple.TabIndex = 1;
            this.btnSeleccionSimple.Text = "Seleccion simple";
            this.btnSeleccionSimple.UseVisualStyleBackColor = true;
            this.btnSeleccionSimple.Click += new System.EventHandler(this.btnSeleccionSimple_Click);
            // 
            // dgvSQL
            // 
            this.dgvSQL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSQL.Location = new System.Drawing.Point(31, 31);
            this.dgvSQL.Name = "dgvSQL";
            this.dgvSQL.Size = new System.Drawing.Size(828, 327);
            this.dgvSQL.TabIndex = 6;
            // 
            // gbProyeccion
            // 
            this.gbProyeccion.Controls.Add(this.btnJuntar);
            this.gbProyeccion.Controls.Add(this.btnPrMult);
            this.gbProyeccion.Controls.Add(this.btnPrSimple);
            this.gbProyeccion.Location = new System.Drawing.Point(31, 376);
            this.gbProyeccion.Name = "gbProyeccion";
            this.gbProyeccion.Size = new System.Drawing.Size(225, 115);
            this.gbProyeccion.TabIndex = 7;
            this.gbProyeccion.TabStop = false;
            this.gbProyeccion.Text = "Operaciones de Proyeccion";
            // 
            // btnJuntar
            // 
            this.btnJuntar.Location = new System.Drawing.Point(6, 80);
            this.btnJuntar.Name = "btnJuntar";
            this.btnJuntar.Size = new System.Drawing.Size(202, 21);
            this.btnJuntar.TabIndex = 3;
            this.btnJuntar.Text = "Juntar";
            this.btnJuntar.UseVisualStyleBackColor = true;
            this.btnJuntar.Click += new System.EventHandler(this.btnJuntar_Click);
            // 
            // btnPrMult
            // 
            this.btnPrMult.Location = new System.Drawing.Point(6, 53);
            this.btnPrMult.Name = "btnPrMult";
            this.btnPrMult.Size = new System.Drawing.Size(202, 21);
            this.btnPrMult.TabIndex = 2;
            this.btnPrMult.Text = "Proyeccion multiatributo";
            this.btnPrMult.UseVisualStyleBackColor = true;
            this.btnPrMult.Click += new System.EventHandler(this.btnPrMult_Click);
            // 
            // btnPrSimple
            // 
            this.btnPrSimple.Location = new System.Drawing.Point(6, 26);
            this.btnPrSimple.Name = "btnPrSimple";
            this.btnPrSimple.Size = new System.Drawing.Size(202, 21);
            this.btnPrSimple.TabIndex = 1;
            this.btnPrSimple.Text = "Proyeccion simple";
            this.btnPrSimple.UseVisualStyleBackColor = true;
            this.btnPrSimple.Click += new System.EventHandler(this.btnPrSimple_Click);
            // 
            // frmBaseDeDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 527);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.grpSelección);
            this.Controls.Add(this.dgvSQL);
            this.Controls.Add(this.gbProyeccion);
            this.Name = "frmBaseDeDatos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Base de datos";
            this.Load += new System.EventHandler(this.frmBaseDeDatos_Load);
            this.groupBox3.ResumeLayout(false);
            this.grpSelección.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSQL)).EndInit();
            this.gbProyeccion.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnDiferencia;
        private System.Windows.Forms.Button btnIntersección;
        private System.Windows.Forms.Button btnUnion;
        private System.Windows.Forms.GroupBox grpSelección;
        private System.Windows.Forms.Button btnSeleccConv;
        private System.Windows.Forms.Button btnSeleccionMult;
        private System.Windows.Forms.Button btnSeleccionSimple;
        private System.Windows.Forms.DataGridView dgvSQL;
        private System.Windows.Forms.GroupBox gbProyeccion;
        private System.Windows.Forms.Button btnJuntar;
        private System.Windows.Forms.Button btnPrMult;
        private System.Windows.Forms.Button btnPrSimple;
    }
}