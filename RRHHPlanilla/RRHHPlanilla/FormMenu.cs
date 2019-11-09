using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

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

        private void Login()
        {
            var formLogin = new FormLogin();
            formLogin.ShowDialog();

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
                //this.WindowState = FormWindowState.Maximized;
            }
        }

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

        private void FormMenu_Load(object sender, EventArgs e)
        {

            
            panel1.Height = i;
            panel2.Height = i;
            panel3.Height = i;

            tableLayoutPanel1.Width = anchoc;
            pictureBox1.Image = RRHHPlanilla.Properties.Resources.ICONO;
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

        private void FormMenu_KeyDown(object sender, KeyEventArgs e)
        {

        }

        #region botones Panel
        private void button2_Click(object sender, EventArgs e)
        {
            abrirformhija(new Prestamos());

            //var prestamos = new Prestamos();
            //prestamos.MdiParent = this;
            //prestamos.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            abrirformhija(new Trabajadores());
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

        private void abrirformhija(Form formhija)
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

        #endregion

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblhora.Text = DateTime.Now.ToString("h:mm:ss");
            lblfecha.Text = DateTime.Now.ToLongDateString();
        }

        #region BOTONES DE CERRAR, MAX, MIN

        int lx, ly;
        int sw, sh;

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Seguro que dese salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
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

            this.Size = new Size(sw, sh);
            this.Location = new Point(lx, ly);
            picrehavi.Visible = false;
            picmaxi.Visible = true;
        }

        private void picmini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion

        private void label1_Click(object sender, EventArgs e)
        {
            abrirformhija(new FrmInicio());
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (pnlmenu.Height == 105)
            {
                this.tmContraerMenu.Start();
            }
            else if (pnlmenu.Height == 35)
            {
                this.tmExpandirMenu.Start();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //if (pnlmenu.Height == 195)
            //{
            //    pnlmenu.Height = 1;
            //}
            //else
            //{
            //    pnlmenu.Height = 195;
            //}
        }




        #region TIMERS

        private void tmExpandirMenu_Tick(object sender, EventArgs e)
        {
            if (pnlmenu.Height >= 105)
                this.tmExpandirMenu.Stop();
            else
                pnlmenu.Height = pnlmenu.Height + 5;
        }

        private void tmContraerMenu_Tick(object sender, EventArgs e)
        {
            if (pnlmenu.Height <= 35)
                this.tmContraerMenu.Stop();
            else
                pnlmenu.Height = pnlmenu.Height - 5;

        }


        #endregion
    }
}
