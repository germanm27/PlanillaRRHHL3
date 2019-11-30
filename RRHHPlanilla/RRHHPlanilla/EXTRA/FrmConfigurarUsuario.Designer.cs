namespace RRHHPlanilla
{
    partial class FrmConfirmarConf
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConfirmarConf));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboprivil = new System.Windows.Forms.ComboBox();
            this.listaSeguridadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listaPrivilegiosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblhora = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.fotoPictureBox = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listaSeguridadBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.listaSeguridadBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripButton();
            this.apellidoTextBox = new System.Windows.Forms.TextBox();
            this.cedulaTextBox = new System.Windows.Forms.TextBox();
            this.contrasenaTextBox = new System.Windows.Forms.TextBox();
            this.correoTextBox = new System.Windows.Forms.TextBox();
            this.edadTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.nombUsuarioTextBox = new System.Windows.Forms.TextBox();
            this.txtconfirmar = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtnueva = new System.Windows.Forms.TextBox();
            this.lblcontrasena = new System.Windows.Forms.Label();
            this.lblcamb = new System.Windows.Forms.LinkLabel();
            this.lblcamb1 = new System.Windows.Forms.LinkLabel();
            this.lblcamb2 = new System.Windows.Forms.LinkLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.listaSeguridadDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label12 = new System.Windows.Forms.Label();
            this.fechaInicioDateTimePicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaSeguridadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaPrivilegiosBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaSeguridadBindingNavigator)).BeginInit();
            this.listaSeguridadBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaSeguridadDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::RRHHPlanilla.Properties.Resources.salir;
            this.pictureBox1.Location = new System.Drawing.Point(1158, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // comboprivil
            // 
            this.comboprivil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboprivil.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.listaSeguridadBindingSource, "PrivilegioId", true));
            this.comboprivil.DataSource = this.listaPrivilegiosBindingSource;
            this.comboprivil.DisplayMember = "Descripcion";
            this.comboprivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboprivil.FormattingEnabled = true;
            this.comboprivil.Location = new System.Drawing.Point(589, 486);
            this.comboprivil.Name = "comboprivil";
            this.comboprivil.Size = new System.Drawing.Size(121, 21);
            this.comboprivil.TabIndex = 10;
            this.comboprivil.ValueMember = "Id";
            // 
            // listaSeguridadBindingSource
            // 
            this.listaSeguridadBindingSource.DataSource = typeof(RRHH.BL.Usuario);
            // 
            // listaPrivilegiosBindingSource
            // 
            this.listaPrivilegiosBindingSource.DataSource = typeof(RRHH.BL.Privilegio);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(383, 485);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 18);
            this.label3.TabIndex = 62;
            this.label3.Text = "Privilegio:";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(383, 167);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(139, 18);
            this.label9.TabIndex = 61;
            this.label9.Text = "Nombre de Usuario:";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(383, 449);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 18);
            this.label8.TabIndex = 60;
            this.label8.Text = "Cedula:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(383, 415);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 18);
            this.label7.TabIndex = 59;
            this.label7.Text = "Edad:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(383, 383);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 18);
            this.label6.TabIndex = 58;
            this.label6.Text = "Correo:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(383, 344);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 18);
            this.label5.TabIndex = 57;
            this.label5.Text = "Confirmación de Contraseña:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(383, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 18);
            this.label4.TabIndex = 56;
            this.label4.Text = "Nueva Contraseña:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(383, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 18);
            this.label2.TabIndex = 55;
            this.label2.Text = "Apellido:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(383, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 18);
            this.label1.TabIndex = 54;
            this.label1.Text = "Nombre:";
            // 
            // lblhora
            // 
            this.lblhora.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblhora.AutoSize = true;
            this.lblhora.BackColor = System.Drawing.Color.Transparent;
            this.lblhora.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhora.ForeColor = System.Drawing.Color.Black;
            this.lblhora.Location = new System.Drawing.Point(116, 48);
            this.lblhora.Name = "lblhora";
            this.lblhora.Size = new System.Drawing.Size(518, 49);
            this.lblhora.TabIndex = 53;
            this.lblhora.Text = "Configuración de Usuario";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(83, 124);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(158, 18);
            this.label10.TabIndex = 74;
            this.label10.Text = "Seleccionar Usuario";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.fotoPictureBox);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(862, 107);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(228, 255);
            this.groupBox2.TabIndex = 75;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "FOTO";
            // 
            // fotoPictureBox
            // 
            this.fotoPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.listaSeguridadBindingSource, "Foto", true));
            this.fotoPictureBox.ErrorImage = null;
            this.fotoPictureBox.Image = global::RRHHPlanilla.Properties.Resources.male_close_up_silhouette_with_tie1;
            this.fotoPictureBox.Location = new System.Drawing.Point(20, 27);
            this.fotoPictureBox.Name = "fotoPictureBox";
            this.fotoPictureBox.Size = new System.Drawing.Size(190, 173);
            this.fotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.fotoPictureBox.TabIndex = 101;
            this.fotoPictureBox.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(120, 209);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(69, 23);
            this.button2.TabIndex = 41;
            this.button2.Text = "Remover Foto";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(35, 209);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 23);
            this.button1.TabIndex = 40;
            this.button1.Text = "Agregar Foto";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listaSeguridadBindingNavigator
            // 
            this.listaSeguridadBindingNavigator.AddNewItem = null;
            this.listaSeguridadBindingNavigator.BindingSource = this.listaSeguridadBindingSource;
            this.listaSeguridadBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.listaSeguridadBindingNavigator.DeleteItem = null;
            this.listaSeguridadBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.listaSeguridadBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.listaSeguridadBindingNavigatorSaveItem,
            this.toolStripSeparator1,
            this.toolStripLabel1});
            this.listaSeguridadBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.listaSeguridadBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.listaSeguridadBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.listaSeguridadBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.listaSeguridadBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.listaSeguridadBindingNavigator.Name = "listaSeguridadBindingNavigator";
            this.listaSeguridadBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.listaSeguridadBindingNavigator.Size = new System.Drawing.Size(343, 25);
            this.listaSeguridadBindingNavigator.TabIndex = 76;
            this.listaSeguridadBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // listaSeguridadBindingNavigatorSaveItem
            // 
            this.listaSeguridadBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.listaSeguridadBindingNavigatorSaveItem.Enabled = false;
            this.listaSeguridadBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("listaSeguridadBindingNavigatorSaveItem.Image")));
            this.listaSeguridadBindingNavigatorSaveItem.Name = "listaSeguridadBindingNavigatorSaveItem";
            this.listaSeguridadBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.listaSeguridadBindingNavigatorSaveItem.Text = "Guardar datos";
            this.listaSeguridadBindingNavigatorSaveItem.Click += new System.EventHandler(this.listaSeguridadBindingNavigatorSaveItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripLabel1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLabel1.Image")));
            this.toolStripLabel1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(57, 22);
            this.toolStripLabel1.Text = "Cancelar";
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // apellidoTextBox
            // 
            this.apellidoTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.apellidoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaSeguridadBindingSource, "Apellido", true));
            this.apellidoTextBox.Location = new System.Drawing.Point(589, 233);
            this.apellidoTextBox.Name = "apellidoTextBox";
            this.apellidoTextBox.Size = new System.Drawing.Size(164, 20);
            this.apellidoTextBox.TabIndex = 3;
            // 
            // cedulaTextBox
            // 
            this.cedulaTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cedulaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaSeguridadBindingSource, "Cedula", true));
            this.cedulaTextBox.Location = new System.Drawing.Point(589, 453);
            this.cedulaTextBox.Name = "cedulaTextBox";
            this.cedulaTextBox.Size = new System.Drawing.Size(164, 20);
            this.cedulaTextBox.TabIndex = 9;
            // 
            // contrasenaTextBox
            // 
            this.contrasenaTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.contrasenaTextBox.BackColor = System.Drawing.Color.Silver;
            this.contrasenaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaSeguridadBindingSource, "Contrasena", true));
            this.contrasenaTextBox.Location = new System.Drawing.Point(589, 263);
            this.contrasenaTextBox.Name = "contrasenaTextBox";
            this.contrasenaTextBox.ReadOnly = true;
            this.contrasenaTextBox.Size = new System.Drawing.Size(164, 20);
            this.contrasenaTextBox.TabIndex = 4;
            this.contrasenaTextBox.UseSystemPasswordChar = true;
            this.contrasenaTextBox.TextChanged += new System.EventHandler(this.contrasenaTextBox_TextChanged);
            this.contrasenaTextBox.Leave += new System.EventHandler(this.contrasenaTextBox_Leave);
            // 
            // correoTextBox
            // 
            this.correoTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.correoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaSeguridadBindingSource, "Correo", true));
            this.correoTextBox.Location = new System.Drawing.Point(589, 387);
            this.correoTextBox.Name = "correoTextBox";
            this.correoTextBox.Size = new System.Drawing.Size(164, 20);
            this.correoTextBox.TabIndex = 7;
            // 
            // edadTextBox
            // 
            this.edadTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.edadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaSeguridadBindingSource, "edad", true));
            this.edadTextBox.Location = new System.Drawing.Point(589, 419);
            this.edadTextBox.Name = "edadTextBox";
            this.edadTextBox.Size = new System.Drawing.Size(164, 20);
            this.edadTextBox.TabIndex = 8;
            // 
            // idTextBox
            // 
            this.idTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaSeguridadBindingSource, "Id", true));
            this.idTextBox.Enabled = false;
            this.idTextBox.Location = new System.Drawing.Point(589, 141);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(164, 20);
            this.idTextBox.TabIndex = 87;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaSeguridadBindingSource, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(589, 202);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(164, 20);
            this.nombreTextBox.TabIndex = 2;
            // 
            // nombUsuarioTextBox
            // 
            this.nombUsuarioTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nombUsuarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaSeguridadBindingSource, "NombUsuario", true));
            this.nombUsuarioTextBox.Location = new System.Drawing.Point(589, 171);
            this.nombUsuarioTextBox.Name = "nombUsuarioTextBox";
            this.nombUsuarioTextBox.Size = new System.Drawing.Size(164, 20);
            this.nombUsuarioTextBox.TabIndex = 1;
            // 
            // txtconfirmar
            // 
            this.txtconfirmar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtconfirmar.Location = new System.Drawing.Point(589, 345);
            this.txtconfirmar.Name = "txtconfirmar";
            this.txtconfirmar.Size = new System.Drawing.Size(164, 20);
            this.txtconfirmar.TabIndex = 6;
            this.txtconfirmar.UseSystemPasswordChar = true;
            this.txtconfirmar.TextChanged += new System.EventHandler(this.txtconfirmar_TextChanged);
            this.txtconfirmar.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(383, 140);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(22, 18);
            this.label11.TabIndex = 93;
            this.label11.Text = "Id";
            // 
            // txtnueva
            // 
            this.txtnueva.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtnueva.Location = new System.Drawing.Point(589, 305);
            this.txtnueva.Name = "txtnueva";
            this.txtnueva.Size = new System.Drawing.Size(164, 20);
            this.txtnueva.TabIndex = 5;
            this.txtnueva.UseSystemPasswordChar = true;
            this.txtnueva.TextChanged += new System.EventHandler(this.txtnueva_TextChanged);
            this.txtnueva.Leave += new System.EventHandler(this.txtnueva_Leave);
            // 
            // lblcontrasena
            // 
            this.lblcontrasena.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblcontrasena.AutoSize = true;
            this.lblcontrasena.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcontrasena.Location = new System.Drawing.Point(383, 262);
            this.lblcontrasena.Name = "lblcontrasena";
            this.lblcontrasena.Size = new System.Drawing.Size(140, 18);
            this.lblcontrasena.TabIndex = 96;
            this.lblcontrasena.Text = "Antigua Contraseña:";
            // 
            // lblcamb
            // 
            this.lblcamb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblcamb.AutoSize = true;
            this.lblcamb.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcamb.LinkColor = System.Drawing.Color.Red;
            this.lblcamb.Location = new System.Drawing.Point(590, 285);
            this.lblcamb.Name = "lblcamb";
            this.lblcamb.Size = new System.Drawing.Size(49, 12);
            this.lblcamb.TabIndex = 98;
            this.lblcamb.TabStop = true;
            this.lblcamb.Text = "linkLabel1";
            this.lblcamb.Visible = false;
            // 
            // lblcamb1
            // 
            this.lblcamb1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblcamb1.AutoSize = true;
            this.lblcamb1.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcamb1.LinkColor = System.Drawing.Color.Red;
            this.lblcamb1.Location = new System.Drawing.Point(590, 327);
            this.lblcamb1.Name = "lblcamb1";
            this.lblcamb1.Size = new System.Drawing.Size(49, 12);
            this.lblcamb1.TabIndex = 99;
            this.lblcamb1.TabStop = true;
            this.lblcamb1.Text = "linkLabel1";
            this.lblcamb1.Visible = false;
            // 
            // lblcamb2
            // 
            this.lblcamb2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblcamb2.AutoSize = true;
            this.lblcamb2.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcamb2.LinkColor = System.Drawing.Color.Red;
            this.lblcamb2.Location = new System.Drawing.Point(590, 367);
            this.lblcamb2.Name = "lblcamb2";
            this.lblcamb2.Size = new System.Drawing.Size(49, 12);
            this.lblcamb2.TabIndex = 100;
            this.lblcamb2.TabStop = true;
            this.lblcamb2.Text = "linkLabel1";
            this.lblcamb2.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::RRHHPlanilla.Properties.Resources.ojo3;
            this.pictureBox2.Location = new System.Drawing.Point(759, 262);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(26, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 97;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseDown);
            this.pictureBox2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseUp);
            // 
            // listaSeguridadDataGridView
            // 
            this.listaSeguridadDataGridView.AllowUserToDeleteRows = false;
            this.listaSeguridadDataGridView.AutoGenerateColumns = false;
            this.listaSeguridadDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.listaSeguridadDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaSeguridadDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn7});
            this.listaSeguridadDataGridView.DataSource = this.listaSeguridadBindingSource;
            this.listaSeguridadDataGridView.Location = new System.Drawing.Point(65, 144);
            this.listaSeguridadDataGridView.Name = "listaSeguridadDataGridView";
            this.listaSeguridadDataGridView.ReadOnly = true;
            this.listaSeguridadDataGridView.Size = new System.Drawing.Size(194, 220);
            this.listaSeguridadDataGridView.TabIndex = 100;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "NombUsuario";
            this.dataGridViewTextBoxColumn7.HeaderText = "Usuario";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(383, 523);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(111, 18);
            this.label12.TabIndex = 102;
            this.label12.Text = "Fecha de Inicio:";
            // 
            // fechaInicioDateTimePicker
            // 
            this.fechaInicioDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.listaSeguridadBindingSource, "FechaInicio", true));
            this.fechaInicioDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaInicioDateTimePicker.Location = new System.Drawing.Point(588, 523);
            this.fechaInicioDateTimePicker.Name = "fechaInicioDateTimePicker";
            this.fechaInicioDateTimePicker.Size = new System.Drawing.Size(164, 20);
            this.fechaInicioDateTimePicker.TabIndex = 103;
            // 
            // FrmConfirmarConf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(1200, 588);
            this.Controls.Add(this.fechaInicioDateTimePicker);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.listaSeguridadDataGridView);
            this.Controls.Add(this.lblcamb2);
            this.Controls.Add(this.lblcamb1);
            this.Controls.Add(this.lblcamb);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblcontrasena);
            this.Controls.Add(this.txtnueva);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtconfirmar);
            this.Controls.Add(this.apellidoTextBox);
            this.Controls.Add(this.cedulaTextBox);
            this.Controls.Add(this.contrasenaTextBox);
            this.Controls.Add(this.correoTextBox);
            this.Controls.Add(this.edadTextBox);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(this.nombUsuarioTextBox);
            this.Controls.Add(this.listaSeguridadBindingNavigator);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.comboprivil);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblhora);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmConfirmarConf";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmConfirmarConf";
            this.Load += new System.EventHandler(this.FrmConfirmarConf_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmConfirmarConf_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaSeguridadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaPrivilegiosBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fotoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaSeguridadBindingNavigator)).EndInit();
            this.listaSeguridadBindingNavigator.ResumeLayout(false);
            this.listaSeguridadBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaSeguridadDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboprivil;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblhora;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource listaSeguridadBindingSource;
        private System.Windows.Forms.BindingNavigator listaSeguridadBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton listaSeguridadBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox apellidoTextBox;
        private System.Windows.Forms.TextBox cedulaTextBox;
        private System.Windows.Forms.TextBox contrasenaTextBox;
        private System.Windows.Forms.TextBox correoTextBox;
        private System.Windows.Forms.TextBox edadTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox nombUsuarioTextBox;
        private System.Windows.Forms.TextBox txtconfirmar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.BindingSource listaPrivilegiosBindingSource;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtnueva;
        private System.Windows.Forms.Label lblcontrasena;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.LinkLabel lblcamb;
        private System.Windows.Forms.LinkLabel lblcamb1;
        private System.Windows.Forms.LinkLabel lblcamb2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.PictureBox fotoPictureBox;
        private System.Windows.Forms.DataGridView listaSeguridadDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.ToolStripButton toolStripLabel1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker fechaInicioDateTimePicker;
    }
}