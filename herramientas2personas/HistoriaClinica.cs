using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herramientas2personas
{
    public class HistoriaClinica
    {
        public string Codigo;
        public string Codigomascota;
        public string Enfermedadesanteriores;
        public string Fechaenfermedad;
        public string Fechavacuna;
        public string Enfermedadvacunada;
        


        public HistoriaClinica(string Codigo, string Codigomascota, string Enfermedadesanteriores, string Fechaenfermedad, string Fechavacuna, string Enfermedadvacunada)
        {
            this.Codigo = Codigo;
            this.Codigomascota = Codigomascota;
            this.Enfermedadesanteriores = Enfermedadesanteriores;
            this.Fechaenfermedad = Fechaenfermedad;
            this.Fechavacuna = Fechavacuna;
            this.Enfermedadvacunada = Enfermedadvacunada;
            
        }

        public string getCodigo()
        {
            return this.Codigo;
        }

        public string getCodigomascota()
        {
            return this.Codigomascota;
        }

        public string getEnfermedadesanteriores()
        {
            return this.Enfermedadesanteriores;
        }

        public string getFechaenfermedad()
        {
            return this.Fechaenfermedad;
        }

        public string getEnfermedadvacunada()
        {
            return this.Enfermedadvacunada;
        }

        public string getFechavacuna()
        {
            return this.Fechavacuna;
        }

        public void setCodigo(string Codigo)
        {
            this.Codigo = Codigo;
        }


        public void setCodigomascota(string Codigomascota)
        {
            this.Codigomascota = Codigomascota;
        }

        public void setEnfermedadesanteriores(string Enfermedadesanteriores)
        {
            this.Enfermedadesanteriores = Enfermedadesanteriores;
        }


        public void setFechaenfermedad(string Fechaenfermedad)
        {
            this.Fechaenfermedad = Fechaenfermedad;
        }


        public void setEnfermedadvacunada(string Enfermedadvacunada)
        {
            this.Enfermedadvacunada = Enfermedadvacunada;
        }


        public void setFechavacuna(string Fechavacuna)
        {
            this.Fechavacuna = Fechavacuna;
        }


        public override string ToString()
        {
            return Codigo + ", " + Codigomascota + ", " + Enfermedadesanteriores + ", " + Fechaenfermedad + ", "  + Fechavacuna + " ," + Enfermedadvacunada;
        }
    }
}
