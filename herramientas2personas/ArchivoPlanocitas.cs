using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herramientas2personas
{
    public class ArchivoPlanocitas
    {

        public string RutaArchivo;

        public ArchivoPlanocitas(string rutaArchivo)
        {
            this.RutaArchivo = rutaArchivo;
        }

        public void GuardarEnArchivo(List<Gestioncitas> ListaGestioncitas)
        {
            using (StreamWriter writer = new StreamWriter(RutaArchivo))
            {
                foreach (Gestioncitas Gestioncitas in ListaGestioncitas)
                {
                    writer.WriteLine(Gestioncitas.ToString());
                }
            }
        }

        public List<Gestioncitas> CargarDesdeArchivo()
        {
            List<Gestioncitas> ListaGestioncitas = new List<Gestioncitas>();

            if (File.Exists(RutaArchivo))
            {
                using (StreamReader reader = new StreamReader(RutaArchivo))
                {
                    string Linea;
                    while ((Linea = reader.ReadLine()) != null)
                    {
                        string[] partes = Linea.Split(',');
                        if (partes.Length == 6)
                        {
                            Gestioncitas Gestioncitas = new Gestioncitas(partes[0], partes[1], partes[2], partes[3], partes[4], partes[5]);
                            ListaGestioncitas.Add(Gestioncitas);
                        }
                    }

                }

            }

            return ListaGestioncitas;

        }

    }
}
