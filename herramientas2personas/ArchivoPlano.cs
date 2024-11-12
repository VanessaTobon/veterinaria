using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herramientas2personas
{
    public class ArchivoPlano
    {
        public string RutaArchivo; 

        public ArchivoPlano(string rutaArchivo)
        {
            this.RutaArchivo = rutaArchivo;
        }

        public void GuardarEnArchivo(List<Usuario> ListaUsuarios)
        {
            using (StreamWriter writer = new StreamWriter(RutaArchivo))
            {
                foreach(Usuario usuario in ListaUsuarios)
                {
                    writer.WriteLine(usuario.ToString());
                }
            }
        }

        public List<Usuario> CargarDesdeArchivo()
        {
            List<Usuario> ListaUsuarios = new List<Usuario>();

            if (File.Exists(RutaArchivo))
            {
                using (StreamReader reader = new StreamReader(RutaArchivo))
                {
                    string Linea;
                    while ((Linea = reader.ReadLine()) != null)
                    {
                        string[] partes = Linea.Split(',');

                        // Verificar que haya suficientes partes para crear un usuario
                        if (partes.Length == 5) // 5 partes son necesarias para crear un usuario
                        {
                            Usuario usuario = new Usuario(partes[0], partes[1], partes[2], partes[3], partes[4]);
                            ListaUsuarios.Add(usuario);
                        }
                    }
                }
            }

            return ListaUsuarios;
        }


    }
}
