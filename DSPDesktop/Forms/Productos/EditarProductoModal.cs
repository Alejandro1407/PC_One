using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using AdministradorPcOne;
using AdministradorPcOne.Servicios;

namespace PcOne.Forms
{
    public partial class EditarProductoModal : Form
    {
        /*Funciones para arrastre*/
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        /*Arrastre*/

        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream mss = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(mss);
            return returnImage;
        }

        CatalogoServicio CatalogoServicio = new CatalogoServicio();
        public int id = 0;
        public EditarProductoModal()
        {
            InitializeComponent();
            MostrarData();
        }
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

        private void btnSubir_Click(object sender, EventArgs e)
        {
            Subir.ShowDialog(); //Se obtiene la Imagen
            if(Subir.FileName != "") { 
            PreviewImg.Image = Image.FromFile(Subir.FileName);
            }

        }
        private async void btnOk_Click(object sender, EventArgs e)
        {
            status.Visible = true;
            btnOk.Visible = false;
            byte[] ImgBytes = null;
            if (Subir.FileName != "")
            {
                Image image = Image.FromFile(Subir.FileName);
                MemoryStream Memory = new MemoryStream();
                image.Save(Memory, ImageFormat.Jpeg);
                ImgBytes = Memory.ToArray();
            }
            else
            {
                Image image = PreviewImg.Image;
                MemoryStream memory = new MemoryStream();
                image.Save(memory, ImageFormat.Jpeg);
                ImgBytes = memory.ToArray();
            }
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Debe Ingresar Nombre");
                status.Visible = false;
                btnOk.Visible = true;
                return;
            }
            if (comboCategoria.SelectedIndex == -1)
            {
                MessageBox.Show("Categoria no seleccionada");
                status.Visible = false;
                btnOk.Visible = true;
                return;
            }

            if (NumPrecio.Value == 0)
            {
                MessageBox.Show("Precio Invalido");
                status.Visible = false;
                btnOk.Visible = true;
                return;
            }
            if (int.Parse(NumDis.Value.ToString()) == 0)
            {
                MessageBox.Show("Stock Invalido");
                status.Visible = false;
                btnOk.Visible = true;
                return;
            }

            Producto p = new Producto();
            p.nombre = txtNombre.Text;
            p.id_categoria = (comboCategoria.SelectedItem as Categoria).id;
            p.precio_venta = NumPrecio.Value;
            p.cantidad = int.Parse(NumDis.Value.ToString());
            p.imagen_producto = ImgBytes;
            bool answer = await CatalogoServicio.EditarProductoAsync(id,p);
               if(answer == true)
                {
                    MessageBox.Show("Producto Actualizado");
                    this.Close();
                }
                else
                {
                    status.Visible = false;
                    btnOk.Visible = true;
                    MessageBox.Show("Lo Sentimos hubo un error");
                }
        }//Funcion
        private void EditarModal_Load(object sender, EventArgs e)
        {
            
        }
        public async void MostrarData()
        {
            pnelContenedor.Controls.Clear();
            pnelContenedor.Controls.AddRange(new Control[] { status, lblStatus });
            pnelContenedor.Refresh();

            List<Categoria> categorias = await CatalogoServicio.ObtenerCategoriasAsync();
            if(categorias == null)
            {
                status.Image = AdministradorPcOne.Properties.Resources.Error;
                lblStatus.Text = "Ocurrio un Error";
                return;
            }
            comboCategoria.DataSource = categorias;
            comboCategoria.DisplayMember = "nombre_categoria";
            Producto p = await CatalogoServicio.ObtenerProductoAsync(id);
            if ( p == null)
            {
                status.Image = AdministradorPcOne.Properties.Resources.Error;
                lblStatus.Text = "Ocurrio un Error";
                return;
            }
            status.Visible = false;
            status.Location = new Point(173,345);
            lblStatus.Visible = false;
            btnSubir.Location = new Point(100,240);
            pnelContenedor.Controls.Clear();
            txtNombre.Text = p.nombre;
            comboCategoria.SelectedValue = p.Categoria.nombre_categoria;
            NumPrecio.Value = decimal.Parse(p.precio_venta.ToString());
            NumDis.Value = decimal.Parse(p.cantidad.ToString());
            PreviewImg.Image = byteArrayToImage(p.imagen_producto);
            pnelContenedor.Controls.AddRange(new Control[] {btnSubir, txtNombre,comboCategoria,NumPrecio,NumDis,pictureBox1,pictureBox2,pictureBox3,pictureBox4,PreviewImg,btnOk,lblStatus,status});
            pnelContenedor.Refresh();
        }
    }//Clase
}//NameSpace