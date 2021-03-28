using System.Windows.Forms;
using System.Runtime.InteropServices;
using AdministradorPcOne;
using AdministradorPcOne.Servicios;
using System.Text.RegularExpressions;

namespace DSPDesktop
{
    public partial class LoginForm : Form
    {
        /*Utiles para permitir arrastre*/
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        /*Arrastre*/

        SesionServicio sesionServicio = new SesionServicio(); //Instancia de Login para inicio de sesion

        public LoginForm()
        {
            InitializeComponent();
        }
        private void btnMin_Click(object sender, System.EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }
        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture(); //Arrastre
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

    
        /*Depuracion*/
        private void LoginForm_Load(object sender, System.EventArgs e)
        {
      /*      Form form = new IndexForm();
            this.Close();
            form.Show();
            */
        }

        private async void BtnOk_Click(object sender, System.EventArgs e)
        {

            Status.Visible = true;
            BtnOk.Visible = false;
            if (txtEmail.Text == "")
            {
                MessageBox.Show("Debe Ingresar Un Correo!");
                BtnOk.Visible = true;
                Status.Visible = false;
                return;
            }
            string Email = @"^(\w){5,}(@){1}(\w){1,}(\.{1}(\w){2,}){1,}$";
            Regex CheckEmail = new Regex(Email);
            if (!CheckEmail.IsMatch(txtEmail.Text))
            {
                MessageBox.Show("Correo No Valido");
                BtnOk.Visible = true;
                Status.Visible = false;
                return;
            }
            if (txtPass.Text == "")
            {
                MessageBox.Show("Debe Ingresar una Contraseña");
                BtnOk.Visible = true;
                Status.Visible = false;
                return;
            }
            string pass = @"[A-Z]{1}((\w){1,})*(\d{1,})$";
            Regex CheckPass = new Regex(pass);
            if (!CheckPass.IsMatch(txtPass.Text))
            {
                MessageBox.Show("Contraseña Invalida");
                BtnOk.Visible = true;
                Status.Visible = false;
                return;
            }
            Empleado answer = await sesionServicio.IniciarSesionAsync(txtEmail.Text);
            if(answer == null)
            {
                MessageBox.Show("Datos Invalidos");
                BtnOk.Visible = true;
                Status.Visible = false;
                return;
            }
            if (answer.contrasena.Equals(txtPass.Text))
            {
                IndexForm indexform = new IndexForm();
                indexform.Usuario = answer.nombres;
                this.Close();
                indexform.Show();
            }
            else
            {
                MessageBox.Show("Contraseña Incorrecta");
                BtnOk.Visible = true;
                Status.Visible = false;
            }
        }
    }
}
