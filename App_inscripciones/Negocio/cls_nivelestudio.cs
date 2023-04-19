using System;
using System.Data;
using Datos;

namespace Negocio
{
    public class cls_nivelestudio
    {
        private DataTable dt;
    public void fnt_CargarTipoEstudio()
        {
            cls_funcionesCandidatos objDt = new cls_funcionesCandidatos();
            objDt.fnt_cargarnivelestudio();
            this.dt = objDt.getDt();
        }
        public DataTable getDt() { return this.dt; }
    }
}
