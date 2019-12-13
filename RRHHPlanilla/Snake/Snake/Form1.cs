using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;  //sirve para el sonido wab


namespace Snake
{
    public partial class Form1 : Form
    {
        SoundPlayer player = new SoundPlayer();  //objeto para sonido
        public Form1()
        {
            InitializeComponent();
        }
        PictureBox[,] Box;          //Almacena todo en el pictureboxes del tablero
        int snakeXPos;              //X posicion de la cabeza de la serpiente
        int snakeYPos;              //Y posicion de la cabeza de la serpiente
        string changeToDirection = "left";
        string direction = "left";
        int snakeLength = 1;
        int[] snakeXPositions;      //Almacena todas la posiciones X de cada pieza del snake
        int[] snakeYPositions;      //Almacena todas la posiciones Y de cada pieza del snake
        Random R = new Random();
        int[] foodXPos;
        int[] foodYPos;
        int AmountOfFood = 1;       //Cantidad de comida en la pantalla 
        bool rePlaceFood = true;

        private void label4_Click(object sender, EventArgs e)
        {
            ResetGame();
            MostrarRangin();
            EndGameLabel.Visible = false;
            txtRegistrar.Enabled = false;
        }

        private void A1_Click(object sender, EventArgs e)  // es para el monto de comida para nuestro snake
        {
            A1.ForeColor = Color.Lime;
            A1.Font = new Font(A1.Font, FontStyle.Bold);
            A2.ForeColor = Color.Red;
            A3.ForeColor = Color.Red;
            A4.ForeColor = Color.Red;
            A5.ForeColor = Color.Red;
            A6.ForeColor = Color.Red;
            A7.ForeColor = Color.Red;
            A8.ForeColor = Color.Red;
            A9.ForeColor = Color.Red;
            A10.ForeColor = Color.Red;
            AmountOfFood = 1;
            rePlaceFood = true;
            newFood();
        }

        private void A2_Click(object sender, EventArgs e)
        {
            A2.ForeColor = Color.Lime;
            A2.Font = new Font(A2.Font, FontStyle.Bold);
            A1.ForeColor = Color.Red;
            A3.ForeColor = Color.Red;
            A4.ForeColor = Color.Red;
            A5.ForeColor = Color.Red;
            A6.ForeColor = Color.Red;
            A7.ForeColor = Color.Red;
            A8.ForeColor = Color.Red;
            A9.ForeColor = Color.Red;
            A10.ForeColor = Color.Red;
            AmountOfFood = 2;
            rePlaceFood = true;
            newFood();
        }

        private void A3_Click(object sender, EventArgs e)
        {
            A3.ForeColor = Color.Lime;
            A3.Font = new Font(A3.Font, FontStyle.Bold);
            A1.ForeColor = Color.Red;
            A2.ForeColor = Color.Red;
            A4.ForeColor = Color.Red;
            A5.ForeColor = Color.Red;
            A6.ForeColor = Color.Red;
            A7.ForeColor = Color.Red;
            A8.ForeColor = Color.Red;
            A9.ForeColor = Color.Red;
            A10.ForeColor = Color.Red;
            AmountOfFood = 3;
            rePlaceFood = true;
            newFood();
        }

        private void A4_Click(object sender, EventArgs e)
        {
            A4.ForeColor = Color.Lime;
            A4.Font = new Font(A4.Font, FontStyle.Bold);
            A1.ForeColor = Color.Red;
            A2.ForeColor = Color.Red;
            A3.ForeColor = Color.Red;
            A5.ForeColor = Color.Red;
            A6.ForeColor = Color.Red;
            A7.ForeColor = Color.Red;
            A8.ForeColor = Color.Red;
            A9.ForeColor = Color.Red;
            A10.ForeColor = Color.Red;
            AmountOfFood = 4;
            rePlaceFood = true;
            newFood();
        }

        private void A5_Click(object sender, EventArgs e)
        {
            A5.ForeColor = Color.Lime;
            A5.Font = new Font(A5.Font, FontStyle.Bold);
            A1.ForeColor = Color.Red;
            A2.ForeColor = Color.Red;
            A3.ForeColor = Color.Red;
            A4.ForeColor = Color.Red;
            A6.ForeColor = Color.Red;
            A7.ForeColor = Color.Red;
            A8.ForeColor = Color.Red;
            A9.ForeColor = Color.Red;
            A10.ForeColor = Color.Red;
            AmountOfFood = 5;
            rePlaceFood = true;
            newFood();
        }

        private void A6_Click(object sender, EventArgs e)
        {
            A6.ForeColor = Color.Lime;
            A6.Font = new Font(A6.Font, FontStyle.Bold);
            A1.ForeColor = Color.Red;
            A2.ForeColor = Color.Red;
            A3.ForeColor = Color.Red;
            A4.ForeColor = Color.Red;
            A5.ForeColor = Color.Red;
            A7.ForeColor = Color.Red;
            A8.ForeColor = Color.Red;
            A9.ForeColor = Color.Red;
            A10.ForeColor = Color.Red;
            AmountOfFood = 6;
            rePlaceFood = true;
            newFood();
        }

        private void A7_Click(object sender, EventArgs e)
        {
            A7.ForeColor = Color.Lime;
            A7.Font = new Font(A7.Font, FontStyle.Bold);
            A1.ForeColor = Color.Red;
            A2.ForeColor = Color.Red;
            A3.ForeColor = Color.Red;
            A4.ForeColor = Color.Red;
            A5.ForeColor = Color.Red;
            A6.ForeColor = Color.Red;
            A8.ForeColor = Color.Red;
            A9.ForeColor = Color.Red;
            A10.ForeColor = Color.Red;
            AmountOfFood = 7;
            rePlaceFood = true;
            newFood();
        }

        private void A8_Click(object sender, EventArgs e)
        {
            A8.ForeColor = Color.Lime;
            A8.Font = new Font(A8.Font, FontStyle.Bold);
            A1.ForeColor = Color.Red;
            A2.ForeColor = Color.Red;
            A3.ForeColor = Color.Red;
            A4.ForeColor = Color.Red;
            A5.ForeColor = Color.Red;
            A6.ForeColor = Color.Red;
            A7.ForeColor = Color.Red;
            A9.ForeColor = Color.Red;
            A10.ForeColor = Color.Red;
            AmountOfFood = 8;
            rePlaceFood = true;
            newFood();
        }

        private void A9_Click(object sender, EventArgs e)
        {
            A9.ForeColor = Color.Lime;
            A9.Font = new Font(A9.Font, FontStyle.Bold);
            A1.ForeColor = Color.Red;
            A2.ForeColor = Color.Red;
            A3.ForeColor = Color.Red;
            A4.ForeColor = Color.Red;
            A5.ForeColor = Color.Red;
            A6.ForeColor = Color.Red;
            A7.ForeColor = Color.Red;
            A8.ForeColor = Color.Red;
            A10.ForeColor = Color.Red;
            AmountOfFood = 9;
            rePlaceFood = true;
            newFood();
        }

        private void A10_Click(object sender, EventArgs e)
        {
            A10.ForeColor = Color.Lime;
            A10.Font = new Font(A10.Font, FontStyle.Bold);
            A1.ForeColor = Color.Red;
            A2.ForeColor = Color.Red;
            A3.ForeColor = Color.Red;
            A4.ForeColor = Color.Red;
            A5.ForeColor = Color.Red;
            A6.ForeColor = Color.Red;
            A7.ForeColor = Color.Red;
            A8.ForeColor = Color.Red;
            A9.ForeColor = Color.Red;
            AmountOfFood = 10;
            rePlaceFood = true;
            newFood();
        }

        private void ptbMusica_Click(object sender, EventArgs e)
        {
            player.SoundLocation = "C:/Users/JHON/Desktop/Snake/Snake/imagenes/cobra.wav";// direccion del sonido
            player.Play();// para hacer sonar el sonido 
            /*timer1.Stop();*/
            //para para a snake
        }

        private void lbPausar_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void lbContinuar_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void lbReglas_Click(object sender, EventArgs e)
        {
                 reglas regla = new reglas();
            regla.Show();
            timer1.Stop();
        }

       

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            timer1.Stop();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
 
            panel1.BackColor = Color.GreenYellow; //verde es el fondo de la tabla del juego
            EndGameLabel.Cursor = Cursors.Hand;
            foodXPos = new int[10];
            foodYPos = new int[10];
            snakeXPositions = new int[1000];
            snakeYPositions = new int[1000];
            Box = new PictureBox[30, 30]; //30x30 es la tabla del pictureboxes
            txtRegistrar.CharacterCasing = CharacterCasing.Upper ; // convierte los caracteres en mayusculas .upper (mayuscula)

            for (int y = 0; y < 30; y++)        // Creamos el tablero 30x30 de la tablero pictureboxes
            {
                for (int x = 0; x < 30; x++)
                {

                    Box[x, y] = new PictureBox();
                    Box[x, y].Left = 50 + x * 16;
                    Box[x, y].Top = 100 + y * 16;
                    Box[x, y].Width = 17;
                    Box[x, y].Height = 17;
                    Box[x, y].BackColor = Color.Black;
                    if (BoxBorders.Checked == true)
                    {
                        Box[x, y].BorderStyle = BorderStyle.FixedSingle;
                    }
                    else
                    {
                        Box[x, y].BorderStyle = BorderStyle.None;
                    }

                    Controls.Add(Box[x, y]);
                }
            }                                   // ^
            Box[15, 15].BackColor = Color.Lime;
            snakeXPos = 15; //iniciando la posicion de snake
            snakeYPos = 15;
            snakeXPositions[1] = 15;
            snakeYPositions[1] = 15;
            newFood(); //coloca comida
            panel1.SendToBack();
            MostrarRangin();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData) //Obtener la flecha de entrada para obtener
        {
            switch (keyData)
            {
                case Keys.Left:
                    changeToDirection = "left";
                    break;
                case Keys.Right:
                    changeToDirection = "right";
                    break;
                case Keys.Up:
                    changeToDirection = "up";
                    break;
                case Keys.Down:
                    changeToDirection = "down";
                    break;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        bool foundBox = false;
        int foodNum = 1;

        private void newFood() //coloca comida
        {
            foodNum = 0;
            for (int y = 0; y < 30; y++)                    // Posición de todas las comidas
            {
                for (int x = 0; x < 30; x++)
                {
                    if (Box[x, y].BackColor == Color.Red)
                    {
                        foodXPos[foodNum] = x;
                        foodYPos[foodNum] = y;
                        foodNum += 1;
                        Box[x, y].BackColor = Color.Black;
                    }
                }
            }                                               // ^

            if (rePlaceFood == false) // El reemplazo de alimentos es cierto cuando el juego comienza o la cantidad de alimentos cambia
            {
                for (int i = 0; i <= AmountOfFood - 1; i++)   // coloca comida
                {
                    Box[foodXPos[i], foodYPos[i]].BackColor = Color.Red;
                }                                           // ^

                foundBox = false;
                while (foundBox == false)                   // coloca una comida en un lugar aleatorio y solo en una caja sin nada
                {
                    foodXPos[AmountOfFood - 1] = R.Next(0, 30);
                    foodYPos[AmountOfFood - 1] = R.Next(0, 30);

                    if (Box[foodXPos[AmountOfFood - 1], foodYPos[AmountOfFood - 1]].BackColor == Color.Black)
                    {
                        Box[foodXPos[AmountOfFood - 1], foodYPos[AmountOfFood - 1]].BackColor = Color.Red;
                        foundBox = true;
                    }
                    else
                    {
                        foodXPos[AmountOfFood - 1] = R.Next(0, 30);
                        foodYPos[AmountOfFood - 1] = R.Next(0, 30);
                    }
                }                                           // ^
            }
            else
            {
                rePlaceFood = false;
                for (int i = 0; i <= AmountOfFood - 1; i++)   // coloca del 1 al 10 alimentos dependiendo de la cantidad de la variable variada
                {
                    foundBox = false;
                    while (foundBox == false)
                    {
                        foundBox = false;

                        foodXPos[i] = R.Next(0, 30);
                        foodYPos[i] = R.Next(0, 30);

                        if (Box[foodXPos[i], foodYPos[i]].BackColor == Color.Black)
                        {
                            Box[foodXPos[i], foodYPos[i]].BackColor = Color.Red;
                            foundBox = true;
                        }
                        else
                        {
                            foodXPos[i] = R.Next(0, 30);
                            foodYPos[i] = R.Next(0, 30);
                        }
                    }
                }                                           // ^
            }
        }
        private void configuracionRanking(string nombre, int puntaje) //aca sale el ranking del puntaje de snake
        {
            //My.settings  VB
            
            if (puntaje > Properties.Settings.Default.puntajeTop3)
            {
                if (puntaje > Properties.Settings.Default.puntajeTop2)
                {
                    if (puntaje > Properties.Settings.Default.puntajeTop1)
                    {
                        Properties.Settings.Default.nombreTop3 = Properties.Settings.Default.nombreTop2;
                        Properties.Settings.Default.puntajeTop3 = Properties.Settings.Default.puntajeTop2;
                        Properties.Settings.Default.nombreTop2 = Properties.Settings.Default.nombreTop1;
                        Properties.Settings.Default.puntajeTop2 = Properties.Settings.Default.puntajeTop1;

                        Properties.Settings.Default.nombreTop1 = nombre;
                        Properties.Settings.Default.puntajeTop1 = puntaje;
                    }
                    else
                    {
                        Properties.Settings.Default.nombreTop3 = Properties.Settings.Default.nombreTop2;
                        Properties.Settings.Default.puntajeTop3 = Properties.Settings.Default.puntajeTop2;

                        Properties.Settings.Default.nombreTop2 = nombre;
                        Properties.Settings.Default.puntajeTop2 = puntaje;
                    }
                }
                else
                {
                    Properties.Settings.Default.nombreTop3 = nombre;
                    Properties.Settings.Default.puntajeTop3 = puntaje;
                }
            }
            else
            {
                MessageBox.Show("SIGUE JUGANDO! PUNTUACIÓN BAJA");
            }
        }
        private void MostrarRangin()
        {
            listBox1.Items.Clear(); 
            listBox1.Items.Add("Posición 1: " + Properties.Settings.Default.nombreTop1 + " Tú puntaje es: " + Properties.Settings.Default.puntajeTop1);
            listBox1.Items.Add("Posición 2: " + Properties.Settings.Default.nombreTop2 + " Tú puntaje es: " + Properties.Settings.Default.puntajeTop2);
            listBox1.Items.Add("Posición 3: " + Properties.Settings.Default.nombreTop3 + " Tú puntaje es: " + Properties.Settings.Default.puntajeTop3);

        }
        private void checkIFOffBoard()  //aca esta el texto cuando acaba el juego
        {
            if (snakeXPos < 0 || snakeXPos > 29 || snakeYPos < 0 || snakeYPos > 29)
            {
                EndGameLabel.Text = "PERDISTE!" + Environment.NewLine + /*Environment.NewLine +*/ "La serpiente se estrello" + Environment.NewLine + Environment.NewLine + "Click Aquí para jugar de nuevo";
                txtRegistrar.Enabled = true;
                endGame();
                
                MessageBox.Show("Registra tu nombre para saber si estas en el Ranking!");
            }
        }

        private void EndGameLabel_Click(object sender, EventArgs e)
        {
            EndGameLabel.Visible = false;
            ResetGame();
            txtRegistrar.Enabled = false;
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            SnakeLengthLabel.Text = snakeLength.ToString();
            
     
            switch (changeToDirection) //Comprueba si la serpiente puede moverse en la direccion de la tecla de flecha presionada
            {
                case "left":
                    if (direction != "right")
                    {
                        direction = "left";
                    }
                    break;
                case "right":
                    if (direction != "left")
                    {
                        direction = "right";
                    }
                    break;
                case "up":
                    if (direction != "down")
                    {
                        direction = "up";
                    }
                    break;
                case "down":
                    if (direction != "up")
                    {
                        direction = "down";
                    }
                    break;
            }
            switch (direction) //Cambia la dirección de la serpiente
            {
                case "left":
                    snakeXPos -= 1;
                    checkIFOffBoard();
                    Box[snakeXPos, snakeYPos].BackColor = Color.Lime;
                    break;
                case "right":
                    snakeXPos += 1;
                    checkIFOffBoard();
                    Box[snakeXPos, snakeYPos].BackColor = Color.Lime;
                    break;
                case "up":
                    snakeYPos -= 1;
                    checkIFOffBoard();
                    Box[snakeXPos, snakeYPos].BackColor = Color.Lime;
                    break;
                case "down":
                    snakeYPos += 1;
                    checkIFOffBoard();
                    Box[snakeXPos, snakeYPos].BackColor = Color.Lime;
                    break;
            }

            for (int i = 0; i <= 9; i++)    //Comprueba si la serpiente ha comido un alimento
            {
                if (snakeXPos == foodXPos[i] && snakeYPos == foodYPos[i])
                {
                    snakeLength += 2;
                    SnakeLengthLabel.Text = snakeLength.ToString();
                    newFood();                    
                }
            }           

            for (int i = 1; i < 1000; i++) //Comprueba si la serpiente ha chocado consigo misma
            {
                if (snakeXPos == snakeXPositions[i] && snakeYPos == snakeYPositions[i])
                {
                 
                    EndGameLabel.Text = "PERDISTE!" + Environment.NewLine + /*Environment.NewLine +*/ "La serpiente se estrello" + Environment.NewLine + Environment.NewLine + "Click Aquí para jugar de nuevo";
                    txtRegistrar.Enabled = true;
                    endGame();
                    
                    MessageBox.Show("Registra tu nombre para saber si estas en el Ranking!");
                }
            }

            if (snakeLength < 20) //aumenta la velocidad del movimiento de la serpiente en función de su longitud(shorter timer interval = faster speed)
            {
                timer1.Interval = 500 - snakeLength * 15;
            }
            
            for (int i = 99; i >= 1; i--) // hace que el cuerpo de la serpiente siga el camino de la cabeza de la Serpiente
            {
                if (i < snakeLength)
                {
                    snakeXPositions[i + 1] = snakeXPositions[i];
                    snakeYPositions[i + 1] = snakeYPositions[i];
                }
                else if (i > snakeLength)
                {
                    snakeXPositions[i] = -1;
                    snakeYPositions[i] = 0;
                }
            }                          

            snakeXPositions[1] = snakeXPos;            
            snakeYPositions[1] = snakeYPos;

            for (int y = 0; y < 30; y++) //modifica la posicion de snake
            {
                for (int x = 0; x < 30; x++)
                {
                    if (Box[x, y].BackColor != Color.Red)
                    {
                        Box[x, y].BackColor = Color.Black;
                    }


                    if (BoxBorders.Checked == true)
                    {
                        Box[x, y].BorderStyle = BorderStyle.FixedSingle;
                    }
                    else
                    {
                        Box[x, y].BorderStyle = BorderStyle.None;
                    }
                        
                }
            }

            for (int i = 1; i < 100; i++)
            {
                if (snakeXPositions[i] != -1)
                {
                    Box[snakeXPositions[i], snakeYPositions[i]].BackColor = Color.Lime;
                }

            }                          
        }

        private void endGame()
        {
            snakeXPos = 15;
            snakeYPos = 15;
            EndGameLabel.Visible = true;
            timer1.Stop();
        }

        private void ResetGame()
        {
            timer1.Interval = 500;
            timer1.Start();
            rePlaceFood = true;

            for (int y = 0; y < 30; y++)
            {
                for (int x = 0; x < 30; x++)
                {
                    Box[x, y].BackColor = Color.Black;
                }
            }

            for (int i = 1; i < 100; i++)
            {
                snakeXPositions[i] = -1;
                snakeYPositions[i] = -1;
            }

            snakeLength = 1;

            Box[15, 15].BackColor = Color.Lime;
            snakeXPos = 15;
            snakeYPos = 15;
            direction = "left";
            changeToDirection = "left";
            snakeXPositions[1] = 15;
            snakeYPositions[1] = 15;
            newFood();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            int puntaje = Convert.ToInt32(SnakeLengthLabel.Text);
            configuracionRanking(txtRegistrar.Text, puntaje);
            MostrarRangin();
            txtRegistrar.Clear();
        }

    }
}
