using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebMacul.Comun
{
    public class Liquidacion
    {
        public Liquidacion()
        {
        }
        private Int32 _Tipo;

        public Int32 Tipo
        {
            get { return _Tipo; }
            set { _Tipo = value; }
        }
        private Int32 _Ano;

        public Int32 Ano
        {
            get { return _Ano; }
            set { _Ano = value; }
        }
        private Int32 _Mes;

        public Int32 Mes
        {
            get { return _Mes; }
            set { _Mes = value; }
        }
        private Int32 _Rut;

        public Int32 Rut
        {
            get { return _Rut; }
            set { _Rut = value; }
        }
        private string _Dv;

        public string Dv
        {
            get { return _Dv; }
            set { _Dv = value; }
        }


    }
}