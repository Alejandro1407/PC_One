namespace DSPDesktop
{
    partial class IndexForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IndexForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAtencion = new System.Windows.Forms.Button();
            this.btnCuenta = new System.Windows.Forms.Button();
            this.lblUsuario = new MaterialSkin.Controls.MaterialLabel();
            this.btnAdmi = new System.Windows.Forms.Button();
            this.btnCatalogo = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.pnelContenedor = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.BarraTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnAtencion);
            this.panel1.Controls.Add(this.btnCuenta);
            this.panel1.Controls.Add(this.lblUsuario);
            this.panel1.Controls.Add(this.btnAdmi);
            this.panel1.Controls.Add(this.btnCatalogo);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 595);
            this.panel1.TabIndex = 0;
            // 
            // btnAtencion
            // 
            this.btnAtencion.FlatAppearance.BorderSize = 0;
            this.btnAtencion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtencion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtencion.Image = global::AdministradorPcOne.Properties.Resources.NombreCategoria1;
            this.btnAtencion.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAtencion.Location = new System.Drawing.Point(3, 214);
            this.btnAtencion.Name = "btnAtencion";
            this.btnAtencion.Size = new System.Drawing.Size(197, 50);
            this.btnAtencion.TabIndex = 6;
            this.btnAtencion.Text = "Categorias";
            this.btnAtencion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtencion.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAtencion.UseVisualStyleBackColor = true;
            this.btnAtencion.Click += new System.EventHandler(this.btnAtencion_Click);
            // 
            // btnCuenta
            // 
            this.btnCuenta.FlatAppearance.BorderSize = 0;
            this.btnCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCuenta.Image = global::AdministradorPcOne.Properties.Resources.Ajustes1;
            this.btnCuenta.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCuenta.Location = new System.Drawing.Point(3, 364);
            this.btnCuenta.Name = "btnCuenta";
            this.btnCuenta.Size = new System.Drawing.Size(197, 50);
            this.btnCuenta.TabIndex = 5;
            this.btnCuenta.Text = "Cuenta";
            this.btnCuenta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCuenta.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCuenta.UseVisualStyleBackColor = true;
            this.btnCuenta.Click += new System.EventHandler(this.btnCuenta_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Depth = 0;
            this.lblUsuario.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblUsuario.Location = new System.Drawing.Point(61, 88);
            this.lblUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(73, 19);
            this.lblUsuario.TabIndex = 4;
            this.lblUsuario.Text = "Alejandro";
            // 
            // btnAdmi
            // 
            this.btnAdmi.FlatAppearance.BorderSize = 0;
            this.btnAdmi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmi.Image = global::AdministradorPcOne.Properties.Resources.admins1;
            this.btnAdmi.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdmi.Location = new System.Drawing.Point(3, 289);
            this.btnAdmi.Name = "btnAdmi";
            this.btnAdmi.Size = new System.Drawing.Size(197, 50);
            this.btnAdmi.TabIndex = 2;
            this.btnAdmi.Text = "Empleados";
            this.btnAdmi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdmi.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAdmi.UseVisualStyleBackColor = true;
            this.btnAdmi.Click += new System.EventHandler(this.btnAdmi_Click);
            // 
            // btnCatalogo
            // 
            this.btnCatalogo.BackColor = System.Drawing.Color.LightGray;
            this.btnCatalogo.FlatAppearance.BorderSize = 0;
            this.btnCatalogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCatalogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCatalogo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCatalogo.Image = global::AdministradorPcOne.Properties.Resources.Inventory;
            this.btnCatalogo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCatalogo.Location = new System.Drawing.Point(3, 130);
            this.btnCatalogo.Name = "btnCatalogo";
            this.btnCatalogo.Size = new System.Drawing.Size(197, 59);
            this.btnCatalogo.TabIndex = 1;
            this.btnCatalogo.Text = "Catalogo";
            this.btnCatalogo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCatalogo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCatalogo.UseVisualStyleBackColor = false;
            this.btnCatalogo.Click += new System.EventHandler(this.btnCatalogo_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(21, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.Controls.Add(this.btnClose);
            this.BarraTitulo.Controls.Add(this.btnMin);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(200, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(638, 32);
            this.BarraTitulo.TabIndex = 8;
            this.BarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseDown);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackgroundImage = global::AdministradorPcOne.Properties.Resources.Close;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(605, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 26);
            this.btnClose.TabIndex = 2;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.BackgroundImage = global::AdministradorPcOne.Properties.Resources.minus;
            this.btnMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMin.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Location = new System.Drawing.Point(578, 3);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(30, 26);
            this.btnMin.TabIndex = 0;
            this.btnMin.UseVisualStyleBackColor = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // pnelContenedor
            // 
            this.pnelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnelContenedor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnelContenedor.Location = new System.Drawing.Point(200, 32);
            this.pnelContenedor.Name = "pnelContenedor";
            this.pnelContenedor.Size = new System.Drawing.Size(638, 563);
            this.pnelContenedor.TabIndex = 9;
            // 
            // IndexForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(838, 595);
            this.Controls.Add(this.pnelContenedor);
            this.Controls.Add(this.BarraTitulo);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1280, 640);
            this.Name = "IndexForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.IndexForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.BarraTitulo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCatalogo;
        private System.Windows.Forms.Button btnAdmi;
        private System.Windows.Forms.Panel pnelContenedor;
        private System.Windows.Forms.Button btnCuenta;
        private MaterialSkin.Controls.MaterialLabel lblUsuario;
        private System.Windows.Forms.Button btnAtencion;
    }
}