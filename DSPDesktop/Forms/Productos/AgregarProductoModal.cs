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
    public partial class AgregarProductoModal : Form
    {
        /*Funciones para arrastre*/
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        /*Arrastre*/


        CatalogoServicio CatalogoServicio = new CatalogoServicio();

        public AgregarProductoModal()
        {
            InitializeComponent();
         
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
        private async void AddForm_Load(object sender, EventArgs e)
        {
            comboCategoria.DataSource = await CatalogoServicio.ObtenerCategoriasAsync();
            comboCategoria.DisplayMember = "nombre_categoria";
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
                MessageBox.Show("Debe Seleccionar una Imagen");
                status.Visible = false;
                btnOk.Visible = true;
                return;
            }
          
             
            if(txtNombre.Text == "")
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
           
            if(NumPrecio.Value == 0)
            {
               MessageBox.Show("Precio Invalido");
                status.Visible = false;
                btnOk.Visible = true;
                return;
            }
           if(int.Parse(NumDis.Value.ToString()) == 0)
            {
                MessageBox.Show("Stock Invalido");
                status.Visible = false;
                btnOk.Visible = true;
                return;
            }
            
                Producto p = new Producto();
                p.nombre = txtNombre.Text;
                p.id_categoria =  (comboCategoria.SelectedItem as Categoria).id;
                p.precio_venta = NumPrecio.Value;
                p.cantidad = int.Parse(NumDis.Value.ToString());
                p.imagen_producto = ImgBytes;
                bool answer = await CatalogoServicio.AgregarProductoAsync(p);
               if(answer == true)
                {
                    MessageBox.Show("Producto Agregado");
                    this.Close();
                }
                else
                {
                    status.Visible = false;
                    btnOk.Visible = true;
                    MessageBox.Show("Lo Sentimos hubo un error");
                }
                
            
            

        }//Funcion
    }//Clase
}//NameSpace
