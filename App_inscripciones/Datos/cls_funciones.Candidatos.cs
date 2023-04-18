using System;
using Datos;
using MySql.Data.MySqlClient;

namespace Datos
{
    public class cls_funciones
    {
        public void fnt_Guardar(
            String id, string primernombre, string segundonombre, string primerapellido, string segundoapellido, string contacto, string direccion,
            string correo, string edad, int estudio, string acudientes)
        {
            try
            {
            cls_Conexion obj_conexion = new cls_Conexion();
                obj_conexion.fnt_conectar();
                string cosulta = "insert into tbl_personas(PKId,P_Nombre,S_Nombre,P_Apellido,S_Apellido,Contacto,Direccion,Correo,Edad,FKCodigo_tbl_nivelestudio,Acudiente)" + " values ('" + id + "','" + primernombre + "','" + segundonombre + "','" + primerapellido + "','" + segundoapellido + "','" + contacto + "','" + direccion + "','" + correo + "','" + edad + "','" + estudio + "','" + acudientes + "')";
                MySqlCommand comando = new MySqlCommand(cosulta, obj_conexion.conex);
                MySqlDataReader lectura = comando.ExecuteReader();
                obj_conexion.fnt_Desconectar();
            }catch (Exception) { }
        }
    }
}
