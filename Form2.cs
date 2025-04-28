using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PreLaboratorioIUnidad
{
    public partial class Form2 : Form
    {
        static int seleccionFila; //que los numeros se queden en su lugar

        public Form2()
        {
            InitializeComponent(); //inicializador
        }
        void limpiar() //metodo para limpiar 
        { //cada textbox quedara limpio
            txtNombres.Text = "";
            txtApellidos.Text = "";
            txtGrado.Text = "";
            txtSeccion.Text = "";
            txtClave.Text = "";
            txtPromo.Text = "";
            txtMatri.Text = "";
            txtCiclo.Text = "";
            txtNum.Text = "";
            txtMail.Text = "";
            txtEnca.Text = "";
            txtNombres.Focus(); //el cursor iniciara aqui 
        }

        private void créditosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 creditos = new Form3();
            creditos.ShowDialog(); //para pasar a creditos por el menu
        }

        private void btnGuardar_Click(object sender, EventArgs e) //btn para agregar
        {
            object[] agregardatos = //lista para darle valor y agregarlos
            {
                //pegar los datos a la tabla
                txtNombres.Text,
                txtApellidos.Text,
                txtGrado.Text,
                txtSeccion.Text,
                txtClave.Text,
                txtPromo.Text,
                txtMatri.Text,
                txtCiclo.Text,
                txtNum.Text,
                txtMail.Text,
                txtEnca.Text,
        };
            dataGridView1.Rows.Add(agregardatos); //agregar filas a la tabla
            MessageBox.Show("Datos Guardados", "Secretaria Colegio Don Bosco", MessageBoxButtons.OK,
                MessageBoxIcon.Information); //avisar que los datos fueron agregados
            limpiar(); //se limpiaran los textbox
        }

        private void btnEditar_Click(object sender, EventArgs e) //btn editar datos
        {
            try //metodo para probar y si es correcto se ejecuta
            {
                if (dataGridView1.RowCount != 0) //si no tiene filas agregar una los datos
                {
                    int indice = dataGridView1.CurrentRow.Index; //se cambian los datos al seleccionar fila
                    //cada dato se actualizara y agregara a la columna correspondiente
                    dataGridView1.Rows[indice].Cells[0].Value = txtNombres.Text;
                    dataGridView1.Rows[indice].Cells[1].Value = txtApellidos.Text;
                    dataGridView1.Rows[indice].Cells[2].Value = txtGrado.Text;
                    dataGridView1.Rows[indice].Cells[3].Value = txtSeccion.Text;
                    dataGridView1.Rows[indice].Cells[4].Value = txtClave.Text;
                    dataGridView1.Rows[indice].Cells[5].Value = txtPromo.Text;
                    dataGridView1.Rows[indice].Cells[6].Value = txtMatri.Text;
                    dataGridView1.Rows[indice].Cells[7].Value = txtCiclo.Text;
                    dataGridView1.Rows[indice].Cells[8].Value = txtNum.Text;
                    dataGridView1.Rows[indice].Cells[9].Value = txtMail.Text;
                    dataGridView1.Rows[indice].Cells[10].Value = txtEnca.Text;
                    MessageBox.Show("Datos Modificados", "Secretaria Colegio Don Bosco", MessageBoxButtons.OK,
                MessageBoxIcon.Information); //avisar que se han agregado los datos
                }
            }
            catch (Exception) //si existiera algun error hacer lo siguiente
            {
                MessageBox.Show("No hay datos", "Secretaria Colegio Don Bosco", MessageBoxButtons.OK,
                MessageBoxIcon.Error); //avisar que no hay datos
                throw; //solo realizara eso
            }
            limpiar(); //se limpiaran los textbox
        }

        private void btnEliminar_Click(object sender, EventArgs e) //btn eliminar datos
        {
            try //metodo para probar y si es correcto se ejecuta
            {
                if (seleccionFila >= 0) //si no hay seleccion de fila
                    dataGridView1.Rows.RemoveAt(seleccionFila); //la tabla eliminara la fila
                else //caso contrario
                    MessageBox.Show("No hay datos", "Secretaria Colegio Don Bosco", MessageBoxButtons.OK,
                MessageBoxIcon.Error); //avisar que no hay datos
                limpiar(); //se limpiaran los textbox
            }
            catch (Exception) //si existiera algun error hacer lo siguiente
            {
                MessageBox.Show("No hay datos seleccionados", "Secretaria Colegio Don Bosco", MessageBoxButtons.OK,
                MessageBoxIcon.Error); //avisar que no hay datos para eliminar
                limpiar(); //se limpiaran los textbox
                throw; //solo realizara eso
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e) //click de celda
        {
            if (e.RowIndex >= 0) { //si la fila es 0
                DataGridViewRow fila = dataGridView1.Rows[e.RowIndex];

                txtNombres.Text = fila.Cells[0].Value.ToString(); //se seleccionaran todos los textbox
                txtApellidos.Text = fila.Cells[1].Value.ToString(); //para poder editarlos
                txtGrado.Text = fila.Cells[2].Value.ToString();
                txtSeccion.Text = fila.Cells[3].Value.ToString();
                txtClave.Text = fila.Cells[4].Value.ToString();
                txtPromo.Text = fila.Cells[5].Value.ToString();
                txtMatri.Text = fila.Cells[6].Value.ToString();
                txtCiclo.Text = fila.Cells[7].Value.ToString();
                txtNum.Text = fila.Cells[8].Value.ToString();
                txtMail.Text = fila.Cells[9].Value.ToString();
                txtEnca.Text = fila.Cells[10].Value.ToString();
            }      
        }
    }
} 
