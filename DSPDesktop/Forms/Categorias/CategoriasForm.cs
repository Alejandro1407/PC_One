using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using AdministradorPcOne;
using AdministradorPcOne.Forms;
using AdministradorPcOne.Servicios;

namespace PcOne.Forms
{
    public partial class CategoriaForm : Form
    {
        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        CatalogoServicio catalogoServicio = new CatalogoServicio();
        List<Categoria> Categorias = new List<Categoria>();
        
        public CategoriaForm()
        {
            InitializeComponent();
            MostrarData();
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            AgregarCateogriaModal modal = new AgregarCateogriaModal();
            modal.Show();
            modal.FormClosed += new FormClosedEventHandler(addform_FormClosed);
        }
        public async void MostrarData(string param = "", bool IsSearch = false)
        {
            pnelContenedor.Controls.Clear();
            pnelContenedor.Controls.Add(btnReload);
            pnelContenedor.Controls.Add(lblStatus);
            pnelContenedor.Controls.Add(Status);
            pnelContenedor.Refresh();
            btnReload.Visible = false;
            Status.Image = AdministradorPcOne.Properties.Resources.Loading;
            lblStatus.Text = "Cargando";
            Categorias = await catalogoServicio.ObtenerCategoriasAsync();
            if (Categorias == null)
            {
                Status.Image = AdministradorPcOne.Properties.Resources.Error;
                lblStatus.Text = "Ha Ocurrido un error";
                btnReload.Visible = true;
                return;
            }
            if (Categorias.Count == 0)
            {
                Status.Image = AdministradorPcOne.Properties.Resources.Empty;
                lblStatus.Text = "¡Oh No, Aun no Hay Categorias!";
                btnReload.Visible = true;
                return;
            }
            pnelContenedor.Controls.Clear();
            int Y = 75;
            foreach (Categoria x in Categorias)
            {
                Panel pnel = new Panel();
                pnel.Size = new Size(475, 193);
                pnel.Location = new Point(27, Y);
                PictureBox Img = new PictureBox();
                Img.Location = new Point(6, 0);
                Img.SizeMode = PictureBoxSizeMode.StretchImage;
                Img.Image = byteArrayToImage(x.imagen_categoria);
                Img.Size = new Size(197, 193);
                pnel.Controls.Add(Img);
                Label lblTitle = new Label();
                lblTitle.Location = new Point(203, 33);
                lblTitle.Size = new Size(253, 30);
                lblTitle.TextAlign = ContentAlignment.MiddleCenter;
                lblTitle.Text = x.nombre_categoria;
                lblTitle.ForeColor = Color.Gray;
                lblTitle.Font = new Font("Times New Roman", 18);
                
                /*Label lblCategoria = new Label();
                lblCategoria.Size = new Size(259, 17);
                lblCategoria.TextAlign = ContentAlignment.MiddleCenter;
                lblCategoria.Text = "Productos?";
                //lblCategoria.ForeColor = Color.Black;
                lblCategoria.Location = new Point(197, 53);
                lblCategoria.Font = new Font("Times New Roman", 9, FontStyle.Bold);
                lblCategoria.ForeColor = Color.Black;*/
               /* Label lblPrecio = new Label();
                lblPrecio.AutoSize = true;
                lblPrecio.ForeColor = Color.Gray;
                lblPrecio.Text = x.descripcion;
                lblPrecio.Location = new Point(277, 60);
                lblPrecio.Font = new Font("Times New Roman", 12);*/
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
                BtnEditar.Click += new System.EventHandler(this.Editar_Click);
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
                pnel.Controls.AddRange(new Control[] { Img, lblTitle, /*lblCategoria, lblPrecio,*/ BtnEditar, BtnEliminar });
                pnelContenedor.Controls.Add(pnel);
                Y = (Y + 205); //Para que no imprimar una sobre  otra
            }
            pnelContenedor.Refresh(); //Actualiza el Contenido
        }//Metodo

        private void Editar_Click(object sender, System.EventArgs e)
            {
                EditarCategoriaModal editform = new EditarCategoriaModal();
                editform.id = (int.Parse((sender as Button).Name));
                editform.Show();
                editform.FormClosed += new FormClosedEventHandler(addform_FormClosed);

            }
        private void addform_FormClosed(object sender, FormClosedEventArgs e)
        {
            MostrarData();
        }

        private async void Eliminar_Click(object sender, System.EventArgs e)
            {
                bool answer = await catalogoServicio.EliminarCategoriaAsync(int.Parse((sender as Button).Name));

                if (answer)
                {
                    MessageBox.Show("Categoria Eliminada");
                    MostrarData();
                }
                else
                {
                    MessageBox.Show("No se puede eliminar un categoria con productos");
                }

            }
    }
}
