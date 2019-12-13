namespace Snake
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.lbContinuar = new System.Windows.Forms.Label();
            this.lbPausar = new System.Windows.Forms.Label();
            this.lbReglas = new System.Windows.Forms.Label();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.A10 = new System.Windows.Forms.Label();
            this.A9 = new System.Windows.Forms.Label();
            this.A8 = new System.Windows.Forms.Label();
            this.A7 = new System.Windows.Forms.Label();
            this.A6 = new System.Windows.Forms.Label();
            this.A5 = new System.Windows.Forms.Label();
            this.A4 = new System.Windows.Forms.Label();
            this.A3 = new System.Windows.Forms.Label();
            this.A2 = new System.Windows.Forms.Label();
            this.A1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SnakeLengthLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.EndGameLabel = new System.Windows.Forms.Label();
            this.BoxBorders = new System.Windows.Forms.CheckBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRegistrar = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbContinuar
            // 
            this.lbContinuar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lbContinuar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbContinuar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbContinuar.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbContinuar.ForeColor = System.Drawing.Color.White;
            this.lbContinuar.Location = new System.Drawing.Point(224, 762);
            this.lbContinuar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbContinuar.Name = "lbContinuar";
            this.lbContinuar.Size = new System.Drawing.Size(143, 63);
            this.lbContinuar.TabIndex = 37;
            this.lbContinuar.Text = "Continuar";
            this.lbContinuar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbContinuar.Click += new System.EventHandler(this.lbContinuar_Click);
            // 
            // lbPausar
            // 
            this.lbPausar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lbPausar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbPausar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbPausar.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPausar.ForeColor = System.Drawing.Color.White;
            this.lbPausar.Location = new System.Drawing.Point(85, 762);
            this.lbPausar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPausar.Name = "lbPausar";
            this.lbPausar.Size = new System.Drawing.Size(122, 63);
            this.lbPausar.TabIndex = 36;
            this.lbPausar.Text = "Pausar";
            this.lbPausar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbPausar.Click += new System.EventHandler(this.lbPausar_Click);
            // 
            // lbReglas
            // 
            this.lbReglas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lbReglas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbReglas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbReglas.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbReglas.ForeColor = System.Drawing.Color.White;
            this.lbReglas.Location = new System.Drawing.Point(540, 762);
            this.lbReglas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbReglas.Name = "lbReglas";
            this.lbReglas.Size = new System.Drawing.Size(183, 63);
            this.lbReglas.TabIndex = 35;
            this.lbReglas.Text = "Reglas";
            this.lbReglas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbReglas.Click += new System.EventHandler(this.lbReglas_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.BackColor = System.Drawing.Color.Black;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(13, 13);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(40, 37);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 60;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackColor = System.Drawing.Color.Black;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(724, 13);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(40, 37);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 59;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Lime;
            this.label5.Location = new System.Drawing.Point(441, 1103);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(289, 69);
            this.label5.TabIndex = 58;
            this.label5.Text = "Snake 98";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(383, 762);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 63);
            this.label4.TabIndex = 31;
            this.label4.Text = "Reiniciar";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // A10
            // 
            this.A10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.A10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A10.ForeColor = System.Drawing.Color.Red;
            this.A10.Location = new System.Drawing.Point(208, 86);
            this.A10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.A10.Name = "A10";
            this.A10.Size = new System.Drawing.Size(35, 28);
            this.A10.TabIndex = 54;
            this.A10.Text = "10";
            this.A10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.A10.Click += new System.EventHandler(this.A10_Click);
            // 
            // A9
            // 
            this.A9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.A9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A9.ForeColor = System.Drawing.Color.Red;
            this.A9.Location = new System.Drawing.Point(172, 86);
            this.A9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.A9.Name = "A9";
            this.A9.Size = new System.Drawing.Size(35, 28);
            this.A9.TabIndex = 53;
            this.A9.Text = "9";
            this.A9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.A9.Click += new System.EventHandler(this.A9_Click);
            // 
            // A8
            // 
            this.A8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.A8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A8.ForeColor = System.Drawing.Color.Red;
            this.A8.Location = new System.Drawing.Point(136, 86);
            this.A8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.A8.Name = "A8";
            this.A8.Size = new System.Drawing.Size(35, 28);
            this.A8.TabIndex = 52;
            this.A8.Text = "8";
            this.A8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.A8.Click += new System.EventHandler(this.A8_Click);
            // 
            // A7
            // 
            this.A7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.A7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A7.ForeColor = System.Drawing.Color.Red;
            this.A7.Location = new System.Drawing.Point(100, 86);
            this.A7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.A7.Name = "A7";
            this.A7.Size = new System.Drawing.Size(35, 28);
            this.A7.TabIndex = 51;
            this.A7.Text = "7";
            this.A7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.A7.Click += new System.EventHandler(this.A7_Click);
            // 
            // A6
            // 
            this.A6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.A6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A6.ForeColor = System.Drawing.Color.Red;
            this.A6.Location = new System.Drawing.Point(64, 86);
            this.A6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.A6.Name = "A6";
            this.A6.Size = new System.Drawing.Size(35, 28);
            this.A6.TabIndex = 50;
            this.A6.Text = "6";
            this.A6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.A6.Click += new System.EventHandler(this.A6_Click);
            // 
            // A5
            // 
            this.A5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.A5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A5.ForeColor = System.Drawing.Color.Red;
            this.A5.Location = new System.Drawing.Point(208, 57);
            this.A5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.A5.Name = "A5";
            this.A5.Size = new System.Drawing.Size(35, 28);
            this.A5.TabIndex = 49;
            this.A5.Text = "5";
            this.A5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.A5.Click += new System.EventHandler(this.A5_Click);
            // 
            // A4
            // 
            this.A4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.A4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A4.ForeColor = System.Drawing.Color.Red;
            this.A4.Location = new System.Drawing.Point(172, 57);
            this.A4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.A4.Name = "A4";
            this.A4.Size = new System.Drawing.Size(35, 28);
            this.A4.TabIndex = 48;
            this.A4.Text = "4";
            this.A4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.A4.Click += new System.EventHandler(this.A4_Click);
            // 
            // A3
            // 
            this.A3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.A3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A3.ForeColor = System.Drawing.Color.Red;
            this.A3.Location = new System.Drawing.Point(136, 57);
            this.A3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.A3.Name = "A3";
            this.A3.Size = new System.Drawing.Size(35, 28);
            this.A3.TabIndex = 47;
            this.A3.Text = "3";
            this.A3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.A3.Click += new System.EventHandler(this.A3_Click);
            // 
            // A2
            // 
            this.A2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.A2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A2.ForeColor = System.Drawing.Color.Red;
            this.A2.Location = new System.Drawing.Point(100, 57);
            this.A2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.A2.Name = "A2";
            this.A2.Size = new System.Drawing.Size(35, 28);
            this.A2.TabIndex = 46;
            this.A2.Text = "2";
            this.A2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.A2.Click += new System.EventHandler(this.A2_Click);
            // 
            // A1
            // 
            this.A1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.A1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A1.ForeColor = System.Drawing.Color.Lime;
            this.A1.Location = new System.Drawing.Point(64, 57);
            this.A1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.A1.Name = "A1";
            this.A1.Size = new System.Drawing.Size(35, 28);
            this.A1.TabIndex = 45;
            this.A1.Text = "1";
            this.A1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.A1.Click += new System.EventHandler(this.A1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(64, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 29);
            this.label2.TabIndex = 17;
            this.label2.Text = "CANTIDAD DE COMIDA:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(491, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 29);
            this.label1.TabIndex = 43;
            this.label1.Text = "PUNTUACIÓN:";
            // 
            // SnakeLengthLabel
            // 
            this.SnakeLengthLabel.BackColor = System.Drawing.Color.Transparent;
            this.SnakeLengthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SnakeLengthLabel.ForeColor = System.Drawing.Color.Lime;
            this.SnakeLengthLabel.Location = new System.Drawing.Point(517, 48);
            this.SnakeLengthLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SnakeLengthLabel.Name = "SnakeLengthLabel";
            this.SnakeLengthLabel.Size = new System.Drawing.Size(108, 69);
            this.SnakeLengthLabel.TabIndex = 14;
            this.SnakeLengthLabel.Text = "1";
            this.SnakeLengthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Yellow;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.Red;
            this.panel1.Location = new System.Drawing.Point(64, 121);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(645, 596);
            this.panel1.TabIndex = 3;
            // 
            // EndGameLabel
            // 
            this.EndGameLabel.BackColor = System.Drawing.Color.Black;
            this.EndGameLabel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndGameLabel.ForeColor = System.Drawing.Color.Red;
            this.EndGameLabel.Location = new System.Drawing.Point(201, 276);
            this.EndGameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EndGameLabel.Name = "EndGameLabel";
            this.EndGameLabel.Size = new System.Drawing.Size(331, 210);
            this.EndGameLabel.TabIndex = 40;
            this.EndGameLabel.Text = "PERDISTE! \r\n\r\nLa serpiente se estrello\r\n\r\nClick Aquí para jugar de nuevo :3\r\n";
            this.EndGameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EndGameLabel.Visible = false;
            this.EndGameLabel.Click += new System.EventHandler(this.EndGameLabel_Click);
            // 
            // BoxBorders
            // 
            this.BoxBorders.AutoSize = true;
            this.BoxBorders.Checked = true;
            this.BoxBorders.CheckState = System.Windows.Forms.CheckState.Checked;
            this.BoxBorders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BoxBorders.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxBorders.ForeColor = System.Drawing.Color.Black;
            this.BoxBorders.Location = new System.Drawing.Point(284, 725);
            this.BoxBorders.Margin = new System.Windows.Forms.Padding(4);
            this.BoxBorders.Name = "BoxBorders";
            this.BoxBorders.Size = new System.Drawing.Size(203, 33);
            this.BoxBorders.TabIndex = 55;
            this.BoxBorders.Text = "SALUDA A SNAKE";
            this.BoxBorders.UseVisualStyleBackColor = true;
            this.BoxBorders.Visible = false;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.DarkGreen;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Font = new System.Drawing.Font("Rockwell Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.Color.White;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 29;
            this.listBox1.Location = new System.Drawing.Point(34, 1002);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(375, 87);
            this.listBox1.TabIndex = 69;
            this.listBox1.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DarkGreen;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(360, 998);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 48);
            this.label6.TabIndex = 72;
            this.label6.Text = "Nombre del\r\n Jugador :";
            this.label6.Visible = false;
            // 
            // txtRegistrar
            // 
            this.txtRegistrar.Enabled = false;
            this.txtRegistrar.Location = new System.Drawing.Point(514, 1002);
            this.txtRegistrar.Margin = new System.Windows.Forms.Padding(4);
            this.txtRegistrar.Name = "txtRegistrar";
            this.txtRegistrar.Size = new System.Drawing.Size(235, 22);
            this.txtRegistrar.TabIndex = 70;
            this.txtRegistrar.Visible = false;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.LimeGreen;
            this.btnRegistrar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(607, 1047);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(124, 42);
            this.btnRegistrar.TabIndex = 71;
            this.btnRegistrar.Text = "Registrarse";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Visible = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(777, 1102);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txtRegistrar);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lbContinuar);
            this.Controls.Add(this.lbPausar);
            this.Controls.Add(this.lbReglas);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BoxBorders);
            this.Controls.Add(this.A10);
            this.Controls.Add(this.A9);
            this.Controls.Add(this.A8);
            this.Controls.Add(this.A7);
            this.Controls.Add(this.A6);
            this.Controls.Add(this.A5);
            this.Controls.Add(this.A4);
            this.Controls.Add(this.A3);
            this.Controls.Add(this.A2);
            this.Controls.Add(this.A1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SnakeLengthLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.EndGameLabel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Snake";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label lbContinuar;
        private System.Windows.Forms.Label lbPausar;
        private System.Windows.Forms.Label lbReglas;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label A10;
        private System.Windows.Forms.Label A9;
        private System.Windows.Forms.Label A8;
        private System.Windows.Forms.Label A7;
        private System.Windows.Forms.Label A6;
        private System.Windows.Forms.Label A5;
        private System.Windows.Forms.Label A4;
        private System.Windows.Forms.Label A3;
        private System.Windows.Forms.Label A2;
        private System.Windows.Forms.Label A1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label SnakeLengthLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label EndGameLabel;
        private System.Windows.Forms.CheckBox BoxBorders;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRegistrar;
        private System.Windows.Forms.Button btnRegistrar;
    }
}

