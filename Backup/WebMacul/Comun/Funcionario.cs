using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebMacul.Comun
{
    public class Funcionario
    {
        public Funcionario()
        { }

        private Int32 _IdFunci;

        public Int32 IdFunci
        {
            get { return _IdFunci; }
            set { _IdFunci = value; }
        }
        private Int32 _RUtFunci;

        public Int32 RUtFunci
        {
            get { return _RUtFunci; }
            set { _RUtFunci = value; }
        }
        private Int32 _DvFunci;

        public Int32 DvFunci
        {
            get { return _DvFunci; }
            set { _DvFunci = value; }
        }
        private string _NombreFunci;

        public string NombreFunci
        {
            get { return _NombreFunci; }
            set { _NombreFunci = value; }
        }
        private string _FecNacFunci;

        public string FecNacFunci
        {
            get { return _FecNacFunci; }
            set { _FecNacFunci = value; }
        }
        private string _CJFunc;

        public string CJFunc
        {
            get { return _CJFunc; }
            set { _CJFunc = value; }
        }
        private Int32 _NumFunci;

        public Int32 NumFunci
        {
            get { return _NumFunci; }
            set { _NumFunci = value; }
        }
        private string _DirecFunci;

        public string DirecFunci
        {
            get { return _DirecFunci; }
            set { _DirecFunci = value; }
        }
        private string _ComeFunci;

        public string ComeFunci
        {
            get { return _ComeFunci; }
            set { _ComeFunci = value; }
        }
        private string _EduFunci;

        public string EduFunci
        {
            get { return _EduFunci; }
            set { _EduFunci = value; }
        }
        private string _TipContrFunci;

        public string TipContrFunci
        {
            get { return _TipContrFunci; }
            set { _TipContrFunci = value; }
        }
        private string _CCosFunci;

        public string CCosFunci
        {
            get { return _CCosFunci; }
            set { _CCosFunci = value; }
        }
        private string _GradoFunci;

        public string GradoFunci
        {
            get { return _GradoFunci; }
            set { _GradoFunci = value; }
        }
    
    }
}