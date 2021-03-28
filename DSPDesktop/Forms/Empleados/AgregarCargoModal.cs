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
    public partial class AgregarCargoModal : Form
    {
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
            //Depuracion
            // Application.Exit();
            this.Close();
        }
        public AgregarCargoModal()
        {
            InitializeComponent();
        }
        private async void btnOk_Click(object sender, EventArgs e)
        {
            btnOk.Visible = false;
            Status.Visible = true;
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Nombre Invalido");
                Status.Visible = false;
                btnOk.Visible = true;
                return;
            }
            if (txtDescripcion.Text == "Descripcion")
            {
                MessageBox.Show("Descripcion Invalida");
                Status.Visible = false;
                btnOk.Visible = true;
                return;
            }
            Cargo c = new Cargo();
            c.nombre_cargo = txtNombre.Text;
            c.descripcion_cargo = txtDescripcion.Text;
            if (await CatalogoServicio.AgregarCargoAsync(c))
            {
                MessageBox.Show("Cargo Agregado");
                Status.Visible = false;
                btnOk.Visible = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Ocurrio un error");
                Status.Visible = false;
                btnOk.Visible = true;
            }
        }
    
    }//Clase
}//NameSpace
