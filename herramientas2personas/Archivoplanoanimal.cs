using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herramientas2personas
{
    public class Archivoplanoanimal
    {
        public string RutaArchivo;

        public Archivoplanoanimal(string rutaArchivo)
        {
            this.RutaArchivo = rutaArchivo;
        }

        public void GuardarEnArchivo(List<Animal> ListaAnimal)
        {
            using (StreamWriter writer = new StreamWriter(RutaArchivo))
            {
                foreach (Animal Animal in ListaAnimal)
                {
                    writer.WriteLine(Animal.ToString());
                }
            }
        }

        public List<Animal> CargarDesdeArchivo()
        {
            List<Animal> ListaAnimal = new List<Animal>();

            if (File.Exists(RutaArchivo))
            {
                using (StreamReader reader = new StreamReader(RutaArchivo))
                {
                    string Linea;
                    while ((Linea = reader.ReadLine()) != null)
                    {
                        string[] partes = Linea.Split(',');
                        if (partes.Length == 8)
                        {
                            Animal Animal = new Animal(partes[0], partes[1], partes[2], partes[3], partes[4], partes[5], partes[6], partes[7]);
                            ListaAnimal.Add(Animal);
                        }
                    }

                }

            }

            return ListaAnimal;

        }

    }
}
