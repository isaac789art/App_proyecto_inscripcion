using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public class cls_agregarCandidatos
    {
        private string str_id;
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
        private Byte[] byt_imagen;
        private string str_msn;//enviar mensajes a la capa de presentacion.

        public cls_agregarCandidatos(string str_id, string str_primernombre, string str_segundonombre, string str_primerapellido, string str_segundoapellido, string str_contacto, string str_direccion, string str_correo, string str_edad, int str_estudio, string str_acudientes, byte[] aByte)
        {
            this.str_id = str_id;
            this.str_primernombre = str_primernombre;
            this.str_segundonombre = str_segundonombre;
            this.str_primerapellido = str_primerapellido;
            this.str_segundoapellido = str_segundoapellido;
            this.str_contacto = str_contacto;
            this.str_direccion = str_direccion;
            this.str_correo = str_correo;
            this.str_edad = str_edad;
            this.int_estudio = str_estudio;
            this.str_acudientes = str_acudientes;
            this.byt_imagen = aByte;
            if (str_id == "" || str_primernombre == "" || str_segundonombre == "" || str_primerapellido == "" || str_segundoapellido == "" || str_contacto == "" || str_direccion == "" || str_correo == "" || str_edad == "" ||str_acudientes == "")
            {
                str_msn = "Debe ingresar toda la informacion requerida";
            }
            else
            {
                cls_funcionesCandidatos objGuardar = new cls_funcionesCandidatos();
                objGuardar.fnt_Guardar(str_id, str_primernombre, str_segundonombre, str_primerapellido, str_segundoapellido, str_contacto, str_correo, str_edad, int_estudio, str_acudientes, byt_imagen);
                
                str_msn = "EL CANDIDATO" + str_primernombre + "HA SIDO REGISTRADO";
            }
        }
        public string getMsn() { return this.str_msn; }
    }
}
