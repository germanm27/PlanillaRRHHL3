using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using WindowsFormsApplication1;
using RRHHPlanilla.Transacciones.Horas_Extras;
using RRHHPlanilla.Reportes;


namespace RRHHPlanilla
{
    public partial class FormMenu : Form
    
    {

        
        int i = 47;
        //int a = 150;
        int anchoa = 215;
        int anchoc = 70;
        //int alto = 33;
        //int bajo = 109;
        //bool comprovacion = true;
        //string ruta = @"C:\Users\Kenin\Desktop\Prueba-master(1)\Prueba-master\RRHHPlanilla\RRHHPlanilla\Resources\ICONO.gif";
        //string ruta2 = @"C:\Users\Kenin\Desktop\Prueba-master(1)\Prueba-master\RRHHPlanilla\RRHHPlanilla\Resources\X.gif";

        public FormMenu()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true;

        }

        #region Drag Form/ Mover Arrastrar Formulario
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void FormMenu_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel5_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel7_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #endregion

        public void label1_Click(object sender, EventArgs e)
        {
            abrirformhija(new FrmInicio());
        }

        public byte[] imageToByteArray(Image ImageIn)
        {
            MemoryStream ms = new MemoryStream();
            ImageIn.Save(ms, ImageIn.RawFormat);

            return ms.ToArray();
        }

        #region LOGIN
        private void Login()
        {
            var formLogin = new FormLogin();
            formLogin.ShowDialog();

            if (Program.usuario == null)
            {
                DialogResult result = MessageBox.Show("Seguro que dese salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (result == DialogResult.Yes)
                {                   
                    Application.Exit();
                }

                if (result == DialogResult.No)
                {
                    Login();
                }
            }

            if (Program.usuario !=null)
            {             
                label1.Text = Program.usuario.Nombre + " " + Program.usuario.Apellido;
                label2.Text = Program.usuario.Privilegio.Descripcion;

                usu2.Text = Program.usuario.Nombre + " " + Program.usuario.Apellido;
                pues2.Text = Program.usuario.Privilegio.Descripcion;

                if (Program.usuario.Foto != null)
                {
                    MemoryStream ms = new MemoryStream(Program.usuario.Foto);
                    System.Drawing.Image returnImage = System.Drawing.Image.FromStream(ms);
                  
                    pictureBox3.Image = Image.FromStream(ms);
                }
     
            }
            else {
                label1.Text = "Usuario";
            }

            if (formLogin.UsuarioAutenticado == formLogin.Cancelar)
            {

            }
            if(formLogin.c == formLogin.u)
            {

                lx = this.Location.X;
                ly = this.Location.Y;
                sw = this.Size.Width;
                sh = this.Size.Height;
                this.Size = Screen.PrimaryScreen.WorkingArea.Size;
                this.Location = Screen.PrimaryScreen.WorkingArea.Location;
                this.Show();
                //this.WindowState = FormWindowState.Maximized;

                if (Program.usuario.Privilegio.Descripcion == "Gerente")
                {
                    button23.Visible = false;
                    button24.Visible = false;
                    panel1.Visible = false;

                    //USUARIO
                    button13.Visible = false;
                }

                if (Program.usuario.Privilegio.Descripcion == "Supervisor")
                {
                    //Mantenimiento
                    button16.Visible = false;
                    button2.Visible = false;
                    button3.Visible = false;

                    //Transacciones
                    button5.Visible = false;
                    button17.Visible = false;
                    button18.Visible = false;
                    button19.Visible = false;
                    button22.Visible = false;
                    

                    //REPORTE
                    button7.Visible = false;
                    //button9.Visible = false;


                    //USUARIO
                    button13.Visible = false;
                }

                if (Program.usuario.Privilegio.Descripcion == "Administrador")
                {
                    button23.Visible = true;
                    panel1.Visible = true;

                    //Mantenimiento
                    button16.Visible = true;
                    button2.Visible = true;
                    button3.Visible = true;

                    //Transacciones
                    button5.Visible = true;
                    button17.Visible = true;
                    button18.Visible = true;
                    button19.Visible = true;
                    button22.Visible = true;
                    button24.Visible = true;

                    //REPORTE
                    button7.Visible = true;
                    //button9.Visible = true;

                    //USUARIO
                    button13.Visible = true;
                }
            }
        }
        #endregion\

        //FORM LOAD 
        //FORM LOAD 
        //FORM LOAD 
        //FORM LOAD 
        //FORM LOAD 
        //FORM LOAD 
        //FORM LOAD 
        //FORM LOAD 
        //FORM LOAD 
        //FORM LOAD 
        //FORM LOAD 
        //FORM LOAD 

        #region FORM LOAD
        //Mostrar Logo en PANTALLA
        private void MostrarFormLogo()
        {
            abrirformhija(new FrmInicio());
        }

        //METODO PARA MOSTRAR FORMULARIO DE LOGO Al CERRAR OTROS FORM ----------------------------------------------------------
        private void MostrarFormLogoAlCerrarForms(object sender, FormClosedEventArgs e)
        {
            MostrarFormLogo();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            
            label3.Visible = false;
            label4.Visible = false;
            usu2.Visible = false;
            pues2.Visible = false;

            pnlUsuario.Width = 0;
            pnlayuda.Width = 0;
            panel1.Height = i;
            panel2.Height = i;
            panel3.Height = i;

            //tableLayoutPanel1.Width = anchoc;
            pictureBox1.Image = RRHHPlanilla.Properties.Resources.ICONO;
            MostrarFormLogo();
            //label1_Click(null, e);
            //pictureBox1.Image = Image.FromFile(ruta);

            if (tableLayoutPanel1.Width == anchoc)
            {
                button1.Text = " ";
                button4.Text = " ";
                button8.Text = " ";
            }
            else
            {

            }

            Login();
        }

        #endregion

        #region botones Panel
        private void button2_Click(object sender, EventArgs e)
        {
            //abrirformhija(new Prestamos());

            Capacitaciones fm = new Capacitaciones();
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            abrirformhija(fm);

            //var prestamos = new Prestamos();
            //prestamos.MdiParent = this;
            //prestamos.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //abrirformhija(new Trabajadores());

            Empleados fm = new Empleados();
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            abrirformhija(fm);
            
            //var formTrabajadores = new Trabajadores();
            //formTrabajadores.MdiParent = this;
            //formTrabajadores.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (panel1.Height == i)
            {
                panel1.Height = 60;
                panel1.AutoSize = true;
                //panel2.Height = i;
                //panel3.Height = i;
            }
            else
            {
                panel1.AutoSize = false;
                panel1.Height = i;
                //panel1.AutoSize = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (panel2.Height == i)
            {
                //panel1.Height = i;
                panel2.Height = 43;
                panel2.AutoSize = true;
                //panel3.Height = i;
            }
            else
            {
                panel2.Height = i;
                panel2.AutoSize = false;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (panel3.Height == i)
            {
                //panel1.Height = i;
                //panel2.Height = i;               
                panel3.Height = 84;
                panel3.AutoSize = true;
            }
            else
            {
                panel3.Height = i;
                panel3.AutoSize = false;
            }
        }

        #endregion


        //ABRIR FROMHIJA
        public void abrirformhija(Form formhija)
        {
            if (this.panel5.Controls.Count > 0)
                this.panel5.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;

            this.panel5.Controls.Add(fh);
            this.panel5.Tag = fh;
            //fh.MdiParent = this;
            fh.Show();
        }

        #region NO SIRVE/AUN ASI NO BORRAR
        private void panel5_MouseEnter(object sender, EventArgs e)
        {
            //tableLayoutPanel1.Width = 65;
            //button1.Text = " ";
            //button4.Text = " ";
            //button8.Text = " ";

            //panel1.AutoSize = false;
            //panel2.AutoSize = false;
            //panel3.AutoSize = false;

            //panel1.Height = 25;
            //panel2.Height = 25;
            //panel3.Height = 25;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripDropDownButton1_MouseEnter(object sender, EventArgs e)
        {
            //toolStripDropDownButton1.BackColor = Color.Brown;
        }
        #endregion

        #region MOUSE ENTER
        private void button1_MouseEnter(object sender, EventArgs e)
        {

        }
            
        private void button8_MouseEnter(object sender, EventArgs e)
        {

        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {

        }

        #endregion

        //PANEL RETRACTIL
        private void tableLayoutPanel1_MouseEnter(object sender, EventArgs e)
        {

            //PANEL SIMPLE
            //if (checkBox1.Checked == false)
            //{
            //    tableLayoutPanel1.Width = anchoa;
            //    button1.Text = "Mantenimiento";
            //    button4.Text = "Transacciones";
            //    button8.Text = "Reportes";
            //}

            //if (checkBox1.Checked == true)
            //{

            //}

            //PANEL ANIMADO
            //if (tableLayoutPanel1.Width == anchoa)
            //{
            //    this.tmContraerMenu.Start();
            //}
            //else if (tableLayoutPanel1.Width == anchoc)
            //{
            //    this.tmExpandirMenu.Start();
            //}

        }

        #region pICTURE BOXES

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (pnlmenu.Height == 105)
            {
                pictureBox3.Visible = false;
                pnlUsuario.Width = 0;
                this.tmContraerMenu.Start();
            }
            else if (pnlmenu.Height == 35)
            {
                pictureBox3.Visible = true;
                label3.Visible = false;
                label4.Visible = false;

                usu2.Visible = false;
                pues2.Visible = false;
                this.tmExpandirMenu.Start();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            if (tableLayoutPanel1.Width == anchoa)
            {
                tableLayoutPanel1.Width = anchoc;
                button1.Text = " ";
                button4.Text = " ";
                button8.Text = " ";

                panel1.AutoSize = false;
                panel2.AutoSize = false;
                panel3.AutoSize = false;

                panel1.Height = i;
                panel2.Height = i;
                panel3.Height = i;
            }

            else
            {
                tableLayoutPanel1.Width = anchoa;
                button1.Text = "Mantenimiento";
                button4.Text = "Transacciones";
                button8.Text = "Reportes";

            }

        }



        private void pictureBox1_MouseEnter_1(object sender, EventArgs e)
        {
           
            pictureBox1.Image = RRHHPlanilla.Properties.Resources.X;

            //pictureBox1.Image = Image.FromFile(ruta2);
        }

        private void pictureBox1_MouseLeave_1(object sender, EventArgs e)
        {
            pictureBox1.Image = RRHHPlanilla.Properties.Resources.ICONO;
            //pictureBox1.Image = Image.FromFile(ruta);
        }

        #endregion

        #region BOTONES DE CERRAR, MAX, MIN

        private void button10_Click(object sender, EventArgs e)
        {
            if (pnlUsuario.Width == 0)
            {
                pnlUsuario.Width = 185;
            }
            else
                pnlUsuario.Width = 0;
        }

        int lx, ly;
        int sw, sh;

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Seguro que dese salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                //UsuarioAutenticado = Cancelar;
                Application.Exit();
            }

            if (result == DialogResult.No)
            {

            }
        }

        private void picmaxi_Click(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Maximized;

            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;

            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            picrehavi.Visible = true;
            picmaxi.Visible = false;
        }

        private void picrehavi_Click(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Normal;
            
            this.Size = new Size(1155, 604);
            this.Location = new Point(lx, ly);
            picrehavi.Visible = false;
            picmaxi.Visible = true;
        }

        private void picmini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion

        #region TIMERS

        private void tmExpandirMenu_Tick(object sender, EventArgs e)
        {

            if (pnlmenu.Height >= 105)
            {
                this.tmExpandirMenu.Stop();
            }
            else
                pnlmenu.Height = pnlmenu.Height + 10;

        }

        //Logo
        private void pictureBox2_Click(object sender, EventArgs e)
        {

            if (tableLayoutPanel1.Width == anchoa)
            {
                tableLayoutPanel1.Width = anchoc;
                button1.Text = " ";
                button4.Text = " ";
                button8.Text = " ";

                panel1.AutoSize = false;
                panel2.AutoSize = false;
                panel3.AutoSize = false;

                panel1.Height = i;
                panel2.Height = i;
                panel3.Height = i;
            }

            else
            {
                tableLayoutPanel1.Width = anchoa;
                button1.Text = "Mantenimiento";
                button4.Text = "Transacciones";
                button8.Text = "Reportes";
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

            
        }

        private void Interrogacion_Click(object sender, EventArgs e)
        {
            if (pnlayuda.Width == 0)
            {
                pnlayuda.Width = 79;
            }
            else
            pnlayuda.Width = 0;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Application.Restart();
            //this.Hide();
            //Login();
        }

    private void button12_Click_1(object sender, EventArgs e)
        {
            FrmAcercaDe frm = new FrmAcercaDe();
            frm.ShowDialog();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        
            {
                Anticipos fm = new Anticipos();
                fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
                abrirformhija(fm);
            }
        

        private void button16_Click(object sender, EventArgs e)
        {
            Busquedas fms = new Busquedas();
            fms.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            abrirformhija(fms);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Planillas fm = new Planillas();
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            abrirformhija(fm);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Prestaciones fm = new Prestaciones();
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            abrirformhija(fm);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Vacaciones fm = new Vacaciones();
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            abrirformhija(fm);
        }

        private void button22_Click(object sender, EventArgs e)
        
            {
                HorasExtras fm = new HorasExtras();
                fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
                abrirformhija(fm);
            }

        private void button13_Click(object sender, EventArgs e)
        {
            pnlUsuario.Width = 0;
            FrmConfirmarConf frm = new FrmConfirmarConf();
            frm.ShowDialog();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            pnlUsuario.Width = 0;
            FrmConfiUsuario frm = new FrmConfiUsuario();
            frm.Show();
        }

        private void button23_Click(object sender, EventArgs e)
        {
           
            Form3 fms = new Form3();
            fms.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            abrirformhija(fms);
            
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button24_Click(object sender, EventArgs e)
        {

            EvaluacionMenu fms = new EvaluacionMenu();
            fms.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            abrirformhija(fms);

            if (pnlmenu.Height == 105)
            {
                pictureBox3.Visible = false;
                pnlUsuario.Width = 0;
                this.tmContraerMenu.Start();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            {
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {

            ReportPrestaciones fms = new ReportPrestaciones();
            fms.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            abrirformhija(fms);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            ReportEmpleado fms = new ReportEmpleado();
            fms.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            abrirformhija(fms);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            ReportEvalPersonal fms = new ReportEvalPersonal();
            fms.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            abrirformhija(fms);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            ReporteHorasExtras fms = new ReporteHorasExtras();
            fms.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            abrirformhija(fms);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //Form1 f4 = new Form1();
            Asistencia f4 = new Asistencia();

            f4.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ReportedePlanilla fms = new ReportedePlanilla();
            fms.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            abrirformhija(fms);
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            {
                //Form1 f4 = new Form1();

                //f4.Show();
            }
        }

        /*
       private void button25_Click(object sender, EventArgs e)
      
       */
        private void tmContraerMenu_Tick(object sender, EventArgs e)
        {

            if (pnlmenu.Height <= 35)
            {
                this.tmContraerMenu.Stop();
                usu2.Visible = true;
                pues2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
            }
            else
                pnlmenu.Height = pnlmenu.Height - 10;
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            lblhora.Text = DateTime.Now.ToString("h:mm:ss");
            lblfecha.Text = DateTime.Now.ToLongDateString();

            label4.Text = DateTime.Now.ToString("h:mm:ss");
            label3.Text = DateTime.Now.ToLongDateString();
        }

        #endregion
    }
}
