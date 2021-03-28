using AdministradorPcOne.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace AdministradorPcOne.Forms
{
    public partial class EditarCategoriaModal : Form
    {
        CatalogoServicio catalogoServicio = new CatalogoServicio();
        public int id = 0;
        private bool WereEdited = false;
        public EditarCategoriaModal()
        {
            InitializeComponent();
            
        }
        private byte[] FromImageToArrayByte()
        {
            byte[] ImgBytes = null;
            Image image = Image.FromFile(ImageFile.FileName);
            MemoryStream Memory = new MemoryStream();
            image.Save(Memory, ImageFormat.Jpeg);
            return ImgBytes = Memory.ToArray();
        }
        /*Funciones para arrastre*/
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        /*Arrastre*/
        CatalogoServicio CatalogoServicio = new CatalogoServicio();
        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture(); //Arrastre
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
             this.Close();
        }
     
        public async void MostrarData()
        {
            pnelContenedor.Controls.Clear();
            pnelContenedor.Controls.AddRange(new Control[] { status, lblStatus });
            pnelContenedor.Refresh();
            Categoria categoria = new Categoria();
            categoria = await catalogoServicio.ObtenerCategoriaAsync(id);
            if (categoria == null)
            {
                status.Image = AdministradorPcOne.Properties.Resources.Error;
                lblStatus.Text = "Ocurrio un Error";
                return;
            }
            
            txtNombre.Text = categoria.nombre_categoria;
            txtDescripcion.Text = categoria.descripcion;
            status.Visible = false;
            status.Location = new Point(173, 345);
            lblStatus.Visible = false;
            picSuccess.Visible = true;
            //btnUpload.Location = new Point(71, 219);
            pnelContenedor.Controls.AddRange(new Control[] { txtNombre, txtDescripcion, pictureBox1, pictureBox2, pictureBox3, btnUpload, picSuccess, btnOk });
            pnelContenedor.Refresh();

        }
            private async void btnOk_Click(object sender, EventArgs e)
        {
            btnOk.Visible = false;
            status.Visible = true;
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Nombre Invalido");
                status.Visible = false;
                btnOk.Visible = true;
                return;
            }
            if (txtDescripcion.Text == "Descripcion")
            {
                MessageBox.Show("Descripcion Invalida");
                status.Visible = false;
                btnOk.Visible = true;
                return;
            }
            if (picSuccess.Visible == false)
            {
                MessageBox.Show("No se ha seleccionado Imagen");
                status.Visible = false;
                btnOk.Visible = true;
                return;
            }
            Categoria c = new Categoria();
            c.nombre_categoria = txtNombre.Text;
            c.descripcion = txtDescripcion.Text;
            if (WereEdited) { c.imagen_categoria = FromImageToArrayByte(); }
            if (await CatalogoServicio.ActualizarCategoriaAsync(id,c,WereEdited))
            {
                MessageBox.Show("Datos Actualizados");
                status.Visible = false;
                btnOk.Visible = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Ocurrio un error");
                status.Visible = false;
                btnOk.Visible = true;
            }
        }


        private void btnUpload_Click(object sender, EventArgs e)
        {
            picSuccess.Visible = false;
            ImageFile.ShowDialog();

        }
        private void ImageFile_FileOk(object sender, CancelEventArgs e)
        {
            picSuccess.Visible = true;
            WereEdited = true;
        }

        private void EditarCategoriaModal_Load(object sender, EventArgs e)
        {
            MostrarData();
        }
    }
}
