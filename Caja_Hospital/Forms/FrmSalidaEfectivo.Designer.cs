namespace Caja_Hospital
{
    partial class FrmSalidaEfectivo
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
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.txtRecibido = new MaterialSkin.Controls.MaterialTextBox();
            this.txtConcepto = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.btnCancelar = new FontAwesome.Sharp.IconButton();
            this.btnRetirar = new FontAwesome.Sharp.IconButton();
            this.txtAutorizacion = new MaterialSkin.Controls.MaterialTextBox();
            this.txtCosto = new MaterialSkin.Controls.MaterialTextBox();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            this.materialCard1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.txtRecibido);
            this.materialCard1.Controls.Add(this.txtConcepto);
            this.materialCard1.Controls.Add(this.btnCancelar);
            this.materialCard1.Controls.Add(this.btnRetirar);
            this.materialCard1.Controls.Add(this.txtAutorizacion);
            this.materialCard1.Controls.Add(this.txtCosto);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(68, 47);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(1127, 703);
            this.materialCard1.TabIndex = 44;
            // 
            // txtRecibido
            // 
            this.txtRecibido.AnimateReadOnly = false;
            this.txtRecibido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRecibido.Depth = 0;
            this.txtRecibido.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtRecibido.Hint = "Recibido por:";
            this.txtRecibido.LeadingIcon = null;
            this.txtRecibido.Location = new System.Drawing.Point(567, 54);
            this.txtRecibido.MaxLength = 50;
            this.txtRecibido.MouseState = MaterialSkin.MouseState.OUT;
            this.txtRecibido.Multiline = false;
            this.txtRecibido.Name = "txtRecibido";
            this.txtRecibido.Size = new System.Drawing.Size(379, 50);
            this.txtRecibido.TabIndex = 67;
            this.txtRecibido.Text = "";
            this.txtRecibido.TrailingIcon = null;
            this.txtRecibido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoloLetras_KeyPress);
            // 
            // txtConcepto
            // 
            this.txtConcepto.AnimateReadOnly = false;
            this.txtConcepto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtConcepto.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtConcepto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtConcepto.Depth = 0;
            this.txtConcepto.HideSelection = true;
            this.txtConcepto.Hint = "Concepto:";
            this.txtConcepto.Location = new System.Drawing.Point(168, 250);
            this.txtConcepto.MaxLength = 32767;
            this.txtConcepto.MouseState = MaterialSkin.MouseState.OUT;
            this.txtConcepto.Name = "txtConcepto";
            this.txtConcepto.PasswordChar = '\0';
            this.txtConcepto.ReadOnly = false;
            this.txtConcepto.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtConcepto.SelectedText = "";
            this.txtConcepto.SelectionLength = 0;
            this.txtConcepto.SelectionStart = 0;
            this.txtConcepto.ShortcutsEnabled = true;
            this.txtConcepto.Size = new System.Drawing.Size(778, 239);
            this.txtConcepto.TabIndex = 66;
            this.txtConcepto.TabStop = false;
            this.txtConcepto.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtConcepto.UseSystemPasswordChar = false;
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
            this.btnCancelar.Location = new System.Drawing.Point(633, 538);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(251, 110);
            this.btnCancelar.TabIndex = 65;
            this.btnCancelar.Text = "Limpiar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnRetirar
            // 
            this.btnRetirar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(82)))));
            this.btnRetirar.FlatAppearance.BorderSize = 0;
            this.btnRetirar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetirar.Font = new System.Drawing.Font("Century Gothic", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetirar.ForeColor = System.Drawing.Color.White;
            this.btnRetirar.IconChar = FontAwesome.Sharp.IconChar.MoneyCheckDollar;
            this.btnRetirar.IconColor = System.Drawing.Color.White;
            this.btnRetirar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRetirar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRetirar.Location = new System.Drawing.Point(233, 537);
            this.btnRetirar.Name = "btnRetirar";
            this.btnRetirar.Size = new System.Drawing.Size(251, 110);
            this.btnRetirar.TabIndex = 64;
            this.btnRetirar.Text = "Retirada de Efectivo";
            this.btnRetirar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRetirar.UseVisualStyleBackColor = false;
            this.btnRetirar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtAutorizacion
            // 
            this.txtAutorizacion.AnimateReadOnly = false;
            this.txtAutorizacion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAutorizacion.Depth = 0;
            this.txtAutorizacion.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtAutorizacion.Hint = "Autorizado por:";
            this.txtAutorizacion.LeadingIcon = null;
            this.txtAutorizacion.Location = new System.Drawing.Point(168, 54);
            this.txtAutorizacion.MaxLength = 50;
            this.txtAutorizacion.MouseState = MaterialSkin.MouseState.OUT;
            this.txtAutorizacion.Multiline = false;
            this.txtAutorizacion.Name = "txtAutorizacion";
            this.txtAutorizacion.Size = new System.Drawing.Size(379, 50);
            this.txtAutorizacion.TabIndex = 62;
            this.txtAutorizacion.Text = "";
            this.txtAutorizacion.TrailingIcon = null;
            this.txtAutorizacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoloLetras_KeyPress);
            // 
            // txtCosto
            // 
            this.txtCosto.AnimateReadOnly = false;
            this.txtCosto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCosto.Depth = 0;
            this.txtCosto.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCosto.Hint = "Monto de:";
            this.txtCosto.LeadingIcon = null;
            this.txtCosto.Location = new System.Drawing.Point(168, 152);
            this.txtCosto.MaxLength = 50;
            this.txtCosto.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCosto.Multiline = false;
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(778, 50);
            this.txtCosto.TabIndex = 47;
            this.txtCosto.Text = "";
            this.txtCosto.TrailingIcon = null;
            this.txtCosto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoloNumeros_KeyPress);
            // 
            // FrmSalidaEfectivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 796);
            this.Controls.Add(this.materialCard1);
            this.Name = "FrmSalidaEfectivo";
            this.Text = "FrmSalidaEfectivo";
            this.materialCard1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialTextBox txtAutorizacion;
        private MaterialSkin.Controls.MaterialTextBox txtCosto;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconButton btnRetirar;
        private MaterialSkin.Controls.MaterialTextBox txtRecibido;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtConcepto;
    }
}