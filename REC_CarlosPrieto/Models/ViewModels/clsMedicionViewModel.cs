using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using REC_CarlosPrieto.Models.Entidades;

namespace REC_CarlosPrieto.Models.ViewModels
{
    public class clsMedicionViewModel
    {

        [Display(Name = "FECHA")]
        public DateTime fecha { get; set; }

        [Display(Name = "TRAMO")]
        public char tramo { get; set; }

        /// <summary>
        /// Listado con las mediciones de los ancianos
        /// </summary>
        public List<clsMedicionNombreAnciano> listadoMediciones { get; set; }

        public clsMedicionViewModel()
        {
            this.fecha = System.DateTime.Now;
            this.listadoMediciones = _lstListaMedicionNombre();
        }


        /// <summary>
        /// lstListaMedicionNombre
        /// 
        /// descripción: devuelve una lista de objetos tipo clsMediciónConNombreAnciano que servirá como modelo para la vista
        /// entradas: nada
        /// precondiciones: nada
        /// salidas: una lista de clsMedicionConNombreAnciano
        /// Postcondiciones: asociado al nombre de la función devuelve una lista de objetos tipo clsMediciónConNombreAnciano
        /// </summary>
        /// <returns></returns>
        private List<clsMedicionNombreAnciano> _lstListaMedicionNombre()
        {
            List<clsMedicionNombreAnciano> miLista = new List<clsMedicionNombreAnciano>();

            miLista.Add(new clsMedicionNombreAnciano(0, 0, "carlos"));
            miLista.Add(new clsMedicionNombreAnciano(1, 0, "antonio"));
            miLista.Add(new clsMedicionNombreAnciano(2, 0, "javi"));
            miLista.Add(new clsMedicionNombreAnciano(3, 0, "paco"));
            miLista.Add(new clsMedicionNombreAnciano(4, 0, "coxinito"));

            return miLista;
        }

    }
}