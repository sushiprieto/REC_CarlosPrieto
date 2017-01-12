using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace REC_CarlosPrieto.Models.Entidades
{
    public class clsAnciano
    {

        #region atributos

        public int idAnciano { get; set; }
        public String nombreAnciano { get; set; }

        #endregion

        //constructor sin parámetros
        public clsAnciano()
        {
            idAnciano = 0;
            nombreAnciano = "";
        }
        //constructor con parámtros
        public clsAnciano(int idAnciano, String nombreAnciano)
        {
            this.idAnciano = idAnciano;
            this.nombreAnciano = nombreAnciano;
        }

    }
}