using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herramientas2personas
{
    public class Animal
    {

        public string codigo;
        public string nombre;
        public string fechanacimiento;
        public string colorpelo;
        public string especie;
        public string raza;
        public string pesoanterior;
        public string peso;


        public Animal(string codigo, string nombre, string fechanacimiento, string colorpelo, string especie, string raza, string pesoanterior, string peso)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.fechanacimiento = fechanacimiento;
            this.colorpelo = colorpelo;
            this.especie = especie;
            this.raza = raza;
            this.pesoanterior = pesoanterior;
            this.peso = peso;
        }
        public Animal()
        {
        }
        public string getcodigo()
        {
            return this.codigo;
        }

        public string getnombre()
        {
            return this.nombre;
        }

        public string getfechanacimiento()
        {
            return this.fechanacimiento;
        }


        public string getcolorpelo()
        {
            return this.colorpelo;
        }

        public string getespecie()
        {
            return this.especie;
        }

        public string getraza()
        {
            return this.raza;
        }

        public string getpesoanterior()
        {
            return this.pesoanterior;
        }

        public string getpeso()
        {
            return this.peso;
        }

        public void setcodigo(string codigo)
        {
            this.codigo = codigo;
        }

        public void setnombre(string nombre)
        {
            this.nombre = nombre;
        }

        public void setfechanacimiento(string fechanacimiento)
        {
            this.fechanacimiento = fechanacimiento;
        }


        public void setcolorpelo(string colorpelo)
        {
            this.colorpelo = colorpelo;
        }

        public void setespecie(string especie)
        {
            this.especie = especie;
        }

        public void setraza(string raza)
        {
            this.raza = raza;
        }

        public void setpesoanterior(string pesoanterior)
        {
            this.pesoanterior = pesoanterior;
        }

        public void setpeso(string peso)
        {
            this.peso = peso;
        }


        public override string ToString()
        {
            return codigo + ", " + nombre + ", " + fechanacimiento + ", " + colorpelo + ", " + especie + ", " + raza + ", " + pesoanterior + ", " + peso;
        }
    }
}
