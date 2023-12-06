namespace Caja_Hospital
{
    partial class FormResumen
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
            this.materialCard5 = new MaterialSkin.Controls.MaterialCard();
            this.cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            this.Monto_Caja = new System.Windows.Forms.Label();
            this.materialCard3 = new MaterialSkin.Controls.MaterialCard();
            this.lblIngresoTotal = new System.Windows.Forms.Label();
            this.T_Entrada = new System.Windows.Forms.Label();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.lblMontoCaja = new System.Windows.Forms.Label();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.lblAperturaDia = new System.Windows.Forms.Label();
            this.lblMontoDiaAnterior = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.materialCard5.SuspendLayout();
            this.materialCard3.SuspendLayout();
            this.materialCard2.SuspendLayout();
            this.materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // materialCard5
            // 
            this.materialCard5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard5.Controls.Add(this.cartesianChart1);
            this.materialCard5.Controls.Add(this.label1);
            this.materialCard5.Depth = 0;
            this.materialCard5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard5.Location = new System.Drawing.Point(477, 228);
            this.materialCard5.Margin = new System.Windows.Forms.Padding(13);
            this.materialCard5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard5.Name = "materialCard5";
            this.materialCard5.Padding = new System.Windows.Forms.Padding(13);
            this.materialCard5.Size = new System.Drawing.Size(753, 518);
            this.materialCard5.TabIndex = 9;
            // 
            // cartesianChart1
            // 
            this.cartesianChart1.Location = new System.Drawing.Point(17, 85);
            this.cartesianChart1.Margin = new System.Windows.Forms.Padding(4);
            this.cartesianChart1.Name = "cartesianChart1";
            this.cartesianChart1.Size = new System.Drawing.Size(719, 427);
            this.cartesianChart1.TabIndex = 0;
            this.cartesianChart1.Text = "cartesianChart1";
            // 
            // Monto_Caja
            // 
            this.Monto_Caja.AutoSize = true;
            this.Monto_Caja.Font = new System.Drawing.Font("Century Gothic", 15.85714F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Monto_Caja.Location = new System.Drawing.Point(17, 13);
            this.Monto_Caja.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Monto_Caja.Name = "Monto_Caja";
            this.Monto_Caja.Size = new System.Drawing.Size(244, 44);
            this.Monto_Caja.TabIndex = 5;
            this.Monto_Caja.Text = "Ingresos hoy";
            // 
            // materialCard3
            // 
            this.materialCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard3.Controls.Add(this.lblIngresoTotal);
            this.materialCard3.Controls.Add(this.T_Entrada);
            this.materialCard3.Depth = 0;
            this.materialCard3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard3.Location = new System.Drawing.Point(647, 45);
            this.materialCard3.Margin = new System.Windows.Forms.Padding(13);
            this.materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard3.Name = "materialCard3";
            this.materialCard3.Padding = new System.Windows.Forms.Padding(13);
            this.materialCard3.Size = new System.Drawing.Size(583, 146);
            this.materialCard3.TabIndex = 7;
            // 
            // lblIngresoTotal
            // 
            this.lblIngresoTotal.AutoSize = true;
            this.lblIngresoTotal.Font = new System.Drawing.Font("Century Gothic", 15.85714F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngresoTotal.Location = new System.Drawing.Point(24, 72);
            this.lblIngresoTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIngresoTotal.Name = "lblIngresoTotal";
            this.lblIngresoTotal.Size = new System.Drawing.Size(31, 44);
            this.lblIngresoTotal.TabIndex = 1;
            this.lblIngresoTotal.Text = "-";
            this.lblIngresoTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // T_Entrada
            // 
            this.T_Entrada.AutoSize = true;
            this.T_Entrada.Font = new System.Drawing.Font("Century Gothic", 15.85714F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T_Entrada.Location = new System.Drawing.Point(24, 8);
            this.T_Entrada.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.T_Entrada.Name = "T_Entrada";
            this.T_Entrada.Size = new System.Drawing.Size(291, 44);
            this.T_Entrada.TabIndex = 1;
            this.T_Entrada.Text = "Total generado";
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.lblMontoCaja);
            this.materialCard2.Controls.Add(this.Monto_Caja);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(46, 228);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(13);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(13);
            this.materialCard2.Size = new System.Drawing.Size(405, 157);
            this.materialCard2.TabIndex = 8;
            // 
            // lblMontoCaja
            // 
            this.lblMontoCaja.AutoSize = true;
            this.lblMontoCaja.Font = new System.Drawing.Font("Century Gothic", 15.85714F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoCaja.Location = new System.Drawing.Point(17, 83);
            this.lblMontoCaja.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMontoCaja.Name = "lblMontoCaja";
            this.lblMontoCaja.Size = new System.Drawing.Size(40, 44);
            this.lblMontoCaja.TabIndex = 1;
            this.lblMontoCaja.Text = "0";
            this.lblMontoCaja.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.lblAperturaDia);
            this.materialCard1.Controls.Add(this.lblMontoDiaAnterior);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(46, 45);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(13);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(13);
            this.materialCard1.Size = new System.Drawing.Size(548, 146);
            this.materialCard1.TabIndex = 4;
            // 
            // lblAperturaDia
            // 
            this.lblAperturaDia.AutoSize = true;
            this.lblAperturaDia.Font = new System.Drawing.Font("Century Gothic", 15.85714F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAperturaDia.Location = new System.Drawing.Point(17, 77);
            this.lblAperturaDia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAperturaDia.Name = "lblAperturaDia";
            this.lblAperturaDia.Size = new System.Drawing.Size(31, 44);
            this.lblAperturaDia.TabIndex = 1;
            this.lblAperturaDia.Text = "-";
            this.lblAperturaDia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMontoDiaAnterior
            // 
            this.lblMontoDiaAnterior.AutoSize = true;
            this.lblMontoDiaAnterior.Font = new System.Drawing.Font("Century Gothic", 15.85714F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoDiaAnterior.Location = new System.Drawing.Point(17, 13);
            this.lblMontoDiaAnterior.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMontoDiaAnterior.Name = "lblMontoDiaAnterior";
            this.lblMontoDiaAnterior.Size = new System.Drawing.Size(402, 44);
            this.lblMontoDiaAnterior.TabIndex = 1;
            this.lblMontoDiaAnterior.Text = "Generado hasta ayer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.85714F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(447, 44);
            this.label1.TabIndex = 10;
            this.label1.Text = "Gráfico ingresos por día";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Caja_Hospital.Properties.Resources.Normal;
            this.pictureBox1.Location = new System.Drawing.Point(46, 401);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(395, 376);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // FormResumen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 796);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.materialCard5);
            this.Controls.Add(this.materialCard3);
            this.Controls.Add(this.materialCard2);
            this.Controls.Add(this.materialCard1);
            this.Name = "FormResumen";
            this.Text = "FormResumen";
            this.materialCard5.ResumeLayout(false);
            this.materialCard5.PerformLayout();
            this.materialCard3.ResumeLayout(false);
            this.materialCard3.PerformLayout();
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard5;
        private LiveCharts.WinForms.CartesianChart cartesianChart1;
        private System.Windows.Forms.Label Monto_Caja;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private System.Windows.Forms.Label T_Entrada;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private System.Windows.Forms.Label lblMontoCaja;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private System.Windows.Forms.Label lblMontoDiaAnterior;
        private System.Windows.Forms.Label lblIngresoTotal;
        private System.Windows.Forms.Label lblAperturaDia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}