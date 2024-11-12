using System;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
// comando Install-Package MySql.Data
public class ConexionMySQL
{
    private string servidor;
    private string usuario;
    private string password;
    private string baseDatos;
    private MySqlConnection conexion;

    public ConexionMySQL(string servidor, string usuario, string password, string baseDatos)
    {
        this.servidor = servidor;
        this.usuario = usuario;
        this.password = password;
        this.baseDatos = baseDatos;

        string cadenaConexion = $"server={servidor};user={usuario};password={password};database={baseDatos}";
        conexion = new MySqlConnection(cadenaConexion);
    }

    public void AbrirConexion()
    {
        try
        {
            conexion.Open();
            Console.WriteLine("Conexión abierta con éxito.");
        }
        catch (MySqlException ex)
        {
            Console.WriteLine($"Error al abrir la conexión: {ex.Message}");
        }
    }

    public void CerrarConexion()
    {
        try
        {
            conexion.Close();
            Console.WriteLine("Conexión cerrada con éxito.");
        }
        catch (MySqlException ex)
        {
            Console.WriteLine($"Error al cerrar la conexión: {ex.Message}");
        }
    }

    public MySqlConnection ObtenerConexion()
    {
        return conexion;
    }
}