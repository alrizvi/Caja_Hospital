namespace Caja_Hospital
{
    partial class FormMainMenu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainMenu));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.horafecha = new System.Windows.Forms.Timer(this.components);
            this.btnMinimizar = new FontAwesome.Sharp.IconButton();
            this.btnMaximizar = new FontAwesome.Sharp.IconButton();
            this.btnCerrar = new FontAwesome.Sharp.IconButton();
            this.iconCurrentChildFrom = new FontAwesome.Sharp.IconPictureBox();
            this.btnSalidaEfectivo = new FontAwesome.Sharp.IconButton();
            this.btnLogOut = new FontAwesome.Sharp.IconButton();
            this.btnDashboard = new FontAwesome.Sharp.IconButton();
            this.btnReportes = new FontAwesome.Sharp.IconButton();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.btnCuentas = new FontAwesome.Sharp.IconButton();
            this.btnPacientes = new FontAwesome.Sharp.IconButton();
            this.btnServicios = new FontAwesome.Sharp.IconButton();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(31)))), ((int)(((byte)(37)))));
            this.panelMenu.Controls.Add(this.btnSalidaEfectivo);
            this.panelMenu.Controls.Add(this.btnLogOut);
            this.panelMenu.Controls.Add(this.btnDashboard);
            this.panelMenu.Controls.Add(this.btnReportes);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Controls.Add(this.btnCuentas);
            this.panelMenu.Controls.Add(this.btnPacientes);
            this.panelMenu.Controls.Add(this.btnServicios);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(31)))), ((int)(((byte)(37)))));
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(340, 911);
            this.panelMenu.TabIndex = 0;
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.btnHome);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(340, 210);
            this.panelLogo.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            this.panel1.Controls.Add(this.btnMinimizar);
            this.panel1.Controls.Add(this.btnMaximizar);
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Controls.Add(this.lblTitleChildForm);
            this.panel1.Controls.Add(this.iconCurrentChildFrom);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(31)))), ((int)(((byte)(37)))));
            this.panel1.Location = new System.Drawing.Point(340, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1286, 112);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.Font = new System.Drawing.Font("Century Gothic", 14.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleChildForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitleChildForm.Location = new System.Drawing.Point(102, 37);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(107, 40);
            this.lblTitleChildForm.TabIndex = 1;
            this.lblTitleChildForm.Text = "Inicio";
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(23)))), ((int)(((byte)(27)))));
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(23)))), ((int)(((byte)(28)))));
            this.panelShadow.Location = new System.Drawing.Point(340, 112);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(1286, 9);
            this.panelShadow.TabIndex = 2;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.Gainsboro;
            this.panelDesktop.Controls.Add(this.lblFecha);
            this.panelDesktop.Controls.Add(this.lblHora);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(0, 0);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1626, 911);
            this.panelDesktop.TabIndex = 3;
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblFecha.Location = new System.Drawing.Point(414, 556);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(245, 83);
            this.lblFecha.TabIndex = 1;
            this.lblFecha.Text = "label1";
            this.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHora
            // 
            this.lblHora.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Century Gothic", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(26)))), ((int)(((byte)(31)))));
            this.lblHora.Location = new System.Drawing.Point(721, 390);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(490, 166);
            this.lblHora.TabIndex = 0;
            this.lblHora.Text = "label1";
            this.lblHora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // horafecha
            // 
            this.horafecha.Enabled = true;
            this.horafecha.Tick += new System.EventHandler(this.horafecha_Tick);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            this.btnMinimizar.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinimizar.IconColor = System.Drawing.Color.White;
            this.btnMinimizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimizar.Location = new System.Drawing.Point(1153, 0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(40, 43);
            this.btnMinimizar.TabIndex = 4;
            this.btnMinimizar.UseVisualStyleBackColor = false;
            this.btnMinimizar.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            this.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            this.btnMaximizar.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.btnMaximizar.IconColor = System.Drawing.Color.White;
            this.btnMaximizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaximizar.Location = new System.Drawing.Point(1198, 0);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(40, 43);
            this.btnMaximizar.TabIndex = 3;
            this.btnMaximizar.UseVisualStyleBackColor = false;
            this.btnMaximizar.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            this.btnCerrar.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.btnCerrar.IconColor = System.Drawing.Color.White;
            this.btnCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCerrar.Location = new System.Drawing.Point(1243, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(40, 43);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // iconCurrentChildFrom
            // 
            this.iconCurrentChildFrom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            this.iconCurrentChildFrom.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconCurrentChildFrom.IconChar = FontAwesome.Sharp.IconChar.House;
            this.iconCurrentChildFrom.IconColor = System.Drawing.Color.Gainsboro;
            this.iconCurrentChildFrom.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildFrom.IconSize = 69;
            this.iconCurrentChildFrom.Location = new System.Drawing.Point(16, 22);
            this.iconCurrentChildFrom.Name = "iconCurrentChildFrom";
            this.iconCurrentChildFrom.Size = new System.Drawing.Size(85, 69);
            this.iconCurrentChildFrom.TabIndex = 0;
            this.iconCurrentChildFrom.TabStop = false;
            // 
            // btnSalidaEfectivo
            // 
            this.btnSalidaEfectivo.FlatAppearance.BorderSize = 0;
            this.btnSalidaEfectivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalidaEfectivo.Font = new System.Drawing.Font("Century Gothic", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalidaEfectivo.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSalidaEfectivo.IconChar = FontAwesome.Sharp.IconChar.SackXmark;
            this.btnSalidaEfectivo.IconColor = System.Drawing.Color.Gainsboro;
            this.btnSalidaEfectivo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSalidaEfectivo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalidaEfectivo.Location = new System.Drawing.Point(0, 660);
            this.btnSalidaEfectivo.Name = "btnSalidaEfectivo";
            this.btnSalidaEfectivo.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnSalidaEfectivo.Size = new System.Drawing.Size(340, 90);
            this.btnSalidaEfectivo.TabIndex = 7;
            this.btnSalidaEfectivo.Text = "Salida de efectivo";
            this.btnSalidaEfectivo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalidaEfectivo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalidaEfectivo.UseVisualStyleBackColor = true;
            this.btnSalidaEfectivo.Click += new System.EventHandler(this.btnSalidaEfectivo_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Century Gothic", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnLogOut.IconChar = FontAwesome.Sharp.IconChar.RightToBracket;
            this.btnLogOut.IconColor = System.Drawing.Color.Gainsboro;
            this.btnLogOut.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.Location = new System.Drawing.Point(0, 821);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnLogOut.Size = new System.Drawing.Size(340, 90);
            this.btnLogOut.TabIndex = 6;
            this.btnLogOut.Text = "Cerrar Sesión";
            this.btnLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnConfiguracion_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Century Gothic", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDashboard.IconChar = FontAwesome.Sharp.IconChar.ChartPie;
            this.btnDashboard.IconColor = System.Drawing.Color.Gainsboro;
            this.btnDashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(0, 210);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnDashboard.Size = new System.Drawing.Size(340, 90);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnReportes
            // 
            this.btnReportes.FlatAppearance.BorderSize = 0;
            this.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportes.Font = new System.Drawing.Font("Century Gothic", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportes.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnReportes.IconChar = FontAwesome.Sharp.IconChar.ChartColumn;
            this.btnReportes.IconColor = System.Drawing.Color.Gainsboro;
            this.btnReportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportes.Location = new System.Drawing.Point(0, 570);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnReportes.Size = new System.Drawing.Size(340, 90);
            this.btnReportes.TabIndex = 5;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReportes.UseVisualStyleBackColor = true;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // btnHome
            // 
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.Image = global::Caja_Hospital.Properties.Resources.Blanco;
            this.btnHome.Location = new System.Drawing.Point(0, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(340, 207);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHome.TabIndex = 0;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnCuentas
            // 
            this.btnCuentas.FlatAppearance.BorderSize = 0;
            this.btnCuentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCuentas.Font = new System.Drawing.Font("Century Gothic", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCuentas.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCuentas.IconChar = FontAwesome.Sharp.IconChar.MoneyBill;
            this.btnCuentas.IconColor = System.Drawing.Color.Gainsboro;
            this.btnCuentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCuentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCuentas.Location = new System.Drawing.Point(0, 390);
            this.btnCuentas.Name = "btnCuentas";
            this.btnCuentas.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnCuentas.Size = new System.Drawing.Size(340, 90);
            this.btnCuentas.TabIndex = 2;
            this.btnCuentas.Text = "Cuentas";
            this.btnCuentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCuentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCuentas.UseVisualStyleBackColor = true;
            this.btnCuentas.Click += new System.EventHandler(this.btnCuentas_Click);
            // 
            // btnPacientes
            // 
            this.btnPacientes.FlatAppearance.BorderSize = 0;
            this.btnPacientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPacientes.Font = new System.Drawing.Font("Century Gothic", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPacientes.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnPacientes.IconChar = FontAwesome.Sharp.IconChar.HandHoldingMedical;
            this.btnPacientes.IconColor = System.Drawing.Color.Gainsboro;
            this.btnPacientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPacientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPacientes.Location = new System.Drawing.Point(0, 300);
            this.btnPacientes.Name = "btnPacientes";
            this.btnPacientes.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnPacientes.Size = new System.Drawing.Size(340, 90);
            this.btnPacientes.TabIndex = 4;
            this.btnPacientes.Text = "Pacientes";
            this.btnPacientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPacientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPacientes.UseVisualStyleBackColor = true;
            this.btnPacientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnServicios
            // 
            this.btnServicios.FlatAppearance.BorderSize = 0;
            this.btnServicios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServicios.Font = new System.Drawing.Font("Century Gothic", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServicios.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnServicios.IconChar = FontAwesome.Sharp.IconChar.BookMedical;
            this.btnServicios.IconColor = System.Drawing.Color.Gainsboro;
            this.btnServicios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnServicios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnServicios.Location = new System.Drawing.Point(0, 480);
            this.btnServicios.Name = "btnServicios";
            this.btnServicios.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnServicios.Size = new System.Drawing.Size(340, 90);
            this.btnServicios.TabIndex = 3;
            this.btnServicios.Text = "Servicios";
            this.btnServicios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnServicios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnServicios.UseVisualStyleBackColor = true;
            this.btnServicios.Click += new System.EventHandler(this.btnServicios_Click);
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1626, 911);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelDesktop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CEMED";
            this.Load += new System.EventHandler(this.FormMainMenu_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnDashboard;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton btnReportes;
        private FontAwesome.Sharp.IconButton btnPacientes;
        private FontAwesome.Sharp.IconButton btnServicios;
        private FontAwesome.Sharp.IconButton btnCuentas;
        private FontAwesome.Sharp.IconButton btnLogOut;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitleChildForm;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildFrom;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Panel panelDesktop;
        private FontAwesome.Sharp.IconButton btnCerrar;
        private FontAwesome.Sharp.IconButton btnMinimizar;
        private FontAwesome.Sharp.IconButton btnMaximizar;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Timer horafecha;
        private FontAwesome.Sharp.IconButton btnSalidaEfectivo;
    }
}

