namespace PcOne.Forms
{

    partial class EditarProductoModal
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
            this.Subir = new System.Windows.Forms.OpenFileDialog();
            this.pnelContenedor = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.PictureBox();
            this.btnSubir = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboCategoria = new System.Windows.Forms.ComboBox();
            this.NumDis = new System.Windows.Forms.NumericUpDown();
            this.NumPrecio = new System.Windows.Forms.NumericUpDown();
            this.txtNombre = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.PreviewImg = new System.Windows.Forms.PictureBox();
            this.BarraTitulo.SuspendLayout();
            this.pnelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.status)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumDis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PreviewImg)).BeginInit();
            this.SuspendLayout();
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.White;
            this.BarraTitulo.Controls.Add(this.btnClose);
            this.BarraTitulo.Controls.Add(this.btnMin);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(589, 32);
            this.BarraTitulo.TabIndex = 9;
            this.BarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseDown);
            // 
            // Subir
            // 
            this.Subir.Filter = "JPEG|*.jpeg*";
            this.Subir.InitialDirectory = "@C:\\";
            this.Subir.Title = "Subir Imagen";
            // 
            // pnelContenedor
            // 
            this.pnelContenedor.Controls.Add(this.status);
            this.pnelContenedor.Controls.Add(this.PreviewImg);
            this.pnelContenedor.Controls.Add(this.pictureBox4);
            this.pnelContenedor.Controls.Add(this.pictureBox3);
            this.pnelContenedor.Controls.Add(this.pictureBox2);
            this.pnelContenedor.Controls.Add(this.pictureBox1);
            this.pnelContenedor.Controls.Add(this.comboCategoria);
            this.pnelContenedor.Controls.Add(this.NumDis);
            this.pnelContenedor.Controls.Add(this.NumPrecio);
            this.pnelContenedor.Controls.Add(this.txtNombre);
            this.pnelContenedor.Controls.Add(this.lblStatus);
            this.pnelContenedor.Controls.Add(this.btnSubir);
            this.pnelContenedor.Controls.Add(this.btnOk);
            this.pnelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnelContenedor.Location = new System.Drawing.Point(0, 32);
            this.pnelContenedor.Name = "pnelContenedor";
            this.pnelContenedor.Size = new System.Drawing.Size(589, 464);
            this.pnelContenedor.TabIndex = 23;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Gray;
            this.lblStatus.Location = new System.Drawing.Point(193, 290);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(146, 21);
            this.lblStatus.TabIndex = 26;
            this.lblStatus.Text = "Obteniendo Datos";
            // 
            // status
            // 
            this.status.Image = global::AdministradorPcOne.Properties.Resources.Loading;
            this.status.Location = new System.Drawing.Point(197, 136);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(142, 135);
            this.status.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.status.TabIndex = 22;
            this.status.TabStop = false;
            // 
            // btnSubir
            // 
            this.btnSubir.FlatAppearance.BorderSize = 0;
            this.btnSubir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubir.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubir.ForeColor = System.Drawing.Color.Gray;
            this.btnSubir.Image = global::AdministradorPcOne.Properties.Resources.Upload;
            this.btnSubir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubir.Location = new System.Drawing.Point(82, 245);
            this.btnSubir.Name = "btnSubir";
            this.btnSubir.Size = new System.Drawing.Size(105, 46);
            this.btnSubir.TabIndex = 24;
            this.btnSubir.Text = "Subir";
            this.btnSubir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSubir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSubir.UseVisualStyleBackColor = true;
            this.btnSubir.Click += new System.EventHandler(this.btnSubir_Click);
            // 
            // btnOk
            // 
            this.btnOk.FlatAppearance.BorderSize = 0;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Image = global::AdministradorPcOne.Properties.Resources.Add;
            this.btnOk.Location = new System.Drawing.Point(184, 343);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(188, 58);
            this.btnOk.TabIndex = 18;
            this.btnOk.Text = "Actualizar Datos";
            this.btnOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackgroundImage = global::AdministradorPcOne.Properties.Resources.Close;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(564, 3);
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
            this.btnMin.Location = new System.Drawing.Point(536, 3);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(22, 26);
            this.btnMin.TabIndex = 0;
            this.btnMin.UseVisualStyleBackColor = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::AdministradorPcOne.Properties.Resources.disponible;
            this.pictureBox4.Location = new System.Drawing.Point(317, 180);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(35, 33);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 35;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::AdministradorPcOne.Properties.Resources.precio;
            this.pictureBox3.Location = new System.Drawing.Point(317, 125);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(35, 33);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 34;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::AdministradorPcOne.Properties.Resources.name;
            this.pictureBox2.Location = new System.Drawing.Point(317, 13);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 33);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 33;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AdministradorPcOne.Properties.Resources.NombreCategoria;
            this.pictureBox1.Location = new System.Drawing.Point(317, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // comboCategoria
            // 
            this.comboCategoria.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboCategoria.ForeColor = System.Drawing.Color.Gray;
            this.comboCategoria.FormattingEnabled = true;
            this.comboCategoria.Location = new System.Drawing.Point(358, 79);
            this.comboCategoria.Name = "comboCategoria";
            this.comboCategoria.Size = new System.Drawing.Size(121, 23);
            this.comboCategoria.TabIndex = 31;
            // 
            // NumDis
            // 
            this.NumDis.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.NumDis.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NumDis.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumDis.ForeColor = System.Drawing.Color.Gray;
            this.NumDis.Location = new System.Drawing.Point(358, 191);
            this.NumDis.Name = "NumDis";
            this.NumDis.Size = new System.Drawing.Size(120, 22);
            this.NumDis.TabIndex = 30;
            this.NumDis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NumDis.ThousandsSeparator = true;
            // 
            // NumPrecio
            // 
            this.NumPrecio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.NumPrecio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NumPrecio.DecimalPlaces = 2;
            this.NumPrecio.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumPrecio.ForeColor = System.Drawing.Color.Gray;
            this.NumPrecio.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.NumPrecio.Location = new System.Drawing.Point(358, 136);
            this.NumPrecio.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.NumPrecio.Name = "NumPrecio";
            this.NumPrecio.Size = new System.Drawing.Size(120, 22);
            this.NumPrecio.TabIndex = 29;
            this.NumPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NumPrecio.ThousandsSeparator = true;
            // 
            // txtNombre
            // 
            this.txtNombre.Depth = 0;
            this.txtNombre.Hint = "Nombre de Producto";
            this.txtNombre.Location = new System.Drawing.Point(358, 23);
            this.txtNombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PasswordChar = '\0';
            this.txtNombre.SelectedText = "";
            this.txtNombre.SelectionLength = 0;
            this.txtNombre.SelectionStart = 0;
            this.txtNombre.Size = new System.Drawing.Size(166, 23);
            this.txtNombre.TabIndex = 28;
            this.txtNombre.UseSystemPasswordChar = false;
            // 
            // PreviewImg
            // 
            this.PreviewImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PreviewImg.Image = global::AdministradorPcOne.Properties.Resources._default;
            this.PreviewImg.Location = new System.Drawing.Point(12, 13);
            this.PreviewImg.Name = "PreviewImg";
            this.PreviewImg.Size = new System.Drawing.Size(276, 217);
            this.PreviewImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PreviewImg.TabIndex = 36;
            this.PreviewImg.TabStop = false;
            // 
            // EditarProductoModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(589, 496);
            this.Controls.Add(this.pnelContenedor);
            this.Controls.Add(this.BarraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditarProductoModal";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddForm";
            this.Load += new System.EventHandler(this.EditarModal_Load);
            this.BarraTitulo.ResumeLayout(false);
            this.pnelContenedor.ResumeLayout(false);
            this.pnelContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.status)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumDis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PreviewImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.OpenFileDialog Subir;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.PictureBox status;
        private System.Windows.Forms.Panel pnelContenedor;
        private System.Windows.Forms.Button btnSubir;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboCategoria;
        private System.Windows.Forms.NumericUpDown NumDis;
        private System.Windows.Forms.NumericUpDown NumPrecio;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNombre;
        private System.Windows.Forms.PictureBox PreviewImg;
    }
}