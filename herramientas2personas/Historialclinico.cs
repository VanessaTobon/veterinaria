using MySql.Data.MySqlClient;
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

namespace herramientas2personas
{
    public partial class Historialclinico : Form
    {
        List<HistoriaClinica> ListaHistoriaClinica;

        string servidor = "localhost";
        string usuario = "root";
        string password = "";
        string baseDatos = "so";

        ArchivoPlanoHistoria archivo;

        int sel;

        public Citas CitasFormulario { get; private set; }
        public Historialclinico(Citas citas)
        {
            InitializeComponent();

            ListaHistoriaClinica = new List<HistoriaClinica>();

            string RutaProyecto = @"C:\Users\vanes\source";
            string NombreArchivo = "archivoHistoriaclinica.txt";

            string RutaCompleta = Path.Combine(RutaProyecto, NombreArchivo);
            archivo = new ArchivoPlanoHistoria(RutaCompleta);
            ListaHistoriaClinica = archivo.CargarDesdeArchivo();
            ActualizarDataGridView();

            // Llama a los métodos para cargar los datos en los ComboBox
            CargarAnimalesDesdeBD();

            dataHistoriaClinica.CellEndEdit += dataHistoriaClinica_CellEndEdit;

        }

        private void btn_crearregistro2_Click(object sender, EventArgs e)
        {
            // Validación de campos vacíos antes de guardar
            if (String.IsNullOrEmpty(txt_codigo.Text) ||
                comboBox1.SelectedItem == null ||
                String.IsNullOrEmpty(txt_enfermedadesanteriores.Text) ||
                String.IsNullOrEmpty(txt_fechaenfermedad.Text) ||
                String.IsNullOrEmpty(txt_fechavacuna.Text) ||
                String.IsNullOrEmpty(txt_enfermedadvacunada.Text))
            {
                MessageBox.Show("No se puede ingresar campos vacíos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Agregar nuevo registro a la lista
            ListaHistoriaClinica.Add(new HistoriaClinica(
                txt_codigo.Text,
                comboBox1.SelectedItem.ToString(),
                txt_enfermedadesanteriores.Text,
                txt_fechaenfermedad.Text,
                txt_fechavacuna.Text,
                txt_enfermedadvacunada.Text
            ));

            // Guardar en archivo plano
            archivo.GuardarEnArchivo(ListaHistoriaClinica);

            // Limpiar campos después de guardar
            txt_codigo.Text = "";
            comboBox1.SelectedIndex = -1;
            txt_enfermedadesanteriores.Text = "";
            txt_fechaenfermedad.Text = "";
            txt_fechavacuna.Text = "";
            txt_enfermedadvacunada.Text = "";

            ActualizarDataGridView();

            // Guardar en la base de datos solo si hay registros en la lista
            if (ListaHistoriaClinica.Any())
            {
                ConexionMySQL conexion = new ConexionMySQL(servidor, usuario, password, baseDatos);
                UsuarioDAO usuarioDAO = new UsuarioDAO(conexion);

                try
                {
                    // Guardar el último registro en la base de datos
                    HistoriaClinica ultimoRegistro = ListaHistoriaClinica.Last();
                    usuarioDAO.GuardarHistoria(ListaHistoriaClinica);
                    MessageBox.Show("Datos guardados en la base de datos correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al guardar los datos en la base de datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    // Cerrar la conexión si está abierta
                    if (conexion != null)
                    {
                        conexion.CerrarConexion();
                    }
                }
            }
        }

        private void btn_eliminarregistro2_Click(object sender, EventArgs e)
        {
            if (sel != -1 && dataHistoriaClinica.SelectedRows.Count > 0)
            {
                sel = dataHistoriaClinica.SelectedRows[0].Index;

                dataHistoriaClinica.Rows.RemoveAt(sel);
            }
            else
            {
                MessageBox.Show("Usted esta seguro de eliminar el registro", "Fue eliminado con exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataHistoriaClinica.Rows.RemoveAt(sel);
            }
            if (sel < ListaHistoriaClinica.Count)
            {
                ListaHistoriaClinica.RemoveAt(sel);
                archivo.GuardarEnArchivo(ListaHistoriaClinica);
            }
        }

        private void ActualizarDataGridView()
        {
            dataHistoriaClinica.Rows.Clear();

            foreach (HistoriaClinica historiaClinica in ListaHistoriaClinica)
            {
                int n = dataHistoriaClinica.Rows.Add();
                dataHistoriaClinica.Rows[n].Cells[0].Value = historiaClinica.Codigo;
                dataHistoriaClinica.Rows[n].Cells[1].Value = historiaClinica.Codigomascota;
                dataHistoriaClinica.Rows[n].Cells[2].Value = historiaClinica.Enfermedadesanteriores;
                dataHistoriaClinica.Rows[n].Cells[3].Value = historiaClinica.Fechaenfermedad;
                dataHistoriaClinica.Rows[n].Cells[4].Value = historiaClinica.Fechavacuna;
                dataHistoriaClinica.Rows[n].Cells[5].Value = historiaClinica.Enfermedadvacunada;
            }
        }

        public void ActualizarHistoria(HistoriaClinica historia)
        {
            dataHistoriaClinica.Rows.Clear();

            foreach (HistoriaClinica historiaClinica in ListaHistoriaClinica)
            {
                int n = dataHistoriaClinica.Rows.Add();
                dataHistoriaClinica.Rows[n].Cells[0].Value = historiaClinica.Codigo;
                dataHistoriaClinica.Rows[n].Cells[1].Value = historiaClinica.Codigomascota;
                dataHistoriaClinica.Rows[n].Cells[2].Value = historiaClinica.Enfermedadesanteriores;
                dataHistoriaClinica.Rows[n].Cells[3].Value = historiaClinica.Fechaenfermedad;
                dataHistoriaClinica.Rows[n].Cells[4].Value = historiaClinica.Fechavacuna;
                dataHistoriaClinica.Rows[n].Cells[5].Value = historiaClinica.Enfermedadvacunada;
            }
        }

        private void dataHistoriaClinica_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = e.RowIndex;

            // Validar que la fila y columna sean válidas
            if (fila >= 0 && fila < ListaHistoriaClinica.Count)
            {
                try
                {
                    // Validar que los campos no sean nulos o vacíos
                    for (int col = 0; col < dataHistoriaClinica.ColumnCount; col++)
                    {
                        if (string.IsNullOrEmpty(dataHistoriaClinica.Rows[fila].Cells[col].Value?.ToString()))
                        {
                            MessageBox.Show("Los campos no pueden estar vacíos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    // Actualizar la lista con los datos editados en el DataGridView
                    ListaHistoriaClinica[fila].Codigo = dataHistoriaClinica.Rows[fila].Cells[0].Value.ToString();
                    ListaHistoriaClinica[fila].Codigomascota = dataHistoriaClinica.Rows[fila].Cells[1].Value.ToString();
                    ListaHistoriaClinica[fila].Enfermedadesanteriores = dataHistoriaClinica.Rows[fila].Cells[2].Value.ToString();
                    ListaHistoriaClinica[fila].Fechaenfermedad = dataHistoriaClinica.Rows[fila].Cells[3].Value.ToString();
                    ListaHistoriaClinica[fila].Fechavacuna = dataHistoriaClinica.Rows[fila].Cells[4].Value.ToString();
                    ListaHistoriaClinica[fila].Enfermedadvacunada = dataHistoriaClinica.Rows[fila].Cells[5].Value.ToString();

                    // Guardar cambios en el archivo plano
                    archivo.GuardarEnArchivo(ListaHistoriaClinica);

                    // Actualizar la base de datos
                    ConexionMySQL conexion = new ConexionMySQL(servidor, usuario, password, baseDatos);
                    UsuarioDAO usuarioDAO = new UsuarioDAO(conexion);
                    usuarioDAO.ActualizarHistoria(ListaHistoriaClinica[fila]);

                    MessageBox.Show("Registro actualizado correctamente en la base de datos y archivo.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al actualizar el registro: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnelimarbd2_Click(object sender, EventArgs e)
        {
            // Crear una instancia de la clase ConexionMySQL
            ConexionMySQL conexion = new ConexionMySQL(servidor, usuario, password, baseDatos);
            UsuarioDAO usuarioDAO = new UsuarioDAO(conexion);

            try
            {

                // Obtener el documento del usuario que deseas eliminar
                string codigo = txt_codigo.Text;
                string codigo1 = dataHistoriaClinica.Rows[sel].Cells[0].Value.ToString(); ;


                // Llamar al método EliminarUsuario de UsuarioDAO para eliminar el usuario de la base de datos
                usuarioDAO.EliminarHistoria(codigo); usuarioDAO.EliminarHistoria(codigo1);

                // Mostrar un mensaje de éxito
                MessageBox.Show("Historia eliminada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Mostrar un mensaje de error si ocurre algún problema durante la eliminación del usuario
                MessageBox.Show($"Error al eliminar historia: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CargarAnimalesDesdeBD()
        {
            ConexionMySQL conexion = new ConexionMySQL(servidor, usuario, password, baseDatos);
            UsuarioDAO usuarioDAO = new UsuarioDAO(conexion);

            try
            {
                List<Animal> animales = usuarioDAO.BuscarAnimales();

                // Limpiar el ComboBox antes de agregar los nuevos elementos
                comboBox1.Items.Clear();

                // Agregar los códigos de los animales al ComboBox
                foreach (Animal animal in animales)
                {
                    comboBox1.Items.Add(animal.codigo);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los animales desde la base de datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void text_enfermedadesanteriores_TextChanged(object sender, EventArgs e)
        {
            //
        }

        private void comboBoxcodigo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //
        }

        private void txt_codigo_TextChanged(object sender, EventArgs e)
        {
            //
        }

        private void Historialclinico_Load(object sender, EventArgs e)
        {
            //
        }

        private void txt_fechaenfermedad_TextChanged(object sender, EventArgs e)
        {
            //
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //
        }

        private void dataHistoriaClinica_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int fila = e.RowIndex;

            // Verifica que la fila esté dentro del rango válido de la lista
            if (fila >= 0 && fila < ListaHistoriaClinica.Count)
            {
                try
                {
                    // Actualiza el objeto HistoriaClinica con los valores editados en el DataGridView
                    ListaHistoriaClinica[fila].Codigo = dataHistoriaClinica.Rows[fila].Cells[0].Value?.ToString();
                    ListaHistoriaClinica[fila].Codigomascota = dataHistoriaClinica.Rows[fila].Cells[1].Value?.ToString();
                    ListaHistoriaClinica[fila].Enfermedadesanteriores = dataHistoriaClinica.Rows[fila].Cells[2].Value?.ToString();
                    ListaHistoriaClinica[fila].Fechaenfermedad = dataHistoriaClinica.Rows[fila].Cells[3].Value?.ToString();
                    ListaHistoriaClinica[fila].Fechavacuna = dataHistoriaClinica.Rows[fila].Cells[4].Value?.ToString();
                    ListaHistoriaClinica[fila].Enfermedadvacunada = dataHistoriaClinica.Rows[fila].Cells[5].Value?.ToString();

                    // Guarda los cambios en el archivo plano
                    archivo.GuardarEnArchivo(ListaHistoriaClinica);

                    // Guarda los cambios en la base de datos
                    ConexionMySQL conexion = new ConexionMySQL(servidor, usuario, password, baseDatos);
                    UsuarioDAO usuarioDAO = new UsuarioDAO(conexion);
                    usuarioDAO.ActualizarHistoria(ListaHistoriaClinica[fila]);

                    MessageBox.Show("Registro actualizado correctamente en la base de datos y archivo.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al actualizar el registro: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ActualizarHistoriaEnLista(int fila)
        {
            // Asigna los valores actuales de las celdas del DataGridView a la lista de historia
            ListaHistoriaClinica[fila].Codigo = dataHistoriaClinica.Rows[fila].Cells[0].Value?.ToString();
            ListaHistoriaClinica[fila].Codigomascota = dataHistoriaClinica.Rows[fila].Cells[1].Value?.ToString();
            ListaHistoriaClinica[fila].Enfermedadesanteriores = dataHistoriaClinica.Rows[fila].Cells[2].Value?.ToString();
            ListaHistoriaClinica[fila].Fechaenfermedad = dataHistoriaClinica.Rows[fila].Cells[3].Value?.ToString();
            ListaHistoriaClinica[fila].Fechavacuna = dataHistoriaClinica.Rows[fila].Cells[4].Value?.ToString();
            ListaHistoriaClinica[fila].Enfermedadvacunada = dataHistoriaClinica.Rows[fila].Cells[5].Value?.ToString();
        }

        private void lbltitulo_Click(object sender, EventArgs e)
        {
            //
        }
    }
}
