namespace herramientas2personas
{
    partial class Animales
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
            this.btnelimarbd1 = new System.Windows.Forms.Button();
            this.txt_especie = new System.Windows.Forms.TextBox();
            this.lblespecie = new System.Windows.Forms.Label();
            this.txt_nacimiento = new System.Windows.Forms.TextBox();
            this.lblnacimiento = new System.Windows.Forms.Label();
            this.txt_colordepelo = new System.Windows.Forms.TextBox();
            this.lblcolordepelo = new System.Windows.Forms.Label();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_eliminarregistro1 = new System.Windows.Forms.Button();
            this.btn_crearregistro1 = new System.Windows.Forms.Button();
            this.txt_nombre1 = new System.Windows.Forms.TextBox();
            this.lbl_nombre1 = new System.Windows.Forms.Label();
            this.lbl_codigo = new System.Windows.Forms.Label();
            this.dataAnimales = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colorpelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechanacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Especie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Raza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pesoanterior = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Peso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.txt_raza = new System.Windows.Forms.TextBox();
            this.lblraza = new System.Windows.Forms.Label();
            this.txt_pesoanterior = new System.Windows.Forms.TextBox();
            this.lblpesoanterior = new System.Windows.Forms.Label();
            this.txt_pesoactual = new System.Windows.Forms.TextBox();
            this.lblpesoactual = new System.Windows.Forms.Label();
            this.btnsiguiente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataAnimales)).BeginInit();
            this.SuspendLayout();
            // 
            // btnelimarbd1
            // 
            this.btnelimarbd1.Location = new System.Drawing.Point(999, 375);
            this.btnelimarbd1.Name = "btnelimarbd1";
            this.btnelimarbd1.Size = new System.Drawing.Size(101, 52);
            this.btnelimarbd1.TabIndex = 36;
            this.btnelimarbd1.Text = "Eliminar BD";
            this.btnelimarbd1.UseVisualStyleBackColor = true;
            this.btnelimarbd1.Click += new System.EventHandler(this.btnelimarbd1_Click);
            // 
            // txt_especie
            // 
            this.txt_especie.Location = new System.Drawing.Point(461, 391);
            this.txt_especie.Name = "txt_especie";
            this.txt_especie.Size = new System.Drawing.Size(176, 26);
            this.txt_especie.TabIndex = 34;
            // 
            // lblespecie
            // 
            this.lblespecie.AutoSize = true;
            this.lblespecie.Location = new System.Drawing.Point(157, 391);
            this.lblespecie.Name = "lblespecie";
            this.lblespecie.Size = new System.Drawing.Size(66, 20);
            this.lblespecie.TabIndex = 33;
            this.lblespecie.Text = "Especie";
            // 
            // txt_nacimiento
            // 
            this.txt_nacimiento.Location = new System.Drawing.Point(461, 351);
            this.txt_nacimiento.Name = "txt_nacimiento";
            this.txt_nacimiento.Size = new System.Drawing.Size(176, 26);
            this.txt_nacimiento.TabIndex = 32;
            // 
            // lblnacimiento
            // 
            this.lblnacimiento.AutoSize = true;
            this.lblnacimiento.Location = new System.Drawing.Point(157, 347);
            this.lblnacimiento.Name = "lblnacimiento";
            this.lblnacimiento.Size = new System.Drawing.Size(157, 20);
            this.lblnacimiento.TabIndex = 31;
            this.lblnacimiento.Text = "Fecha de nacimiento";
            // 
            // txt_colordepelo
            // 
            this.txt_colordepelo.Location = new System.Drawing.Point(461, 308);
            this.txt_colordepelo.Name = "txt_colordepelo";
            this.txt_colordepelo.Size = new System.Drawing.Size(176, 26);
            this.txt_colordepelo.TabIndex = 30;
            // 
            // lblcolordepelo
            // 
            this.lblcolordepelo.AutoSize = true;
            this.lblcolordepelo.Location = new System.Drawing.Point(157, 304);
            this.lblcolordepelo.Name = "lblcolordepelo";
            this.lblcolordepelo.Size = new System.Drawing.Size(102, 20);
            this.lblcolordepelo.TabIndex = 29;
            this.lblcolordepelo.Text = "Color de pelo";
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Location = new System.Drawing.Point(194, 155);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(163, 20);
            this.lbltitulo.TabIndex = 28;
            this.lbltitulo.Text = "Datos Usuario Animal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(148, 630);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "Registro seleccionado";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btn_eliminarregistro1
            // 
            this.btn_eliminarregistro1.Image = global::herramientas2personas.Properties.Resources.icons8_trash_50;
            this.btn_eliminarregistro1.Location = new System.Drawing.Point(999, 276);
            this.btn_eliminarregistro1.Name = "btn_eliminarregistro1";
            this.btn_eliminarregistro1.Size = new System.Drawing.Size(115, 72);
            this.btn_eliminarregistro1.TabIndex = 25;
            this.btn_eliminarregistro1.UseVisualStyleBackColor = true;
            this.btn_eliminarregistro1.Click += new System.EventHandler(this.btn_eliminarregistro1_Click);
            // 
            // btn_crearregistro1
            // 
            this.btn_crearregistro1.Image = global::herramientas2personas.Properties.Resources.icons8_document_67;
            this.btn_crearregistro1.Location = new System.Drawing.Point(999, 172);
            this.btn_crearregistro1.Name = "btn_crearregistro1";
            this.btn_crearregistro1.Size = new System.Drawing.Size(120, 82);
            this.btn_crearregistro1.TabIndex = 24;
            this.btn_crearregistro1.UseVisualStyleBackColor = true;
            this.btn_crearregistro1.Click += new System.EventHandler(this.btn_crearregistro1_Click);
            // 
            // txt_nombre1
            // 
            this.txt_nombre1.Location = new System.Drawing.Point(461, 261);
            this.txt_nombre1.Name = "txt_nombre1";
            this.txt_nombre1.Size = new System.Drawing.Size(176, 26);
            this.txt_nombre1.TabIndex = 23;
            // 
            // lbl_nombre1
            // 
            this.lbl_nombre1.AutoSize = true;
            this.lbl_nombre1.Location = new System.Drawing.Point(157, 261);
            this.lbl_nombre1.Name = "lbl_nombre1";
            this.lbl_nombre1.Size = new System.Drawing.Size(65, 20);
            this.lbl_nombre1.TabIndex = 21;
            this.lbl_nombre1.Text = "Nombre";
            // 
            // lbl_codigo
            // 
            this.lbl_codigo.AutoSize = true;
            this.lbl_codigo.Location = new System.Drawing.Point(157, 222);
            this.lbl_codigo.Name = "lbl_codigo";
            this.lbl_codigo.Size = new System.Drawing.Size(59, 20);
            this.lbl_codigo.TabIndex = 20;
            this.lbl_codigo.Text = "Codigo";
            // 
            // dataAnimales
            // 
            this.dataAnimales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataAnimales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Colorpelo,
            this.Nombre,
            this.fechanacimiento,
            this.Especie,
            this.Raza,
            this.Pesoanterior,
            this.Peso});
            this.dataAnimales.Location = new System.Drawing.Point(47, 695);
            this.dataAnimales.Name = "dataAnimales";
            this.dataAnimales.RowHeadersWidth = 62;
            this.dataAnimales.RowTemplate.Height = 28;
            this.dataAnimales.Size = new System.Drawing.Size(1573, 219);
            this.dataAnimales.TabIndex = 37;
            this.dataAnimales.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataAnimales_CellContentClick);
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.MinimumWidth = 8;
            this.Codigo.Name = "Codigo";
            this.Codigo.Width = 150;
            // 
            // Colorpelo
            // 
            this.Colorpelo.HeaderText = "Color de pelo";
            this.Colorpelo.MinimumWidth = 8;
            this.Colorpelo.Name = "Colorpelo";
            this.Colorpelo.Width = 150;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 8;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 150;
            // 
            // fechanacimiento
            // 
            this.fechanacimiento.HeaderText = "Fecha de nacimiento";
            this.fechanacimiento.MinimumWidth = 8;
            this.fechanacimiento.Name = "fechanacimiento";
            this.fechanacimiento.Width = 150;
            // 
            // Especie
            // 
            this.Especie.HeaderText = "Especie";
            this.Especie.MinimumWidth = 8;
            this.Especie.Name = "Especie";
            this.Especie.Width = 150;
            // 
            // Raza
            // 
            this.Raza.HeaderText = "Raza";
            this.Raza.MinimumWidth = 8;
            this.Raza.Name = "Raza";
            this.Raza.Width = 150;
            // 
            // Pesoanterior
            // 
            this.Pesoanterior.HeaderText = "Peso anterior";
            this.Pesoanterior.MinimumWidth = 8;
            this.Pesoanterior.Name = "Pesoanterior";
            this.Pesoanterior.Width = 150;
            // 
            // Peso
            // 
            this.Peso.HeaderText = "Peso";
            this.Peso.MinimumWidth = 8;
            this.Peso.Name = "Peso";
            this.Peso.Width = 150;
            // 
            // txt_codigo
            // 
            this.txt_codigo.Location = new System.Drawing.Point(461, 216);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(176, 26);
            this.txt_codigo.TabIndex = 38;
            this.txt_codigo.TextChanged += new System.EventHandler(this.txt_codigo_TextChanged);
            // 
            // txt_raza
            // 
            this.txt_raza.Location = new System.Drawing.Point(461, 432);
            this.txt_raza.Name = "txt_raza";
            this.txt_raza.Size = new System.Drawing.Size(176, 26);
            this.txt_raza.TabIndex = 40;
            // 
            // lblraza
            // 
            this.lblraza.AutoSize = true;
            this.lblraza.Location = new System.Drawing.Point(157, 432);
            this.lblraza.Name = "lblraza";
            this.lblraza.Size = new System.Drawing.Size(47, 20);
            this.lblraza.TabIndex = 39;
            this.lblraza.Text = "Raza";
            // 
            // txt_pesoanterior
            // 
            this.txt_pesoanterior.Location = new System.Drawing.Point(461, 476);
            this.txt_pesoanterior.Name = "txt_pesoanterior";
            this.txt_pesoanterior.Size = new System.Drawing.Size(176, 26);
            this.txt_pesoanterior.TabIndex = 42;
            // 
            // lblpesoanterior
            // 
            this.lblpesoanterior.AutoSize = true;
            this.lblpesoanterior.Location = new System.Drawing.Point(157, 476);
            this.lblpesoanterior.Name = "lblpesoanterior";
            this.lblpesoanterior.Size = new System.Drawing.Size(168, 20);
            this.lblpesoanterior.TabIndex = 41;
            this.lblpesoanterior.Text = "Peso ultimas 10 visitas";
            // 
            // txt_pesoactual
            // 
            this.txt_pesoactual.Location = new System.Drawing.Point(461, 521);
            this.txt_pesoactual.Name = "txt_pesoactual";
            this.txt_pesoactual.Size = new System.Drawing.Size(176, 26);
            this.txt_pesoactual.TabIndex = 44;
            // 
            // lblpesoactual
            // 
            this.lblpesoactual.AutoSize = true;
            this.lblpesoactual.Location = new System.Drawing.Point(157, 521);
            this.lblpesoactual.Name = "lblpesoactual";
            this.lblpesoactual.Size = new System.Drawing.Size(92, 20);
            this.lblpesoactual.TabIndex = 43;
            this.lblpesoactual.Text = "Peso actual";
            // 
            // btnsiguiente
            // 
            this.btnsiguiente.Location = new System.Drawing.Point(1384, 947);
            this.btnsiguiente.Name = "btnsiguiente";
            this.btnsiguiente.Size = new System.Drawing.Size(120, 54);
            this.btnsiguiente.TabIndex = 45;
            this.btnsiguiente.Text = "Siguiente";
            this.btnsiguiente.UseVisualStyleBackColor = true;
            this.btnsiguiente.Click += new System.EventHandler(this.btnsiguiente_Click);
            // 
            // Animales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::herramientas2personas.Properties.Resources.R;
            this.ClientSize = new System.Drawing.Size(1814, 1035);
            this.Controls.Add(this.btnsiguiente);
            this.Controls.Add(this.txt_pesoactual);
            this.Controls.Add(this.lblpesoactual);
            this.Controls.Add(this.txt_pesoanterior);
            this.Controls.Add(this.lblpesoanterior);
            this.Controls.Add(this.txt_raza);
            this.Controls.Add(this.lblraza);
            this.Controls.Add(this.txt_codigo);
            this.Controls.Add(this.dataAnimales);
            this.Controls.Add(this.btnelimarbd1);
            this.Controls.Add(this.txt_especie);
            this.Controls.Add(this.lblespecie);
            this.Controls.Add(this.txt_nacimiento);
            this.Controls.Add(this.lblnacimiento);
            this.Controls.Add(this.txt_colordepelo);
            this.Controls.Add(this.lblcolordepelo);
            this.Controls.Add(this.lbltitulo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_eliminarregistro1);
            this.Controls.Add(this.btn_crearregistro1);
            this.Controls.Add(this.txt_nombre1);
            this.Controls.Add(this.lbl_nombre1);
            this.Controls.Add(this.lbl_codigo);
            this.Name = "Animales";
            this.Text = "Animal";
            this.Load += new System.EventHandler(this.Animal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataAnimales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnelimarbd1;
        private System.Windows.Forms.TextBox txt_especie;
        private System.Windows.Forms.Label lblespecie;
        private System.Windows.Forms.TextBox txt_nacimiento;
        private System.Windows.Forms.Label lblnacimiento;
        private System.Windows.Forms.TextBox txt_colordepelo;
        private System.Windows.Forms.Label lblcolordepelo;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_eliminarregistro1;
        private System.Windows.Forms.Button btn_crearregistro1;
        private System.Windows.Forms.TextBox txt_nombre1;
        private System.Windows.Forms.Label lbl_nombre1;
        private System.Windows.Forms.Label lbl_codigo;
        private System.Windows.Forms.DataGridView dataAnimales;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.TextBox txt_raza;
        private System.Windows.Forms.Label lblraza;
        private System.Windows.Forms.TextBox txt_pesoanterior;
        private System.Windows.Forms.Label lblpesoanterior;
        private System.Windows.Forms.TextBox txt_pesoactual;
        private System.Windows.Forms.Label lblpesoactual;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colorpelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechanacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Especie;
        private System.Windows.Forms.DataGridViewTextBoxColumn Raza;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pesoanterior;
        private System.Windows.Forms.DataGridViewTextBoxColumn Peso;
        private System.Windows.Forms.Button btnsiguiente;
    }
}