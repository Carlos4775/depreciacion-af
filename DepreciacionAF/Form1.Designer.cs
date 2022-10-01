namespace DepreciacionAF
{
    partial class FrmDepreciacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDepreciacion));
            this.lbCostoActivo = new System.Windows.Forms.Label();
            this.lbValorResidual = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtCostoActivo = new System.Windows.Forms.TextBox();
            this.txtValorResidual = new System.Windows.Forms.TextBox();
            this.lbVidaUtilActivo = new System.Windows.Forms.Label();
            this.txtVidaUtil = new System.Windows.Forms.TextBox();
            this.txtGastoAnual = new System.Windows.Forms.TextBox();
            this.lbGastoAnualDepreciacion = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbCostoActivo
            // 
            this.lbCostoActivo.AutoSize = true;
            this.lbCostoActivo.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCostoActivo.Location = new System.Drawing.Point(56, 20);
            this.lbCostoActivo.Name = "lbCostoActivo";
            this.lbCostoActivo.Size = new System.Drawing.Size(96, 16);
            this.lbCostoActivo.TabIndex = 0;
            this.lbCostoActivo.Text = "Costo de activo";
            // 
            // lbValorResidual
            // 
            this.lbValorResidual.AutoSize = true;
            this.lbValorResidual.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValorResidual.Location = new System.Drawing.Point(56, 108);
            this.lbValorResidual.Name = "lbValorResidual";
            this.lbValorResidual.Size = new System.Drawing.Size(83, 16);
            this.lbValorResidual.TabIndex = 1;
            this.lbValorResidual.Text = "Valor residual";
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCalcular.Location = new System.Drawing.Point(48, 328);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 29);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtCostoActivo
            // 
            this.txtCostoActivo.Location = new System.Drawing.Point(59, 58);
            this.txtCostoActivo.Name = "txtCostoActivo";
            this.txtCostoActivo.Size = new System.Drawing.Size(100, 22);
            this.txtCostoActivo.TabIndex = 4;
            // 
            // txtValorResidual
            // 
            this.txtValorResidual.Location = new System.Drawing.Point(59, 140);
            this.txtValorResidual.Name = "txtValorResidual";
            this.txtValorResidual.Size = new System.Drawing.Size(100, 22);
            this.txtValorResidual.TabIndex = 5;
            // 
            // lbVidaUtilActivo
            // 
            this.lbVidaUtilActivo.AutoSize = true;
            this.lbVidaUtilActivo.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVidaUtilActivo.Location = new System.Drawing.Point(56, 201);
            this.lbVidaUtilActivo.Name = "lbVidaUtilActivo";
            this.lbVidaUtilActivo.Size = new System.Drawing.Size(111, 16);
            this.lbVidaUtilActivo.TabIndex = 6;
            this.lbVidaUtilActivo.Text = "Vida util del activo";
            // 
            // txtVidaUtil
            // 
            this.txtVidaUtil.Location = new System.Drawing.Point(59, 232);
            this.txtVidaUtil.Name = "txtVidaUtil";
            this.txtVidaUtil.Size = new System.Drawing.Size(100, 22);
            this.txtVidaUtil.TabIndex = 7;
            // 
            // txtGastoAnual
            // 
            this.txtGastoAnual.Location = new System.Drawing.Point(470, 30);
            this.txtGastoAnual.Name = "txtGastoAnual";
            this.txtGastoAnual.Size = new System.Drawing.Size(100, 22);
            this.txtGastoAnual.TabIndex = 8;
            // 
            // lbGastoAnualDepreciacion
            // 
            this.lbGastoAnualDepreciacion.AutoSize = true;
            this.lbGastoAnualDepreciacion.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGastoAnualDepreciacion.Location = new System.Drawing.Point(253, 30);
            this.lbGastoAnualDepreciacion.Name = "lbGastoAnualDepreciacion";
            this.lbGastoAnualDepreciacion.Size = new System.Drawing.Size(179, 17);
            this.lbGastoAnualDepreciacion.TabIndex = 9;
            this.lbGastoAnualDepreciacion.Text = "Gasto anual de depreciacion";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(140, 328);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 29);
            this.button1.TabIndex = 10;
            this.button1.Text = "Limpiar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lbVidaUtilActivo);
            this.panel1.Controls.Add(this.lbCostoActivo);
            this.panel1.Controls.Add(this.txtVidaUtil);
            this.panel1.Controls.Add(this.lbValorResidual);
            this.panel1.Controls.Add(this.txtCostoActivo);
            this.panel1.Controls.Add(this.txtValorResidual);
            this.panel1.Location = new System.Drawing.Point(26, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(568, 296);
            this.panel1.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(291, 85);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(235, 173);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FrmDepreciacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(625, 377);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbGastoAnualDepreciacion);
            this.Controls.Add(this.txtGastoAnual);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.panel1);
            this.Name = "FrmDepreciacion";
            this.Text = "Depreciacion Activo Fijo";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCostoActivo;
        private System.Windows.Forms.Label lbValorResidual;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtCostoActivo;
        private System.Windows.Forms.TextBox txtValorResidual;
        private System.Windows.Forms.Label lbVidaUtilActivo;
        private System.Windows.Forms.TextBox txtVidaUtil;
        private System.Windows.Forms.TextBox txtGastoAnual;
        private System.Windows.Forms.Label lbGastoAnualDepreciacion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

