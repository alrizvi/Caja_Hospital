namespace Caja_Hospital.Forms
{
    partial class FrmServicios
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
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.txtDescripcion = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.txtCosto = new MaterialSkin.Controls.MaterialTextBox();
            this.btnCancelar = new FontAwesome.Sharp.IconButton();
            this.btnAgregar = new FontAwesome.Sharp.IconButton();
            this.cbTipoServicio = new MaterialSkin.Controls.MaterialComboBox();
            this.txtServicio = new MaterialSkin.Controls.MaterialTextBox();
            this.txtRequisitos = new MaterialSkin.Controls.MaterialTextBox();
            this.dSHospital = new Caja_Hospital.DSHospital();
            this.tblTipoServicioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblTipoServicioTableAdapter = new Caja_Hospital.DSHospitalTableAdapters.tblTipoServicioTableAdapter();
            this.materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dSHospital)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTipoServicioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            this.materialCard1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.txtDescripcion);
            this.materialCard1.Controls.Add(this.txtCosto);
            this.materialCard1.Controls.Add(this.btnCancelar);
            this.materialCard1.Controls.Add(this.btnAgregar);
            this.materialCard1.Controls.Add(this.cbTipoServicio);
            this.materialCard1.Controls.Add(this.txtServicio);
            this.materialCard1.Controls.Add(this.txtRequisitos);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(134, 47);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(995, 703);
            this.materialCard1.TabIndex = 42;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.AnimateReadOnly = false;
            this.txtDescripcion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtDescripcion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescripcion.Depth = 0;
            this.txtDescripcion.HideSelection = true;
            this.txtDescripcion.Hint = "Descripción";
            this.txtDescripcion.Location = new System.Drawing.Point(98, 263);
            this.txtDescripcion.MaxLength = 32767;
            this.txtDescripcion.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.PasswordChar = '\0';
            this.txtDescripcion.ReadOnly = false;
            this.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDescripcion.SelectedText = "";
            this.txtDescripcion.SelectionLength = 0;
            this.txtDescripcion.SelectionStart = 0;
            this.txtDescripcion.ShortcutsEnabled = true;
            this.txtDescripcion.Size = new System.Drawing.Size(778, 239);
            this.txtDescripcion.TabIndex = 40;
            this.txtDescripcion.TabStop = false;
            this.txtDescripcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDescripcion.UseSystemPasswordChar = false;
            // 
            // txtCosto
            // 
            this.txtCosto.AnimateReadOnly = false;
            this.txtCosto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCosto.Depth = 0;
            this.txtCosto.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCosto.Hint = "Costo $";
            this.txtCosto.LeadingIcon = null;
            this.txtCosto.Location = new System.Drawing.Point(506, 157);
            this.txtCosto.MaxLength = 50;
            this.txtCosto.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCosto.Multiline = false;
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(380, 50);
            this.txtCosto.TabIndex = 39;
            this.txtCosto.Text = "";
            this.txtCosto.TrailingIcon = null;
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
            this.btnCancelar.Location = new System.Drawing.Point(558, 542);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(251, 110);
            this.btnCancelar.TabIndex = 24;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(82)))));
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Century Gothic", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.IconChar = FontAwesome.Sharp.IconChar.FileMedicalAlt;
            this.btnAgregar.IconColor = System.Drawing.Color.White;
            this.btnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.Location = new System.Drawing.Point(158, 542);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(251, 110);
            this.btnAgregar.TabIndex = 23;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // cbTipoServicio
            // 
            this.cbTipoServicio.AutoResize = false;
            this.cbTipoServicio.BackColor = System.Drawing.Color.White;
            this.cbTipoServicio.Depth = 0;
            this.cbTipoServicio.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbTipoServicio.DropDownHeight = 174;
            this.cbTipoServicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoServicio.DropDownWidth = 121;
            this.cbTipoServicio.Font = new System.Drawing.Font("Century Gothic", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoServicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbTipoServicio.FormattingEnabled = true;
            this.cbTipoServicio.Hint = "Tipo Servicio";
            this.cbTipoServicio.IntegralHeight = false;
            this.cbTipoServicio.ItemHeight = 43;
            this.cbTipoServicio.Location = new System.Drawing.Point(97, 52);
            this.cbTipoServicio.MaxDropDownItems = 4;
            this.cbTipoServicio.MouseState = MaterialSkin.MouseState.OUT;
            this.cbTipoServicio.Name = "cbTipoServicio";
            this.cbTipoServicio.Size = new System.Drawing.Size(379, 49);
            this.cbTipoServicio.StartIndex = 0;
            this.cbTipoServicio.TabIndex = 28;
            // 
            // txtServicio
            // 
            this.txtServicio.AnimateReadOnly = false;
            this.txtServicio.BackColor = System.Drawing.Color.White;
            this.txtServicio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtServicio.Depth = 0;
            this.txtServicio.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtServicio.Hint = "Servicio";
            this.txtServicio.LeadingIcon = null;
            this.txtServicio.Location = new System.Drawing.Point(496, 51);
            this.txtServicio.MaxLength = 50;
            this.txtServicio.MouseState = MaterialSkin.MouseState.OUT;
            this.txtServicio.Multiline = false;
            this.txtServicio.Name = "txtServicio";
            this.txtServicio.Size = new System.Drawing.Size(379, 50);
            this.txtServicio.TabIndex = 29;
            this.txtServicio.Text = "";
            this.txtServicio.TrailingIcon = null;
            // 
            // txtRequisitos
            // 
            this.txtRequisitos.AnimateReadOnly = false;
            this.txtRequisitos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRequisitos.Depth = 0;
            this.txtRequisitos.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtRequisitos.Hint = "Requisitos";
            this.txtRequisitos.LeadingIcon = null;
            this.txtRequisitos.Location = new System.Drawing.Point(97, 157);
            this.txtRequisitos.MaxLength = 50;
            this.txtRequisitos.MouseState = MaterialSkin.MouseState.OUT;
            this.txtRequisitos.Multiline = false;
            this.txtRequisitos.Name = "txtRequisitos";
            this.txtRequisitos.Size = new System.Drawing.Size(379, 50);
            this.txtRequisitos.TabIndex = 31;
            this.txtRequisitos.Text = "";
            this.txtRequisitos.TrailingIcon = null;
            // 
            // dSHospital
            // 
            this.dSHospital.DataSetName = "DSHospital";
            this.dSHospital.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblTipoServicioBindingSource
            // 
            this.tblTipoServicioBindingSource.DataMember = "tblTipoServicio";
            this.tblTipoServicioBindingSource.DataSource = this.dSHospital;
            // 
            // tblTipoServicioTableAdapter
            // 
            this.tblTipoServicioTableAdapter.ClearBeforeFill = true;
            // 
            // FrmServicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 796);
            this.Controls.Add(this.materialCard1);
            this.Name = "FrmServicios";
            this.Text = "FormServicios";
            this.Load += new System.EventHandler(this.FrmServicios_Load);
            this.materialCard1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dSHospital)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTipoServicioBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconButton btnAgregar;
        private MaterialSkin.Controls.MaterialComboBox cbTipoServicio;
        private MaterialSkin.Controls.MaterialTextBox txtServicio;
        private MaterialSkin.Controls.MaterialTextBox txtRequisitos;
        private MaterialSkin.Controls.MaterialTextBox txtCosto;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtDescripcion;
        private DSHospital dSHospital;
        private System.Windows.Forms.BindingSource tblTipoServicioBindingSource;
        private DSHospitalTableAdapters.tblTipoServicioTableAdapter tblTipoServicioTableAdapter;
    }
}