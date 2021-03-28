using System.Windows.Forms;
using AdministradorPcOne.Servicios;
using AdministradorPcOne;
using AdministradorPcOne.Forms;
using System.Collections.Generic;
using System;
using System.Drawing;

namespace PcOne.Forms
{
    public partial class EmpleadoForm : Form
    {
        SesionServicio sesionServicio = new SesionServicio();
        List<Empleado> Empleados = new List<Empleado>();
        public EmpleadoForm()
        {
            InitializeComponent();
            MostrarEmpleados();
        }
        private async void MostrarEmpleados()
        {
            Empleados = await sesionServicio.ObtenerEmpleadosAsync();
            if (Empleados == null)
            {
                Status.Image = AdministradorPcOne.Properties.Resources.Error;
                lblStatus.Text = "Ha Ocurrido un error";
                btnReload.Visible = true;
                return;
            }
            if (Empleados.Count == 0)
            {
                Status.Image = AdministradorPcOne.Properties.Resources.Empty;
                lblStatus.Text = "¡Oh No, No hay Ningun Empleado Registrado!";
                btnReload.Visible = true;
                return;
            }
            int y = 79;
            pnelContenedor.Controls.Clear();
            foreach (Empleado empleado in Empleados) {


                Panel panel = new Panel();
                
                panel.Size = new Size(531, 171);
                panel.Location = new Point(56,y);

                Label lblTitle = new Label();
                lblTitle.Location = new Point(19,13);
                lblTitle.Font = new Font("Times New Roman", 14);
                lblTitle.ForeColor = Color.Gray;
                lblTitle.Text = "Ficha de Empleado";
                lblTitle.AutoSize = true;

                PictureBox fotonombre = new PictureBox();
                fotonombre.Size = new Size(35, 33);
                fotonombre.Image = AdministradorPcOne.Properties.Resources.Nombre;
                fotonombre.Location = new Point(23, 46);
                fotonombre.SizeMode = PictureBoxSizeMode.StretchImage;
                Label lblNombre = new Label();
                lblNombre.Location = new Point(64, 60);
                lblNombre.Font = new Font("Times New Roman", 12);
                lblNombre.ForeColor = Color.Gray;
                lblNombre.Text = empleado.nombres;
                lblNombre.AutoSize = true;

                PictureBox fotoDUI = new PictureBox();
                fotoDUI.Size = new Size(35, 33);
                fotoDUI.Image = AdministradorPcOne.Properties.Resources.dui;
                fotoDUI.Location = new Point(23, 85);
                fotoDUI.SizeMode = PictureBoxSizeMode.StretchImage;
                Label lblDUI = new Label();
                lblDUI.Location = new Point(66, 99);
                lblDUI.Font = new Font("Times New Roman", 12);
                lblDUI.ForeColor = Color.Gray;
                lblDUI.Text = empleado.DUI;
                lblDUI.AutoSize = true;

                PictureBox fotoEMAIL = new PictureBox();
                fotoEMAIL.Size = new Size(35, 33);
                fotoEMAIL.Image = AdministradorPcOne.Properties.Resources.email;
                fotoEMAIL.Location = new Point(23, 124);
                fotoEMAIL.SizeMode = PictureBoxSizeMode.StretchImage; 
                Label lblEMAIL = new Label();
                lblEMAIL.Location = new Point(66, 138);
                lblEMAIL.Font = new Font("Times New Roman", 12);
                lblEMAIL.ForeColor = Color.Gray;
                lblEMAIL.Text = empleado.email;
                lblEMAIL.AutoSize = true; 

                PictureBox fotoTELEFONO = new PictureBox();
                fotoTELEFONO.Size = new Size(35, 33);
                fotoTELEFONO.Image = AdministradorPcOne.Properties.Resources.Telefono;
                fotoTELEFONO.Location = new Point(294, 46);
                fotoTELEFONO.SizeMode = PictureBoxSizeMode.StretchImage;
                Label lblTELEFONO = new Label();
                lblTELEFONO.Location = new Point(335, 60);
                lblTELEFONO.Font = new Font("Times New Roman", 12);
                lblTELEFONO.ForeColor = Color.Gray;
                lblTELEFONO.Text = empleado.telefono;
                lblTELEFONO.AutoSize = true;

                PictureBox fotoSALARIO = new PictureBox();
                fotoSALARIO.Size = new Size(35, 33);
                fotoSALARIO.Image = AdministradorPcOne.Properties.Resources.salario;
                fotoSALARIO.Location = new Point(294, 85);
                fotoSALARIO.SizeMode = PictureBoxSizeMode.StretchImage;
                Label lblSALARIO = new Label();
                lblSALARIO.Location = new Point(335, 99);
                lblSALARIO.Font = new Font("Times New Roman", 12, FontStyle.Bold);
                lblSALARIO.ForeColor = Color.Gray;
                lblSALARIO.Text = empleado.salario.ToString();
                lblSALARIO.AutoSize = true;

                PictureBox fotoCARGO = new PictureBox();
                fotoCARGO.Size = new Size(35, 33);
                fotoCARGO.Image = AdministradorPcOne.Properties.Resources.Cargo;
                fotoCARGO.Location = new Point(294, 124);
                fotoCARGO.SizeMode = PictureBoxSizeMode.StretchImage;
                Label lblCARGO = new Label();
                lblCARGO.Location = new Point(335, 138);
                lblCARGO.Font = new Font("Times New Roman", 12);
                lblCARGO.ForeColor = Color.Gray;
                lblCARGO.Text = empleado.Cargo.nombre_cargo;
                lblCARGO.AutoSize = true;

                panel.Controls.AddRange(new Control[]{lblTitle,fotonombre,lblNombre,fotoDUI,lblDUI,fotoEMAIL,lblEMAIL,fotoTELEFONO,lblTELEFONO,fotoSALARIO,lblSALARIO,fotoCARGO,lblCARGO });
                pnelContenedor.Controls.Add(panel);
                y += 175;
            }
           

        }
        private void btnReload_Click(object sender, System.EventArgs e)
        {
            MostrarEmpleados();
        }

        private void btnAddEmployee_Click(object sender, System.EventArgs e)
        {
            AgregarEmpleadoModal modal = new AgregarEmpleadoModal();
            modal.Show();
            modal.FormClosed += new FormClosedEventHandler(addform_FormClosed);
        }

        private void addform_FormClosed(object sender, FormClosedEventArgs e)
        {
            MostrarEmpleados();
        }

        private void btnAddCargo_Click(object sender, System.EventArgs e)
        {
            AgregarCargoModal modal = new AgregarCargoModal();
            modal.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
