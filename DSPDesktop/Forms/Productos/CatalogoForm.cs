using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using PcOne.Forms;
using System;
using AdministradorPcOne;
using AdministradorPcOne.Servicios;

namespace DSPDesktop.Forms
{
    public partial class CatalogoForm : Form
    {
        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        CatalogoServicio catalogoServicio = new CatalogoServicio(); //Instancia Objeto
        List<Producto> Productos = new List<Producto>(); //Lista con los Objetos

        public CatalogoForm()
        {
            InitializeComponent();
            MostrarData();
        }

        private void Editar_Click(object sender, System.EventArgs e)
        {
            EditarProductoModal editarform = new EditarProductoModal();
            editarform.id = (int.Parse((sender as Button).Name));
            editarform.Show();
            editarform.FormClosed += new FormClosedEventHandler(addform_FormClosed);

        }

        private async void Eliminar_Click(object sender, System.EventArgs e)
        {
            bool answer = await catalogoServicio.EliminarProductoAsync(int.Parse((sender as Button).Name));
            
            if (answer)
            {
                MessageBox.Show("Registro Eliminado");
                MostrarData();
            }
            else
            {
                MessageBox.Show("Hubo un error");
            }
            
        }
        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            MostrarData(((TextBox)sender).Text,true);
        }
        private void btnAdd_Click(object sender, System.EventArgs e)
         {
            AgregarProductoModal addform = new AgregarProductoModal();
            addform.Show();
            addform.FormClosed += new FormClosedEventHandler(addform_FormClosed); //Cuando se cierre recargue la lista
         }
        private void addform_FormClosed(Object sender, FormClosedEventArgs e)
        {
             MostrarData(); //Vuelve a mostrar los productos
        }
        private void btnReload_Click(object sender, EventArgs e)
        {
            MostrarData();
        }
        public async void MostrarData(string param = "",bool IsSearch = false)
        {
            pnelContenedor.Controls.Clear();
            pnelContenedor.Controls.Add(btnReload);
            pnelContenedor.Controls.Add(lblStatus);
            pnelContenedor.Controls.Add(Status);
            pnelContenedor.Refresh();
            btnReload.Visible = false;
            Status.Image = AdministradorPcOne.Properties.Resources.Loading;
            lblStatus.Text = "Cargando Catalogo";
            Productos = await catalogoServicio.ObtenerProductosAsync(param);
            if (Productos == null)
            {
                Status.Image = AdministradorPcOne.Properties.Resources.Error;
                lblStatus.Text = "Ha Ocurrido un error";
                btnReload.Visible = true;
                return;
            }
            if (Productos.Count == 0 && !IsSearch)
            {
                Status.Image = AdministradorPcOne.Properties.Resources.Empty;
                lblStatus.Text = "¡Oh No, El catalogo esta vacio!";
                btnReload.Visible = true;
                return;
            }
         
            if (Productos.Count == 0 && IsSearch)
            {
                Status.Image = AdministradorPcOne.Properties.Resources.NoResult;
                lblStatus.Text = "No hay resultado para\n    " + param;
                return;
            }
            pnelContenedor.Controls.Clear();
            int Y = 50;
             foreach (Producto x in Productos)
                 {
                     Panel pnel = new Panel();
                     pnel.Size = new Size(475, 193);
                     pnel.Location = new Point(27, Y);
                     PictureBox Img = new PictureBox();
                     Img.Location = new Point(6, 0);
                     Img.SizeMode = PictureBoxSizeMode.StretchImage;
                     Img.Image = byteArrayToImage(x.imagen_producto);
                     Img.Size = new Size(197, 193);
                     pnel.Controls.Add(Img);
                     Label lblTitle = new Label();
                     lblTitle.Location = new Point(203, 33);
                     lblTitle.Size = new Size(253, 20);
                     lblTitle.TextAlign = ContentAlignment.MiddleCenter;
                     lblTitle.Text = x.nombre;
                     lblTitle.ForeColor = Color.Gray;
                     lblTitle.Font = new Font("Times New Roman", 12);
                     Label lblCategoria = new Label();
                     lblCategoria.Size = new Size(259, 17);
                     lblCategoria.TextAlign = ContentAlignment.MiddleCenter;
                     lblCategoria.Text = x.Categoria.nombre_categoria;
                     //lblCategoria.ForeColor = Color.Black;
                     lblCategoria.Location = new Point(197, 53);
                     lblCategoria.Font = new Font("Times New Roman", 9);
                     lblCategoria.ForeColor = Color.Gray;
                     Label lblPrecio = new Label();
                     lblPrecio.AutoSize = true;
                     lblPrecio.ForeColor = Color.Gray;
                     lblPrecio.Text = "Precio:$" + x.precio_venta.ToString();
                     lblPrecio.Location = new Point(277, 103);
                     lblPrecio.Font = new Font("Times New Roman", 12);
                     Button BtnEditar = new Button();
                     BtnEditar.Location = new Point(242, 137);
                     BtnEditar.Size = new Size(110, 50);
                     BtnEditar.FlatStyle = FlatStyle.Flat;
                     BtnEditar.FlatAppearance.BorderSize = 0;
                     BtnEditar.Image = AdministradorPcOne.Properties.Resources.Editar;
                     BtnEditar.TextImageRelation = TextImageRelation.ImageBeforeText;
                     BtnEditar.Text = "Editar";
                     BtnEditar.Name = x.id.ToString();
                     BtnEditar.ForeColor = Color.Gray;
                     BtnEditar.Font = new Font("Times New Roman", 12);
                     BtnEditar.Click += new System.EventHandler(Editar_Click);
                     Button BtnEliminar = new Button();
                     BtnEliminar.Location = new Point(350, 137);
                     BtnEliminar.Size = new Size(125, 50);
                     BtnEliminar.FlatStyle = FlatStyle.Flat;
                     BtnEliminar.FlatAppearance.BorderSize = 0;
                     BtnEliminar.Image = AdministradorPcOne.Properties.Resources.Eliminar;
                     BtnEliminar.TextImageRelation = TextImageRelation.ImageBeforeText;
                     BtnEliminar.Text = "Eliminar";
                     BtnEliminar.Name = x.id.ToString();
                     BtnEliminar.ForeColor = Color.Gray;
                     BtnEliminar.Font = new Font("Times New Roman", 12);
                     BtnEliminar.Click += new System.EventHandler(this.Eliminar_Click);
                     pnel.Controls.AddRange( new Control[] { Img ,lblTitle,lblCategoria,lblPrecio,BtnEditar,BtnEliminar});
                     /*pnel.Controls.Add(lblTitle);
                     pnel.Controls.Add(lblCategoria);
                     pnel.Controls.Add(lblPrecio);
                     pnel.Controls.Add(BtnEditar);
                     pnel.Controls.Add(BtnEliminar);*/
                     pnelContenedor.Controls.Add(pnel);
                     Y = (Y + 205); //Para que no imprimar una sobre  otra
                 }
            pnelContenedor.Refresh(); //Actualiza el Contenido
         }//Metodo

    }//Clase
}//NameSpace
