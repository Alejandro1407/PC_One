namespace PcOne.Forms
{
    partial class CategoriaForm
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
            this.pnelContenedor = new System.Windows.Forms.Panel();
            this.Status = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnReload = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pnelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Status)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnelContenedor
            // 
            this.pnelContenedor.AutoScroll = true;
            this.pnelContenedor.BackColor = System.Drawing.Color.Transparent;
            this.pnelContenedor.Controls.Add(this.btnReload);
            this.pnelContenedor.Controls.Add(this.lblStatus);
            this.pnelContenedor.Controls.Add(this.Status);
            this.pnelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnelContenedor.Location = new System.Drawing.Point(0, 0);
            this.pnelContenedor.Name = "pnelContenedor";
            this.pnelContenedor.Size = new System.Drawing.Size(638, 563);
            this.pnelContenedor.TabIndex = 9;
            // 
            // Status
            // 
            this.Status.Image = global::AdministradorPcOne.Properties.Resources.Loading;
            this.Status.Location = new System.Drawing.Point(247, 178);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(117, 111);
            this.Status.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Status.TabIndex = 24;
            this.Status.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAddCategory);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(638, 55);
            this.panel1.TabIndex = 7;
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.FlatAppearance.BorderSize = 0;
            this.btnAddCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCategory.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCategory.ForeColor = System.Drawing.Color.Gray;
            this.btnAddCategory.Image = global::AdministradorPcOne.Properties.Resources.AddCategory;
            this.btnAddCategory.Location = new System.Drawing.Point(41, 3);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(117, 49);
            this.btnAddCategory.TabIndex = 11;
            this.btnAddCategory.Text = "Añadir";
            this.btnAddCategory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddCategory.UseVisualStyleBackColor = true;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Gray;
            this.lblStatus.Location = new System.Drawing.Point(235, 301);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(146, 21);
            this.lblStatus.TabIndex = 47;
            this.lblStatus.Text = "Obteniendo Datos";
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
            this.btnReload.Location = new System.Drawing.Point(239, 339);
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
            // CategoriaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(638, 563);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnelContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CategoriaForm";
            this.Text = "AparenciaForm";
            this.pnelContenedor.ResumeLayout(false);
            this.pnelContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Status)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnelContenedor;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Status;
        private System.Windows.Forms.Label lblStatus;
        private Bunifu.Framework.UI.BunifuFlatButton btnReload;
    }
}