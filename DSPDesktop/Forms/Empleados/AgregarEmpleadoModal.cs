using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using AdministradorPcOne;
using AdministradorPcOne.Servicios;
using System.Text.RegularExpressions;


namespace PcOne.Forms
{
    public partial class AgregarEmpleadoModal : Form
    {
        /*Funciones para arrastre*/
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        /*Arrastre*/


        CatalogoServicio CatalogoServicio = new CatalogoServicio();

        public AgregarEmpleadoModal()
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

        
        private async void AddForm_Load(object sender, EventArgs e)
        {
            List<Cargo> cargos = await CatalogoServicio.ObtenerCargosAsync();
            if(cargos == null)
            {
                MessageBox.Show("Error Cargando Datos,Saliendo...");
                this.Close();
            }
            comboCargo.DataSource = cargos;
            comboCargo.DisplayMember = "nombre_cargo";
        }

        private async void btnOk_Click(object sender, EventArgs e)
        {
            btnOk.Visible = false;
            status.Visible = true;
            Cargo selected = comboCargo.SelectedItem as Cargo;
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Debe Ingresar un Nombre");
                btnOk.Visible = true;
                status.Visible = false;
                return;
            }
            string Nombre = @"^([A-Z]{1})+([a-z]){2,}(([''][A-Z][a-z]{1,})?){1}$";
            Regex CheckNombre = new Regex(Nombre);
            if (!CheckNombre.IsMatch(txtNombre.Text))
            {
                MessageBox.Show("Nombre Invalido!");
                btnOk.Visible = true;
                status.Visible = false;
                return;
            }
            if (txtDUI.Text == "")
            {
                MessageBox.Show("Debe Ingresar un DUI");
                btnOk.Visible = true;
                status.Visible = false;
                return;
            }
            string DUI = "^[0-9]{8}(-[0-9]{1})$";
            Regex CheckDUI = new Regex(DUI);
            if (!CheckDUI.IsMatch(txtDUI.Text))
            {
                MessageBox.Show("DUI Invalido!");
                btnOk.Visible = true;
                status.Visible = false;
                return;
            }
            if (txtEmail.Text == "")
            {
                MessageBox.Show("Debe Ingresar Un Correo!");
                btnOk.Visible = true;
                status.Visible = false;
                return;
            }
            string Email = @"^(\w){5,}(@){1}(\w){1,}(\.{1}(\w){2,}){1,}$";
            Regex CheckEmail = new Regex(Email);
            if (!CheckEmail.IsMatch(txtEmail.Text))
            {
                MessageBox.Show("Correo No Valido");
                btnOk.Visible = true;
                status.Visible = false;
                return;
            }
            if(txtPass.Text == "")
            {
                MessageBox.Show("Debe Ingresar una Contraseña");
                btnOk.Visible = true;
                status.Visible = false;
                return;
            }
            string pass = @"[A-Z]{1}((\w){1,})*(\d{1,})$";
            Regex CheckPass = new Regex(pass);
            if (!CheckPass.IsMatch(txtPass.Text))
            {
                MessageBox.Show("Contraseña Invalida");
                btnOk.Visible = true;
                status.Visible = false;
                return;
            }

            if (txtTelefono.Text == "")
            {
                MessageBox.Show("Debe Ingresar un Teléfono!");
                btnOk.Visible = true;
                status.Visible = false;
                return;
            }
            string Telefono = "^(22|78|60|61|73){1}[0-9]{6}$";
            Regex CheckTelefono = new Regex(Telefono);
            if (!CheckTelefono.IsMatch(txtTelefono.Text))
            {
                MessageBox.Show("Numero de Telefono No Valido");
                btnOk.Visible = true;
                status.Visible = false;
                return;
            }
            int Edad = (DateTime.Now.Subtract(dateNacimiento.Value).Days / 365);
            if (Edad < 18)
            {
                MessageBox.Show("Aqui no contratamos menores de edad");
                btnOk.Visible = true;
                status.Visible = false;
                return;
            }
            Empleado empleado = new Empleado();
            empleado.nombres = txtNombre.Text;
            empleado.DUI = txtDUI.Text;
            empleado.email = txtEmail.Text;
            empleado.contrasena = txtPass.Text;
            empleado.telefono = txtTelefono.Text;
            empleado.fecha_nac = dateNacimiento.Value;
            empleado.salario = numericSalario.Value;
            empleado.id_cargo = selected.id;
            empleado.edad = Edad;
            if(await CatalogoServicio.AgregarEmpleadoAsync(empleado))
            {
                MessageBox.Show("Empleado Agregado");
                this.Close();
            }
            else
            {
                MessageBox.Show("Hubo un Error");
                btnOk.Visible = true;
                status.Visible = false;
            }


        }//Funcion

    
    }//Clase
}//NameSpace
