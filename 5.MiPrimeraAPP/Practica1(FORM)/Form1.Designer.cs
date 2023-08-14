namespace Practica1_FORM_
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(practica1));
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblGuardar = new System.Windows.Forms.Label();
            this.txtbGuardar = new System.Windows.Forms.TextBox();
            this.txtbGuardarMulti = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(403, 141);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(148, 48);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblGuardar
            // 
            this.lblGuardar.AutoSize = true;
            this.lblGuardar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblGuardar.Font = new System.Drawing.Font("Pristina", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuardar.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblGuardar.Location = new System.Drawing.Point(282, 362);
            this.lblGuardar.Name = "lblGuardar";
            this.lblGuardar.Size = new System.Drawing.Size(84, 34);
            this.lblGuardar.TabIndex = 1;
            this.lblGuardar.Text = "Guardar";
            this.lblGuardar.MouseLeave += new System.EventHandler(this.lblGuardar_MouseLeave);
            this.lblGuardar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblGuardar_MouseMove);
            // 
            // txtbGuardar
            // 
            this.txtbGuardar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtbGuardar.Location = new System.Drawing.Point(507, 369);
            this.txtbGuardar.MaxLength = 15;
            this.txtbGuardar.Name = "txtbGuardar";
            this.txtbGuardar.Size = new System.Drawing.Size(295, 26);
            this.txtbGuardar.TabIndex = 2;
            this.txtbGuardar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbGuardar_KeyPress);
            // 
            // txtbGuardarMulti
            // 
            this.txtbGuardarMulti.Location = new System.Drawing.Point(507, 455);
            this.txtbGuardarMulti.Multiline = true;
            this.txtbGuardarMulti.Name = "txtbGuardarMulti";
            this.txtbGuardarMulti.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtbGuardarMulti.Size = new System.Drawing.Size(295, 176);
            this.txtbGuardarMulti.TabIndex = 3;
            this.txtbGuardarMulti.Leave += new System.EventHandler(this.txtbGuardarMulti_Leave);
            // 
            // practica1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.txtbGuardarMulti);
            this.Controls.Add(this.txtbGuardar);
            this.Controls.Add(this.lblGuardar);
            this.Controls.Add(this.btnAgregar);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "practica1";
            this.Opacity = 0.5D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "practica1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.practica1_FormClosed);
            this.Load += new System.EventHandler(this.practica1_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.practica1_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblGuardar;
        private System.Windows.Forms.TextBox txtbGuardar;
        private System.Windows.Forms.TextBox txtbGuardarMulti;
    }
}

