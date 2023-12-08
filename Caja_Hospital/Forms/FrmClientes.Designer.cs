namespace Caja_Hospital.Forms
{
    partial class FrmClientes
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
            this.btnCancelar = new FontAwesome.Sharp.IconButton();
            this.btnAgregar = new FontAwesome.Sharp.IconButton();
            this.cbTipoDocumento = new MaterialSkin.Controls.MaterialComboBox();
            this.txtDocumento = new MaterialSkin.Controls.MaterialTextBox();
            this.txtNombres = new MaterialSkin.Controls.MaterialTextBox();
            this.txtApellidos = new MaterialSkin.Controls.MaterialTextBox();
            this.txtFechaNacimiento = new MaterialSkin.Controls.MaterialTextBox();
            this.txtAlergias = new MaterialSkin.Controls.MaterialTextBox();
            this.txtEnfermedades = new MaterialSkin.Controls.MaterialTextBox();
            this.txtTelefono = new MaterialSkin.Controls.MaterialTextBox();
            this.txtCorreo = new MaterialSkin.Controls.MaterialTextBox();
            this.txtDireccion = new MaterialSkin.Controls.MaterialTextBox();
            this.rbMujer = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.btnConsultar = new MaterialSkin.Controls.MaterialButton();
            this.rbHombre = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(0)))), ((int)(((byte)(63)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.btnCancelar.IconColor = System.Drawing.Color.White;
            this.btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.Location = new System.Drawing.Point(306, 303);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(137, 60);
            this.btnCancelar.TabIndex = 24;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(82)))));
            this.btnAgregar.Enabled = false;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Century Gothic", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.btnAgregar.IconColor = System.Drawing.Color.White;
            this.btnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.Location = new System.Drawing.Point(88, 303);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(137, 60);
            this.btnAgregar.TabIndex = 23;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // cbTipoDocumento
            // 
            this.cbTipoDocumento.AutoResize = false;
            this.cbTipoDocumento.BackColor = System.Drawing.Color.White;
            this.cbTipoDocumento.Depth = 0;
            this.cbTipoDocumento.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbTipoDocumento.DropDownHeight = 174;
            this.cbTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoDocumento.DropDownWidth = 121;
            this.cbTipoDocumento.Font = new System.Drawing.Font("Century Gothic", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoDocumento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbTipoDocumento.FormattingEnabled = true;
            this.cbTipoDocumento.Hint = "Tipo Documento";
            this.cbTipoDocumento.IntegralHeight = false;
            this.cbTipoDocumento.ItemHeight = 43;
            this.cbTipoDocumento.Items.AddRange(new object[] {
            "Cédula",
            "Pasaporte"});
            this.cbTipoDocumento.Location = new System.Drawing.Point(53, 28);
            this.cbTipoDocumento.Margin = new System.Windows.Forms.Padding(2);
            this.cbTipoDocumento.MaxDropDownItems = 4;
            this.cbTipoDocumento.MouseState = MaterialSkin.MouseState.OUT;
            this.cbTipoDocumento.Name = "cbTipoDocumento";
            this.cbTipoDocumento.Size = new System.Drawing.Size(209, 49);
            this.cbTipoDocumento.StartIndex = 0;
            this.cbTipoDocumento.TabIndex = 28;
            this.cbTipoDocumento.SelectedIndexChanged += new System.EventHandler(this.cbTipoDocumento_SelectedIndexChanged);
            // 
            // txtDocumento
            // 
            this.txtDocumento.AnimateReadOnly = false;
            this.txtDocumento.BackColor = System.Drawing.Color.White;
            this.txtDocumento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDocumento.Depth = 0;
            this.txtDocumento.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDocumento.Hint = "Documento";
            this.txtDocumento.LeadingIcon = null;
            this.txtDocumento.Location = new System.Drawing.Point(271, 28);
            this.txtDocumento.Margin = new System.Windows.Forms.Padding(2);
            this.txtDocumento.MaxLength = 50;
            this.txtDocumento.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDocumento.Multiline = false;
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(145, 50);
            this.txtDocumento.TabIndex = 29;
            this.txtDocumento.Text = "";
            this.txtDocumento.TrailingIcon = null;
            this.txtDocumento.TextChanged += new System.EventHandler(this.txtTodos_TextChanged);
            this.txtDocumento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDocumento_KeyPress);
            // 
            // txtNombres
            // 
            this.txtNombres.AnimateReadOnly = false;
            this.txtNombres.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombres.Depth = 0;
            this.txtNombres.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNombres.Hint = "Nombres";
            this.txtNombres.LeadingIcon = null;
            this.txtNombres.Location = new System.Drawing.Point(53, 68);
            this.txtNombres.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombres.MaxLength = 50;
            this.txtNombres.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNombres.Multiline = false;
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(207, 50);
            this.txtNombres.TabIndex = 30;
            this.txtNombres.Text = "";
            this.txtNombres.TrailingIcon = null;
            this.txtNombres.TextChanged += new System.EventHandler(this.txtTodos_TextChanged);
            this.txtNombres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoloLetras_KeyPress);
            // 
            // txtApellidos
            // 
            this.txtApellidos.AnimateReadOnly = false;
            this.txtApellidos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApellidos.Depth = 0;
            this.txtApellidos.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtApellidos.Hint = "Apellidos";
            this.txtApellidos.LeadingIcon = null;
            this.txtApellidos.Location = new System.Drawing.Point(271, 68);
            this.txtApellidos.Margin = new System.Windows.Forms.Padding(2);
            this.txtApellidos.MaxLength = 50;
            this.txtApellidos.MouseState = MaterialSkin.MouseState.OUT;
            this.txtApellidos.Multiline = false;
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(207, 50);
            this.txtApellidos.TabIndex = 31;
            this.txtApellidos.Text = "";
            this.txtApellidos.TrailingIcon = null;
            this.txtApellidos.TextChanged += new System.EventHandler(this.txtTodos_TextChanged);
            this.txtApellidos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoloLetras_KeyPress);
            // 
            // txtFechaNacimiento
            // 
            this.txtFechaNacimiento.AnimateReadOnly = false;
            this.txtFechaNacimiento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFechaNacimiento.Depth = 0;
            this.txtFechaNacimiento.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtFechaNacimiento.Hint = "Fecha de nacimiento (AAAA-MM-DD)";
            this.txtFechaNacimiento.LeadingIcon = null;
            this.txtFechaNacimiento.Location = new System.Drawing.Point(53, 141);
            this.txtFechaNacimiento.Margin = new System.Windows.Forms.Padding(2);
            this.txtFechaNacimiento.MaxLength = 50;
            this.txtFechaNacimiento.MouseState = MaterialSkin.MouseState.OUT;
            this.txtFechaNacimiento.Multiline = false;
            this.txtFechaNacimiento.Name = "txtFechaNacimiento";
            this.txtFechaNacimiento.Size = new System.Drawing.Size(424, 50);
            this.txtFechaNacimiento.TabIndex = 33;
            this.txtFechaNacimiento.Text = "";
            this.txtFechaNacimiento.TrailingIcon = null;
            this.txtFechaNacimiento.TextChanged += new System.EventHandler(this.txtTodos_TextChanged);
            this.txtFechaNacimiento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFechaNacimiento_KeyPress);
            // 
            // txtAlergias
            // 
            this.txtAlergias.AnimateReadOnly = false;
            this.txtAlergias.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAlergias.Depth = 0;
            this.txtAlergias.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtAlergias.Hint = "Alergias";
            this.txtAlergias.LeadingIcon = null;
            this.txtAlergias.Location = new System.Drawing.Point(53, 181);
            this.txtAlergias.Margin = new System.Windows.Forms.Padding(2);
            this.txtAlergias.MaxLength = 50;
            this.txtAlergias.MouseState = MaterialSkin.MouseState.OUT;
            this.txtAlergias.Multiline = false;
            this.txtAlergias.Name = "txtAlergias";
            this.txtAlergias.Size = new System.Drawing.Size(207, 50);
            this.txtAlergias.TabIndex = 34;
            this.txtAlergias.Text = "";
            this.txtAlergias.TrailingIcon = null;
            this.txtAlergias.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoloLetras_KeyPress);
            // 
            // txtEnfermedades
            // 
            this.txtEnfermedades.AnimateReadOnly = false;
            this.txtEnfermedades.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEnfermedades.Depth = 0;
            this.txtEnfermedades.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEnfermedades.Hint = "Enfermedades";
            this.txtEnfermedades.LeadingIcon = null;
            this.txtEnfermedades.Location = new System.Drawing.Point(271, 181);
            this.txtEnfermedades.Margin = new System.Windows.Forms.Padding(2);
            this.txtEnfermedades.MaxLength = 50;
            this.txtEnfermedades.MouseState = MaterialSkin.MouseState.OUT;
            this.txtEnfermedades.Multiline = false;
            this.txtEnfermedades.Name = "txtEnfermedades";
            this.txtEnfermedades.Size = new System.Drawing.Size(207, 50);
            this.txtEnfermedades.TabIndex = 35;
            this.txtEnfermedades.Text = "";
            this.txtEnfermedades.TrailingIcon = null;
            this.txtEnfermedades.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoloLetras_KeyPress);
            // 
            // txtTelefono
            // 
            this.txtTelefono.AnimateReadOnly = false;
            this.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelefono.Depth = 0;
            this.txtTelefono.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTelefono.Hint = "Teléfono";
            this.txtTelefono.LeadingIcon = null;
            this.txtTelefono.Location = new System.Drawing.Point(53, 221);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(2);
            this.txtTelefono.MaxLength = 50;
            this.txtTelefono.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTelefono.Multiline = false;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(207, 50);
            this.txtTelefono.TabIndex = 36;
            this.txtTelefono.Text = "";
            this.txtTelefono.TrailingIcon = null;
            this.txtTelefono.TextChanged += new System.EventHandler(this.txtTodos_TextChanged);
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // txtCorreo
            // 
            this.txtCorreo.AnimateReadOnly = false;
            this.txtCorreo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCorreo.Depth = 0;
            this.txtCorreo.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCorreo.Hint = "Correo";
            this.txtCorreo.LeadingIcon = null;
            this.txtCorreo.Location = new System.Drawing.Point(271, 221);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(2);
            this.txtCorreo.MaxLength = 50;
            this.txtCorreo.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCorreo.Multiline = false;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(207, 50);
            this.txtCorreo.TabIndex = 37;
            this.txtCorreo.Text = "";
            this.txtCorreo.TrailingIcon = null;
            this.txtCorreo.TextChanged += new System.EventHandler(this.txtTodos_TextChanged);
            this.txtCorreo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCorreo_KeyPress);
            // 
            // txtDireccion
            // 
            this.txtDireccion.AnimateReadOnly = false;
            this.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDireccion.Depth = 0;
            this.txtDireccion.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDireccion.Hint = "Dirección";
            this.txtDireccion.LeadingIcon = null;
            this.txtDireccion.Location = new System.Drawing.Point(53, 261);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(2);
            this.txtDireccion.MaxLength = 50;
            this.txtDireccion.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDireccion.Multiline = false;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(424, 50);
            this.txtDireccion.TabIndex = 38;
            this.txtDireccion.Text = "";
            this.txtDireccion.TrailingIcon = null;
            this.txtDireccion.TextChanged += new System.EventHandler(this.txtTodos_TextChanged);
            this.txtDireccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDireccion_KeyPress);
            // 
            // rbMujer
            // 
            this.rbMujer.AutoSize = true;
            this.rbMujer.Depth = 0;
            this.rbMujer.Location = new System.Drawing.Point(352, 108);
            this.rbMujer.Margin = new System.Windows.Forms.Padding(0);
            this.rbMujer.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbMujer.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbMujer.Name = "rbMujer";
            this.rbMujer.Ripple = true;
            this.rbMujer.Size = new System.Drawing.Size(75, 37);
            this.rbMujer.TabIndex = 40;
            this.rbMujer.TabStop = true;
            this.rbMujer.Text = "Mujer";
            this.rbMujer.UseVisualStyleBackColor = true;
            // 
            // materialCard1
            // 
            this.materialCard1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.btnConsultar);
            this.materialCard1.Controls.Add(this.txtAlergias);
            this.materialCard1.Controls.Add(this.btnCancelar);
            this.materialCard1.Controls.Add(this.btnAgregar);
            this.materialCard1.Controls.Add(this.rbMujer);
            this.materialCard1.Controls.Add(this.cbTipoDocumento);
            this.materialCard1.Controls.Add(this.rbHombre);
            this.materialCard1.Controls.Add(this.txtDocumento);
            this.materialCard1.Controls.Add(this.txtDireccion);
            this.materialCard1.Controls.Add(this.txtNombres);
            this.materialCard1.Controls.Add(this.txtCorreo);
            this.materialCard1.Controls.Add(this.txtApellidos);
            this.materialCard1.Controls.Add(this.txtTelefono);
            this.materialCard1.Controls.Add(this.txtFechaNacimiento);
            this.materialCard1.Controls.Add(this.txtEnfermedades);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(73, 23);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(8);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(8);
            this.materialCard1.Size = new System.Drawing.Size(543, 381);
            this.materialCard1.TabIndex = 41;
            // 
            // btnConsultar
            // 
            this.btnConsultar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnConsultar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnConsultar.Depth = 0;
            this.btnConsultar.HighEmphasis = true;
            this.btnConsultar.Icon = null;
            this.btnConsultar.Location = new System.Drawing.Point(419, 31);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnConsultar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnConsultar.Size = new System.Drawing.Size(106, 36);
            this.btnConsultar.TabIndex = 41;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnConsultar.UseAccentColor = false;
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // rbHombre
            // 
            this.rbHombre.AutoSize = true;
            this.rbHombre.Depth = 0;
            this.rbHombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbHombre.Location = new System.Drawing.Point(125, 108);
            this.rbHombre.Margin = new System.Windows.Forms.Padding(0);
            this.rbHombre.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbHombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbHombre.Name = "rbHombre";
            this.rbHombre.Ripple = true;
            this.rbHombre.Size = new System.Drawing.Size(91, 37);
            this.rbHombre.TabIndex = 39;
            this.rbHombre.TabStop = true;
            this.rbHombre.Text = "Hombre";
            this.rbHombre.UseVisualStyleBackColor = true;
            // 
            // FrmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 431);
            this.Controls.Add(this.materialCard1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmClientes";
            this.Text = "FormClientes";
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private FontAwesome.Sharp.IconButton btnAgregar;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private MaterialSkin.Controls.MaterialComboBox cbTipoDocumento;
        private MaterialSkin.Controls.MaterialTextBox txtDocumento;
        private MaterialSkin.Controls.MaterialTextBox txtNombres;
        private MaterialSkin.Controls.MaterialTextBox txtApellidos;
        private MaterialSkin.Controls.MaterialTextBox txtFechaNacimiento;
        private MaterialSkin.Controls.MaterialTextBox txtAlergias;
        private MaterialSkin.Controls.MaterialTextBox txtEnfermedades;
        private MaterialSkin.Controls.MaterialTextBox txtTelefono;
        private MaterialSkin.Controls.MaterialTextBox txtCorreo;
        private MaterialSkin.Controls.MaterialTextBox txtDireccion;
        private MaterialSkin.Controls.MaterialRadioButton rbMujer;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialButton btnConsultar;
        private MaterialSkin.Controls.MaterialRadioButton rbHombre;
    }
}