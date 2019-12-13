namespace RRHHPlanilla.Transacciones.Horas_Extras
{
    partial class ResultadoHoras
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
            this.piccerrar = new System.Windows.Forms.PictureBox();
            this.listaHoraExtrasDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.listaVacacionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listaHoraExtrasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listaAnticiposBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vacacionesBLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listaTrabajadoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listaCargosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listaEstadoCivilesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listaMetodoPagosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listaJornadasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listaSexosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listaExTrabajadoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.piccerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaHoraExtrasDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaVacacionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaHoraExtrasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaAnticiposBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacacionesBLBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaTrabajadoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaCargosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaEstadoCivilesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaMetodoPagosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaJornadasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaSexosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaExTrabajadoresBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // piccerrar
            // 
            this.piccerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.piccerrar.BackColor = System.Drawing.Color.Transparent;
            this.piccerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.piccerrar.Image = global::RRHHPlanilla.Properties.Resources.close;
            this.piccerrar.Location = new System.Drawing.Point(461, 11);
            this.piccerrar.Name = "piccerrar";
            this.piccerrar.Size = new System.Drawing.Size(33, 34);
            this.piccerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.piccerrar.TabIndex = 45;
            this.piccerrar.TabStop = false;
            this.piccerrar.Click += new System.EventHandler(this.piccerrar_Click);
            // 
            // listaHoraExtrasDataGridView
            // 
            this.listaHoraExtrasDataGridView.AutoGenerateColumns = false;
            this.listaHoraExtrasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaHoraExtrasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Nombre,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.listaHoraExtrasDataGridView.DataSource = this.listaHoraExtrasBindingSource;
            this.listaHoraExtrasDataGridView.Location = new System.Drawing.Point(9, 75);
            this.listaHoraExtrasDataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listaHoraExtrasDataGridView.Name = "listaHoraExtrasDataGridView";
            this.listaHoraExtrasDataGridView.RowTemplate.Height = 24;
            this.listaHoraExtrasDataGridView.Size = new System.Drawing.Size(484, 243);
            this.listaHoraExtrasDataGridView.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(160, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 46);
            this.label1.TabIndex = 46;
            this.label1.Text = "Sistema de Control \r\n     Horas Extras";
            // 
            // listaVacacionesBindingSource
            // 
            this.listaVacacionesBindingSource.DataMember = "ListaVacaciones";
            this.listaVacacionesBindingSource.DataSource = this.vacacionesBLBindingSource;
            // 
            // listaHoraExtrasBindingSource
            // 
            this.listaHoraExtrasBindingSource.DataSource = typeof(RRHH.BL.HoraExtra);
            // 
            // listaAnticiposBindingSource
            // 
            this.listaAnticiposBindingSource.DataSource = typeof(RRHH.BL.Anticipo);
            // 
            // vacacionesBLBindingSource
            // 
            this.vacacionesBLBindingSource.DataSource = typeof(RRHH.BL.VacacionesBL);
            // 
            // listaTrabajadoresBindingSource
            // 
            this.listaTrabajadoresBindingSource.DataSource = typeof(RRHH.BL.Trabajador);
            // 
            // listaCargosBindingSource
            // 
            this.listaCargosBindingSource.DataSource = typeof(RRHH.BL.Cargo);
            // 
            // listaEstadoCivilesBindingSource
            // 
            this.listaEstadoCivilesBindingSource.DataSource = typeof(RRHH.BL.EstadoCivil);
            // 
            // listaMetodoPagosBindingSource
            // 
            this.listaMetodoPagosBindingSource.DataSource = typeof(RRHH.BL.MetodoPago);
            // 
            // listaJornadasBindingSource
            // 
            this.listaJornadasBindingSource.DataSource = typeof(RRHH.BL.Jornada);
            // 
            // listaSexosBindingSource
            // 
            this.listaSexosBindingSource.DataSource = typeof(RRHH.BL.Sexo);
            // 
            // listaExTrabajadoresBindingSource
            // 
            this.listaExTrabajadoresBindingSource.DataSource = typeof(RRHH.BL.ExTrabajador);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Cantidad";
            this.dataGridViewTextBoxColumn2.HeaderText = "Cantidad";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Fecha";
            this.dataGridViewTextBoxColumn3.HeaderText = "Fecha";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Pago";
            this.dataGridViewTextBoxColumn4.HeaderText = "Pago";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // ResultadoHoras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 328);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listaHoraExtrasDataGridView);
            this.Controls.Add(this.piccerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ResultadoHoras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ResultadoHoras";
            this.Load += new System.EventHandler(this.ResultadoHoras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.piccerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaHoraExtrasDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaVacacionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaHoraExtrasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaAnticiposBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacacionesBLBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaTrabajadoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaCargosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaEstadoCivilesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaMetodoPagosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaJornadasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaSexosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaExTrabajadoresBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox piccerrar;
        private System.Windows.Forms.BindingSource listaHoraExtrasBindingSource;
        private System.Windows.Forms.DataGridView listaHoraExtrasDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource listaAnticiposBindingSource;
        private System.Windows.Forms.BindingSource vacacionesBLBindingSource;
        private System.Windows.Forms.BindingSource listaVacacionesBindingSource;
        private System.Windows.Forms.BindingSource listaTrabajadoresBindingSource;
        private System.Windows.Forms.BindingSource listaCargosBindingSource;
        private System.Windows.Forms.BindingSource listaEstadoCivilesBindingSource;
        private System.Windows.Forms.BindingSource listaMetodoPagosBindingSource;
        private System.Windows.Forms.BindingSource listaJornadasBindingSource;
        private System.Windows.Forms.BindingSource listaSexosBindingSource;
        private System.Windows.Forms.BindingSource listaExTrabajadoresBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}