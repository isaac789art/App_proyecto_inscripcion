using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class cls_ConsultarCanditato
    {
        private DataTable dt;
        private Bitmap bmp;
        private string str_primernombre;
        private string str_segundonombre;
        private string str_primerapellido;
        private string str_segundoapellido;
        private string str_contacto;
        private string str_direccion;
        private string str_correo;
        private string str_edad;
        private int int_estudio;
        private string str_acudientes;
        public void Fnt_Consultar(string identificacion)
        { }


        public void fnt_Consultar(string identificacion, Func<Bitmap> bmp)
        {
            cls_funcionesCandidatos obj_consultar = new cls_funcionesCandidatos();
            obj_consultar.fnt_consultar(identificacion);
            bmp = obj_consultar.Bmp;
            this.str_primernombre = obj_consultar.getprimernombre();
            this.str_segundonombre= obj_consultar.getsegundonombre();
            this.str_primerapellido = obj_consultar.getprimerapellido();
            this.str_segundoapellido = obj_consultar.getsegundoapellido();
            this.str_contacto = obj_consultar.getContacto();
            this.str_direccion= obj_consultar.getdireccion();
            this.str_correo= obj_consultar.getcorreo();
            this.str_edad= obj_consultar.getEdad();
            this.int_estudio= obj_consultar.getestudio();
            this.str_acudientes= obj_consultar.getacudientes();
        }
        public Bitmap getBmp() { return bmp; }

        public string getprimernombre() { return this.str_primernombre; }

        public string getsegundonombre() { return this.str_segundonombre; }

        public string getprimerapellido() { return this.str_primerapellido; }

        public string getsegundoapellido() { return this.str_primernombre; }

        public string getContacto() { return this.str_contacto; }

        public string getdireccion() { return this.str_direccion; }

        public string getcorreo() { return this.str_correo; }

        public string getEdad() { return this.str_edad; }

        public int getestudio() { return this.int_estudio; }

        public string getacudientes() { return this.str_acudientes; }

    }
}
