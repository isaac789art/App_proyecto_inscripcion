﻿using System;
using System.Data;
using System.Drawing;
using System.IO;
using Datos;
using MySql.Data.MySqlClient;


namespace Datos
{
    public class cls_funcionesCandidatos
    {
        private DataTable Dt;
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




        public void fnt_Guardar(
            String id, string primernombre, string segundonombre, string primerapellido, string segundoapellido, string contacto, string direccion,
            string correo, string edad, int estudio, string acudientes, byte[] imagen)

        {
            try
            {
            cls_Conexion obj_conexion = new cls_Conexion();
                obj_conexion.fnt_conectar();
                string consulta = "insert into tbl_personas( PKId,P_Nombre,S_Nombre,P_Apellido,S_Apellido,Contacto,Direccion,Correo,Edad," +
                    "FKCodigo_tbl_nivelestudio,Acudiente,Imagenes) values('" + id + "','" + primernombre + "','" + segundonombre + "' , '" + primerapellido + "' , '" + segundoapellido + "' , '" + contacto + "', '" + direccion + "', '" + correo + "', '" + edad + "', '" + estudio + "' , '" + acudientes + "','" + imagen + "')";
                MySqlCommand comando = new MySqlCommand(consulta, obj_conexion.conex);
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
        public void fnt_consultar(string identificacion)
        {
            String sql = "select P_Nombre,S_Nombre,P_Apellido,S_Apellido,Contacto,Direccion,Correo,Edad,FKCodigo_tbl_nivelestudio,Acudiente,Imagenes from tbl_personas wherePKId = \"\";";
            cls_Conexion obj_conectar = new cls_Conexion();
            obj_conectar.fnt_conectar();
            try
            {
                MySqlCommand comando = new MySqlCommand(sql,obj_conectar.conex);
                MySqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    MemoryStream ms = new MemoryStream((byte[])reader["Foto"]);
                    bmp = new Bitmap(ms);
                    str_primernombre = reader["str_primernombre"].ToString();
                }
                
              
                  
                
            }
            catch { }


            obj_conectar.fnt_Desconectar();
        }
        public Bitmap getBop() { return bmp; }

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



        public void fnt_Guardar(string str_id, string str_primernombre, string str_segundonombre, string str_primerapellido, string str_segundoapellido, string str_contacto, string str_correo, string str_edad, int int_estudio, string str_acudientes)
        {
            throw new NotImplementedException();
        }

        public void fnt_Guardar(string str_id, string str_primernombre, string str_segundonombre, string str_primerapellido, string str_segundoapellido, string str_contacto, string str_correo, string str_edad, int int_estudio, string str_acudientes, byte[] byt_imagen)
        {
            throw new NotImplementedException();
        }

        public Bitmap Bmp()
        {
            throw new NotImplementedException();
        }
    }
}
