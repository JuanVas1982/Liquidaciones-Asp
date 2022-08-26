using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebMacul.Comun
{
    public class Usuario
    {
        public Usuario()
        { }

        private string _Nombre;

        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }

        private Int32 _Rut;

        public Int32 Rut
        {
            get { return _Rut; }
            set { _Rut = value; }
        }

        private string _DV;

        public string DV
        {
            get { return _DV; }
            set { _DV = value; }
        }

        private string _Email;

        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }

        private string _NomUsuario;

        public string NomUsuario
        {
            get { return _NomUsuario; }
            set { _NomUsuario = value; }
        }

        private string _PassWord;

        public string PassWord
        {
            get { return _PassWord; }
            set { _PassWord = value; }
        }

        private string _Cargo;

        public string Cargo
        {
            get { return _Cargo; }
            set { _Cargo = value; }
        }

        private string _Ccosto;

        public string Ccosto
        {
            get { return _Ccosto; }
            set { _Ccosto = value; }
        }
     

        private Int32 _IDPerfil;

        public Int32 IDPerfil
        {
            get { return _IDPerfil; }
            set { _IDPerfil = value; }
        }

        int _sWOpcion;

        public int SWOpcion
        {
            get { return _sWOpcion; }
            set { _sWOpcion = value; }
        }

        string _EstadoE;

        public string EstadoE
        {
            get { return _EstadoE; }
            set { _EstadoE = value; }
        }

     

    }
}