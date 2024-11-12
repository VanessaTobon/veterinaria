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
    public partial class Form1 : Form
    {
        ArchivoPlano archivo;

        string servidor = "localhost";
        string usuario = "root";
        string password = "";
        string baseDatos = "so";

        int sel = 0;
        List<Usuario> ListaUsuarios;

        public Form1()
        {
            InitializeComponent();

            // Inicializar la lista de usuarios
            ListaUsuarios = new List<Usuario>();

            // Cargar datos desde el archivo al iniciar el formulario
            string RutaProyecto = @"C:\Users\vanes\source";
            string NombreArchivo = "archivo.txt";
            string RutaCompleta = Path.Combine(RutaProyecto, NombreArchivo);
            archivo = new ArchivoPlano(RutaCompleta);
            ListaUsuarios = archivo.CargarDesdeArchivo();
            ActualizarDataGridView();

            dataPersonas.CellEndEdit += dataPersonas_CellEndEdit;

        }

        private void label2_Click(object sender, EventArgs e)
        {
            //
        }

        private void btn_crearregistro_Click(object sender, EventArgs e)
        {
            // Verificación de campos vacíos
            if (String.IsNullOrEmpty(txt_documento.Text) ||
                String.IsNullOrEmpty(txt_nombres.Text) ||
                String.IsNullOrEmpty(txt_apellidos.Text) ||
                String.IsNullOrEmpty(txt_telefono.Text) ||
                String.IsNullOrEmpty(txt_direccion.Text))
            {
                MessageBox.Show("No se puede ingresar campos vacíos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Sale del método si hay campos vacíos
            }

            // Agregar usuario a la lista
            Usuario nuevoUsuario = new Usuario(
                txt_documento.Text,
                txt_nombres.Text,
                txt_apellidos.Text,
                txt_telefono.Text,
                txt_direccion.Text
            );
            ListaUsuarios.Add(nuevoUsuario);

            // Guardar lista actualizada en el archivo
            archivo.GuardarEnArchivo(ListaUsuarios);

            // Limpiar campos
            LimpiarCampos();

            // Actualizar DataGridView
            ActualizarDataGridView();

            MessageBox.Show("Persona agregada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Intento de guardar en la base de datos
            GuardarEnBaseDeDatos();
        }

        private void LimpiarCampos()
        {
            txt_documento.Text = "";
            txt_nombres.Text = "";
            txt_apellidos.Text = "";
            txt_telefono.Text = "";
            txt_direccion.Text = "";
        }

        private void GuardarEnBaseDeDatos()
        {
            // Crear instancia de conexión a la base de datos
            ConexionMySQL conexion = new ConexionMySQL(servidor, usuario, password, baseDatos);
            UsuarioDAO usuarioDAO = new UsuarioDAO(conexion);

            try
            {
                // Guardar los elementos en la base de datos
                usuarioDAO.GuardarUsuarios(ListaUsuarios);
                MessageBox.Show("Datos guardados en la base de datos correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Mostrar mensaje de error si la operación falló
                MessageBox.Show($"Error al guardar los datos en la base de datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void ActualizarDataGridView()
        {
            dataPersonas.Rows.Clear();

            foreach (Usuario usuario in ListaUsuarios)
            {

                int n = dataPersonas.Rows.Add();
                dataPersonas.Rows[n].Cells[0].Value = usuario.Documento;
                dataPersonas.Rows[n].Cells[1].Value = usuario.Nombres;
                dataPersonas.Rows[n].Cells[2].Value = usuario.Apellidos;
                dataPersonas.Rows[n].Cells[3].Value = usuario.Telefono;
                dataPersonas.Rows[n].Cells[4].Value = usuario.Direccion;

            }

        }

        private void dataPersonas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            sel = e.RowIndex;

            if (sel != -1 && (dataPersonas.Rows[sel].Cells[0] != null && dataPersonas.Rows[sel].Cells[0].Value != null))
            {
                string Documento = dataPersonas.Rows[sel].Cells[0].Value.ToString();
                string Nombres = dataPersonas.Rows[sel].Cells[1].Value.ToString();
                string Apellidos = dataPersonas.Rows[sel].Cells[2].Value.ToString();
                string Telefono = dataPersonas.Rows[sel].Cells[3].Value.ToString();
                string Direccion = dataPersonas.Rows[sel].Cells[4].Value.ToString();

                label3.Text = "Documento: " + Documento + " Nombres: " + Nombres + " Apellidos: " + Apellidos + " Telefono: " + Telefono + " Direccion: " + Direccion;
            }
        }

        private void btn_eliminarregistro_Click(object sender, EventArgs e)
        {

            if (sel != -1 && dataPersonas.SelectedRows.Count > 0)
            {
                sel = dataPersonas.SelectedRows[0].Index;

                dataPersonas.Rows.RemoveAt(sel);
            }
            else
            {
                MessageBox.Show("Usted esta seguro de eliminar el registro", "Fue eliminado con exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataPersonas.Rows.RemoveAt(sel);
            }
            if (sel < ListaUsuarios.Count)
            {
                ListaUsuarios.RemoveAt(sel);
                archivo.GuardarEnArchivo(ListaUsuarios);
            }

        }

        private void txt_nombres_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_documento_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_documento_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //
        }

        private void btnmostar_Click(object sender, EventArgs e)
        {
            foreach (Usuario dato in ListaUsuarios)
            {
                string x = dato.ToString();
                MessageBox.Show(x, "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btnelimarbd_Click(object sender, EventArgs e)
        {
            // Crear una instancia de la clase ConexionMySQL
            ConexionMySQL conexion = new ConexionMySQL(servidor, usuario, password, baseDatos);
            UsuarioDAO usuarioDAO = new UsuarioDAO(conexion);

            try
            {

                // Obtener el documento del usuario que deseas eliminar
                string documento = txt_documento.Text;
                string documento1 = dataPersonas.Rows[sel].Cells[0].Value.ToString(); ;


                // Llamar al método EliminarUsuario de UsuarioDAO para eliminar el usuario de la base de datos
                usuarioDAO.EliminarUsuario(documento); usuarioDAO.EliminarUsuario(documento1);

                // Mostrar un mensaje de éxito
                MessageBox.Show("Usuario eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Mostrar un mensaje de error si ocurre algún problema durante la eliminación del usuario
                MessageBox.Show($"Error al eliminar usuario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {
            //
        }

        private void btnsiguiente_Click(object sender, EventArgs e)
        {
            Animales Animales = new Animales(this);
            Animales.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            //
        }

        private void ActualizarUsuarioEnLista(Usuario usuarioActualizado)
        {
            // Buscar el índice del usuario en la lista basado en el documento
            int indice = ListaUsuarios.FindIndex(u => u.Documento == usuarioActualizado.Documento);

            if (indice != -1)
            {
                // Actualizar la lista con el nuevo objeto Usuario
                ListaUsuarios[indice] = usuarioActualizado;
            }
        }

        private void dataPersonas_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // Obtener el índice de la fila y la columna editada
            int fila = e.RowIndex;
            int columna = e.ColumnIndex;

            if (fila != -1)
            {
                try
                {
                    // Crear instancia de conexión a la base de datos
                    ConexionMySQL conexion = new ConexionMySQL(servidor, usuario, password, baseDatos);
                    UsuarioDAO usuarioDAO = new UsuarioDAO(conexion);

                    // Obtener los datos actualizados del DataGridView
                    string documento = dataPersonas.Rows[fila].Cells[0].Value?.ToString();
                    string nombres = dataPersonas.Rows[fila].Cells[1].Value?.ToString();
                    string apellidos = dataPersonas.Rows[fila].Cells[2].Value?.ToString();
                    string telefono = dataPersonas.Rows[fila].Cells[3].Value?.ToString();
                    string direccion = dataPersonas.Rows[fila].Cells[4].Value?.ToString();

                    // Crear un nuevo objeto Usuario con los datos actualizados
                    Usuario usuarioActualizado = new Usuario(documento, nombres, apellidos, telefono, direccion);

                    // Actualizar en la base de datos
                    usuarioDAO.ActualizarUsuario(usuarioActualizado);

                    // Actualizar en la lista y guardar en el archivo
                    ActualizarUsuarioEnLista(usuarioActualizado);
                    archivo.GuardarEnArchivo(ListaUsuarios);

                    MessageBox.Show("Registro actualizado correctamente en la base de datos y archivo.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al actualizar el usuario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
