using System;
using System.Data;
using Datos;
using MySql.Data.MySqlClient;

namespace Datos
{
    public class cls_funcionesCandidatos
    {
        private DataTable Dt;

        public void fnt_Guardar(
            String id, string primernombre, string segundonombre, string primerapellido, string segundoapellido, string contacto, string direccion,
            string correo, string edad, int estudio, string acudientes, byte[] imagen)

        {
            try
            {
            cls_Conexion obj_conexion = new cls_Conexion();
                obj_conexion.fnt_conectar();
                string cosulta = "insert into tbl_personas(PKId,P_Nombre,S_Nombre,P_Apellido,S_Apellido,Contacto,Direccion,Correo,Edad,FKCodigo_tbl_nivelestudio,Acudiente, Imagen)" + " values ('" + id + "','" + primernombre + "','" + segundonombre + "','" + primerapellido + "','" + segundoapellido + "','" + contacto + "','" + direccion + "','" + correo + "','" + edad + "','" + estudio + "','" + acudientes + "','"+imagen+"');
                MySqlCommand comando = new MySqlCommand(cosulta, obj_conexion.conex);
                MySqlDataReader lectura = comando.ExecuteReader();
                obj_conexion.fnt_Desconectar();
            }catch (Exception) { }
        }
        public void fnt_cargarnivelestudio()
        {
           
            string sql = "select PKCodigo,Nombre from tbl_nivelestudio ";
            cls_Conexion objConecta = new cls_Conexion();
            objConecta.fnt_conectar();

            try
            {
                MySqlCommand comando = new MySqlCommand(sql, objConecta.conex);
                Dt = new DataTable();
                MySqlDataAdapter Data = new MySqlDataAdapter(comando);
                Data.Fill(Dt);
            }
            catch (Exception)
            {
                objConecta.fnt_Desconectar();
            }
        }
        public DataTable getDt() { return Dt; }

        public void fnt_Guardar(string str_id, string str_primernombre, string str_segundonombre, string str_primerapellido, string str_segundoapellido, string str_contacto, string str_correo, string str_edad, int int_estudio, string str_acudientes)
        {
            throw new NotImplementedException();
        }
    }
}
