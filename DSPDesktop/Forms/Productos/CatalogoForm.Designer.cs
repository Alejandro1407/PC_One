namespace DSPDesktop.Forms
{
    partial class CatalogoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtBuscar = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnelOpciones = new System.Windows.Forms.PictureBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pnelContenedor = new System.Windows.Forms.Panel();
            this.btnReload = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblStatus = new System.Windows.Forms.Label();
            this.Status = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnelOpciones)).BeginInit();
            this.pnelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Status)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBuscar
            // 
            this.txtBuscar.Depth = 0;
            this.txtBuscar.Hint = "Buscar";
            this.txtBuscar.Location = new System.Drawing.Point(348, 26);
            this.txtBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.PasswordChar = '\0';
            this.txtBuscar.SelectedText = "";
            this.txtBuscar.SelectionLength = 0;
            this.txtBuscar.SelectionStart = 0;
            this.txtBuscar.Size = new System.Drawing.Size(175, 23);
            this.txtBuscar.TabIndex = 0;
            this.txtBuscar.UseSystemPasswordChar = false;
            this.txtBuscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscar_KeyUp);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnelOpciones);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.txtBuscar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(638, 55);
            this.panel1.TabIndex = 6;
            // 
            // pnelOpciones
            // 
            this.pnelOpciones.Image = global::AdministradorPcOne.Properties.Resources.Buscar;
            this.pnelOpciones.Location = new System.Drawing.Point(491, 12);
            this.pnelOpciones.Name = "pnelOpciones";
            this.pnelOpciones.Size = new System.Drawing.Size(41, 37);
            this.pnelOpciones.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pnelOpciones.TabIndex = 1;
            this.pnelOpciones.TabStop = false;
            // 
            // btnAdd
            // 
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Gray;
            this.btnAdd.Image = global::AdministradorPcOne.Properties.Resources.Add;
            this.btnAdd.Location = new System.Drawing.Point(38, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(117, 49);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Añadir";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // pnelContenedor
            // 
            this.pnelContenedor.AutoScroll = true;
            this.pnelContenedor.BackColor = System.Drawing.Color.Transparent;
            this.pnelContenedor.Controls.Add(this.btnReload);
            this.pnelContenedor.Controls.Add(this.lblStatus);
            this.pnelContenedor.Controls.Add(this.Status);
            this.pnelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnelContenedor.Location = new System.Drawing.Point(0, 55);
            this.pnelContenedor.Name = "pnelContenedor";
            this.pnelContenedor.Size = new System.Drawing.Size(638, 508);
            this.pnelContenedor.TabIndex = 7;
            // 
            // btnReload
            // 
            this.btnReload.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnReload.BackColor = System.Drawing.Color.White;
            this.btnReload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReload.BorderRadius = 0;
            this.btnReload.ButtonText = "Reintentar";
            this.btnReload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReload.DisabledColor = System.Drawing.Color.Gray;
            this.btnReload.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReload.Iconcolor = System.Drawing.Color.Transparent;
            this.btnReload.Iconimage = global::AdministradorPcOne.Properties.Resources.reload;
            this.btnReload.Iconimage_right = null;
            this.btnReload.Iconimage_right_Selected = null;
            this.btnReload.Iconimage_Selected = null;
            this.btnReload.IconMarginLeft = 0;
            this.btnReload.IconMarginRight = 0;
            this.btnReload.IconRightVisible = true;
            this.btnReload.IconRightZoom = 0D;
            this.btnReload.IconVisible = true;
            this.btnReload.IconZoom = 90D;
            this.btnReload.IsTab = false;
            this.btnReload.Location = new System.Drawing.Point(252, 291);
            this.btnReload.Name = "btnReload";
            this.btnReload.Normalcolor = System.Drawing.Color.White;
            this.btnReload.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnReload.OnHoverTextColor = System.Drawing.Color.White;
            this.btnReload.selected = false;
            this.btnReload.Size = new System.Drawing.Size(134, 53);
            this.btnReload.TabIndex = 48;
            this.btnReload.Text = "Reintentar";
            this.btnReload.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReload.Textcolor = System.Drawing.Color.Gray;
            this.btnReload.TextFont = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReload.Visible = false;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Gray;
            this.lblStatus.Location = new System.Drawing.Point(239, 255);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(146, 21);
            this.lblStatus.TabIndex = 47;
            this.lblStatus.Text = "Obteniendo Datos";
            // 
            // Status
            // 
            this.Status.Image = global::AdministradorPcOne.Properties.Resources.Loading;
            this.Status.Location = new System.Drawing.Point(252, 125);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(117, 111);
            this.Status.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Status.TabIndex = 25;
            this.Status.TabStop = false;
            // 
            // CatalogoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(638, 563);
            this.Controls.Add(this.pnelContenedor);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CatalogoForm";
            this.Opacity = 0.5D;
            this.Text = "CatalogoForm";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnelOpciones)).EndInit();
            this.pnelContenedor.ResumeLayout(false);
            this.pnelContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Status)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pnelOpciones;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBuscar;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnelContenedor;
        private System.Windows.Forms.PictureBox Status;
        private System.Windows.Forms.Label lblStatus;
        private Bunifu.Framework.UI.BunifuFlatButton btnReload;
    }
}