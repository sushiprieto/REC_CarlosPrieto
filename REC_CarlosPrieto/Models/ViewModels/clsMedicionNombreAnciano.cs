using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace REC_CarlosPrieto.Models.ViewModels
{
    public class clsMedicionNombreAnciano
    {

        #region

        public int idAnciano { get; set; }


        [Range(0, 50, ErrorMessage = "Con esa temperatura no eres miembro")]
        public float temperatura { get; set; }
        public String nombre { get; set; }
        //public DateTime fecha { get; set; }
        //public char tramo { get; set; }

        #endregion

        //constructor sin parámetros
        public clsMedicionNombreAnciano()
        {

            //fecha = System.DateTime.Now;
            idAnciano = 0;
            temperatura = 0.0F;
            nombre = "";
            //tramo=' ';
        }
        //constructor con parámetros
        public clsMedicionNombreAnciano(int idAnciano, float temperatura, String nombre)
        {
            //this.fecha = System.DateTime.Now;
            this.idAnciano = idAnciano;
            this.temperatura = temperatura;
            this.nombre = nombre;
            //this.tramo = tramo;
        }

    }
}