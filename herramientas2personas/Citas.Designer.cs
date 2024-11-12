namespace herramientas2personas
{
    partial class Citas
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_sede = new System.Windows.Forms.TextBox();
            this.lblsede = new System.Windows.Forms.Label();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.dataCita = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigomascota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Documentousuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fechadecita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sede = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnelimarbd2 = new System.Windows.Forms.Button();
            this.txt_hora = new System.Windows.Forms.TextBox();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblfechacita = new System.Windows.Forms.Label();
            this.lbldocumentousuario = new System.Windows.Forms.Label();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_eliminarregistro2 = new System.Windows.Forms.Button();
            this.btn_crearregistro2 = new System.Windows.Forms.Button();
            this.lbl_codigomascota = new System.Windows.Forms.Label();
            this.lbl_codigo = new System.Windows.Forms.Label();
            this.comboBoxcodigo = new System.Windows.Forms.ComboBox();
            this.comboBoxdocumento = new System.Windows.Forms.ComboBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.btnsiguiente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataCita)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(228, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 1;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_sede
            // 
            this.txt_sede.Location = new System.Drawing.Point(541, 659);
            this.txt_sede.Name = "txt_sede";
            this.txt_sede.Size = new System.Drawing.Size(176, 26);
            this.txt_sede.TabIndex = 63;
            this.txt_sede.TextChanged += new System.EventHandler(this.txt_sede_TextChanged);
            // 
            // lblsede
            // 
            this.lblsede.AutoSize = true;
            this.lblsede.Location = new System.Drawing.Point(237, 659);
            this.lblsede.Name = "lblsede";
            this.lblsede.Size = new System.Drawing.Size(47, 20);
            this.lblsede.TabIndex = 62;
            this.lblsede.Text = "Sede";
            this.lblsede.Click += new System.EventHandler(this.lblsede_Click);
            // 
            // txt_codigo
            // 
            this.txt_codigo.Location = new System.Drawing.Point(541, 182);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(176, 26);
            this.txt_codigo.TabIndex = 61;
            this.txt_codigo.TextChanged += new System.EventHandler(this.txt_codigo_TextChanged);
            // 
            // dataCita
            // 
            this.dataCita.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCita.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Codigomascota,
            this.Documentousuario,
            this.Fechadecita,
            this.Hora,
            this.Sede});
            this.dataCita.Location = new System.Drawing.Point(172, 778);
            this.dataCita.Name = "dataCita";
            this.dataCita.RowHeadersWidth = 62;
            this.dataCita.RowTemplate.Height = 28;
            this.dataCita.Size = new System.Drawing.Size(1559, 219);
            this.dataCita.TabIndex = 60;
            this.dataCita.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataCita_CellContentClick);
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
            // Documentousuario
            // 
            this.Documentousuario.HeaderText = "Documento usuario";
            this.Documentousuario.MinimumWidth = 8;
            this.Documentousuario.Name = "Documentousuario";
            this.Documentousuario.Width = 150;
            // 
            // Fechadecita
            // 
            this.Fechadecita.HeaderText = "Fecha de cita";
            this.Fechadecita.MinimumWidth = 8;
            this.Fechadecita.Name = "Fechadecita";
            this.Fechadecita.Width = 150;
            // 
            // Hora
            // 
            this.Hora.HeaderText = "Hora";
            this.Hora.MinimumWidth = 8;
            this.Hora.Name = "Hora";
            this.Hora.Width = 150;
            // 
            // Sede
            // 
            this.Sede.HeaderText = "Sedes";
            this.Sede.MinimumWidth = 8;
            this.Sede.Name = "Sede";
            this.Sede.Width = 150;
            // 
            // btnelimarbd2
            // 
            this.btnelimarbd2.Location = new System.Drawing.Point(1079, 341);
            this.btnelimarbd2.Name = "btnelimarbd2";
            this.btnelimarbd2.Size = new System.Drawing.Size(101, 52);
            this.btnelimarbd2.TabIndex = 59;
            this.btnelimarbd2.Text = "Eliminar BD";
            this.btnelimarbd2.UseVisualStyleBackColor = true;
            this.btnelimarbd2.Click += new System.EventHandler(this.btnelimarbd2_Click);
            // 
            // txt_hora
            // 
            this.txt_hora.Location = new System.Drawing.Point(541, 618);
            this.txt_hora.Name = "txt_hora";
            this.txt_hora.Size = new System.Drawing.Size(176, 26);
            this.txt_hora.TabIndex = 57;
            this.txt_hora.TextChanged += new System.EventHandler(this.txt_hora_TextChanged);
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(237, 618);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(44, 20);
            this.lblHora.TabIndex = 56;
            this.lblHora.Text = "Hora";
            this.lblHora.Click += new System.EventHandler(this.lblHora_Click);
            // 
            // lblfechacita
            // 
            this.lblfechacita.AutoSize = true;
            this.lblfechacita.Location = new System.Drawing.Point(237, 341);
            this.lblfechacita.Name = "lblfechacita";
            this.lblfechacita.Size = new System.Drawing.Size(83, 20);
            this.lblfechacita.TabIndex = 54;
            this.lblfechacita.Text = "Fecha cita";
            this.lblfechacita.Click += new System.EventHandler(this.lblfechacita_Click);
            // 
            // lbldocumentousuario
            // 
            this.lbldocumentousuario.AutoSize = true;
            this.lbldocumentousuario.Location = new System.Drawing.Point(237, 270);
            this.lbldocumentousuario.Name = "lbldocumentousuario";
            this.lbldocumentousuario.Size = new System.Drawing.Size(148, 20);
            this.lbldocumentousuario.TabIndex = 52;
            this.lbldocumentousuario.Text = "Documento usuario";
            this.lbldocumentousuario.Click += new System.EventHandler(this.lblcolordepelo_Click);
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Location = new System.Drawing.Point(277, 121);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(84, 20);
            this.lbltitulo.TabIndex = 51;
            this.lbltitulo.Text = "Datos Cita";
            this.lbltitulo.Click += new System.EventHandler(this.lbltitulo_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(228, 709);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 20);
            this.label3.TabIndex = 50;
            this.label3.Text = "Registro seleccionado";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btn_eliminarregistro2
            // 
            this.btn_eliminarregistro2.Image = global::herramientas2personas.Properties.Resources.icons8_trash_50;
            this.btn_eliminarregistro2.Location = new System.Drawing.Point(1079, 242);
            this.btn_eliminarregistro2.Name = "btn_eliminarregistro2";
            this.btn_eliminarregistro2.Size = new System.Drawing.Size(115, 72);
            this.btn_eliminarregistro2.TabIndex = 49;
            this.btn_eliminarregistro2.UseVisualStyleBackColor = true;
            this.btn_eliminarregistro2.Click += new System.EventHandler(this.btn_eliminarregistro1_Click);
            // 
            // btn_crearregistro2
            // 
            this.btn_crearregistro2.Image = global::herramientas2personas.Properties.Resources.icons8_document_67;
            this.btn_crearregistro2.Location = new System.Drawing.Point(1079, 138);
            this.btn_crearregistro2.Name = "btn_crearregistro2";
            this.btn_crearregistro2.Size = new System.Drawing.Size(120, 82);
            this.btn_crearregistro2.TabIndex = 48;
            this.btn_crearregistro2.UseVisualStyleBackColor = true;
            this.btn_crearregistro2.Click += new System.EventHandler(this.btn_crearregistro2_Click);
            // 
            // lbl_codigomascota
            // 
            this.lbl_codigomascota.AutoSize = true;
            this.lbl_codigomascota.Location = new System.Drawing.Point(237, 227);
            this.lbl_codigomascota.Name = "lbl_codigomascota";
            this.lbl_codigomascota.Size = new System.Drawing.Size(124, 20);
            this.lbl_codigomascota.TabIndex = 46;
            this.lbl_codigomascota.Text = "Codigo mascota";
            this.lbl_codigomascota.Click += new System.EventHandler(this.lbl_codigomascota_Click);
            // 
            // lbl_codigo
            // 
            this.lbl_codigo.AutoSize = true;
            this.lbl_codigo.Location = new System.Drawing.Point(237, 188);
            this.lbl_codigo.Name = "lbl_codigo";
            this.lbl_codigo.Size = new System.Drawing.Size(59, 20);
            this.lbl_codigo.TabIndex = 45;
            this.lbl_codigo.Text = "Codigo";
            this.lbl_codigo.Click += new System.EventHandler(this.lbl_codigo_Click);
            // 
            // comboBoxcodigo
            // 
            this.comboBoxcodigo.FormattingEnabled = true;
            this.comboBoxcodigo.Location = new System.Drawing.Point(541, 219);
            this.comboBoxcodigo.Name = "comboBoxcodigo";
            this.comboBoxcodigo.Size = new System.Drawing.Size(176, 28);
            this.comboBoxcodigo.TabIndex = 64;
            this.comboBoxcodigo.SelectedIndexChanged += new System.EventHandler(this.comboBoxcodigo_SelectedIndexChanged);
            // 
            // comboBoxdocumento
            // 
            this.comboBoxdocumento.FormattingEnabled = true;
            this.comboBoxdocumento.Location = new System.Drawing.Point(541, 267);
            this.comboBoxdocumento.Name = "comboBoxdocumento";
            this.comboBoxdocumento.Size = new System.Drawing.Size(176, 28);
            this.comboBoxdocumento.TabIndex = 65;
            this.comboBoxdocumento.SelectedIndexChanged += new System.EventHandler(this.comboBoxdocuemnto_SelectedIndexChanged);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(541, 323);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // btnsiguiente
            // 
            this.btnsiguiente.Location = new System.Drawing.Point(1079, 631);
            this.btnsiguiente.Name = "btnsiguiente";
            this.btnsiguiente.Size = new System.Drawing.Size(120, 54);
            this.btnsiguiente.TabIndex = 66;
            this.btnsiguiente.Text = "Siguiente";
            this.btnsiguiente.UseVisualStyleBackColor = true;
            this.btnsiguiente.Click += new System.EventHandler(this.btnsiguiente_Click);
            // 
            // Citas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::herramientas2personas.Properties.Resources.R;
            this.ClientSize = new System.Drawing.Size(1920, 1050);
            this.Controls.Add(this.btnsiguiente);
            this.Controls.Add(this.comboBoxdocumento);
            this.Controls.Add(this.comboBoxcodigo);
            this.Controls.Add(this.txt_sede);
            this.Controls.Add(this.lblsede);
            this.Controls.Add(this.txt_codigo);
            this.Controls.Add(this.dataCita);
            this.Controls.Add(this.btnelimarbd2);
            this.Controls.Add(this.txt_hora);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblfechacita);
            this.Controls.Add(this.lbldocumentousuario);
            this.Controls.Add(this.lbltitulo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_eliminarregistro2);
            this.Controls.Add(this.btn_crearregistro2);
            this.Controls.Add(this.lbl_codigomascota);
            this.Controls.Add(this.lbl_codigo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.monthCalendar1);
            this.Name = "Citas";
            this.Text = "Citas";
            this.Load += new System.EventHandler(this.Citas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataCita)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_sede;
        private System.Windows.Forms.Label lblsede;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.DataGridView dataCita;
        private System.Windows.Forms.Button btnelimarbd2;
        private System.Windows.Forms.TextBox txt_hora;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblfechacita;
        private System.Windows.Forms.Label lbldocumentousuario;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_eliminarregistro2;
        private System.Windows.Forms.Button btn_crearregistro2;
        private System.Windows.Forms.Label lbl_codigomascota;
        private System.Windows.Forms.Label lbl_codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigomascota;
        private System.Windows.Forms.DataGridViewTextBoxColumn Documentousuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fechadecita;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sede;
        private System.Windows.Forms.ComboBox comboBoxcodigo;
        private System.Windows.Forms.ComboBox comboBoxdocumento;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button btnsiguiente;
    }
}