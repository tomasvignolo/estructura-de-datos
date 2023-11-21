namespace pryVignoloTp1
{
    partial class frmConsultaCombo
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
            this.cboOperaciones = new System.Windows.Forms.ComboBox();
            this.btnListar = new System.Windows.Forms.Button();
            this.lblOperacion = new System.Windows.Forms.Label();
            this.dgvSQL = new System.Windows.Forms.DataGridView();
            this.txtRepaso = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSQL)).BeginInit();
            this.SuspendLayout();
            // 
            // cboOperaciones
            // 
            this.cboOperaciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOperaciones.FormattingEnabled = true;
            this.cboOperaciones.Items.AddRange(new object[] {
            "Diferencia",
            "Intersección",
            "Juntar",
            "Proyección simple",
            "Proyección Multiatributo",
            "Proyección Multiatributo con operador AND",
            "Proyección Multiatributo con operador OR",
            "Selección Multiatributo por convolución",
            "Selección Simple",
            "Unión"});
            this.cboOperaciones.Location = new System.Drawing.Point(234, 33);
            this.cboOperaciones.Name = "cboOperaciones";
            this.cboOperaciones.Size = new System.Drawing.Size(429, 21);
            this.cboOperaciones.TabIndex = 0;
            this.cboOperaciones.SelectedIndexChanged += new System.EventHandler(this.cboOperaciones_SelectedIndexChanged);
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(559, 71);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(104, 21);
            this.btnListar.TabIndex = 1;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // lblOperacion
            // 
            this.lblOperacion.AutoSize = true;
            this.lblOperacion.Location = new System.Drawing.Point(28, 36);
            this.lblOperacion.Name = "lblOperacion";
            this.lblOperacion.Size = new System.Drawing.Size(200, 13);
            this.lblOperacion.TabIndex = 2;
            this.lblOperacion.Text = "Operación a realizar en la base de datos:";
            // 
            // dgvSQL
            // 
            this.dgvSQL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSQL.Location = new System.Drawing.Point(36, 247);
            this.dgvSQL.Name = "dgvSQL";
            this.dgvSQL.Size = new System.Drawing.Size(627, 268);
            this.dgvSQL.TabIndex = 3;
            // 
            // txtRepaso
            // 
            this.txtRepaso.Location = new System.Drawing.Point(35, 109);
            this.txtRepaso.Multiline = true;
            this.txtRepaso.Name = "txtRepaso";
            this.txtRepaso.Size = new System.Drawing.Size(627, 121);
            this.txtRepaso.TabIndex = 4;
            // 
            // frmConsultaCombo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 527);
            this.Controls.Add(this.txtRepaso);
            this.Controls.Add(this.dgvSQL);
            this.Controls.Add(this.lblOperacion);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.cboOperaciones);
            this.Name = "frmConsultaCombo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Repaso de operaciones en la base de datos:";
            this.Load += new System.EventHandler(this.frmConsultaCombo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSQL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboOperaciones;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Label lblOperacion;
        private System.Windows.Forms.DataGridView dgvSQL;
        private System.Windows.Forms.TextBox txtRepaso;
    }
}