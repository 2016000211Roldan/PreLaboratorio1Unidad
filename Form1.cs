namespace PreLaboratorioIUnidad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "12345") //si el textbox es igual a esta contrase�a
            {
                Form2 crud = new Form2();
                crud.ShowDialog(); //abrira el form 2
            }
            else
            {
                MessageBox.Show("La contrase�a que se ha intentado ingresar es incorrecta");
                textBox1.Clear(); //si no es la misma contrase�a aparecera ese mensaje 
                //y se pondra de nuevo en blanco el textboc
            }
        }
        private void cr�ditosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 creditos = new Form3(); //para que el menu pueda llevarnos a la ventana
            creditos.ShowDialog(); //creditos
        }
    }
}
