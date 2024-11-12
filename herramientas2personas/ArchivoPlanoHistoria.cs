using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herramientas2personas
{
    public class ArchivoPlanoHistoria
    {

        public string RutaArchivo;

        public ArchivoPlanoHistoria(string rutaArchivo)
        {
            this.RutaArchivo = rutaArchivo;
        }

        public void GuardarEnArchivo(List<HistoriaClinica> ListaHistoria)
        {
            using (StreamWriter writer = new StreamWriter(RutaArchivo))
            {
                foreach (HistoriaClinica HistoriaClinica in ListaHistoria)
                {
                    writer.WriteLine(HistoriaClinica.ToString());
                }
            }
        }

        public List<HistoriaClinica> CargarDesdeArchivo()
        {
            List<HistoriaClinica> ListaHistoria = new List<HistoriaClinica>();

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
                            HistoriaClinica HistoriaClinica = new HistoriaClinica(partes[0], partes[1], partes[2], partes[3], partes[4], partes[5]);
                            ListaHistoria.Add(HistoriaClinica);
                        }
                    }

                }

            }

            return ListaHistoria;

        }
    }
}
