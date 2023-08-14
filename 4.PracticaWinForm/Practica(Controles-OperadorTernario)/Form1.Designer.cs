namespace Practica_Controles_OperadorTernario_
{
    partial class practica1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.chbSocio = new System.Windows.Forms.CheckBox();
            this.rbEdadMenor = new System.Windows.Forms.RadioButton();
            this.rbEdadMayor = new System.Windows.Forms.RadioButton();
            this.rbEdadJubilado = new System.Windows.Forms.RadioButton();
            this.lblFecha = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.gbEdad = new System.Windows.Forms.GroupBox();
            this.lblCodigoNombre = new System.Windows.Forms.Label();
            this.lwListaNombres = new System.Windows.Forms.ListView();
            this.lblNumeroCodigoNombre = new System.Windows.Forms.Label();
            this.lblTuEdad = new System.Windows.Forms.Label();
            this.lblTuEdadAnio = new System.Windows.Forms.Label();
            this.gbEdad.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpFecha
            // 
            this.dtpFecha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFecha.Location = new System.Drawing.Point(242, 248);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(270, 26);
            this.dtpFecha.TabIndex = 1;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(89, 445);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(155, 72);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // chbSocio
            // 
            this.chbSocio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chbSocio.AutoSize = true;
            this.chbSocio.Location = new System.Drawing.Point(242, 310);
            this.chbSocio.Name = "chbSocio";
            this.chbSocio.Size = new System.Drawing.Size(79, 24);
            this.chbSocio.TabIndex = 2;
            this.chbSocio.Text = "SOCIO";
            this.chbSocio.UseVisualStyleBackColor = true;
            // 
            // rbEdadMenor
            // 
            this.rbEdadMenor.AutoSize = true;
            this.rbEdadMenor.Location = new System.Drawing.Point(15, 39);
            this.rbEdadMenor.Name = "rbEdadMenor";
            this.rbEdadMenor.Size = new System.Drawing.Size(136, 24);
            this.rbEdadMenor.TabIndex = 5;
            this.rbEdadMenor.TabStop = true;
            this.rbEdadMenor.Text = "Menor de Edad";
            this.rbEdadMenor.UseVisualStyleBackColor = true;
            // 
            // rbEdadMayor
            // 
            this.rbEdadMayor.AutoSize = true;
            this.rbEdadMayor.Location = new System.Drawing.Point(175, 39);
            this.rbEdadMayor.Name = "rbEdadMayor";
            this.rbEdadMayor.Size = new System.Drawing.Size(134, 24);
            this.rbEdadMayor.TabIndex = 6;
            this.rbEdadMayor.TabStop = true;
            this.rbEdadMayor.Text = "Mayor de Edad";
            this.rbEdadMayor.UseVisualStyleBackColor = true;
            // 
            // rbEdadJubilado
            // 
            this.rbEdadJubilado.AutoSize = true;
            this.rbEdadJubilado.Location = new System.Drawing.Point(329, 39);
            this.rbEdadJubilado.Name = "rbEdadJubilado";
            this.rbEdadJubilado.Size = new System.Drawing.Size(86, 24);
            this.rbEdadJubilado.TabIndex = 7;
            this.rbEdadJubilado.TabStop = true;
            this.rbEdadJubilado.Text = "Jubilado";
            this.rbEdadJubilado.UseVisualStyleBackColor = true;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(96, 253);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(58, 20);
            this.lblFecha.TabIndex = 8;
            this.lblFecha.Text = "Fecha:";
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombre.Location = new System.Drawing.Point(242, 190);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(270, 26);
            this.txtNombre.TabIndex = 0;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(85, 196);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(69, 20);
            this.lblNombre.TabIndex = 10;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft YaHei UI", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(158, 63);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(295, 36);
            this.lblTitulo.TabIndex = 11;
            this.lblTitulo.Text = "PRACTICA PERSONA";
            // 
            // gbEdad
            // 
            this.gbEdad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbEdad.Controls.Add(this.rbEdadMenor);
            this.gbEdad.Controls.Add(this.rbEdadMayor);
            this.gbEdad.Controls.Add(this.rbEdadJubilado);
            this.gbEdad.Location = new System.Drawing.Point(89, 340);
            this.gbEdad.Name = "gbEdad";
            this.gbEdad.Size = new System.Drawing.Size(448, 88);
            this.gbEdad.TabIndex = 3;
            this.gbEdad.TabStop = false;
            this.gbEdad.Text = "Edad:";
            // 
            // lblCodigoNombre
            // 
            this.lblCodigoNombre.AutoSize = true;
            this.lblCodigoNombre.Location = new System.Drawing.Point(95, 143);
            this.lblCodigoNombre.Name = "lblCodigoNombre";
            this.lblCodigoNombre.Size = new System.Drawing.Size(59, 20);
            this.lblCodigoNombre.TabIndex = 13;
            this.lblCodigoNombre.Text = "Código";
            // 
            // lwListaNombres
            // 
            this.lwListaNombres.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lwListaNombres.HideSelection = false;
            this.lwListaNombres.Location = new System.Drawing.Point(269, 445);
            this.lwListaNombres.Name = "lwListaNombres";
            this.lwListaNombres.Size = new System.Drawing.Size(259, 143);
            this.lwListaNombres.TabIndex = 14;
            this.lwListaNombres.UseCompatibleStateImageBehavior = false;
            // 
            // lblNumeroCodigoNombre
            // 
            this.lblNumeroCodigoNombre.AutoSize = true;
            this.lblNumeroCodigoNombre.Location = new System.Drawing.Point(321, 152);
            this.lblNumeroCodigoNombre.Name = "lblNumeroCodigoNombre";
            this.lblNumeroCodigoNombre.Size = new System.Drawing.Size(0, 20);
            this.lblNumeroCodigoNombre.TabIndex = 15;
            // 
            // lblTuEdad
            // 
            this.lblTuEdad.AutoSize = true;
            this.lblTuEdad.Location = new System.Drawing.Point(85, 542);
            this.lblTuEdad.Name = "lblTuEdad";
            this.lblTuEdad.Size = new System.Drawing.Size(94, 20);
            this.lblTuEdad.TabIndex = 16;
            this.lblTuEdad.Text = "Tu Edad es:";
            // 
            // lblTuEdadAnio
            // 
            this.lblTuEdadAnio.AutoSize = true;
            this.lblTuEdadAnio.Location = new System.Drawing.Point(193, 542);
            this.lblTuEdadAnio.Name = "lblTuEdadAnio";
            this.lblTuEdadAnio.Size = new System.Drawing.Size(0, 20);
            this.lblTuEdadAnio.TabIndex = 17;
            // 
            // practica1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(596, 614);
            this.Controls.Add(this.lblTuEdadAnio);
            this.Controls.Add(this.lblTuEdad);
            this.Controls.Add(this.lblNumeroCodigoNombre);
            this.Controls.Add(this.lwListaNombres);
            this.Controls.Add(this.lblCodigoNombre);
            this.Controls.Add(this.gbEdad);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.chbSocio);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dtpFecha);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(690, 653);
            this.MinimumSize = new System.Drawing.Size(612, 653);
            this.Name = "practica1";
            this.Text = "practica";
            this.gbEdad.ResumeLayout(false);
            this.gbEdad.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.CheckBox chbSocio;
        private System.Windows.Forms.RadioButton rbEdadMenor;
        private System.Windows.Forms.RadioButton rbEdadMayor;
        private System.Windows.Forms.RadioButton rbEdadJubilado;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox gbEdad;
        private System.Windows.Forms.Label lblCodigoNombre;
        private System.Windows.Forms.ListView lwListaNombres;
        private System.Windows.Forms.Label lblNumeroCodigoNombre;
        private System.Windows.Forms.Label lblTuEdad;
        private System.Windows.Forms.Label lblTuEdadAnio;
    }
}

