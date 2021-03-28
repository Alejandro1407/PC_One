using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using DSPDesktop.Forms;
using PcOne.Forms;
using System.Drawing;

namespace DSPDesktop
{
    public partial class IndexForm : Form
    {
        public string Usuario = "Alejandro";
        Button Actual; //Guarda el button que inicio la form actual para darle color
        Form formActual; //Guarda la form actual abierta
        /*Utiles para permitir arrastre*/
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        /*Arrastre*/


        private void AbrirFormInPanel(object formulario)
        {
            Form fh = formulario as Form;
            if (pnelContenedor.Controls.Count > 0)
            {
                pnelContenedor.Controls.RemoveAt(0);
                formActual.Close();
            }
            else
            {
                formActual = fh;
            }
            formActual = fh;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.pnelContenedor.Controls.Add(fh);
            fh.Show();
          }

        public IndexForm()
        {
            InitializeComponent();
            Actual = btnCatalogo;
            AbrirFormInPanel(new CatalogoForm());
        }
        private void btnMin_Click(object sender, System.EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized) {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                
                this.WindowState = FormWindowState.Maximized;
                this.CenterToScreen();
                this.Refresh();
            }
         }

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture(); //Arrastre
            SendMessage(this.Handle,0x112,0xf012,0);
        }

        private void btnCatalogo_Click(object sender, EventArgs e)
        {
            Actual.BackColor = Color.White;
            Actual = ((Button)sender);
            Actual.BackColor = Color.LightGray;
            AbrirFormInPanel(new CatalogoForm());
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
                Actual.BackColor = Color.White;
                Actual = ((Button)sender);
                Actual.BackColor = Color.LightGray;
              AbrirFormInPanel(new VentasForm());
        }

        private void btnAdmi_Click(object sender, EventArgs e)
        {
            Actual.BackColor = Color.White;
            Actual = ((Button)sender);
            Actual.BackColor = Color.LightGray;
            AbrirFormInPanel(new EmpleadoForm());
        }
        
        private void btnAtencion_Click(object sender, EventArgs e)
        {
            Actual.BackColor = Color.White;
            Actual = ((Button)sender);
            Actual.BackColor = Color.LightGray;
            AbrirFormInPanel(new CategoriaForm());
        }

        private void btnCuenta_Click(object sender, EventArgs e)
        {
            Actual.BackColor = Color.White;
            Actual = ((Button)sender);
            Actual.BackColor = Color.LightGray;
            CuentaForm cuentaForm = new CuentaForm();
            cuentaForm.Usuario = this.Usuario;
            AbrirFormInPanel(cuentaForm);
        }

        private void IndexForm_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = Usuario;
        }
    }
}
