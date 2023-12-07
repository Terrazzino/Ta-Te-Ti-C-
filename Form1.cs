using System.Timers;

namespace practicaTaTeTi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random random = new Random();
        List<int> posiciones = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = "X";
            button1.Enabled = false;
            posiciones.Remove(1);
            if (posiciones.Count != 0)
            {
                int posicionRandom = random.Next(1, posiciones.Count);
                bool condicion = true;
                while (condicion)
                {
                    switch (posiciones[posicionRandom])
                    {
                        case 1:
                            condicion = true;
                            break;
                        case 2:
                            button2.Text = "O";
                            button2.Enabled = false;
                            posiciones.Remove(2);
                            condicion = false;
                            break;
                        case 3:
                            button3.Text = "O";
                            button3.Enabled = false;
                            posiciones.Remove(3);
                            condicion = false;
                            break;
                        case 4:
                            button4.Text = "O";
                            button4.Enabled = false;
                            posiciones.Remove(4);
                            condicion = false;
                            break;
                        case 5:
                            button5.Text = "O";
                            button5.Enabled = false;
                            posiciones.Remove(5);
                            condicion = false;
                            break;
                        case 6:
                            button6.Text = "O";
                            button6.Enabled = false;
                            posiciones.Remove(6);
                            condicion = false;
                            break;
                        case 7:
                            button7.Text = "O";
                            button7.Enabled = false;
                            posiciones.Remove(7);
                            condicion = false;
                            break;
                        case 8:
                            button8.Text = "O";
                            button8.Enabled = false;
                            posiciones.Remove(8);
                            condicion = false;
                            break;
                        case 9:
                            button9.Text = "O";
                            button9.Enabled = false;
                            posiciones.Remove(9);
                            condicion = false;
                            break;
                    }
                }
            }

            ValidarGanador();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Text = "X";
            button2.Enabled = false;
            posiciones.Remove(2);
            if (posiciones.Count != 0)
            {
                int posicionRandom = random.Next(1, posiciones.Count);
                bool condicion = true;
                while (condicion)
                {
                    switch (posiciones[posicionRandom])
                    {
                        case 1:
                            button1.Text = "O";
                            button1.Enabled = false;
                            condicion = false;
                            posiciones.Remove(1);
                            break;
                        case 2:
                            condicion = true;
                            break;
                        case 3:
                            button3.Text = "O";
                            button3.Enabled = false;
                            condicion = false;
                            posiciones.Remove(3);
                            break;
                        case 4:
                            button4.Text = "O";
                            button4.Enabled = false;
                            condicion = false;
                            posiciones.Remove(4);
                            break;
                        case 5:
                            button5.Text = "O";
                            button5.Enabled = false;
                            condicion = false;
                            posiciones.Remove(5);
                            break;
                        case 6:
                            button6.Text = "O";
                            button6.Enabled = false;
                            condicion = false;
                            posiciones.Remove(6);
                            break;
                        case 7:
                            button7.Text = "O";
                            button7.Enabled = false;
                            condicion = false;
                            posiciones.Remove(7);
                            break;
                        case 8:
                            button8.Text = "O";
                            button8.Enabled = false;
                            condicion = false;
                            posiciones.Remove(8);
                            break;
                        case 9:
                            button9.Text = "O";
                            button9.Enabled = false;
                            condicion = false;
                            posiciones.Remove(9);
                            break;
                    }
                }
            }

            ValidarGanador();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Text = "X";
            button3.Enabled = false;
            posiciones.Remove(3);
            if (posiciones.Count != 0)
            {
                int posicionRandom = random.Next(1, posiciones.Count);
                bool condicion = true;
                while (condicion)
                {
                    switch (posiciones[posicionRandom])
                    {
                        case 1:
                            button1.Text = "O";
                            button1.Enabled = false;
                            condicion = false;
                            posiciones.Remove(1);
                            break;
                        case 2:
                            button2.Text = "O";
                            button2.Enabled = false;
                            condicion = false;
                            posiciones.Remove(2);
                            break;
                        case 3:
                            condicion = true;
                            break;
                        case 4:
                            button4.Text = "O";
                            button4.Enabled = false;
                            condicion = false;
                            posiciones.Remove(4);
                            break;
                        case 5:
                            button5.Text = "O";
                            button5.Enabled = false;
                            condicion = false;
                            posiciones.Remove(5);
                            break;
                        case 6:
                            button6.Text = "O";
                            button6.Enabled = false;
                            condicion = false;
                            posiciones.Remove(6);
                            break;
                        case 7:
                            button7.Text = "O";
                            button7.Enabled = false;
                            condicion = false;
                            posiciones.Remove(7);
                            break;
                        case 8:
                            button8.Text = "O";
                            button8.Enabled = false;
                            condicion = false;
                            posiciones.Remove(8);
                            break;
                        case 9:
                            button9.Text = "O";
                            button9.Enabled = false;
                            condicion = false;
                            posiciones.Remove(9);
                            break;
                    }
                }
            }
            ValidarGanador();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Text = "X";
            button4.Enabled = false;
            posiciones.Remove(4);
            if (posiciones.Count != 0)
            {
                int posicionRandom = random.Next(1, posiciones.Count);
                bool condicion = true;
                while (condicion)
                {
                    switch (posiciones[posicionRandom])
                    {
                        case 1:
                            button1.Text = "O";
                            button1.Enabled = false;
                            condicion = false;
                            posiciones.Remove(1);
                            break;
                        case 2:
                            button2.Text = "O";
                            button2.Enabled = false;
                            condicion = false;
                            posiciones.Remove(2);
                            break;
                        case 3:
                            button3.Text = "O";
                            button3.Enabled = false;
                            condicion = false;
                            posiciones.Remove(3);
                            break;
                        case 4:
                            condicion = true;
                            break;
                        case 5:
                            button5.Text = "O";
                            button5.Enabled = false;
                            condicion = false;
                            posiciones.Remove(5);
                            break;
                        case 6:
                            button6.Text = "O";
                            button6.Enabled = false;
                            condicion = false;
                            posiciones.Remove(6);
                            break;
                        case 7:
                            button7.Text = "O";
                            button7.Enabled = false;
                            condicion = false;
                            posiciones.Remove(7);
                            break;
                        case 8:
                            button8.Text = "O";
                            button8.Enabled = false;
                            condicion = false;
                            posiciones.Remove(8);
                            break;
                        case 9:
                            button9.Text = "O";
                            button9.Enabled = false;
                            condicion = false;
                            posiciones.Remove(9);
                            break;
                    }
                }
            }
            ValidarGanador();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Text = "X";
            button5.Enabled = false;
            posiciones.Remove(5);
            if (posiciones.Count != 0)
            {
                int posicionRandom = random.Next(1, posiciones.Count);
                bool condicion = true;
                while (condicion)
                {
                    switch (posiciones[posicionRandom])
                    {
                        case 1:
                            button1.Text = "O";
                            button1.Enabled = false;
                            condicion = false;
                            posiciones.Remove(1);
                            break;
                        case 2:
                            button2.Text = "O";
                            button2.Enabled = false;
                            condicion = false;
                            posiciones.Remove(2);
                            break;
                        case 3:
                            button3.Text = "O";
                            button3.Enabled = false;
                            condicion = false;
                            posiciones.Remove(3);
                            break;
                        case 4:
                            button4.Text = "O";
                            button4.Enabled = false;
                            condicion = false;
                            posiciones.Remove(4);
                            break;
                        case 5:
                            condicion = true;
                            break;
                        case 6:
                            button6.Text = "O";
                            button6.Enabled = false;
                            condicion = false;
                            posiciones.Remove(6);
                            break;
                        case 7:
                            button7.Text = "O";
                            button7.Enabled = false;
                            condicion = false;
                            posiciones.Remove(7);
                            break;
                        case 8:
                            button8.Text = "O";
                            button8.Enabled = false;
                            condicion = false;
                            posiciones.Remove(8);
                            break;
                        case 9:
                            button9.Text = "O";
                            button9.Enabled = false;
                            condicion = false;
                            posiciones.Remove(9);
                            break;
                    }
                }
            }
            ValidarGanador();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Text = "X";
            button6.Enabled = false;
            posiciones.Remove(6);
            if (posiciones.Count != 0)
            {
                int posicionRandom = random.Next(1, posiciones.Count);
                bool condicion = true;
                while (condicion)
                {
                    switch (posiciones[posicionRandom])
                    {
                        case 1:
                            button1.Text = "O";
                            button1.Enabled = false;
                            condicion = false;
                            posiciones.Remove(1);
                            break;
                        case 2:
                            button2.Text = "O";
                            button2.Enabled = false;
                            condicion = false;
                            posiciones.Remove(2);
                            break;
                        case 3:
                            button3.Text = "O";
                            button3.Enabled = false;
                            condicion = false;
                            posiciones.Remove(3);
                            break;
                        case 4:
                            button4.Text = "O";
                            button4.Enabled = false;
                            condicion = false;
                            posiciones.Remove(4);
                            break;
                        case 5:
                            button5.Text = "O";
                            button5.Enabled = false;
                            condicion = false;
                            posiciones.Remove(5);
                            break;
                        case 6:
                            condicion = true;
                            break;
                        case 7:
                            button7.Text = "O";
                            button7.Enabled = false;
                            condicion = false;
                            posiciones.Remove(7);
                            break;
                        case 8:
                            button8.Text = "O";
                            button8.Enabled = false;
                            condicion = false;
                            posiciones.Remove(8);
                            break;
                        case 9:
                            button9.Text = "O";
                            button9.Enabled = false;
                            condicion = false;
                            posiciones.Remove(9);
                            break;
                    }
                }
            }
            ValidarGanador();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.Text = "X";
            button9.Enabled = false;
            posiciones.Remove(9);
            if (posiciones.Count != 0)
            {
                int posicionRandom = random.Next(1, posiciones.Count);
                bool condicion = true;
                while (condicion)
                {
                    switch (posiciones[posicionRandom])
                    {
                        case 1:
                            button1.Text = "O";
                            button1.Enabled = false;
                            condicion = false;
                            posiciones.Remove(1);
                            break;
                        case 2:
                            button2.Text = "O";
                            button2.Enabled = false;
                            condicion = false;
                            posiciones.Remove(2);
                            break;
                        case 3:
                            button3.Text = "O";
                            button3.Enabled = false;
                            condicion = false;
                            posiciones.Remove(3);
                            break;
                        case 4:
                            button4.Text = "O";
                            button4.Enabled = false;
                            condicion = false;
                            posiciones.Remove(4);
                            break;
                        case 5:
                            button5.Text = "O";
                            button5.Enabled = false;
                            condicion = false;
                            posiciones.Remove(5);
                            break;
                        case 6:
                            button6.Text = "O";
                            button6.Enabled = false;
                            condicion = false;
                            posiciones.Remove(6);
                            break;
                        case 7:
                            button7.Text = "O";
                            button7.Enabled = false;
                            condicion = false;
                            posiciones.Remove(7);
                            break;
                        case 8:
                            button8.Text = "O";
                            button8.Enabled = false;
                            condicion = false;
                            posiciones.Remove(8);
                            break;
                        case 9:
                            condicion = true;
                            break;
                    }
                }
            }
            ValidarGanador();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.Text = "X";
            button8.Enabled = false;
            posiciones.Remove(8);
            if (posiciones.Count != 0)
            {
                int posicionRandom = random.Next(1, posiciones.Count);
                bool condicion = true;
                while (condicion)
                {
                    switch (posiciones[posicionRandom])
                    {
                        case 1:
                            button1.Text = "O";
                            button1.Enabled = false;
                            condicion = false;
                            posiciones.Remove(1);
                            break;
                        case 2:
                            button2.Text = "O";
                            button2.Enabled = false;
                            condicion = false;
                            posiciones.Remove(2);
                            break;
                        case 3:
                            button3.Text = "O";
                            button3.Enabled = false;
                            condicion = false;
                            posiciones.Remove(3);
                            break;
                        case 4:
                            button4.Text = "O";
                            button4.Enabled = false;
                            condicion = false;
                            posiciones.Remove(4);
                            break;
                        case 5:
                            button5.Text = "O";
                            button5.Enabled = false;
                            condicion = false;
                            posiciones.Remove(5);
                            break;
                        case 6:
                            button6.Text = "O";
                            button6.Enabled = false;
                            condicion = false;
                            posiciones.Remove(6);
                            break;
                        case 7:
                            button7.Text = "O";
                            button7.Enabled = false;
                            condicion = false;
                            posiciones.Remove(7);
                            break;
                        case 8:
                            condicion = true;
                            break;
                        case 9:
                            button9.Text = "O";
                            button9.Enabled = false;
                            condicion = false;
                            posiciones.Remove(9);
                            break;
                    }
                }
            }
            ValidarGanador();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.Text = "X";
            button7.Enabled = false;
            posiciones.Remove(7);
            if (posiciones.Count != 0)
            {
                int posicionRandom = random.Next(1, posiciones.Count);
                bool condicion = true;
                while (condicion)
                {
                    switch (posiciones[posicionRandom])
                    {
                        case 1:
                            button1.Text = "O";
                            button1.Enabled = false;
                            condicion = false;
                            posiciones.Remove(1);
                            break;
                        case 2:
                            button2.Text = "O";
                            button2.Enabled = false;
                            condicion = false;
                            posiciones.Remove(2);
                            break;
                        case 3:
                            button3.Text = "O";
                            button3.Enabled = false;
                            condicion = false;
                            posiciones.Remove(3);
                            break;
                        case 4:
                            button4.Text = "O";
                            button4.Enabled = false;
                            condicion = false;
                            posiciones.Remove(4);
                            break;
                        case 5:
                            button5.Text = "O";
                            button5.Enabled = false;
                            condicion = false;
                            posiciones.Remove(5);
                            break;
                        case 6:
                            button6.Text = "O";
                            button6.Enabled = false;
                            condicion = false;
                            posiciones.Remove(6);
                            break;
                        case 7:
                            condicion = true;
                            break;
                        case 8:
                            button8.Text = "O";
                            button8.Enabled = false;
                            condicion = false;
                            posiciones.Remove(8);
                            break;
                        case 9:
                            button9.Text = "O";
                            button9.Enabled = false;
                            condicion = false;
                            posiciones.Remove(9);
                            break;
                    }
                }
            }
            ValidarGanador();
        }

        public void ValidarGanador()
        {
            //********************************** VALIDACIONES PARA LAS X **********************************
            //- Horizontales
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
            {
                lblGanador.Text = "Has ganado!";
                lblGanador.ForeColor = Color.Green;
            }
            else if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
            {
                lblGanador.Text = "Has ganado!";
                lblGanador.ForeColor = Color.Green;
            }
            else if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
            {
                lblGanador.Text = "Has ganado!";
                lblGanador.ForeColor = Color.Green;
            }
            //- Verticales
            else if (button1.Text == "X" && button4.Text == "X" && button9.Text == "X")
            {
                lblGanador.Text = "Has ganado!";
                lblGanador.ForeColor = Color.Green;
            }
            else if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
            {
                lblGanador.Text = "Has ganado!";
                lblGanador.ForeColor = Color.Green;
            }
            else if (button3.Text == "X" && button6.Text == "X" && button7.Text == "X")
            {
                lblGanador.Text = "Has ganado!";
                lblGanador.ForeColor = Color.Green;
            }
            //- Diagonales
            else if (button1.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                lblGanador.Text = "Has ganado!";
                lblGanador.ForeColor = Color.Green;
            }
            else if (button3.Text == "X" && button5.Text == "X" && button9.Text == "X")
            {
                lblGanador.Text = "Has ganado!";
                lblGanador.ForeColor = Color.Green;
            }

            //********************************** VALIDACIONES PARA LAS O **********************************
            //- Horizontales
            else if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
            {
                lblPerdedor.Text = "Has perdido :(";
                lblPerdedor.ForeColor = Color.Red;
            }
            else if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
            {
                lblPerdedor.Text = "Has perdido :(";
                lblPerdedor.ForeColor = Color.Red;
            }
            else if (button9.Text == "O" && button8.Text == "O" && button7.Text == "O")
            {
                lblPerdedor.Text = "Has perdido :(";
                lblPerdedor.ForeColor = Color.Red;
            }
            //- Verticales
            else if (button1.Text == "O" && button4.Text == "O" && button9.Text == "O")
            {
                lblPerdedor.Text = "Has perdido :(";
                lblPerdedor.ForeColor = Color.Red;
            }
            else if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
            {
                lblPerdedor.Text = "Has perdido :(";
                lblPerdedor.ForeColor = Color.Red;
            }
            else if (button3.Text == "O" && button6.Text == "O" && button7.Text == "O")
            {
                lblPerdedor.Text = "Has perdido :(";
                lblPerdedor.ForeColor = Color.Red;
            }
            //- Diagonales
            else if (button1.Text == "O" && button5.Text == "O" && button7.Text == "O")
            {
                lblPerdedor.Text = "Has perdido :(";
                lblPerdedor.ForeColor = Color.Red;
            }
            else if (button3.Text == "O" && button5.Text == "O" && button9.Text == "O")
            {
                lblPerdedor.Text = "Has perdido :(";
                lblPerdedor.ForeColor = Color.Red;
            }

            //****************************************** EMPATE *******************************************

            else if (button1.Text != "" && button2.Text != "" && button3.Text != "" && button4.Text != "" && button5.Text != "" && button6.Text != "" && button7.Text != "" && button8.Text != "" && button9.Text != "")
            {
                lblEmpate.Text = "Empate :O";
                lblEmpate.ForeColor = Color.Blue;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblGanador.Text = string.Empty;
            lblPerdedor.Text = string.Empty;
            lblEmpate.Text = string.Empty;
        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            posiciones.Clear();
            posiciones = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            lblGanador.Text = string.Empty;
            lblPerdedor.Text = string.Empty;
            lblEmpate.Text = string.Empty;

            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";

            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;


        }
    }
}