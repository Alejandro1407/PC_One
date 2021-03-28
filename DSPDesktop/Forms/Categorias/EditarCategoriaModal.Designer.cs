namespace AdministradorPcOne.Forms
{
    partial class EditarCategoriaModal
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
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.picSuccess = new System.Windows.Forms.PictureBox();
            this.btnUpload = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.status = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnOk = new Bunifu.Framework.UI.BunifuFlatButton();
            this.ImageFile = new System.Windows.Forms.OpenFileDialog();
            this.pnelContenedor = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtDescripcion = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSuccess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.status)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnelContenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.White;
            this.BarraTitulo.Controls.Add(this.label2);
            this.BarraTitulo.Controls.Add(this.btnClose);
            this.BarraTitulo.Controls.Add(this.btnMin);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(347, 32);
            this.BarraTitulo.TabIndex = 10;
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
            this.btnClose.Location = new System.Drawing.Point(322, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(22, 26);
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
            this.btnMin.Location = new System.Drawing.Point(294, 3);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(22, 26);
            this.btnMin.TabIndex = 0;
            this.btnMin.UseVisualStyleBackColor = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // picSuccess
            // 
            this.picSuccess.Image = global::AdministradorPcOne.Properties.Resources.OK;
            this.picSuccess.Location = new System.Drawing.Point(243, 159);
            this.picSuccess.Name = "picSuccess";
            this.picSuccess.Size = new System.Drawing.Size(25, 25);
            this.picSuccess.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSuccess.TabIndex = 20;
            this.picSuccess.TabStop = false;
            this.picSuccess.Visible = false;
            // 
            // btnUpload
            // 
            this.btnUpload.Activecolor = System.Drawing.Color.LightGray;
            this.btnUpload.BackColor = System.Drawing.Color.White;
            this.btnUpload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpload.BorderRadius = 0;
            this.btnUpload.ButtonText = "Subir";
            this.btnUpload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpload.DisabledColor = System.Drawing.Color.Gray;
            this.btnUpload.Iconcolor = System.Drawing.Color.Transparent;
            this.btnUpload.Iconimage = global::AdministradorPcOne.Properties.Resources.Upload;
            this.btnUpload.Iconimage_right = null;
            this.btnUpload.Iconimage_right_Selected = null;
            this.btnUpload.Iconimage_Selected = null;
            this.btnUpload.IconMarginLeft = 2;
            this.btnUpload.IconMarginRight = 0;
            this.btnUpload.IconRightVisible = true;
            this.btnUpload.IconRightZoom = 0D;
            this.btnUpload.IconVisible = true;
            this.btnUpload.IconZoom = 90D;
            this.btnUpload.IsTab = false;
            this.btnUpload.Location = new System.Drawing.Point(95, 159);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Normalcolor = System.Drawing.Color.White;
            this.btnUpload.OnHovercolor = System.Drawing.Color.LightGray;
            this.btnUpload.OnHoverTextColor = System.Drawing.Color.LightGray;
            this.btnUpload.selected = false;
            this.btnUpload.Size = new System.Drawing.Size(113, 35);
            this.btnUpload.TabIndex = 19;
            this.btnUpload.Text = "Subir";
            this.btnUpload.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpload.Textcolor = System.Drawing.Color.Gray;
            this.btnUpload.TextFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::AdministradorPcOne.Properties.Resources.imagen;
            this.pictureBox3.Location = new System.Drawing.Point(33, 158);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(37, 36);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 18;
            this.pictureBox3.TabStop = false;
            // 
            // status
            // 
            this.status.Image = global::AdministradorPcOne.Properties.Resources.Loading;
            this.status.Location = new System.Drawing.Point(112, 70);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(125, 114);
            this.status.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.status.TabIndex = 17;
            this.status.TabStop = false;
            this.status.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::AdministradorPcOne.Properties.Resources.Descripcion;
            this.pictureBox2.Location = new System.Drawing.Point(33, 97);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(37, 36);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AdministradorPcOne.Properties.Resources.NombreCategoria;
            this.pictureBox1.Location = new System.Drawing.Point(33, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // btnOk
            // 
            this.btnOk.Activecolor = System.Drawing.Color.Silver;
            this.btnOk.BackColor = System.Drawing.Color.White;
            this.btnOk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOk.BorderRadius = 0;
            this.btnOk.ButtonText = "Actualizar";
            this.btnOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOk.DisabledColor = System.Drawing.Color.Gray;
            this.btnOk.ForeColor = System.Drawing.Color.Black;
            this.btnOk.Iconcolor = System.Drawing.Color.Transparent;
            this.btnOk.Iconimage = global::AdministradorPcOne.Properties.Resources.AddCategory;
            this.btnOk.Iconimage_right = null;
            this.btnOk.Iconimage_right_Selected = null;
            this.btnOk.Iconimage_Selected = null;
            this.btnOk.IconMarginLeft = 0;
            this.btnOk.IconMarginRight = 0;
            this.btnOk.IconRightVisible = true;
            this.btnOk.IconRightZoom = 0D;
            this.btnOk.IconVisible = true;
            this.btnOk.IconZoom = 90D;
            this.btnOk.IsTab = false;
            this.btnOk.Location = new System.Drawing.Point(95, 231);
            this.btnOk.Name = "btnOk";
            this.btnOk.Normalcolor = System.Drawing.Color.White;
            this.btnOk.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnOk.OnHoverTextColor = System.Drawing.Color.White;
            this.btnOk.selected = false;
            this.btnOk.Size = new System.Drawing.Size(125, 48);
            this.btnOk.TabIndex = 12;
            this.btnOk.Text = "Actualizar";
            this.btnOk.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOk.Textcolor = System.Drawing.Color.Gray;
            this.btnOk.TextFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // ImageFile
            // 
            this.ImageFile.Filter = "JPEG|*.jpeg*";
            this.ImageFile.InitialDirectory = "@C:\\";
            this.ImageFile.FileOk += new System.ComponentModel.CancelEventHandler(this.ImageFile_FileOk);
            // 
            // pnelContenedor
            // 
            this.pnelContenedor.Controls.Add(this.status);
            this.pnelContenedor.Controls.Add(this.txtDescripcion);
            this.pnelContenedor.Controls.Add(this.txtNombre);
            this.pnelContenedor.Controls.Add(this.lblStatus);
            this.pnelContenedor.Controls.Add(this.btnUpload);
            this.pnelContenedor.Controls.Add(this.btnOk);
            this.pnelContenedor.Controls.Add(this.pictureBox1);
            this.pnelContenedor.Controls.Add(this.pictureBox2);
            this.pnelContenedor.Controls.Add(this.pictureBox3);
            this.pnelContenedor.Controls.Add(this.picSuccess);
            this.pnelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnelContenedor.Location = new System.Drawing.Point(0, 32);
            this.pnelContenedor.Name = "pnelContenedor";
            this.pnelContenedor.Size = new System.Drawing.Size(347, 320);
            this.pnelContenedor.TabIndex = 25;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Gray;
            this.lblStatus.Location = new System.Drawing.Point(117, 187);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(120, 19);
            this.lblStatus.TabIndex = 21;
            this.lblStatus.Text = "Obteniendo Datos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(108, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 21);
            this.label2.TabIndex = 22;
            this.label2.Text = "Editar Categoria";
            // 
            // txtNombre
            // 
            this.txtNombre.Depth = 0;
            this.txtNombre.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.Gray;
            this.txtNombre.Hint = "Nombre";
            this.txtNombre.Location = new System.Drawing.Point(76, 41);
            this.txtNombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PasswordChar = '\0';
            this.txtNombre.SelectedText = "";
            this.txtNombre.SelectionLength = 0;
            this.txtNombre.SelectionStart = 0;
            this.txtNombre.Size = new System.Drawing.Size(185, 23);
            this.txtNombre.TabIndex = 22;
            this.txtNombre.UseSystemPasswordChar = false;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Depth = 0;
            this.txtDescripcion.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.ForeColor = System.Drawing.Color.Gray;
            this.txtDescripcion.Hint = "Descripcion";
            this.txtDescripcion.Location = new System.Drawing.Point(83, 110);
            this.txtDescripcion.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.PasswordChar = '\0';
            this.txtDescripcion.SelectedText = "";
            this.txtDescripcion.SelectionLength = 0;
            this.txtDescripcion.SelectionStart = 0;
            this.txtDescripcion.Size = new System.Drawing.Size(185, 23);
            this.txtDescripcion.TabIndex = 23;
            this.txtDescripcion.UseSystemPasswordChar = false;
            // 
            // EditarCategoriaModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(347, 352);
            this.Controls.Add(this.pnelContenedor);
            this.Controls.Add(this.BarraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditarCategoriaModal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarCateogriaModal";
            this.Load += new System.EventHandler(this.EditarCategoriaModal_Load);
            this.BarraTitulo.ResumeLayout(false);
            this.BarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSuccess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.status)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnelContenedor.ResumeLayout(false);
            this.pnelContenedor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMin;
        private Bunifu.Framework.UI.BunifuFlatButton btnOk;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox status;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Bunifu.Framework.UI.BunifuFlatButton btnUpload;
        private System.Windows.Forms.PictureBox picSuccess;
        private System.Windows.Forms.OpenFileDialog ImageFile;
        private System.Windows.Forms.Panel pnelContenedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblStatus;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNombre;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDescripcion;
    }
}