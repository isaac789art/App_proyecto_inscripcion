using Negocio;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace App_inscripciones
{
    public partial class Form1 : Form
    {
        string ruta_directorio_Raiz;
        public Form1()
        {
            InitializeComponent();
            
            
            fnt_cargarnivelestudio();
            ruta_directorio_Raiz = Path.Combine(Application.StartupPath + "\\Imagen");
            fnt_nuevo();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void b_Click(object sender, EventArgs e)
        {
          
        }
        
        private void fnt_nuevo()
        {
            txt_acudinetes.Clear();
            txt_correo.Clear();
            txt_contacto.Clear();
            txt_direccion.Clear();
            txt_identificacion.Clear();
            txt_primer_nombre.Clear();
            txt_segundo_nombre.Clear();
            txt_primer_apellido.Clear();
            txt_segundo_apellido.Clear();
            cbx_nivelestudio.SelectedIndex = 0;
            ptb_foto.Image = Image.FromFile(ruta_directorio_Raiz + "\\anadirgrupo.png");
            txt_identificacion.Focus();

        }
        private void fnt_cargarnivelestudio()
        {
            cls_nivelestudio objDt = new cls_nivelestudio();
            objDt.fnt_CargarTipoEstudio();
            cbx_nivelestudio.ValueMember = "PKCodigo";
            cbx_nivelestudio.DisplayMember = "Nombre";
            cbx_nivelestudio.DataSource = objDt.getDt();
        
    }
        private void btn_nuevo_Click_1(object sender, EventArgs e)
        {
            fnt_nuevo();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)

        {
            MemoryStream ms = new MemoryStream();
            ptb_foto.Image.Save(ms, ImageFormat.Jpeg);
            byte[] aByte = ms.ToArray();

           

           
            {
                MessageBox.Show("Error al guardar imagen" + ex.Message);
            }
            cls_agregarCandidatos objagregarCandidato = new cls_agregarCandidatos (txt_identificacion.Text, txt_primer_nombre.Text,txt_segundo_nombre.Text, txt_primer_apellido.Text,txt_segundo_apellido.Text,txt_contacto.Text,txt_direccion.Text,txt_correo.Text,txt_Edad1.Text,cbx_nivelestudio.SelectedIndex + 1,txt_acudinetes.Text,aByte);
            MessageBox.Show("" + objagregarCandidato.getMsn());
        }

        private void ptb_foto_Click(object sender, EventArgs e)
        {
            try
            {
                ruta_directorio_Raiz = Path.Combine(Application.StartupPath + "\\Imagenes");
                OpenFileDialog File = new OpenFileDialog();
                File.Filter = "Archivo JPG|*.jpg";

                if (File.ShowDialog() == DialogResult.OK)
                {
                    ptb_foto.Image = Image.FromFile(File.FileName);
                }
            }
            catch { }
        }
    }
}
