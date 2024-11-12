using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace herramientas2personas
{
    public class UsuarioDAO
    {
        private ConexionMySQL conexion; 

        public UsuarioDAO(ConexionMySQL conexion)
        {
            this.conexion = conexion;
        }

        public void GuardarUsuarios(List<Usuario> usuarios)
        {
            conexion.AbrirConexion();
            foreach (Usuario usuario in usuarios)
            {
                string query = "INSERT INTO usuario (Documento, Nombres, Apellidos, Telefono, Direccion) VALUES (@Documento, @Nombres, @Apellidos, @Telefono, @Direccion)";
                MySqlCommand cmd = new MySqlCommand(query, conexion.ObtenerConexion());
                cmd.Parameters.AddWithValue("@Documento", usuario.Documento);
                cmd.Parameters.AddWithValue("@Nombres", usuario.Nombres);
                cmd.Parameters.AddWithValue("@Apellidos", usuario.Apellidos);
                cmd.Parameters.AddWithValue("@Telefono", usuario.Telefono);
                cmd.Parameters.AddWithValue("@Direccion", usuario.Direccion);

                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    // Manejar el error de inserción lanzando una excepción
                    if (ex.Message.Contains("Duplicate entry"))
                    {
                        Console.WriteLine($"El usuario con documento {usuario.Documento} ya existe en la base de datos.");
                    }
                    else
                    {
                        // Si el error no se debe a una violación de la llave primaria,
                        // lanzar una excepción para que sea manejada en el código que llama a este método
                        throw new Exception($"Error al insertar usuario en la base de datos: {ex.Message}");
                    }

                }
            }
            conexion.CerrarConexion();
        }
        public void EliminarUsuario(string documento)
        {
            try
            {
                // Abrir la conexión a la base de datos
                conexion.AbrirConexion();

                // Crear y ejecutar la consulta SQL para eliminar el usuario
                string query = "DELETE FROM usuario WHERE Documento = @Documento";
                MySqlCommand cmdEliminar = new MySqlCommand(query, conexion.ObtenerConexion());
                cmdEliminar.Parameters.AddWithValue("@Documento", documento);
                cmdEliminar.ExecuteNonQuery();

                // Cerrar la conexión a la base de datos
                conexion.CerrarConexion();
            }
            catch (MySqlException ex)
            {
                // Manejar cualquier excepción que pueda ocurrir durante la ejecución de la consulta SQL
                throw new Exception($"Error al eliminar usuario de la base de datos: {ex.Message}");
            }

        }

        public void GuardarAnimal(List<Animal> animal)
        {
            conexion.AbrirConexion();
            foreach (Animal animales in animal)
            {
                string query = "INSERT INTO animal (codigo, colorpelo, nombre, fechanacimiento, especie, raza, pesoanterior, peso) VALUES (@codigo, @colorpelo, @nombre, @fechanacimiento, @especie, @raza, @pesoanterior, @peso)";
                MySqlCommand cmd = new MySqlCommand(query, conexion.ObtenerConexion());
                cmd.Parameters.AddWithValue("@codigo", animales.codigo);
                cmd.Parameters.AddWithValue("@colorpelo", animales.colorpelo);
                cmd.Parameters.AddWithValue("@nombre", animales.nombre);
                cmd.Parameters.AddWithValue("@fechanacimiento", animales.fechanacimiento);
                cmd.Parameters.AddWithValue("@especie", animales.especie);
                cmd.Parameters.AddWithValue("@raza", animales.raza);
                cmd.Parameters.AddWithValue("@pesoanterior", animales.pesoanterior);
                cmd.Parameters.AddWithValue("@peso", animales.peso);

                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    // Manejar el error de inserción lanzando una excepción
                    if (ex.Message.Contains("Duplicate entry"))
                    {
                        Console.WriteLine($"El animal con codigo {animales.codigo} ya existe en la base de datos.");
                    }
                    else
                    {
                        // Si el error no se debe a una violación de la llave primaria,
                        // lanzar una excepción para que sea manejada en el código que llama a este método
                        throw new Exception($"Error al insertar animal en la base de datos: {ex.Message}");
                    }

                }
            }
            conexion.CerrarConexion();
        }
        public void EliminarAnimal(string codigo)
        {
            try
            {
                // Abrir la conexión a la base de datos
                conexion.AbrirConexion();

                // Crear y ejecutar la consulta SQL para eliminar el usuario
                string query = "DELETE FROM animal WHERE codigo = @codigo";
                MySqlCommand cmdEliminar = new MySqlCommand(query, conexion.ObtenerConexion());
                cmdEliminar.Parameters.AddWithValue("@codigo", codigo);
                cmdEliminar.ExecuteNonQuery();

                // Cerrar la conexión a la base de datos
                conexion.CerrarConexion();
            }
            catch (MySqlException ex)
            {
                // Manejar cualquier excepción que pueda ocurrir durante la ejecución de la consulta SQL
                throw new Exception($"Error al eliminar animal de la base de datos: {ex.Message}");
            }

        }
        public void GuardarCita(List<Gestioncitas> gestioncitas)
        {
            conexion.AbrirConexion();
            foreach (Gestioncitas Citas in gestioncitas)
            {
                string query = "INSERT INTO citas (Codigo, Codigomascota, Documentousuario, Fechadecita, Hora, Sede) VALUES (@Codigo, @Codigomascota, @Documentousuario, @Fechadecita, @Hora, @Sede)";
                MySqlCommand cmd = new MySqlCommand(query, conexion.ObtenerConexion());
                cmd.Parameters.AddWithValue("@Codigo", Citas.Codigo);
                cmd.Parameters.AddWithValue("@Codigomascota", Citas.Codigomascota);
                cmd.Parameters.AddWithValue("@Documentousuario", Citas.Documentousuario);
                cmd.Parameters.AddWithValue("@Fechadecita", Citas.Fechacita);
                cmd.Parameters.AddWithValue("@Hora", Citas.Hora);
                cmd.Parameters.AddWithValue("@Sede", Citas.Sede);
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    // Manejar el error de inserción lanzando una excepción
                    if (ex.Message.Contains("Duplicate entry"))
                    {
                        Console.WriteLine($"La cita con codigo {Citas.Codigo} ya existe en la base de datos.");
                    }
                    else
                    {
                        // Si el error no se debe a una violación de la llave primaria,
                        // lanzar una excepción para que sea manejada en el código que llama a este método
                        throw new Exception($"Error al insertar cita en la base de datos: {ex.Message}");
                    }

                }
            }
            conexion.CerrarConexion();
        }
        public void EliminarCita(string codigo)
        {
            try
            {
                // Abrir la conexión a la base de datos
                conexion.AbrirConexion();

                // Crear y ejecutar la consulta SQL para eliminar el usuario
                string query = "DELETE FROM citas WHERE Codigo = @Codigo";
                MySqlCommand cmdEliminar = new MySqlCommand(query, conexion.ObtenerConexion());
                cmdEliminar.Parameters.AddWithValue("@Codigo", codigo);
                cmdEliminar.ExecuteNonQuery();

                // Cerrar la conexión a la base de datos
                conexion.CerrarConexion();
            }
            catch (MySqlException ex)
            {
                // Manejar cualquier excepción que pueda ocurrir durante la ejecución de la consulta SQL
                throw new Exception($"Error al eliminar cita de la base de datos: {ex.Message}");
            }

        }

        public List<Usuario> BuscarUsuarios()
        {
            List<Usuario> usuarios = new List<Usuario>();

            try
            {
                // Abrir la conexión a la base de datos
                conexion.AbrirConexion();

                // Crear y ejecutar la consulta SQL para buscar todos los usuarios
                string query = "SELECT Documento, Nombres, Apellidos, Telefono, Direccion FROM usuario";
                MySqlCommand cmdBuscar = new MySqlCommand(query, conexion.ObtenerConexion());
                MySqlDataReader reader = cmdBuscar.ExecuteReader();

                // Leer los resultados y agregarlos a la lista de usuarios
                while (reader.Read())
                {
                    Usuario usuario = new Usuario
                    {
                        Documento = reader.GetString("Documento"),
                        Nombres = reader.GetString("Nombres"),
                        Apellidos = reader.GetString("Apellidos"),
                        Telefono = reader.GetString("Telefono"),
                        Direccion = reader.GetString("Direccion")
                    };
                    usuarios.Add(usuario);
                }

                // Cerrar el lector
                reader.Close();
            }
            catch (MySqlException ex)
            {
                // Manejar cualquier excepción que pueda ocurrir durante la ejecución de la consulta SQL
                throw new Exception($"Error al buscar usuarios en la base de datos: {ex.Message}");
            }
            finally
            {
                // Cerrar la conexión a la base de datos
                conexion.CerrarConexion();
            }

            return usuarios;
        }

        public List<Animal> BuscarAnimales()
        {
            List<Animal> animales = new List<Animal>();

            try
            {
                // Abrir la conexión a la base de datos
                conexion.AbrirConexion();

                // Crear y ejecutar la consulta SQL para buscar todos los animales
                string query = "SELECT codigo, colorpelo, nombre, fechanacimiento, especie, raza, pesoanterior, peso FROM animal";
                MySqlCommand cmdBuscar = new MySqlCommand(query, conexion.ObtenerConexion());
                MySqlDataReader reader = cmdBuscar.ExecuteReader();

                // Leer los resultados y agregarlos a la lista de animales
                while (reader.Read())
                {
                    Animal animal = new Animal
                    {
                        codigo = reader.GetString("codigo"),
                        colorpelo = reader.GetString("colorpelo"),
                        nombre = reader.GetString("nombre"),
                        fechanacimiento = reader.GetString("fechanacimiento"),
                        especie = reader.GetString("especie"),
                        raza = reader.GetString("raza"),
                        pesoanterior = reader.GetString("pesoanterior"),
                        peso = reader.GetString("peso")
                    };
                    animales.Add(animal);
                }

                // Cerrar el lector
                reader.Close();
            }
            catch (MySqlException ex)
            {
                // Manejar cualquier excepción que pueda ocurrir durante la ejecución de la consulta SQL
                throw new Exception($"Error al buscar animales en la base de datos: {ex.Message}");
            }
            finally
            {
                // Cerrar la conexión a la base de datos
                conexion.CerrarConexion();
            }

            return animales;
        }


        public void GuardarHistoria(List<HistoriaClinica> historiaClinica)
        {
            conexion.AbrirConexion();
            foreach (HistoriaClinica Historia in historiaClinica)
            {
                string query = "INSERT INTO historiaclinica (Codigo, Codigomascota, Enfermedadesanteriores, Fechaenfermedad, Fechavacuna, Enfermedadvacunada) VALUES (@Codigo, @Codigomascota, @Enfermedadesanteriores, @Fechaenfermedad, @Fechavacuna, @Enfermedadvacunada)";
                MySqlCommand cmd = new MySqlCommand(query, conexion.ObtenerConexion());
                cmd.Parameters.AddWithValue("@Codigo", Historia.Codigo);
                cmd.Parameters.AddWithValue("@Codigomascota", Historia.Codigomascota); 
                cmd.Parameters.AddWithValue("@Enfermedadesanteriores", Historia.Enfermedadesanteriores); 
                cmd.Parameters.AddWithValue("@Fechaenfermedad", Historia.Fechaenfermedad); 
                cmd.Parameters.AddWithValue("@Fechavacuna", Historia.Fechavacuna); 
                cmd.Parameters.AddWithValue("@Enfermedadvacunada", Historia.Enfermedadvacunada); 

                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    if (ex.Message.Contains("Duplicate entry"))
                    {
                        Console.WriteLine($"La historia con codigo {Historia.Codigo} ya existe en la base de datos.");
                    }
                    else
                    {
                        throw new Exception($"Error al insertar cita en la base de datos: {ex.Message}");
                    }
                }
            }
            conexion.CerrarConexion();
        }


        public void EliminarHistoria(string codigo)
        {
            try
            {
                // Abrir la conexión a la base de datos
                conexion.AbrirConexion();

                // Crear y ejecutar la consulta SQL para eliminar el usuario
                string query = "DELETE FROM historiaclinica WHERE Codigo = @Codigo";
                MySqlCommand cmdEliminar = new MySqlCommand(query, conexion.ObtenerConexion());
                cmdEliminar.Parameters.AddWithValue("@Codigo", codigo);
                cmdEliminar.ExecuteNonQuery();

                // Cerrar la conexión a la base de datos
                conexion.CerrarConexion();
            }
            catch (MySqlException ex)
            {
                // Manejar cualquier excepción que pueda ocurrir durante la ejecución de la consulta SQL
                throw new Exception($"Error al eliminar historia de la base de datos: {ex.Message}");
            }

        }

        public void ActualizarUsuario(Usuario usuario)
        {
            try
            {
                conexion.AbrirConexion();
                string query = "UPDATE usuario SET Nombres = @Nombres, Apellidos = @Apellidos, Telefono = @Telefono, Direccion = @Direccion WHERE Documento = @Documento";
                MySqlCommand cmd = new MySqlCommand(query, conexion.ObtenerConexion());
                cmd.Parameters.AddWithValue("@Documento", usuario.Documento);
                cmd.Parameters.AddWithValue("@Nombres", usuario.Nombres);
                cmd.Parameters.AddWithValue("@Apellidos", usuario.Apellidos);
                cmd.Parameters.AddWithValue("@Telefono", usuario.Telefono);
                cmd.Parameters.AddWithValue("@Direccion", usuario.Direccion);

                int filasAfectadas = cmd.ExecuteNonQuery();

                if (filasAfectadas > 0)
                {
                    MessageBox.Show("Usuario actualizado correctamente en la base de datos.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se encontró el usuario para actualizar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al actualizar usuario en la base de datos: {ex.Message}");
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }


        public void ActualizarAnimal(Animal animal)
        {
            try
            {
                conexion.AbrirConexion();
                string query = "UPDATE animal SET colorpelo = @colorpelo, nombre = @nombre, fechanacimiento = @fechanacimiento, especie = @especie, raza = @raza, pesoanterior = @pesoanterior, peso = @peso WHERE codigo = @codigo";
                MySqlCommand cmd = new MySqlCommand(query, conexion.ObtenerConexion());
                cmd.Parameters.AddWithValue("@codigo", animal.codigo);
                cmd.Parameters.AddWithValue("@colorpelo", animal.colorpelo);
                cmd.Parameters.AddWithValue("@nombre", animal.nombre);
                cmd.Parameters.AddWithValue("@fechanacimiento", animal.fechanacimiento);
                cmd.Parameters.AddWithValue("@especie", animal.especie);
                cmd.Parameters.AddWithValue("@raza", animal.raza);
                cmd.Parameters.AddWithValue("@pesoanterior", animal.pesoanterior);
                cmd.Parameters.AddWithValue("@peso", animal.peso);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al actualizar animal en la base de datos: {ex.Message}");
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }

        public void ActualizarCita(Gestioncitas cita)
        {
            try
            {
                conexion.AbrirConexion();
                string query = "UPDATE citas SET Codigomascota = @Codigomascota, Documentousuario = @Documentousuario, Fechadecita = @Fechadecita, Hora = @Hora, Sede = @Sede WHERE Codigo = @Codigo";
                MySqlCommand cmd = new MySqlCommand(query, conexion.ObtenerConexion());
                cmd.Parameters.AddWithValue("@Codigo", cita.Codigo);
                cmd.Parameters.AddWithValue("@Codigomascota", cita.Codigomascota);
                cmd.Parameters.AddWithValue("@Documentousuario", cita.Documentousuario);
                cmd.Parameters.AddWithValue("@Fechadecita", cita.Fechacita);
                cmd.Parameters.AddWithValue("@Hora", cita.Hora);
                cmd.Parameters.AddWithValue("@Sede", cita.Sede);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al actualizar cita en la base de datos: {ex.Message}");
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }

        public void ActualizarHistoria(HistoriaClinica historia)
        {
            try
            {
                conexion.AbrirConexion();
                string query = "UPDATE historiaclinica SET Codigomascota = @Codigomascota, Enfermedadesanteriores = @Enfermedadesanteriores, Fechaenfermedad = @Fechaenfermedad, Fechavacuna = @Fechavacuna, Enfermedadvacunada = @Enfermedadvacunada WHERE Codigo = @Codigo";
                MySqlCommand cmd = new MySqlCommand(query, conexion.ObtenerConexion());
                cmd.Parameters.AddWithValue("@Codigo", historia.Codigo);
                cmd.Parameters.AddWithValue("@Codigomascota", historia.Codigomascota);
                cmd.Parameters.AddWithValue("@Enfermedadesanteriores", historia.Enfermedadesanteriores);
                cmd.Parameters.AddWithValue("@Fechaenfermedad", historia.Fechaenfermedad);
                cmd.Parameters.AddWithValue("@Fechavacuna", historia.Fechavacuna);
                cmd.Parameters.AddWithValue("@Enfermedadvacunada", historia.Enfermedadvacunada);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al actualizar historia clínica en la base de datos: {ex.Message}");
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }
    }
}

