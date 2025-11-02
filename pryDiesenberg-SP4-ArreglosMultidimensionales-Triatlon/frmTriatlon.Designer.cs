namespace pryDiesenberg_SP4_ArreglosMultidimensionales_Triatlon
{
    partial class frmTriatlon
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTriatlon));
            this.dgvParticipantes = new System.Windows.Forms.DataGridView();
            this.colNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblParticipantes = new System.Windows.Forms.Label();
            this.dgvPosiciones = new System.Windows.Forms.DataGridView();
            this.colPrueba = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCarlos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colJuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPedro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLuis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMarcos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiego = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblPosiciones = new System.Windows.Forms.Label();
            this.lblGanadores = new System.Windows.Forms.Label();
            this.dgvGanadores = new System.Windows.Forms.DataGridView();
            this.colPuesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPais2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPuntos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAsignar = new System.Windows.Forms.Button();
            this.btnDeterminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParticipantes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosiciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGanadores)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvParticipantes
            // 
            this.dgvParticipantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParticipantes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNumero,
            this.colNombre,
            this.colPais});
            this.dgvParticipantes.Location = new System.Drawing.Point(12, 25);
            this.dgvParticipantes.Name = "dgvParticipantes";
            this.dgvParticipantes.Size = new System.Drawing.Size(301, 155);
            this.dgvParticipantes.TabIndex = 0;
            this.dgvParticipantes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvParticipantes_CellContentClick);
            // 
            // colNumero
            // 
            this.colNumero.HeaderText = "Número";
            this.colNumero.Name = "colNumero";
            // 
            // colNombre
            // 
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.Name = "colNombre";
            // 
            // colPais
            // 
            this.colPais.HeaderText = "País";
            this.colPais.Name = "colPais";
            // 
            // lblParticipantes
            // 
            this.lblParticipantes.AutoSize = true;
            this.lblParticipantes.Location = new System.Drawing.Point(9, 9);
            this.lblParticipantes.Name = "lblParticipantes";
            this.lblParticipantes.Size = new System.Drawing.Size(68, 13);
            this.lblParticipantes.TabIndex = 1;
            this.lblParticipantes.Text = "Participantes";
            // 
            // dgvPosiciones
            // 
            this.dgvPosiciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPosiciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPrueba,
            this.colCarlos,
            this.colJuan,
            this.colPedro,
            this.colLuis,
            this.colMarcos,
            this.colDiego});
            this.dgvPosiciones.Location = new System.Drawing.Point(12, 199);
            this.dgvPosiciones.Name = "dgvPosiciones";
            this.dgvPosiciones.Size = new System.Drawing.Size(692, 103);
            this.dgvPosiciones.TabIndex = 2;
            // 
            // colPrueba
            // 
            this.colPrueba.HeaderText = "Prueba";
            this.colPrueba.Name = "colPrueba";
            // 
            // colCarlos
            // 
            this.colCarlos.HeaderText = "Carlos";
            this.colCarlos.Name = "colCarlos";
            // 
            // colJuan
            // 
            this.colJuan.HeaderText = "Juan";
            this.colJuan.Name = "colJuan";
            // 
            // colPedro
            // 
            this.colPedro.HeaderText = "Pedro";
            this.colPedro.Name = "colPedro";
            // 
            // colLuis
            // 
            this.colLuis.HeaderText = "Luis";
            this.colLuis.Name = "colLuis";
            // 
            // colMarcos
            // 
            this.colMarcos.HeaderText = "Marcos";
            this.colMarcos.Name = "colMarcos";
            // 
            // colDiego
            // 
            this.colDiego.HeaderText = "Diego";
            this.colDiego.Name = "colDiego";
            // 
            // lblPosiciones
            // 
            this.lblPosiciones.AutoSize = true;
            this.lblPosiciones.Location = new System.Drawing.Point(12, 183);
            this.lblPosiciones.Name = "lblPosiciones";
            this.lblPosiciones.Size = new System.Drawing.Size(58, 13);
            this.lblPosiciones.TabIndex = 3;
            this.lblPosiciones.Text = "Posiciones";
            // 
            // lblGanadores
            // 
            this.lblGanadores.AutoSize = true;
            this.lblGanadores.Location = new System.Drawing.Point(11, 305);
            this.lblGanadores.Name = "lblGanadores";
            this.lblGanadores.Size = new System.Drawing.Size(59, 13);
            this.lblGanadores.TabIndex = 4;
            this.lblGanadores.Text = "Ganadores";
            // 
            // dgvGanadores
            // 
            this.dgvGanadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGanadores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPuesto,
            this.colNombre2,
            this.colPais2,
            this.colPuntos});
            this.dgvGanadores.Location = new System.Drawing.Point(12, 321);
            this.dgvGanadores.Name = "dgvGanadores";
            this.dgvGanadores.Size = new System.Drawing.Size(400, 95);
            this.dgvGanadores.TabIndex = 5;
            // 
            // colPuesto
            // 
            this.colPuesto.HeaderText = "Puesto";
            this.colPuesto.Name = "colPuesto";
            // 
            // colNombre2
            // 
            this.colNombre2.HeaderText = "Nombre";
            this.colNombre2.Name = "colNombre2";
            // 
            // colPais2
            // 
            this.colPais2.HeaderText = "País";
            this.colPais2.Name = "colPais2";
            // 
            // colPuntos
            // 
            this.colPuntos.HeaderText = "Puntos";
            this.colPuntos.Name = "colPuntos";
            // 
            // btnAsignar
            // 
            this.btnAsignar.Location = new System.Drawing.Point(465, 36);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(92, 41);
            this.btnAsignar.TabIndex = 6;
            this.btnAsignar.Text = "Asignar Participantes";
            this.btnAsignar.UseVisualStyleBackColor = true;
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
            // 
            // btnDeterminar
            // 
            this.btnDeterminar.Location = new System.Drawing.Point(612, 36);
            this.btnDeterminar.Name = "btnDeterminar";
            this.btnDeterminar.Size = new System.Drawing.Size(92, 41);
            this.btnDeterminar.TabIndex = 7;
            this.btnDeterminar.Text = "Determinar Ganadores";
            this.btnDeterminar.UseVisualStyleBackColor = true;
            this.btnDeterminar.Click += new System.EventHandler(this.btnDeterminar_Click);
            // 
            // frmTriatlon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 428);
            this.Controls.Add(this.btnDeterminar);
            this.Controls.Add(this.btnAsignar);
            this.Controls.Add(this.dgvGanadores);
            this.Controls.Add(this.lblGanadores);
            this.Controls.Add(this.lblPosiciones);
            this.Controls.Add(this.dgvPosiciones);
            this.Controls.Add(this.lblParticipantes);
            this.Controls.Add(this.dgvParticipantes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTriatlon";
            this.Text = "Triatlón";
            this.Load += new System.EventHandler(this.frmTriatlon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvParticipantes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosiciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGanadores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvParticipantes;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPais;
        private System.Windows.Forms.Label lblParticipantes;
        private System.Windows.Forms.DataGridView dgvPosiciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrueba;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCarlos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colJuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPedro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLuis;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMarcos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiego;
        private System.Windows.Forms.Label lblPosiciones;
        private System.Windows.Forms.Label lblGanadores;
        private System.Windows.Forms.DataGridView dgvGanadores;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPais2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPuntos;
        private System.Windows.Forms.Button btnAsignar;
        private System.Windows.Forms.Button btnDeterminar;
    }
}

