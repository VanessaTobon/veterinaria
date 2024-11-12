using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herramientas2personas
{
    public class Usuario
    {
        public string Documento;
        public string Nombres;
        public string Apellidos;
        public string Telefono;
        public string Direccion;

        public Usuario()
        {
        }
        public Usuario(string Documento, string Nombres, string Apellidos, string Telefono, string Direccion)
        {
            this.Documento = Documento;
            this.Nombres = Nombres;
            this.Apellidos = Apellidos;
            this.Telefono = Telefono;
            this.Direccion = Direccion;
        }

        public string getDocumento()
        {
            return this.Documento;
        }

        public void setDocumento(string Documento)
        {
            this.Documento= Documento;
        }
        public string getNombres()
        {
            return this.Nombres;
        }

        public void setNombres(string Nombres)
        {
            this.Nombres= Nombres;
        }

        public string getApellidos()
        { 
            return this.Apellidos; 
        }

        public string getTelefono()
        {
            return this.Telefono; 
        }

        public string getDireccion()
        {
            return this.Direccion;
        }

        public void setApellidos(string Apellidos)
        {
            this.Apellidos= Apellidos;
        }

        public void setTelefono(string Telefono)
        {
            this.Telefono= Telefono;
        }

        public void setDireccion(string Direccion)
        {
            this.Direccion= Direccion;
        }
        public override string ToString()
        {
            return Documento + ", " + Nombres + ", " + Apellidos + ", " + Telefono + ", " + Direccion;
        }
    }
}
