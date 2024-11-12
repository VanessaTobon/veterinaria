using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Mysqlx.Crud.Order.Types;
using System.Xml.Linq;

namespace herramientas2personas
{
    public partial class Animales : Form
    {
        List<Animal> ListaAnimal = new List<Animal>();


        string servidor = "localhost";
        string usuario = "root";
        string password = "";
        string baseDatos = "so";

        Archivoplanoanimal archivo;

        int sel;

        public Form1 Form1 { get; private set; }

        public Animales(Form1 form1)
        {
            InitializeComponent();

            string RutaProyecto = @"C:\Users\vanes\source";
            string NombreArchivo = "archivoAnimales.txt";

            string RutaCompleta = Path.Combine(RutaProyecto, NombreArchivo);
            archivo = new Archivoplanoanimal(RutaCompleta);
            ListaAnimal = archivo.CargarDesdeArchivo();
            ActualizarDataGridView();

            dataAnimales.CellEndEdit += dataAnimales_CellEndEdit;
            this.Form1 = Form1;

        }

        private void Animal_Load(object sender, EventArgs e)
        {
            //
        }

        private void dataAnimales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            sel = e.RowIndex;

            if (sel != -1 && (dataAnimales.Rows[sel].Cells[0] != null && dataAnimales.Rows[sel].Cells[0].Value != null))
            {
                string codigo = dataAnimales.Rows[sel].Cells[0].Value.ToString();
                string colorpelo = dataAnimales.Rows[sel].Cells[1].Value.ToString();
                string nombre = dataAnimales.Rows[sel].Cells[2].Value.ToString();
                string fechanacimiento = dataAnimales.Rows[sel].Cells[3].Value.ToString();
                string especie = dataAnimales.Rows[sel].Cells[4].Value.ToString();
                string raza = dataAnimales.Rows[sel].Cells[5].Value.ToString();
                string pesoanterior = dataAnimales.Rows[sel].Cells[6].Value.ToString();
                string peso = dataAnimales.Rows[sel].Cells[7].Value.ToString();

                label3.Text = "codigo: " + codigo + " colorpelo: " + colorpelo + " nombre: " + nombre + " fechanacimiento: " + fechanacimiento + " especie: " + especie + " raza: " + raza + " pesoanterior: " + pesoanterior + " peso: " + peso;
            }
        }

        private void btn_eliminarregistro1_Click(object sender, EventArgs e)
        {
            if (sel != -1 && dataAnimales.SelectedRows.Count > 0)
            {
                sel = dataAnimales.SelectedRows[0].Index;

                dataAnimales.Rows.RemoveAt(sel);
            }
            else
            {
                MessageBox.Show("Usted esta seguro de eliminar el registro", "Fue eliminado con exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataAnimales.Rows.RemoveAt(sel);
            }
            if (sel < ListaAnimal.Count)
            {
                ListaAnimal.RemoveAt(sel);
                archivo.GuardarEnArchivo(ListaAnimal);
            }
        }

        private void btn_crearregistro1_Click(object sender, EventArgs e)
        {

            // Verificar si hay algún campo vacío
            if (string.IsNullOrWhiteSpace(txt_codigo.Text) ||
                string.IsNullOrWhiteSpace(txt_colordepelo.Text) ||
                string.IsNullOrWhiteSpace(txt_nombre1.Text) ||
                string.IsNullOrWhiteSpace(txt_nacimiento.Text) ||
                string.IsNullOrWhiteSpace(txt_especie.Text) ||
                string.IsNullOrWhiteSpace(txt_raza.Text) ||
                string.IsNullOrWhiteSpace(txt_pesoanterior.Text) ||
                string.IsNullOrWhiteSpace(txt_pesoactual.Text))
            {
                MessageBox.Show("No se puede ingresar campos vacíos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Salir del método si hay campos vacíos
            }

            // Si todos los campos están llenos, proceder a agregar el registro
            try
            {
                // Agregar el nuevo animal a la lista
                ListaAnimal.Add(new Animal(
                    txt_codigo.Text,
                    txt_nombre1.Text,
                    txt_nacimiento.Text,
                    txt_colordepelo.Text,
                    txt_especie.Text,
                    txt_raza.Text,
                    txt_pesoanterior.Text,
                    txt_pesoactual.Text));

                // Guardar en el archivo plano
                archivo.GuardarEnArchivo(ListaAnimal);

                // Limpiar los campos de entrada
                LimpiarCampos();

                // Actualizar el DataGridView
                ActualizarDataGridView();

                // Crear una instancia de la conexión a la base de datos
                ConexionMySQL conexion = new ConexionMySQL(servidor, usuario, password, baseDatos);
                UsuarioDAO usuarioDAO = new UsuarioDAO(conexion);

                // Guardar los elementos en la base de datos utilizando UsuarioDAO
                usuarioDAO.GuardarAnimal(ListaAnimal);

                // Mostrar mensaje de éxito
                MessageBox.Show("Datos guardados en la base de datos correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Mostrar mensaje de error si ocurre algún problema
                MessageBox.Show($"Error al guardar los datos en la base de datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCampos()
        {
            txt_codigo.Text = "";
            txt_nombre1.Text = "";
            txt_nacimiento.Text = "";
            txt_colordepelo.Text = "";
            txt_especie.Text = "";
            txt_raza.Text = "";
            txt_pesoanterior.Text = "";
            txt_pesoactual.Text = "";
        }

        private void ActualizarDataGridView()
        {
            dataAnimales.Rows.Clear();

            foreach (Animal animal in ListaAnimal)
            {

                int n = dataAnimales.Rows.Add();
                dataAnimales.Rows[n].Cells[0].Value = animal.codigo;
                dataAnimales.Rows[n].Cells[1].Value = animal.colorpelo;
                dataAnimales.Rows[n].Cells[2].Value = animal.nombre;
                dataAnimales.Rows[n].Cells[3].Value = animal.fechanacimiento;
                dataAnimales.Rows[n].Cells[4].Value = animal.especie;
                dataAnimales.Rows[n].Cells[5].Value = animal.raza;
                dataAnimales.Rows[n].Cells[6].Value = animal.pesoanterior;
                dataAnimales.Rows[n].Cells[7].Value = animal.peso;
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnelimarbd1_Click(object sender, EventArgs e)
        {
            // Crear una instancia de la clase ConexionMySQL
            ConexionMySQL conexion = new ConexionMySQL(servidor, usuario, password, baseDatos);
            UsuarioDAO usuarioDAO = new UsuarioDAO(conexion);

            try
            {

                // Obtener el documento del usuario que deseas eliminar
                string codigo = txt_codigo.Text;
                string codigo1 = dataAnimales.Rows[sel].Cells[0].Value.ToString(); ;


                // Llamar al método EliminarUsuario de UsuarioDAO para eliminar el usuario de la base de datos
                usuarioDAO.EliminarAnimal(codigo); usuarioDAO.EliminarAnimal(codigo1);

                // Mostrar un mensaje de éxito
                MessageBox.Show("Animal eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Mostrar un mensaje de error si ocurre algún problema durante la eliminación del usuario
                MessageBox.Show($"Error al eliminar animal: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnsiguiente_Click(object sender, EventArgs e)
        {
            Citas citas = new Citas(this);
            citas.Show();
        }

        private void txt_codigo_TextChanged(object sender, EventArgs e)
        {
            //
        }

        private void ActualizarAnimalEnLista(Animal animalActualizado)
        {
            int indice = ListaAnimal.FindIndex(a => a.codigo == animalActualizado.codigo);

            if (indice != -1)
            {
                ListaAnimal[indice] = animalActualizado;
            }
        }


        private void dataAnimales_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int fila = e.RowIndex;

            if (fila != -1 && fila < ListaAnimal.Count)
            {
                try
                {
                    ConexionMySQL conexion = new ConexionMySQL(servidor, usuario, password, baseDatos);
                    UsuarioDAO usuarioDAO = new UsuarioDAO(conexion);

                    // Obtener los datos actualizados del DataGridView
                    string codigo = dataAnimales.Rows[fila].Cells[0].Value?.ToString();
                    string colorpelo = dataAnimales.Rows[fila].Cells[1].Value?.ToString();
                    string nombre = dataAnimales.Rows[fila].Cells[2].Value?.ToString();
                    string fechanacimiento = dataAnimales.Rows[fila].Cells[3].Value?.ToString();
                    string especie = dataAnimales.Rows[fila].Cells[4].Value?.ToString();
                    string raza = dataAnimales.Rows[fila].Cells[5].Value?.ToString();
                    string pesoanterior = dataAnimales.Rows[fila].Cells[6].Value?.ToString();
                    string peso = dataAnimales.Rows[fila].Cells[7].Value?.ToString();

                    Animal animalActualizado = new Animal(codigo, nombre, fechanacimiento, colorpelo, especie, raza, pesoanterior, peso);

                    // Actualizar en la lista, base de datos y archivo
                    ActualizarAnimalEnLista(animalActualizado);
                    usuarioDAO.ActualizarAnimal(animalActualizado);
                    archivo.GuardarEnArchivo(ListaAnimal);

                    MessageBox.Show("Registro actualizado correctamente en la base de datos y archivo.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al actualizar el animal: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


    }
}
