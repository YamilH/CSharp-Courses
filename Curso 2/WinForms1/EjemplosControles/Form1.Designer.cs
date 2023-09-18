namespace EjemplosControles
{
    partial class Form1
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lwElementos = new System.Windows.Forms.ListView();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpFechaDeNacimiento = new System.Windows.Forms.DateTimePicker();
            this.cbChocolate = new System.Windows.Forms.CheckBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.rbWizard = new System.Windows.Forms.RadioButton();
            this.rbMuggle = new System.Windows.Forms.RadioButton();
            this.rbSquibs = new System.Windows.Forms.RadioButton();
            this.gbTipo = new System.Windows.Forms.GroupBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.cbColorFavorito = new System.Windows.Forms.ComboBox();
            this.nNumero = new System.Windows.Forms.NumericUpDown();
            this.lblNumero = new System.Windows.Forms.Label();
            this.btnVerPerfil = new System.Windows.Forms.Button();
            this.gbTipo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nNumero)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(181, 62);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(200, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(85, 434);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lwElementos
            // 
            this.lwElementos.HideSelection = false;
            this.lwElementos.Location = new System.Drawing.Point(85, 322);
            this.lwElementos.Name = "lwElementos";
            this.lwElementos.Size = new System.Drawing.Size(210, 106);
            this.lwElementos.TabIndex = 7;
            this.lwElementos.UseCompatibleStateImageBehavior = false;
            this.lwElementos.View = System.Windows.Forms.View.List;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(131, 65);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(138, 101);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(37, 13);
            this.lblFecha.TabIndex = 4;
            this.lblFecha.Text = "Fecha";
            // 
            // dtpFechaDeNacimiento
            // 
            this.dtpFechaDeNacimiento.Location = new System.Drawing.Point(181, 98);
            this.dtpFechaDeNacimiento.Name = "dtpFechaDeNacimiento";
            this.dtpFechaDeNacimiento.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaDeNacimiento.TabIndex = 1;
            // 
            // cbChocolate
            // 
            this.cbChocolate.AutoSize = true;
            this.cbChocolate.Location = new System.Drawing.Point(181, 131);
            this.cbChocolate.Name = "cbChocolate";
            this.cbChocolate.Size = new System.Drawing.Size(136, 17);
            this.cbChocolate.TabIndex = 2;
            this.cbChocolate.Text = "Te gusta el Chocolate?";
            this.cbChocolate.UseVisualStyleBackColor = true;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(115, 18);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(140, 24);
            this.lblTitulo.TabIndex = 7;
            this.lblTitulo.Text = "Perfil Persona";
            // 
            // rbWizard
            // 
            this.rbWizard.AutoSize = true;
            this.rbWizard.Checked = true;
            this.rbWizard.Location = new System.Drawing.Point(54, 16);
            this.rbWizard.Name = "rbWizard";
            this.rbWizard.Size = new System.Drawing.Size(58, 17);
            this.rbWizard.TabIndex = 0;
            this.rbWizard.TabStop = true;
            this.rbWizard.Text = "Wizard";
            this.rbWizard.UseVisualStyleBackColor = true;
            // 
            // rbMuggle
            // 
            this.rbMuggle.AutoSize = true;
            this.rbMuggle.Location = new System.Drawing.Point(140, 16);
            this.rbMuggle.Name = "rbMuggle";
            this.rbMuggle.Size = new System.Drawing.Size(60, 17);
            this.rbMuggle.TabIndex = 1;
            this.rbMuggle.Text = "Muggle";
            this.rbMuggle.UseVisualStyleBackColor = true;
            // 
            // rbSquibs
            // 
            this.rbSquibs.AutoSize = true;
            this.rbSquibs.Location = new System.Drawing.Point(231, 16);
            this.rbSquibs.Name = "rbSquibs";
            this.rbSquibs.Size = new System.Drawing.Size(57, 17);
            this.rbSquibs.TabIndex = 2;
            this.rbSquibs.Text = "Squibs";
            this.rbSquibs.UseVisualStyleBackColor = true;
            // 
            // gbTipo
            // 
            this.gbTipo.Controls.Add(this.rbWizard);
            this.gbTipo.Controls.Add(this.rbSquibs);
            this.gbTipo.Controls.Add(this.rbMuggle);
            this.gbTipo.Location = new System.Drawing.Point(95, 146);
            this.gbTipo.Name = "gbTipo";
            this.gbTipo.Size = new System.Drawing.Size(385, 44);
            this.gbTipo.TabIndex = 3;
            this.gbTipo.TabStop = false;
            this.gbTipo.Text = "Tipo";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(95, 218);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(72, 13);
            this.lblColor.TabIndex = 12;
            this.lblColor.Text = "Color Favorito";
            // 
            // cbColorFavorito
            // 
            this.cbColorFavorito.FormattingEnabled = true;
            this.cbColorFavorito.Location = new System.Drawing.Point(174, 215);
            this.cbColorFavorito.Name = "cbColorFavorito";
            this.cbColorFavorito.Size = new System.Drawing.Size(121, 21);
            this.cbColorFavorito.TabIndex = 4;
            // 
            // nNumero
            // 
            this.nNumero.Location = new System.Drawing.Point(174, 243);
            this.nNumero.Name = "nNumero";
            this.nNumero.Size = new System.Drawing.Size(120, 20);
            this.nNumero.TabIndex = 5;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(82, 245);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(85, 13);
            this.lblNumero.TabIndex = 15;
            this.lblNumero.Text = "Número Favorito";
            // 
            // btnVerPerfil
            // 
            this.btnVerPerfil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnVerPerfil.Location = new System.Drawing.Point(85, 280);
            this.btnVerPerfil.Name = "btnVerPerfil";
            this.btnVerPerfil.Size = new System.Drawing.Size(82, 36);
            this.btnVerPerfil.TabIndex = 6;
            this.btnVerPerfil.Text = "Ver &Perfil";
            this.btnVerPerfil.UseVisualStyleBackColor = true;
            this.btnVerPerfil.Click += new System.EventHandler(this.btnVerPerfil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(523, 469);
            this.Controls.Add(this.btnVerPerfil);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.nNumero);
            this.Controls.Add(this.cbColorFavorito);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.gbTipo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.cbChocolate);
            this.Controls.Add(this.dtpFechaDeNacimiento);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lwElementos);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtNombre);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(539, 508);
            this.MinimumSize = new System.Drawing.Size(539, 508);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbTipo.ResumeLayout(false);
            this.gbTipo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nNumero)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ListView lwElementos;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFechaDeNacimiento;
        private System.Windows.Forms.CheckBox cbChocolate;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.RadioButton rbWizard;
        private System.Windows.Forms.RadioButton rbMuggle;
        private System.Windows.Forms.RadioButton rbSquibs;
        private System.Windows.Forms.GroupBox gbTipo;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.ComboBox cbColorFavorito;
        private System.Windows.Forms.NumericUpDown nNumero;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Button btnVerPerfil;
    }
}

