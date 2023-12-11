namespace Caja_Hospital.Forms
{
    partial class FrmCuentas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.txtAutorizacion = new MaterialSkin.Controls.MaterialTextBox();
            this.txtCantidad = new MaterialSkin.Controls.MaterialTextBox();
            this.btnPagar = new FontAwesome.Sharp.IconButton();
            this.lblDevolucion = new System.Windows.Forms.Label();
            this.lblTotalAPagar = new System.Windows.Forms.Label();
            this.txtPagado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rbTerjetaCredito = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbEfectivo = new MaterialSkin.Controls.MaterialRadioButton();
            this.cbTipoServicio = new MaterialSkin.Controls.MaterialComboBox();
            this.txtCosto = new MaterialSkin.Controls.MaterialTextBox();
            this.btnConsultar = new MaterialSkin.Controls.MaterialButton();
            this.txtDocumento = new MaterialSkin.Controls.MaterialTextBox();
            this.btnCancelar = new FontAwesome.Sharp.IconButton();
            this.btnAgregar = new FontAwesome.Sharp.IconButton();
            this.cbServicio = new MaterialSkin.Controls.MaterialComboBox();
            this.lblNombres = new System.Windows.Forms.Label();
            this.materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            this.materialCard1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.lblNombres);
            this.materialCard1.Controls.Add(this.txtAutorizacion);
            this.materialCard1.Controls.Add(this.txtCantidad);
            this.materialCard1.Controls.Add(this.btnPagar);
            this.materialCard1.Controls.Add(this.lblDevolucion);
            this.materialCard1.Controls.Add(this.lblTotalAPagar);
            this.materialCard1.Controls.Add(this.txtPagado);
            this.materialCard1.Controls.Add(this.label2);
            this.materialCard1.Controls.Add(this.label1);
            this.materialCard1.Controls.Add(this.lblTotal);
            this.materialCard1.Controls.Add(this.dataGridView1);
            this.materialCard1.Controls.Add(this.rbTerjetaCredito);
            this.materialCard1.Controls.Add(this.rbEfectivo);
            this.materialCard1.Controls.Add(this.cbTipoServicio);
            this.materialCard1.Controls.Add(this.txtCosto);
            this.materialCard1.Controls.Add(this.btnConsultar);
            this.materialCard1.Controls.Add(this.txtDocumento);
            this.materialCard1.Controls.Add(this.btnCancelar);
            this.materialCard1.Controls.Add(this.btnAgregar);
            this.materialCard1.Controls.Add(this.cbServicio);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(63, 48);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(1127, 703);
            this.materialCard1.TabIndex = 43;
            this.materialCard1.Paint += new System.Windows.Forms.PaintEventHandler(this.materialCard1_Paint);
            // 
            // txtAutorizacion
            // 
            this.txtAutorizacion.AnimateReadOnly = false;
            this.txtAutorizacion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAutorizacion.Depth = 0;
            this.txtAutorizacion.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtAutorizacion.Hint = "Autorizado por:";
            this.txtAutorizacion.LeadingIcon = null;
            this.txtAutorizacion.Location = new System.Drawing.Point(43, 204);
            this.txtAutorizacion.MaxLength = 50;
            this.txtAutorizacion.MouseState = MaterialSkin.MouseState.OUT;
            this.txtAutorizacion.Multiline = false;
            this.txtAutorizacion.Name = "txtAutorizacion";
            this.txtAutorizacion.Size = new System.Drawing.Size(379, 50);
            this.txtAutorizacion.TabIndex = 62;
            this.txtAutorizacion.Text = "";
            this.txtAutorizacion.TrailingIcon = null;
            // 
            // txtCantidad
            // 
            this.txtCantidad.AnimateReadOnly = false;
            this.txtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCantidad.Depth = 0;
            this.txtCantidad.Font = new System.Drawing.Font("Roboto", 6.85F);
            this.txtCantidad.Hint = "Cantidad";
            this.txtCantidad.LeadingIcon = null;
            this.txtCantidad.Location = new System.Drawing.Point(43, 518);
            this.txtCantidad.MaxLength = 50;
            this.txtCantidad.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCantidad.Multiline = false;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(380, 50);
            this.txtCantidad.TabIndex = 61;
            this.txtCantidad.Text = "1";
            this.txtCantidad.TrailingIcon = null;
            // 
            // btnPagar
            // 
            this.btnPagar.BackColor = System.Drawing.Color.Gray;
            this.btnPagar.FlatAppearance.BorderSize = 0;
            this.btnPagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagar.Font = new System.Drawing.Font("Century Gothic", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagar.ForeColor = System.Drawing.Color.White;
            this.btnPagar.IconChar = FontAwesome.Sharp.IconChar.Receipt;
            this.btnPagar.IconColor = System.Drawing.Color.White;
            this.btnPagar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPagar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPagar.Location = new System.Drawing.Point(629, 601);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(285, 64);
            this.btnPagar.TabIndex = 60;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPagar.UseVisualStyleBackColor = false;
            this.btnPagar.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // lblDevolucion
            // 
            this.lblDevolucion.AutoSize = true;
            this.lblDevolucion.Font = new System.Drawing.Font("Century Gothic", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDevolucion.Location = new System.Drawing.Point(896, 521);
            this.lblDevolucion.Name = "lblDevolucion";
            this.lblDevolucion.Size = new System.Drawing.Size(22, 28);
            this.lblDevolucion.TabIndex = 59;
            this.lblDevolucion.Text = "-";
            this.lblDevolucion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalAPagar
            // 
            this.lblTotalAPagar.AutoSize = true;
            this.lblTotalAPagar.Font = new System.Drawing.Font("Century Gothic", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAPagar.Location = new System.Drawing.Point(518, 521);
            this.lblTotalAPagar.Name = "lblTotalAPagar";
            this.lblTotalAPagar.Size = new System.Drawing.Size(22, 28);
            this.lblTotalAPagar.TabIndex = 58;
            this.lblTotalAPagar.Text = "-";
            this.lblTotalAPagar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTotalAPagar.TextChanged += new System.EventHandler(this.lblTotalAPagar_TextChanged);
            // 
            // txtPagado
            // 
            this.txtPagado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPagado.Location = new System.Drawing.Point(699, 517);
            this.txtPagado.Name = "txtPagado";
            this.txtPagado.Size = new System.Drawing.Size(134, 42);
            this.txtPagado.TabIndex = 57;
            this.txtPagado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPagado.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(880, 456);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 28);
            this.label2.TabIndex = 55;
            this.label2.Text = "DEVOLUCIÓN:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(702, 456);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 28);
            this.label1.TabIndex = 54;
            this.label1.Text = "PAGADO:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Century Gothic", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(510, 442);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(113, 56);
            this.lblTotal.TabIndex = 53;
            this.lblTotal.Text = "TOTAL A \r\nPAGAR:";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Precio,
            this.Cantidad,
            this.Column4});
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(470, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 72;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.RowTemplate.Height = 31;
            this.dataGridView1.Size = new System.Drawing.Size(612, 299);
            this.dataGridView1.TabIndex = 52;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Tipo Servicio";
            this.Column1.MinimumWidth = 9;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Servicio";
            this.Column2.MinimumWidth = 9;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.MinimumWidth = 9;
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 9;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Total";
            this.Column4.MinimumWidth = 9;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // rbTerjetaCredito
            // 
            this.rbTerjetaCredito.AutoSize = true;
            this.rbTerjetaCredito.Depth = 0;
            this.rbTerjetaCredito.Location = new System.Drawing.Point(828, 387);
            this.rbTerjetaCredito.Margin = new System.Windows.Forms.Padding(0);
            this.rbTerjetaCredito.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbTerjetaCredito.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbTerjetaCredito.Name = "rbTerjetaCredito";
            this.rbTerjetaCredito.Ripple = true;
            this.rbTerjetaCredito.Size = new System.Drawing.Size(158, 37);
            this.rbTerjetaCredito.TabIndex = 50;
            this.rbTerjetaCredito.TabStop = true;
            this.rbTerjetaCredito.Text = "Tarjeta de credito";
            this.rbTerjetaCredito.UseVisualStyleBackColor = true;
            this.rbTerjetaCredito.CheckedChanged += new System.EventHandler(this.rbTerjetaCredito_CheckedChanged);
            // 
            // rbEfectivo
            // 
            this.rbEfectivo.AutoSize = true;
            this.rbEfectivo.Depth = 0;
            this.rbEfectivo.Location = new System.Drawing.Point(580, 387);
            this.rbEfectivo.Margin = new System.Windows.Forms.Padding(0);
            this.rbEfectivo.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbEfectivo.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbEfectivo.Name = "rbEfectivo";
            this.rbEfectivo.Ripple = true;
            this.rbEfectivo.Size = new System.Drawing.Size(92, 37);
            this.rbEfectivo.TabIndex = 49;
            this.rbEfectivo.TabStop = true;
            this.rbEfectivo.Text = "Efectivo";
            this.rbEfectivo.UseVisualStyleBackColor = true;
            this.rbEfectivo.CheckedChanged += new System.EventHandler(this.rbEfectivo_CheckedChanged);
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
            this.cbTipoServicio.Location = new System.Drawing.Point(43, 283);
            this.cbTipoServicio.MaxDropDownItems = 4;
            this.cbTipoServicio.MouseState = MaterialSkin.MouseState.OUT;
            this.cbTipoServicio.Name = "cbTipoServicio";
            this.cbTipoServicio.Size = new System.Drawing.Size(379, 49);
            this.cbTipoServicio.StartIndex = 0;
            this.cbTipoServicio.TabIndex = 48;
            this.cbTipoServicio.SelectedIndexChanged += new System.EventHandler(this.cbTipoServicio_SelectedIndexChanged);
            // 
            // txtCosto
            // 
            this.txtCosto.AnimateReadOnly = false;
            this.txtCosto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCosto.Depth = 0;
            this.txtCosto.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCosto.Hint = "Costo $";
            this.txtCosto.LeadingIcon = null;
            this.txtCosto.Location = new System.Drawing.Point(43, 439);
            this.txtCosto.MaxLength = 50;
            this.txtCosto.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCosto.Multiline = false;
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(380, 50);
            this.txtCosto.TabIndex = 47;
            this.txtCosto.Text = "";
            this.txtCosto.TrailingIcon = null;
            // 
            // btnConsultar
            // 
            this.btnConsultar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnConsultar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnConsultar.Depth = 0;
            this.btnConsultar.HighEmphasis = true;
            this.btnConsultar.Icon = null;
            this.btnConsultar.Location = new System.Drawing.Point(316, 51);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnConsultar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnConsultar.Size = new System.Drawing.Size(106, 36);
            this.btnConsultar.TabIndex = 46;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnConsultar.UseAccentColor = false;
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
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
            this.txtDocumento.Location = new System.Drawing.Point(43, 46);
            this.txtDocumento.MaxLength = 50;
            this.txtDocumento.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDocumento.Multiline = false;
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(266, 50);
            this.txtDocumento.TabIndex = 42;
            this.txtDocumento.Text = "";
            this.txtDocumento.TrailingIcon = null;
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
            this.btnCancelar.Location = new System.Drawing.Point(251, 597);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(171, 64);
            this.btnCancelar.TabIndex = 24;
            this.btnCancelar.Text = "Eliminar Fila";
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
            this.btnAgregar.IconChar = FontAwesome.Sharp.IconChar.FileCirclePlus;
            this.btnAgregar.IconColor = System.Drawing.Color.White;
            this.btnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.Location = new System.Drawing.Point(43, 597);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(171, 64);
            this.btnAgregar.TabIndex = 23;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // cbServicio
            // 
            this.cbServicio.AutoResize = false;
            this.cbServicio.BackColor = System.Drawing.Color.White;
            this.cbServicio.Depth = 0;
            this.cbServicio.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbServicio.DropDownHeight = 174;
            this.cbServicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbServicio.DropDownWidth = 121;
            this.cbServicio.Font = new System.Drawing.Font("Century Gothic", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbServicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbServicio.FormattingEnabled = true;
            this.cbServicio.Hint = "Servicio";
            this.cbServicio.IntegralHeight = false;
            this.cbServicio.ItemHeight = 43;
            this.cbServicio.Location = new System.Drawing.Point(43, 361);
            this.cbServicio.MaxDropDownItems = 4;
            this.cbServicio.MouseState = MaterialSkin.MouseState.OUT;
            this.cbServicio.Name = "cbServicio";
            this.cbServicio.Size = new System.Drawing.Size(379, 49);
            this.cbServicio.StartIndex = 0;
            this.cbServicio.TabIndex = 28;
            this.cbServicio.SelectedIndexChanged += new System.EventHandler(this.cbServicio_SelectedIndexChanged);
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.Font = new System.Drawing.Font("Century Gothic", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombres.Location = new System.Drawing.Point(50, 137);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(118, 28);
            this.lblNombres.TabIndex = 63;
            this.lblNombres.Text = "Nombres";
            this.lblNombres.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmCuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 796);
            this.Controls.Add(this.materialCard1);
            this.Name = "FrmCuentas";
            this.Text = "FormCuentas";
            this.Load += new System.EventHandler(this.FrmCuentas_Load);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconButton btnAgregar;
        private MaterialSkin.Controls.MaterialComboBox cbServicio;
        private MaterialSkin.Controls.MaterialButton btnConsultar;
        private MaterialSkin.Controls.MaterialTextBox txtDocumento;
        private MaterialSkin.Controls.MaterialTextBox txtCosto;
        private MaterialSkin.Controls.MaterialComboBox cbTipoServicio;
        private MaterialSkin.Controls.MaterialRadioButton rbTerjetaCredito;
        private MaterialSkin.Controls.MaterialRadioButton rbEfectivo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtPagado;
        private System.Windows.Forms.Label lblDevolucion;
        private System.Windows.Forms.Label lblTotalAPagar;
        private FontAwesome.Sharp.IconButton btnPagar;
        private MaterialSkin.Controls.MaterialTextBox txtCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private MaterialSkin.Controls.MaterialTextBox txtAutorizacion;
        private System.Windows.Forms.Label lblNombres;
    }
}