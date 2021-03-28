using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using AdministradorPcOne.Servicios;
using AdministradorPcOne;

namespace PcOne.Forms
{
    public partial class CuentaForm : Form
    {
        public string Usuario = "";
        SesionServicio sesionServicio = new SesionServicio();
        public CuentaForm()
        {
            InitializeComponent();
        }

        private void CuentaForm_Load(object sender, EventArgs e)
        {
            MostrarData();
        }


        private async void MostrarData()
        {
            btnReload.Visible = false;
            Empleado empleado = await sesionServicio.ObtenerDatosEmpleadoAsync(Usuario);

            if(empleado == null)
            {
                status.Image = AdministradorPcOne.Properties.Resources.Error;
                lblStatus.Text = "Ocurrio un Error!";
                btnReload.Visible = true;
                return;
            }
            panel2.Location = new Point(32, 38);
            lblNombre.Text = empleado.nombres;
            lblDUI.Text = empleado.DUI;
            lblEmail.Text = empleado.email;
            lblTelefono.Text = empleado.telefono;
            lblSalario.Text = empleado.salario.ToString();
            lblCargo.Text = empleado.Cargo.nombre_cargo;
            lblNacimiento.Text = empleado.fecha_nac.ToString();
            lblPass.Text = "**********";
            status.Visible = false;
            lblStatus.Visible = false;
            btnReload.Visible = false;
            panel2.Visible = true;
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            MostrarData();
        }
    }
}
