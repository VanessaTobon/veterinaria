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
    public partial class Citas : Form
    {
        List<Gestioncitas> ListaGestioncitas = new List<Gestioncitas>();


        string servidor = "localhost";
        string usuario = "root";
        string password = "";
        string baseDatos = "so";

        ArchivoPlanocitas archivo;

        int sel;

        public Animales Animales { get; private set; }

        public Citas(Animales animales)
        {
            InitializeComponent();

            string RutaProyecto = @"C:\Users\vanes\source";
            string NombreArchivo = "archivoCitas.txt";

            string RutaCompleta = Path.Combine(RutaProyecto, NombreArchivo);
            archivo = new ArchivoPlanocitas(RutaCompleta);
            ListaGestioncitas = archivo.CargarDesdeArchivo();
            ActualizarDataGridView();

            this.Animales = Animales;

            // Llama a los métodos para cargar los datos en los ComboBox
            CargarAnimalesDesdeBD();
            CargarUsuariosDesdeBD();

            dataCita.CellEndEdit += dataCita_CellEndEdit;

        }

        private void btn_crearregistro2_Click(object sender, EventArgs e)
        {
            // Validar que no haya campos vacíos
            if (string.IsNullOrWhiteSpace(txt_codigo.Text) ||
                comboBoxcodigo.SelectedItem == null ||
                comboBoxdocumento.SelectedItem == null ||
                string.IsNullOrWhiteSpace(txt_hora.Text) ||
                string.IsNullOrWhiteSpace(txt_sede.Text))
            {
                MessageBox.Show("No se pueden ingresar campos vacíos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Salir del método si hay campos vacíos
            }

            try
            {
                // Obtener la fecha seleccionada del calendario
                DateTime selectedDate = monthCalendar1.SelectionRange.Start.Date;

                // Agregar el nuevo registro a la lista
                ListaGestioncitas.Add(new Gestioncitas(
                    txt_codigo.Text,
                    comboBoxcodigo.SelectedItem.ToString(),
                    comboBoxdocumento.SelectedItem.ToString(),
                    selectedDate.ToString("yyyy-MM-dd"), // Guardar la fecha en un formato estandarizado
                    txt_hora.Text,
                    txt_sede.Text
                ));

                // Guardar en el archivo plano
                archivo.GuardarEnArchivo(ListaGestioncitas);

                // Limpiar los campos
                LimpiarCampos();

                // Actualizar DataGridView
                ActualizarDataGridView();

                // Guardar en la base de datos
                ConexionMySQL conexion = new ConexionMySQL(servidor, usuario, password, baseDatos);
                UsuarioDAO usuarioDAO = new UsuarioDAO(conexion);
                usuarioDAO.GuardarCita(ListaGestioncitas);

                // Mensaje de éxito
                MessageBox.Show("Datos guardados en la base de datos correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCampos()
        {
            txt_codigo.Text = "";
            comboBoxcodigo.SelectedIndex = -1;
            comboBoxdocumento.SelectedIndex = -1;
            txt_hora.Text = "";
            txt_sede.Text = "";
        }

        private void dataCita_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            sel = e.RowIndex;

            if (sel != -1 && (dataCita.Rows[sel].Cells[0] != null && dataCita.Rows[sel].Cells[0].Value != null))
            {
                string Codigo = dataCita.Rows[sel].Cells[0].Value.ToString();
                string Codigomascota = dataCita.Rows[sel].Cells[1].Value.ToString();
                string Documentousuario = dataCita.Rows[sel].Cells[2].Value.ToString();
                string Fechacita = dataCita.Rows[sel].Cells[3].Value.ToString();
                string Hora = dataCita.Rows[sel].Cells[4].Value.ToString();
                string Sede = dataCita.Rows[sel].Cells[5].Value.ToString();

                label3.Text = "codigo: " + Codigo + " Codigo mascota: " + Codigomascota + " Documento usuario: " + Documentousuario + " Fecha cita: " + Fechacita + " Hora: " + Hora + " Sede: " + Sede;
            }
        }
        private void btn_eliminarregistro1_Click(object sender, EventArgs e)
        {
            if (sel != -1 && dataCita.SelectedRows.Count > 0)
            {
                sel = dataCita.SelectedRows[0].Index;

                dataCita.Rows.RemoveAt(sel);
            }
            else
            {
                MessageBox.Show("Usted esta seguro de eliminar el registro", "Fue eliminado con exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataCita.Rows.RemoveAt(sel);
            }
            if (sel < ListaGestioncitas.Count)
            {
                ListaGestioncitas.RemoveAt(sel);
                archivo.GuardarEnArchivo(ListaGestioncitas);
            }
        }

        private void ActualizarDataGridView()
        {
            dataCita.Rows.Clear();

            foreach (Gestioncitas Gestioncitas in ListaGestioncitas)
            {

                int n = dataCita.Rows.Add();
                dataCita.Rows[n].Cells[0].Value = Gestioncitas.Codigo;
                dataCita.Rows[n].Cells[1].Value = Gestioncitas.Codigomascota;
                dataCita.Rows[n].Cells[2].Value = Gestioncitas.Documentousuario;
                dataCita.Rows[n].Cells[3].Value = Gestioncitas.Fechacita;
                dataCita.Rows[n].Cells[4].Value = Gestioncitas.Hora;
                dataCita.Rows[n].Cells[5].Value = Gestioncitas.Sede;
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
                string codigo1 = dataCita.Rows[sel].Cells[0].Value.ToString(); ;


                // Llamar al método EliminarUsuario de UsuarioDAO para eliminar el usuario de la base de datos
                usuarioDAO.EliminarCita(codigo); usuarioDAO.EliminarCita(codigo1);

                // Mostrar un mensaje de éxito
                MessageBox.Show("Cita eliminada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Mostrar un mensaje de error si ocurre algún problema durante la eliminación del usuario
                MessageBox.Show($"Error al eliminar cita: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                comboBoxcodigo.Items.Clear();

                // Agregar los códigos de los animales al ComboBox
                foreach (Animal animal in animales)
                {
                    comboBoxcodigo.Items.Add(animal.codigo);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los animales desde la base de datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarUsuariosDesdeBD()
        {
            ConexionMySQL conexion = new ConexionMySQL(servidor, usuario, password, baseDatos);
            UsuarioDAO usuarioDAO = new UsuarioDAO(conexion);

            try
            {
                // Llamar al método BuscarUsuarios para obtener la lista de usuarios desde la base de datos
                List<Usuario> usuarios = usuarioDAO.BuscarUsuarios();

                // Limpiar el ComboBox antes de agregar los nuevos elementos
                comboBoxdocumento.Items.Clear();

                // Agregar los nombres de los usuarios al ComboBox
                foreach (Usuario usuario in usuarios)
                {
                    comboBoxdocumento.Items.Add(usuario.Documento);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los usuarios desde la base de datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void lblcolordepelo_Click(object sender, EventArgs e)
        {
            //
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime selectedDate = monthCalendar1.SelectionRange.Start.Date;
            MessageBox.Show("Fecha seleccionada: " + selectedDate.ToShortDateString());
        }

        private void comboBoxcodigo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //
        }

        private void comboBoxdocuemnto_SelectedIndexChanged(object sender, EventArgs e)
        {
            //
        }

        private void Citas_Load(object sender, EventArgs e)
        {
            //
        }

        private void btnsiguiente_Click(object sender, EventArgs e)
        {
            Historialclinico historiaClinica = new Historialclinico(this);
            historiaClinica.Show();

        }

        private void txt_sede_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblsede_Click(object sender, EventArgs e)
        {

        }

        private void txt_codigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_hora_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblHora_Click(object sender, EventArgs e)
        {

        }

        private void lblfechacita_Click(object sender, EventArgs e)
        {

        }

        private void lbltitulo_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lbl_codigomascota_Click(object sender, EventArgs e)
        {

        }

        private void lbl_codigo_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataCita_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int fila = e.RowIndex;

            if (fila != -1 && fila < ListaGestioncitas.Count)
            {
                try
                {
                    ConexionMySQL conexion = new ConexionMySQL(servidor, usuario, password, baseDatos);
                    UsuarioDAO usuarioDAO = new UsuarioDAO(conexion);

                    // Actualizar la lista y la base de datos
                    ActualizarCitaEnLista(fila);
                    Gestioncitas gestion = ListaGestioncitas[fila];
                    usuarioDAO.ActualizarCita(gestion);

                    // Guardar en el archivo
                    archivo.GuardarEnArchivo(ListaGestioncitas);

                    MessageBox.Show("Registro actualizado correctamente en la base de datos y archivo.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al actualizar la cita: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        private void ActualizarCitaEnLista(int rowIndex)
        {
            if (rowIndex >= 0 && rowIndex < ListaGestioncitas.Count)
            {
                Gestioncitas gestion = ListaGestioncitas[rowIndex];
                gestion.Codigo = dataCita.Rows[rowIndex].Cells[0].Value?.ToString();
                gestion.Codigomascota = dataCita.Rows[rowIndex].Cells[1].Value?.ToString();
                gestion.Documentousuario = dataCita.Rows[rowIndex].Cells[2].Value?.ToString();
                gestion.Fechacita = dataCita.Rows[rowIndex].Cells[3].Value?.ToString();
                gestion.Hora = dataCita.Rows[rowIndex].Cells[4].Value?.ToString();
                gestion.Sede = dataCita.Rows[rowIndex].Cells[5].Value?.ToString();
            }
        }
    }
}
