using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herramientas2personas
{
    public class Gestioncitas
    {
        public string Codigo;
        public string Codigomascota;
        public string Documentousuario;
        public string Fechacita;
        public string Hora;
        public string Sede;


        public Gestioncitas(string Codigo, string Codigomascota, string Documentousuario, string Fechacita, string Hora, string Sede)
        {
            this.Codigo = Codigo;
            this.Codigomascota = Codigomascota;
            this.Documentousuario = Documentousuario;
            this.Fechacita = Fechacita;
            this.Hora = Hora;
            this.Sede = Sede;
        }

        public string getCodigo()
        {
            return this.Codigo;
        }

        public string getCodigomascota()
        {
            return this.Codigomascota;
        }

        public string getDocumentousuario()
        {
            return this.Documentousuario;
        }

        public string getFechacita()
        {
            return this.Fechacita;
        }

        public string getHora()
        {
            return this.Hora;
        }

        public string getSede()
        {
            return this.Sede;
        }

        public void setCodigo(string Codigo)
        {
            this.Codigo = Codigo;
        }


        public void setCodigomascota(string Codigomascota)
        {
            this.Codigomascota = Codigomascota;
        }

        public void setDocumentousuario(string Documentousuario)
        {
            this.Documentousuario = Documentousuario;
        }


        public void setFechacita(string Fechacita)
        {
            this.Fechacita = Fechacita;
        }


        public void setHora(string Hora)
        {
            this.Hora = Hora;
        }


        public void setSede(string Sede)
        {
            this.Sede = Sede;
        }


        public override string ToString()
        {
            return Codigo + ", " + Codigomascota + ", " + Documentousuario + ", " + Fechacita + ", " + Hora + ", " + Sede;
        }
    }
}
