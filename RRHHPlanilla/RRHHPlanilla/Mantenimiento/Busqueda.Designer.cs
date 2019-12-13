namespace RRHHPlanilla
{
    partial class Busquedas
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
            System.Windows.Forms.Label cargoIdLabel;
            this.cargoIdComboBox = new System.Windows.Forms.ComboBox();
            this.listaCargosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cargosBLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.piccerrar = new System.Windows.Forms.PictureBox();
            this.listaTrabajadoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            cargoIdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listaCargosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cargosBLBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piccerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaTrabajadoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cargoIdLabel
            // 
            cargoIdLabel.AutoSize = true;
            cargoIdLabel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cargoIdLabel.Location = new System.Drawing.Point(692, 60);
            cargoIdLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            cargoIdLabel.Name = "cargoIdLabel";
            cargoIdLabel.Size = new System.Drawing.Size(55, 17);
            cargoIdLabel.TabIndex = 47;
            cargoIdLabel.Text = "Cargo:";
            // 
            // cargoIdComboBox
            // 
            this.cargoIdComboBox.DataSource = this.listaCargosBindingSource;
            this.cargoIdComboBox.DisplayMember = "Descripcion";
            this.cargoIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cargoIdComboBox.FormattingEnabled = true;
            this.cargoIdComboBox.Location = new System.Drawing.Point(753, 60);
            this.cargoIdComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cargoIdComboBox.Name = "cargoIdComboBox";
            this.cargoIdComboBox.Size = new System.Drawing.Size(130, 21);
            this.cargoIdComboBox.TabIndex = 48;
            this.cargoIdComboBox.ValueMember = "Id";
            this.cargoIdComboBox.SelectedIndexChanged += new System.EventHandler(this.cargoIdComboBox_SelectedIndexChanged);
            // 
            // listaCargosBindingSource
            // 
            this.listaCargosBindingSource.DataMember = "ListaCargos";
            this.listaCargosBindingSource.DataSource = this.cargosBLBindingSource;
            // 
            // cargosBLBindingSource
            // 
            this.cargosBLBindingSource.DataSource = typeof(RRHH.BL.CargosBL);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(224, 59);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(453, 20);
            this.textBox4.TabIndex = 46;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label4.Location = new System.Drawing.Point(38, 53);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 24);
            this.label4.TabIndex = 45;
            this.label4.Text = "Buscar Empleado:";
            // 
            // piccerrar
            // 
            this.piccerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.piccerrar.BackColor = System.Drawing.Color.Transparent;
            this.piccerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.piccerrar.Image = global::RRHHPlanilla.Properties.Resources.close;
            this.piccerrar.Location = new System.Drawing.Point(1341, 1);
            this.piccerrar.Name = "piccerrar";
            this.piccerrar.Size = new System.Drawing.Size(40, 36);
            this.piccerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.piccerrar.TabIndex = 51;
            this.piccerrar.TabStop = false;
            this.piccerrar.Click += new System.EventHandler(this.piccerrar_Click);
            // 
            // listaTrabajadoresBindingSource
            // 
            this.listaTrabajadoresBindingSource.DataSource = typeof(RRHH.BL.Trabajador);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(42, 96);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(954, 344);
            this.dataGridView1.TabIndex = 53;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(902, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 41);
            this.button1.TabIndex = 52;
            this.button1.Text = "Reiniciar Lista";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Busquedas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1040, 572);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.piccerrar);
            this.Controls.Add(cargoIdLabel);
            this.Controls.Add(this.cargoIdComboBox);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Busquedas";
            this.Text = "Busqueda";
            this.Load += new System.EventHandler(this.Busquedas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listaCargosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cargosBLBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piccerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaTrabajadoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cargoIdComboBox;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource cargosBLBindingSource;
        private System.Windows.Forms.BindingSource listaCargosBindingSource;
        private System.Windows.Forms.PictureBox piccerrar;
        private System.Windows.Forms.BindingSource listaTrabajadoresBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
    }
}