using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversiones_Infijas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Elementos globales

        //creamos una pila que es la que termina vacia y otra que muestra todo lo que entra
        Stack<char> pila = new Stack<char>();
        Stack<char> pila2 = new Stack<char>();

        //arreglo de operadores para identificar cuando se ingrese uno
        char[] operadores = { '+', '-', '*', '/', '=', '^', '(', ')' };

        //declaramos las variables para la expresion.
        string expresion;
        string expresionSinEsp;
        bool vacia;
        bool validacion = true;
        string X = "";

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            //Limpiamos para poder convertir varias veces seguidas
            LimpiarPilas();

            //damos valores a las variables
            expresion = txtExp.Text;
            expresionSinEsp = expresion.Replace(" ", "");

            //Validamos que no este vacia
            ValidarVacia();
            //Validamos la expresion
            ValidarExpresion();

            if (vacia == true)
            {
                MessageBox.Show("Expresion Vacia", "Llenar expresion",
                                MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else if (validacion == true)
            {
                //Mensaje que valida la expresion
                MessageBox.Show("Expresion validada!", "Expresion Correcta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtExp.Text = expresionSinEsp;

                // INFIJA A POSFIJA
                if (rdbPos.Checked)
            {

                //Recorremos la expresion caracter por caracter
                foreach (char item in expresionSinEsp)
                {
                    //Identificamos si es letra o numero y lo mandamos directo al resultado
                    if (char.IsLetter(item) || char.IsDigit(item))
                    {
                        txtResultado.Text = txtResultado.Text + item.ToString();
                        Pila();
                        MostrarPila();
                    }
                    //si es un operador pasa a esta parte
                    else if (operadores.Contains(item))
                    {
                        pila2.Push(item); //Los introducimos en la pila2 para observarlos
                        //si la pila esta vacia se introduce directamente
                        if (pila.Count == 0)
                        {
                            pila.Push(item);
                            Pila();
                            MostrarPila();
                        }
                        else
                        {   
                            //identificamos el ultimo operador en la pila para poder compararlo con el siguiente a entrar
                            char ultimoC = pila.Peek();
                            switch (ultimoC)
                            {
                                case '=':
                                    if (item == '=')
                                    {
                                        ultimoC = pila.Pop();
                                        Pila();
                                        MostrarPila();
                                        txtResultado.Text = txtResultado.Text + ultimoC.ToString();
                                        pila.Push(item);
                                        Pila();
                                        MostrarPila();
                                    }
                                    else
                                    {
                                        pila.Push(item);
                                        Pila();
                                        MostrarPila();
                                    }
                                    break;

                                case '+':
                                case '-':
                                    if (item=='=' || item=='+' || item=='-')
                                    {
                                        ultimoC = pila.Pop();
                                        Pila();
                                        MostrarPila();
                                        txtResultado.Text = txtResultado.Text + ultimoC.ToString();
                                        pila.Push(item);
                                        Pila();
                                        MostrarPila();
                                    }
                                    else
                                    {
                                        pila.Push(item);
                                        Pila();
                                        MostrarPila();
                                    }
                                    break;

                                case '*':
                                case '/':          
                                    if (item == '(' || item == ')' || item == '^')
                                    {
                                        pila.Push(item);
                                        Pila();
                                        MostrarPila();
                                    }
                                    else
                                    {
                                       ultimoC = pila.Pop();
                                       Pila();
                                       MostrarPila();
                                       txtResultado.Text = txtResultado.Text + ultimoC.ToString();
                                       pila.Push(item);
                                       Pila();
                                       MostrarPila();
                                    }
                                    break;

                                case '^':
                                    if (item == '(' || item == ')' )
                                    {
                                        pila.Push(item);
                                        Pila();
                                        MostrarPila();
                                    }
                                    else
                                    {
                                       ultimoC = pila.Pop();
                                       Pila();
                                       MostrarPila();
                                       txtResultado.Text = txtResultado.Text + ultimoC.ToString();
                                       pila.Push(item);
                                       Pila();
                                       MostrarPila();
                                    }
                                    break;

                                case '(':
                                    pila.Push(item);
                                    Pila();
                                    MostrarPila();
                                    break;

                                case ')':                                  

                                    while (pila.Count > 0)
                                    {
                                        char operador = pila.Pop();
                                        Pila();
                                        MostrarPila();

                                        if (operador != '(' && operador != ')')
                                        {
                                            txtResultado.Text = txtResultado.Text + operador;
                                            Pila();
                                            MostrarPila();
                                        }
                                        else if (operador == '(')
                                        {
                                            break;
                                        }                                       
                                    }                                 
                                    pila.Push(item);
                                    Pila();
                                    MostrarPila();
                                    break;
                            }                           
                        }                       
                    }                  
                }                
                //recorremos la pila para irla vaciando a el resultado
                Posfija();
                //aqui recorremos la pila2 y agregamos todo
                Pila2();
                //aqui recorremos la pila y agregamos a la listbox con las modificaciones
                Pila();                          
            }

                // INFIJA A PREFIJA
                else
            {
                //capturamos en un arreglo la expresion para voltearla
                char[] expInversa = expresionSinEsp.ToArray();
                Array.Reverse(expInversa);
                string expresionInversa = new string(expInversa);
                Console.WriteLine(expresionInversa);

                //Recorremos la expresion caracter por caracter
                foreach (char item in expresionInversa)
                {
                    //Identificamos si es letra o numero y lo mandamos directo al resultado
                    if (char.IsLetter(item) || char.IsDigit(item))
                    {
                        txtResultado.Text = txtResultado.Text + item.ToString();
                        Pila();
                        MostrarPila();
                    }
                    //si es un operador pasa a esta parte
                    else if (operadores.Contains(item))
                    {
                        pila2.Push(item); //Los introducimos en la pila2 para observarlos

                        //si la pila esta vacia se introduce directamente
                        if (pila.Count == 0)
                        {
                            pila.Push(item);
                            Pila();
                            MostrarPila();
                        }
                        else
                        {
                            //identificamos el ultimo operador en la pila para poder compararlo con el siguiente a entrar
                            char ultimoC = pila.Peek();
                            switch (ultimoC)
                            {
                                case '=':
                                    if (item == '=')
                                    {
                                        ultimoC = pila.Pop();
                                        Pila();
                                        MostrarPila();
                                        txtResultado.Text = txtResultado.Text + ultimoC.ToString();
                                        pila.Push(item);
                                        Pila();
                                        MostrarPila();
                                    }
                                    else
                                    {
                                        pila.Push(item);
                                        Pila();
                                        MostrarPila();
                                    }
                                    break;

                                case '+':
                                case '-':
                                    if (item == '=' || item == '+' || item == '-')
                                    {
                                        ultimoC = pila.Pop();
                                        Pila();
                                        MostrarPila();
                                        txtResultado.Text = txtResultado.Text + ultimoC.ToString();
                                        pila.Push(item);
                                        Pila();
                                        MostrarPila();
                                    }
                                    else
                                    {
                                        pila.Push(item);
                                        Pila();
                                        MostrarPila();
                                    }
                                    break;

                                case '*':
                                case '/':
                                    if (item == '(' || item == ')')
                                    {
                                        pila.Push(item);
                                        Pila();
                                        MostrarPila();
                                    }
                                    else
                                    {
                                        ultimoC = pila.Pop();
                                        Pila();
                                        MostrarPila();
                                        txtResultado.Text = txtResultado.Text + ultimoC.ToString();
                                        pila.Push(item);
                                        Pila();
                                        MostrarPila();
                                    }
                                    break;

                                case '^':
                                        if (item == '(' || item == ')')
                                        {
                                            pila.Push(item);
                                            Pila();
                                            MostrarPila();
                                        }
                                        else
                                        {
                                            ultimoC = pila.Pop();
                                            Pila();
                                            MostrarPila();
                                            txtResultado.Text = txtResultado.Text + ultimoC.ToString();
                                            pila.Push(item);
                                            Pila();
                                            MostrarPila();
                                        }
                                        break;

                                case ')':
                                    pila.Push(item);
                                    Pila();
                                    MostrarPila();
                                    break;

                                case '(':

                                    while (pila.Count > 0)
                                    {
                                        char operador = pila.Pop();
                                        Pila();
                                        MostrarPila();

                                        if (operador != '(' && operador != ')')
                                        {
                                            txtResultado.Text = txtResultado.Text + operador;
                                            Pila();
                                            MostrarPila();
                                        }
                                        else if (operador == ')')
                                        {
                                            break;
                                        }
                                        
                                    }
                                    pila.Push(item);
                                    Pila();
                                    MostrarPila();
                                    break;
                            }
                        }
                    }
                }               
                //recorremos la pila para irla vaciando a el resultado
                Prefija();
                //aqui recorremos la pila2 y agregamos todo
                Pila2();
                //se obserla el primer resultado
                Console.WriteLine(txtResultado.Text);

                string expFinal = txtResultado.Text;
                char[] expresionFinal = expFinal.ToArray();
                Array.Reverse(expresionFinal);
                string resultado = new string(expresionFinal);

                txtResultado.Text = resultado;
                //aqui recorremos la pila y agregamos a la listbox con las modificaciones
                Pila();
            }
            }
            else
            {
                //Mensaje que invalida la expresion
                MessageBox.Show("Expresion invalida por los siguientes caracteres: \n" + X, "!Error en la expresion",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                X = "";
                validacion = true;
            }
        }


       //Metodos
        public void Limpiar()
        {
            foreach (Control control in gpbNotaciones.Controls)
            {
                if (control is TextBox)
                {
                    control.Text = string.Empty;
                }

                if (control is ListBox)
                {
                    ((ListBox)control).Items.Clear();
                }
            }
            pila2.Clear();
        }
        public void LimpiarPilas()
        {
            pila.Clear();
            pila2.Clear();
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            txtResultado.Text = "";
        }
        public void Cerrar()
        {
            Application.Exit();
        }
        public void ValidarVacia()
        {
            if (expresionSinEsp == "")
            {
                vacia = true;
            }
            else
            {
                vacia = false;
            }
        }
        public void ValidarExpresion()
        {               
            foreach (char item in expresionSinEsp)
            {
                if (char.IsLetter(item) || char.IsDigit(item) || operadores.Contains(item))
                {
                }
                else
                {
                    validacion = false;
                    X = X + item + " ";
                }
            }
        }
        public void Posfija()
        {
            bool parentesis = false;
            while (pila.Count > 0)
            {
                char caracter = pila.Pop();               

                if (caracter == ')')
                {
                    parentesis = true;
                }
                else if (parentesis && caracter != '(' && caracter != ')')
                {
                    txtResultado.Text = txtResultado.Text + caracter;                  
                }
                else if (caracter != '(' && caracter != ')')
                {
                    txtResultado.Text = txtResultado.Text + caracter;
                }
                Pila();
                MostrarPila();
            }
        }
        public void Prefija()
        {
            bool parentesis = false;
            while (pila.Count > 0)
            {
                char caracter = pila.Pop();

                if (caracter == '(')
                {
                    parentesis = true;
                }
                else if (parentesis && caracter != '(' && caracter != ')')
                {
                    txtResultado.Text = txtResultado.Text + caracter;
                }
                else if (caracter != '(' && caracter != ')')
                {
                    txtResultado.Text = txtResultado.Text + caracter;
                }
                Pila();
                MostrarPila();
            }
        }
        public void MostrarPila()
        {
            string cadenaPila = "";
            foreach (char operador in pila)
            {
                cadenaPila = cadenaPila + operador.ToString() + "\n"; // Agrega cada elemento de la pila a la cadena
            }
            MessageBox.Show(cadenaPila, "Pila:"); // Muestra la cadena en un MessageBox
        }
        public void Pila()
        {
            listBox1.Items.Clear();
            foreach (char item in pila)
            {
                listBox1.Items.Add(item);
            }
        }
        public void Pila2()
        {
            foreach (char item in pila2)
            {
                listBox2.Items.Add(item);
            }           
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Cerrar();
        }
        private void gpbNotaciones_Enter(object sender, EventArgs e)
        {
        }
        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

