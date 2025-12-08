namespace Bitmap
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.grpEntrada = new System.Windows.Forms.GroupBox();
            this.lblMTI = new System.Windows.Forms.Label();
            this.cmbMTI = new System.Windows.Forms.ComboBox();
            this.lblCampos = new System.Windows.Forms.Label();
            this.txtCampos = new System.Windows.Forms.TextBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.grpResultados = new System.Windows.Forms.GroupBox();
            this.lblBitmapBinario = new System.Windows.Forms.Label();
            this.txtBitmapBinario = new System.Windows.Forms.TextBox();
            this.lblBitmapHex = new System.Windows.Forms.Label();
            this.txtBitmapHex = new System.Windows.Forms.TextBox();
            this.lblMensajeCompleto = new System.Windows.Forms.Label();
            this.txtMensajeCompleto = new System.Windows.Forms.TextBox();
            this.grpDataMatrix = new System.Windows.Forms.GroupBox();
            this.pnlDataMatrix = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.grpEntrada.SuspendLayout();
            this.grpResultados.SuspendLayout();
            this.grpDataMatrix.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(242, 30);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Generador de Bitmap ";
            // 
            // grpEntrada
            // 
            this.grpEntrada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(115)))), ((int)(((byte)(94)))));
            this.grpEntrada.Controls.Add(this.lblMTI);
            this.grpEntrada.Controls.Add(this.cmbMTI);
            this.grpEntrada.Controls.Add(this.lblCampos);
            this.grpEntrada.Controls.Add(this.txtCampos);
            this.grpEntrada.Controls.Add(this.btnGenerar);
            this.grpEntrada.Controls.Add(this.btnLimpiar);
            this.grpEntrada.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpEntrada.Location = new System.Drawing.Point(17, 52);
            this.grpEntrada.Name = "grpEntrada";
            this.grpEntrada.Size = new System.Drawing.Size(500, 180);
            this.grpEntrada.TabIndex = 1;
            this.grpEntrada.TabStop = false;
            this.grpEntrada.Text = "Entrada de Datos";
            // 
            // lblMTI
            // 
            this.lblMTI.AutoSize = true;
            this.lblMTI.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblMTI.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMTI.Location = new System.Drawing.Point(15, 30);
            this.lblMTI.Name = "lblMTI";
            this.lblMTI.Size = new System.Drawing.Size(184, 17);
            this.lblMTI.TabIndex = 0;
            this.lblMTI.Text = "MTI (Message Type Indicator):";
            // 
            // cmbMTI
            // 
            this.cmbMTI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMTI.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cmbMTI.FormattingEnabled = true;
            this.cmbMTI.Items.AddRange(new object[] {
            "0100",
            "0200"});
            this.cmbMTI.Location = new System.Drawing.Point(18, 50);
            this.cmbMTI.Name = "cmbMTI";
            this.cmbMTI.Size = new System.Drawing.Size(150, 25);
            this.cmbMTI.TabIndex = 1;
            // 
            // lblCampos
            // 
            this.lblCampos.AutoSize = true;
            this.lblCampos.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblCampos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCampos.Location = new System.Drawing.Point(15, 85);
            this.lblCampos.Name = "lblCampos";
            this.lblCampos.Size = new System.Drawing.Size(106, 17);
            this.lblCampos.TabIndex = 2;
            this.lblCampos.Text = "Lista de campos:";
            // 
            // txtCampos
            // 
            this.txtCampos.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.txtCampos.Location = new System.Drawing.Point(18, 105);
            this.txtCampos.Name = "txtCampos";
            this.txtCampos.Size = new System.Drawing.Size(465, 23);
            this.txtCampos.TabIndex = 3;
            this.txtCampos.Text = "1, 2, 4, 6, 8, 10, 32, 33, 34, 35, 36, 38, 49, 58";
            // 
            // btnGenerar
            // 
            this.btnGenerar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnGenerar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnGenerar.ForeColor = System.Drawing.Color.White;
            this.btnGenerar.Location = new System.Drawing.Point(18, 140);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(150, 30);
            this.btnGenerar.TabIndex = 4;
            this.btnGenerar.Text = "Generar Bitmap";
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(180, 140);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(100, 30);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // grpResultados
            // 
            this.grpResultados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(65)))), ((int)(((byte)(89)))));
            this.grpResultados.Controls.Add(this.lblBitmapBinario);
            this.grpResultados.Controls.Add(this.txtBitmapBinario);
            this.grpResultados.Controls.Add(this.lblBitmapHex);
            this.grpResultados.Controls.Add(this.txtBitmapHex);
            this.grpResultados.Controls.Add(this.lblMensajeCompleto);
            this.grpResultados.Controls.Add(this.txtMensajeCompleto);
            this.grpResultados.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpResultados.ForeColor = System.Drawing.Color.Snow;
            this.grpResultados.Location = new System.Drawing.Point(17, 238);
            this.grpResultados.Name = "grpResultados";
            this.grpResultados.Size = new System.Drawing.Size(500, 220);
            this.grpResultados.TabIndex = 2;
            this.grpResultados.TabStop = false;
            this.grpResultados.Text = "Resultados";
            // 
            // lblBitmapBinario
            // 
            this.lblBitmapBinario.AutoSize = true;
            this.lblBitmapBinario.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblBitmapBinario.Location = new System.Drawing.Point(15, 30);
            this.lblBitmapBinario.Name = "lblBitmapBinario";
            this.lblBitmapBinario.Size = new System.Drawing.Size(147, 17);
            this.lblBitmapBinario.TabIndex = 0;
            this.lblBitmapBinario.Text = "Bitmap (64 bits binario):";
            // 
            // txtBitmapBinario
            // 
            this.txtBitmapBinario.BackColor = System.Drawing.Color.White;
            this.txtBitmapBinario.Font = new System.Drawing.Font("Consolas", 9F);
            this.txtBitmapBinario.Location = new System.Drawing.Point(18, 50);
            this.txtBitmapBinario.Multiline = true;
            this.txtBitmapBinario.Name = "txtBitmapBinario";
            this.txtBitmapBinario.ReadOnly = true;
            this.txtBitmapBinario.Size = new System.Drawing.Size(465, 40);
            this.txtBitmapBinario.TabIndex = 1;
            // 
            // lblBitmapHex
            // 
            this.lblBitmapHex.AutoSize = true;
            this.lblBitmapHex.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblBitmapHex.Location = new System.Drawing.Point(15, 100);
            this.lblBitmapHex.Name = "lblBitmapHex";
            this.lblBitmapHex.Size = new System.Drawing.Size(208, 17);
            this.lblBitmapHex.TabIndex = 2;
            this.lblBitmapHex.Text = "Bitmap (Hexadecimal - 16 digitos):";
            // 
            // txtBitmapHex
            // 
            this.txtBitmapHex.BackColor = System.Drawing.Color.White;
            this.txtBitmapHex.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold);
            this.txtBitmapHex.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.txtBitmapHex.Location = new System.Drawing.Point(18, 120);
            this.txtBitmapHex.Name = "txtBitmapHex";
            this.txtBitmapHex.ReadOnly = true;
            this.txtBitmapHex.Size = new System.Drawing.Size(465, 25);
            this.txtBitmapHex.TabIndex = 3;
            // 
            // lblMensajeCompleto
            // 
            this.lblMensajeCompleto.AutoSize = true;
            this.lblMensajeCompleto.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblMensajeCompleto.Location = new System.Drawing.Point(15, 155);
            this.lblMensajeCompleto.Name = "lblMensajeCompleto";
            this.lblMensajeCompleto.Size = new System.Drawing.Size(121, 17);
            this.lblMensajeCompleto.TabIndex = 4;
            this.lblMensajeCompleto.Text = "Mensaje Completo:";
            // 
            // txtMensajeCompleto
            // 
            this.txtMensajeCompleto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.txtMensajeCompleto.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold);
            this.txtMensajeCompleto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.txtMensajeCompleto.Location = new System.Drawing.Point(18, 175);
            this.txtMensajeCompleto.Name = "txtMensajeCompleto";
            this.txtMensajeCompleto.ReadOnly = true;
            this.txtMensajeCompleto.Size = new System.Drawing.Size(465, 25);
            this.txtMensajeCompleto.TabIndex = 5;
            // 
            // grpDataMatrix
            // 
            this.grpDataMatrix.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.grpDataMatrix.Controls.Add(this.label1);
            this.grpDataMatrix.Controls.Add(this.pnlDataMatrix);
            this.grpDataMatrix.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpDataMatrix.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grpDataMatrix.Location = new System.Drawing.Point(572, 52);
            this.grpDataMatrix.Name = "grpDataMatrix";
            this.grpDataMatrix.Size = new System.Drawing.Size(275, 295);
            this.grpDataMatrix.TabIndex = 4;
            this.grpDataMatrix.TabStop = false;
            // 
            // pnlDataMatrix
            // 
            this.pnlDataMatrix.AutoScroll = true;
            this.pnlDataMatrix.BackColor = System.Drawing.Color.White;
            this.pnlDataMatrix.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDataMatrix.Location = new System.Drawing.Point(9, 24);
            this.pnlDataMatrix.Name = "pnlDataMatrix";
            this.pnlDataMatrix.Size = new System.Drawing.Size(258, 262);
            this.pnlDataMatrix.TabIndex = 0;
            this.pnlDataMatrix.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDataMatrix_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(7, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Data Matrix";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(857, 475);
            this.Controls.Add(this.grpDataMatrix);
            this.Controls.Add(this.grpResultados);
            this.Controls.Add(this.grpEntrada);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bitmap";
            this.grpEntrada.ResumeLayout(false);
            this.grpEntrada.PerformLayout();
            this.grpResultados.ResumeLayout(false);
            this.grpResultados.PerformLayout();
            this.grpDataMatrix.ResumeLayout(false);
            this.grpDataMatrix.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox grpEntrada;
        private System.Windows.Forms.Label lblMTI;
        private System.Windows.Forms.ComboBox cmbMTI;
        private System.Windows.Forms.Label lblCampos;
        private System.Windows.Forms.TextBox txtCampos;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.GroupBox grpResultados;
        private System.Windows.Forms.Label lblBitmapBinario;
        private System.Windows.Forms.TextBox txtBitmapBinario;
        private System.Windows.Forms.Label lblBitmapHex;
        private System.Windows.Forms.TextBox txtBitmapHex;
        private System.Windows.Forms.Label lblMensajeCompleto;
        private System.Windows.Forms.TextBox txtMensajeCompleto;
        private System.Windows.Forms.GroupBox grpDataMatrix;
        private System.Windows.Forms.Panel pnlDataMatrix;
        private System.Windows.Forms.Label label1;
    }
}