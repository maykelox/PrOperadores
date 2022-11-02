namespace PrOperadores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            // declaracion de variables
            double num1, num2;
            double suma;
            double resta, mult, div, potencia, raiz;
            // entrada de datos
            num1 = double.Parse(textnumero1.Text);
            num2 = Convert.ToDouble(textnumero2.Text);
            //proceso
            suma = num1 + num2;
            resta = num1 - num2;
            mult = num1 * num2; 
            div = num1 / num2;
            potencia = Math.Pow(num1, num2);
            raiz = Math.Pow(num1, (1 / num2));
            //Salida de informacion
            textsuma.Text = Convert.ToString(suma);
            textresta.Text = Convert.ToString(resta);
            textmultiplicacion.Text = Convert.ToString(mult);
            textdivision.Text = Convert.ToString(div); 
            textpotencia.Text = Convert.ToString(potencia);
            textraiz.Text = Convert.ToString(raiz);


        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            textnumero1.Clear();
            textnumero2.Clear();
            textsuma.Text = String.Empty;
            textresta.Text = String.Empty;
            textmultiplicacion.Text = String.Empty;
            textdivision.Text = String.Empty;
            textpotencia.Text = String.Empty;
            textraiz.Text = String.Empty;

        }
    }
}