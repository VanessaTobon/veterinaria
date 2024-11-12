namespace herramientas2personas
{
    partial class Historialclinico
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
            this.txt_enfermedadvacunada = new System.Windows.Forms.TextBox();
            this.lblenfermedadvacunada = new System.Windows.Forms.Label();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.dataHistoriaClinica = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigomascota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Enfermedadesanteriores = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fechaenfermedad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fechavacuna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Enfermedadvacunada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnelimarbd2 = new System.Windows.Forms.Button();
            this.txt_fechavacuna = new System.Windows.Forms.TextBox();
            this.lblfechavacuna = new System.Windows.Forms.Label();
            this.lblfechaenfermedad = new System.Windows.Forms.Label();
            this.lblenfermedadesanteriores = new System.Windows.Forms.Label();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_eliminarregistro2 = new System.Windows.Forms.Button();
            this.btn_crearregistro2 = new System.Windows.Forms.Button();
            this.lbl_codigomascota = new System.Windows.Forms.Label();
            this.lbl_codigo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_enfermedadesanteriores = new System.Windows.Forms.TextBox();
            this.txt_fechaenfermedad = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataHistoriaClinica)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_enfermedadvacunada
            // 
            this.txt_enfermedadvacunada.Location = new System.Drawing.Point(564, 481);
            this.txt_enfermedadvacunada.Name = "txt_enfermedadvacunada";
            this.txt_enfermedadvacunada.Size = new System.Drawing.Size(176, 26);
            this.txt_enfermedadvacunada.TabIndex = 83;
            // 
            // lblenfermedadvacunada
            // 
            this.lblenfermedadvacunada.AutoSize = true;
            this.lblenfermedadvacunada.Location = new System.Drawing.Point(260, 481);
            this.lblenfermedadvacunada.Name = "lblenfermedadvacunada";
            this.lblenfermedadvacunada.Size = new System.Drawing.Size(170, 20);
            this.lblenfermedadvacunada.TabIndex = 82;
            this.lblenfermedadvacunada.Text = "Enfermedad vacunada";
            // 
            // txt_codigo
            // 
            this.txt_codigo.Location = new System.Drawing.Point(564, 240);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(176, 26);
            this.txt_codigo.TabIndex = 81;
            this.txt_codigo.TextChanged += new System.EventHandler(this.txt_codigo_TextChanged);
            // 
            // dataHistoriaClinica
            // 
            this.dataHistoriaClinica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataHistoriaClinica.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Codigomascota,
            this.Enfermedadesanteriores,
            this.Fechaenfermedad,
            this.Fechavacuna,
            this.Enfermedadvacunada});
            this.dataHistoriaClinica.Location = new System.Drawing.Point(140, 709);
            this.dataHistoriaClinica.Name = "dataHistoriaClinica";
            this.dataHistoriaClinica.RowHeadersWidth = 62;
            this.dataHistoriaClinica.RowTemplate.Height = 28;
            this.dataHistoriaClinica.Size = new System.Drawing.Size(1559, 219);
            this.dataHistoriaClinica.TabIndex = 80;
            this.dataHistoriaClinica.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataHistoriaClinica_CellContentClick);
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.MinimumWidth = 8;
            this.Codigo.Name = "Codigo";
            this.Codigo.Width = 150;
            // 
            // Codigomascota
            // 
            this.Codigomascota.HeaderText = "Codigo mascota";
            this.Codigomascota.MinimumWidth = 8;
            this.Codigomascota.Name = "Codigomascota";
            this.Codigomascota.Width = 150;
            // 
            // Enfermedadesanteriores
            // 
            this.Enfermedadesanteriores.HeaderText = "Enfermedades anteriores";
            this.Enfermedadesanteriores.MinimumWidth = 8;
            this.Enfermedadesanteriores.Name = "Enfermedadesanteriores";
            this.Enfermedadesanteriores.Width = 150;
            // 
            // Fechaenfermedad
            // 
            this.Fechaenfermedad.HeaderText = "Fecha enfermedad";
            this.Fechaenfermedad.MinimumWidth = 8;
            this.Fechaenfermedad.Name = "Fechaenfermedad";
            this.Fechaenfermedad.Width = 150;
            // 
            // Fechavacuna
            // 
            this.Fechavacuna.HeaderText = "Fecha vacuna";
            this.Fechavacuna.MinimumWidth = 8;
            this.Fechavacuna.Name = "Fechavacuna";
            this.Fechavacuna.Width = 150;
            // 
            // Enfermedadvacunada
            // 
            this.Enfermedadvacunada.HeaderText = "Enfermedad vacunada";
            this.Enfermedadvacunada.MinimumWidth = 8;
            this.Enfermedadvacunada.Name = "Enfermedadvacunada";
            this.Enfermedadvacunada.Width = 150;
            // 
            // btnelimarbd2
            // 
            this.btnelimarbd2.Location = new System.Drawing.Point(1102, 399);
            this.btnelimarbd2.Name = "btnelimarbd2";
            this.btnelimarbd2.Size = new System.Drawing.Size(101, 52);
            this.btnelimarbd2.TabIndex = 79;
            this.btnelimarbd2.Text = "Eliminar BD";
            this.btnelimarbd2.UseVisualStyleBackColor = true;
            this.btnelimarbd2.Click += new System.EventHandler(this.btnelimarbd2_Click);
            // 
            // txt_fechavacuna
            // 
            this.txt_fechavacuna.Location = new System.Drawing.Point(564, 434);
            this.txt_fechavacuna.Name = "txt_fechavacuna";
            this.txt_fechavacuna.Size = new System.Drawing.Size(176, 26);
            this.txt_fechavacuna.TabIndex = 78;
            // 
            // lblfechavacuna
            // 
            this.lblfechavacuna.AutoSize = true;
            this.lblfechavacuna.Location = new System.Drawing.Point(263, 431);
            this.lblfechavacuna.Name = "lblfechavacuna";
            this.lblfechavacuna.Size = new System.Drawing.Size(109, 20);
            this.lblfechavacuna.TabIndex = 77;
            this.lblfechavacuna.Text = "Fecha vacuna";
            // 
            // lblfechaenfermedad
            // 
            this.lblfechaenfermedad.AutoSize = true;
            this.lblfechaenfermedad.Location = new System.Drawing.Point(260, 379);
            this.lblfechaenfermedad.Name = "lblfechaenfermedad";
            this.lblfechaenfermedad.Size = new System.Drawing.Size(144, 20);
            this.lblfechaenfermedad.TabIndex = 76;
            this.lblfechaenfermedad.Text = "Fecha enfermedad";
            // 
            // lblenfermedadesanteriores
            // 
            this.lblenfermedadesanteriores.AutoSize = true;
            this.lblenfermedadesanteriores.Location = new System.Drawing.Point(260, 328);
            this.lblenfermedadesanteriores.Name = "lblenfermedadesanteriores";
            this.lblenfermedadesanteriores.Size = new System.Drawing.Size(189, 20);
            this.lblenfermedadesanteriores.TabIndex = 75;
            this.lblenfermedadesanteriores.Text = "Enfermedades anteriores";
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Location = new System.Drawing.Point(300, 179);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(84, 20);
            this.lbltitulo.TabIndex = 74;
            this.lbltitulo.Text = "Datos Cita";
            this.lbltitulo.Click += new System.EventHandler(this.lbltitulo_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(229, 595);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 20);
            this.label3.TabIndex = 73;
            this.label3.Text = "Registro seleccionado";
            // 
            // btn_eliminarregistro2
            // 
            this.btn_eliminarregistro2.Image = global::herramientas2personas.Properties.Resources.icons8_trash_50;
            this.btn_eliminarregistro2.Location = new System.Drawing.Point(1102, 300);
            this.btn_eliminarregistro2.Name = "btn_eliminarregistro2";
            this.btn_eliminarregistro2.Size = new System.Drawing.Size(115, 72);
            this.btn_eliminarregistro2.TabIndex = 72;
            this.btn_eliminarregistro2.UseVisualStyleBackColor = true;
            this.btn_eliminarregistro2.Click += new System.EventHandler(this.btn_eliminarregistro2_Click);
            // 
            // btn_crearregistro2
            // 
            this.btn_crearregistro2.Image = global::herramientas2personas.Properties.Resources.icons8_document_67;
            this.btn_crearregistro2.Location = new System.Drawing.Point(1102, 196);
            this.btn_crearregistro2.Name = "btn_crearregistro2";
            this.btn_crearregistro2.Size = new System.Drawing.Size(120, 82);
            this.btn_crearregistro2.TabIndex = 71;
            this.btn_crearregistro2.UseVisualStyleBackColor = true;
            this.btn_crearregistro2.Click += new System.EventHandler(this.btn_crearregistro2_Click);
            // 
            // lbl_codigomascota
            // 
            this.lbl_codigomascota.AutoSize = true;
            this.lbl_codigomascota.Location = new System.Drawing.Point(260, 285);
            this.lbl_codigomascota.Name = "lbl_codigomascota";
            this.lbl_codigomascota.Size = new System.Drawing.Size(124, 20);
            this.lbl_codigomascota.TabIndex = 70;
            this.lbl_codigomascota.Text = "Codigo mascota";
            // 
            // lbl_codigo
            // 
            this.lbl_codigo.AutoSize = true;
            this.lbl_codigo.Location = new System.Drawing.Point(260, 246);
            this.lbl_codigo.Name = "lbl_codigo";
            this.lbl_codigo.Size = new System.Drawing.Size(59, 20);
            this.lbl_codigo.TabIndex = 69;
            this.lbl_codigo.Text = "Codigo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(251, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 68;
            // 
            // txt_enfermedadesanteriores
            // 
            this.txt_enfermedadesanteriores.Location = new System.Drawing.Point(564, 328);
            this.txt_enfermedadesanteriores.Name = "txt_enfermedadesanteriores";
            this.txt_enfermedadesanteriores.Size = new System.Drawing.Size(176, 26);
            this.txt_enfermedadesanteriores.TabIndex = 87;
            this.txt_enfermedadesanteriores.TextChanged += new System.EventHandler(this.text_enfermedadesanteriores_TextChanged);
            // 
            // txt_fechaenfermedad
            // 
            this.txt_fechaenfermedad.Location = new System.Drawing.Point(564, 376);
            this.txt_fechaenfermedad.Name = "txt_fechaenfermedad";
            this.txt_fechaenfermedad.Size = new System.Drawing.Size(176, 26);
            this.txt_fechaenfermedad.TabIndex = 88;
            this.txt_fechaenfermedad.TextChanged += new System.EventHandler(this.txt_fechaenfermedad_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(564, 285);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(176, 28);
            this.comboBox1.TabIndex = 89;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Historialclinico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::herramientas2personas.Properties.Resources.R;
            this.ClientSize = new System.Drawing.Size(1857, 1050);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txt_fechaenfermedad);
            this.Controls.Add(this.txt_enfermedadesanteriores);
            this.Controls.Add(this.txt_enfermedadvacunada);
            this.Controls.Add(this.lblenfermedadvacunada);
            this.Controls.Add(this.txt_codigo);
            this.Controls.Add(this.dataHistoriaClinica);
            this.Controls.Add(this.btnelimarbd2);
            this.Controls.Add(this.txt_fechavacuna);
            this.Controls.Add(this.lblfechavacuna);
            this.Controls.Add(this.lblfechaenfermedad);
            this.Controls.Add(this.lblenfermedadesanteriores);
            this.Controls.Add(this.lbltitulo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_eliminarregistro2);
            this.Controls.Add(this.btn_crearregistro2);
            this.Controls.Add(this.lbl_codigomascota);
            this.Controls.Add(this.lbl_codigo);
            this.Controls.Add(this.label1);
            this.Name = "Historialclinico";
            this.Text = "Historialclinico";
            this.Load += new System.EventHandler(this.Historialclinico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataHistoriaClinica)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_enfermedadvacunada;
        private System.Windows.Forms.Label lblenfermedadvacunada;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.DataGridView dataHistoriaClinica;
        private System.Windows.Forms.Button btnelimarbd2;
        private System.Windows.Forms.TextBox txt_fechavacuna;
        private System.Windows.Forms.Label lblfechavacuna;
        private System.Windows.Forms.Label lblfechaenfermedad;
        private System.Windows.Forms.Label lblenfermedadesanteriores;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_eliminarregistro2;
        private System.Windows.Forms.Button btn_crearregistro2;
        private System.Windows.Forms.Label lbl_codigomascota;
        private System.Windows.Forms.Label lbl_codigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_enfermedadesanteriores;
        private System.Windows.Forms.TextBox txt_fechaenfermedad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigomascota;
        private System.Windows.Forms.DataGridViewTextBoxColumn Enfermedadesanteriores;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fechaenfermedad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fechavacuna;
        private System.Windows.Forms.DataGridViewTextBoxColumn Enfermedadvacunada;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}