using System.Windows.Forms;

namespace herramientas2personas
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
            this.lbl_documento = new System.Windows.Forms.Label();
            this.lbl_nombres = new System.Windows.Forms.Label();
            this.txt_documento = new System.Windows.Forms.TextBox();
            this.txt_nombres = new System.Windows.Forms.TextBox();
            this.dataPersonas = new System.Windows.Forms.DataGridView();
            this.Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_eliminarregistro = new System.Windows.Forms.Button();
            this.btn_crearregistro = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblapellidos = new System.Windows.Forms.Label();
            this.txt_apellidos = new System.Windows.Forms.TextBox();
            this.lbltelefono = new System.Windows.Forms.Label();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.lbldireccion = new System.Windows.Forms.Label();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.btnelimarbd = new System.Windows.Forms.Button();
            this.btnsiguiente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataPersonas)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_documento
            // 
            this.lbl_documento.AutoSize = true;
            this.lbl_documento.Location = new System.Drawing.Point(243, 246);
            this.lbl_documento.Name = "lbl_documento";
            this.lbl_documento.Size = new System.Drawing.Size(92, 20);
            this.lbl_documento.TabIndex = 0;
            this.lbl_documento.Text = "Documento";
            this.lbl_documento.Click += new System.EventHandler(this.lbl_documento_Click);
            // 
            // lbl_nombres
            // 
            this.lbl_nombres.AutoSize = true;
            this.lbl_nombres.Location = new System.Drawing.Point(243, 285);
            this.lbl_nombres.Name = "lbl_nombres";
            this.lbl_nombres.Size = new System.Drawing.Size(73, 20);
            this.lbl_nombres.TabIndex = 1;
            this.lbl_nombres.Text = "Nombres";
            this.lbl_nombres.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_documento
            // 
            this.txt_documento.Location = new System.Drawing.Point(417, 240);
            this.txt_documento.Name = "txt_documento";
            this.txt_documento.Size = new System.Drawing.Size(176, 26);
            this.txt_documento.TabIndex = 2;
            this.txt_documento.TextChanged += new System.EventHandler(this.txt_documento_TextChanged);
            // 
            // txt_nombres
            // 
            this.txt_nombres.Location = new System.Drawing.Point(417, 285);
            this.txt_nombres.Name = "txt_nombres";
            this.txt_nombres.Size = new System.Drawing.Size(176, 26);
            this.txt_nombres.TabIndex = 3;
            this.txt_nombres.TextChanged += new System.EventHandler(this.txt_nombres_TextChanged);
            // 
            // dataPersonas
            // 
            this.dataPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPersonas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Documento,
            this.Nombres,
            this.Apellidos,
            this.Telefono,
            this.Direccion});
            this.dataPersonas.Location = new System.Drawing.Point(233, 603);
            this.dataPersonas.Name = "dataPersonas";
            this.dataPersonas.RowHeadersWidth = 62;
            this.dataPersonas.RowTemplate.Height = 28;
            this.dataPersonas.Size = new System.Drawing.Size(1229, 196);
            this.dataPersonas.TabIndex = 6;
            this.dataPersonas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataPersonas_CellContentClick);
            // 
            // Documento
            // 
            this.Documento.HeaderText = "Documento";
            this.Documento.MinimumWidth = 8;
            this.Documento.Name = "Documento";
            this.Documento.Width = 150;
            // 
            // Nombres
            // 
            this.Nombres.HeaderText = "Nombres";
            this.Nombres.MinimumWidth = 8;
            this.Nombres.Name = "Nombres";
            this.Nombres.Width = 150;
            // 
            // Apellidos
            // 
            this.Apellidos.HeaderText = "Apellidos";
            this.Apellidos.MinimumWidth = 8;
            this.Apellidos.Name = "Apellidos";
            this.Apellidos.Width = 150;
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.MinimumWidth = 8;
            this.Telefono.Name = "Telefono";
            this.Telefono.Width = 150;
            // 
            // Direccion
            // 
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.MinimumWidth = 8;
            this.Direccion.Name = "Direccion";
            this.Direccion.Width = 150;
            // 
            // btn_eliminarregistro
            // 
            this.btn_eliminarregistro.Image = global::herramientas2personas.Properties.Resources.icons8_trash_50;
            this.btn_eliminarregistro.Location = new System.Drawing.Point(1094, 285);
            this.btn_eliminarregistro.Name = "btn_eliminarregistro";
            this.btn_eliminarregistro.Size = new System.Drawing.Size(115, 72);
            this.btn_eliminarregistro.TabIndex = 5;
            this.btn_eliminarregistro.UseVisualStyleBackColor = true;
            this.btn_eliminarregistro.Click += new System.EventHandler(this.btn_eliminarregistro_Click);
            // 
            // btn_crearregistro
            // 
            this.btn_crearregistro.Image = global::herramientas2personas.Properties.Resources.icons8_document_67;
            this.btn_crearregistro.Location = new System.Drawing.Point(1094, 181);
            this.btn_crearregistro.Name = "btn_crearregistro";
            this.btn_crearregistro.Size = new System.Drawing.Size(120, 82);
            this.btn_crearregistro.TabIndex = 4;
            this.btn_crearregistro.UseVisualStyleBackColor = true;
            this.btn_crearregistro.Click += new System.EventHandler(this.btn_crearregistro_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(243, 536);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Registro seleccionado";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(245, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Datos Usuario Cliente";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblapellidos
            // 
            this.lblapellidos.AutoSize = true;
            this.lblapellidos.Location = new System.Drawing.Point(243, 328);
            this.lblapellidos.Name = "lblapellidos";
            this.lblapellidos.Size = new System.Drawing.Size(73, 20);
            this.lblapellidos.TabIndex = 10;
            this.lblapellidos.Text = "Apellidos";
            // 
            // txt_apellidos
            // 
            this.txt_apellidos.Location = new System.Drawing.Point(417, 328);
            this.txt_apellidos.Name = "txt_apellidos";
            this.txt_apellidos.Size = new System.Drawing.Size(176, 26);
            this.txt_apellidos.TabIndex = 11;
            // 
            // lbltelefono
            // 
            this.lbltelefono.AutoSize = true;
            this.lbltelefono.Location = new System.Drawing.Point(243, 371);
            this.lbltelefono.Name = "lbltelefono";
            this.lbltelefono.Size = new System.Drawing.Size(71, 20);
            this.lbltelefono.TabIndex = 12;
            this.lbltelefono.Text = "Telefono";
            // 
            // txt_telefono
            // 
            this.txt_telefono.Location = new System.Drawing.Point(417, 368);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(176, 26);
            this.txt_telefono.TabIndex = 13;
            // 
            // lbldireccion
            // 
            this.lbldireccion.AutoSize = true;
            this.lbldireccion.Location = new System.Drawing.Point(243, 415);
            this.lbldireccion.Name = "lbldireccion";
            this.lbldireccion.Size = new System.Drawing.Size(75, 20);
            this.lbldireccion.TabIndex = 14;
            this.lbldireccion.Text = "Direccion";
            // 
            // txt_direccion
            // 
            this.txt_direccion.Location = new System.Drawing.Point(417, 412);
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(176, 26);
            this.txt_direccion.TabIndex = 15;
            // 
            // btnelimarbd
            // 
            this.btnelimarbd.Location = new System.Drawing.Point(1094, 384);
            this.btnelimarbd.Name = "btnelimarbd";
            this.btnelimarbd.Size = new System.Drawing.Size(101, 52);
            this.btnelimarbd.TabIndex = 19;
            this.btnelimarbd.Text = "Eliminar BD";
            this.btnelimarbd.UseVisualStyleBackColor = true;
            this.btnelimarbd.Click += new System.EventHandler(this.btnelimarbd_Click);
            // 
            // btnsiguiente
            // 
            this.btnsiguiente.Location = new System.Drawing.Point(1342, 843);
            this.btnsiguiente.Name = "btnsiguiente";
            this.btnsiguiente.Size = new System.Drawing.Size(120, 54);
            this.btnsiguiente.TabIndex = 20;
            this.btnsiguiente.Text = "Siguiente";
            this.btnsiguiente.UseVisualStyleBackColor = true;
            this.btnsiguiente.Click += new System.EventHandler(this.btnsiguiente_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::herramientas2personas.Properties.Resources.R;
            this.ClientSize = new System.Drawing.Size(1875, 948);
            this.Controls.Add(this.btnsiguiente);
            this.Controls.Add(this.btnelimarbd);
            this.Controls.Add(this.txt_direccion);
            this.Controls.Add(this.lbldireccion);
            this.Controls.Add(this.txt_telefono);
            this.Controls.Add(this.lbltelefono);
            this.Controls.Add(this.txt_apellidos);
            this.Controls.Add(this.lblapellidos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataPersonas);
            this.Controls.Add(this.btn_eliminarregistro);
            this.Controls.Add(this.btn_crearregistro);
            this.Controls.Add(this.txt_nombres);
            this.Controls.Add(this.txt_documento);
            this.Controls.Add(this.lbl_nombres);
            this.Controls.Add(this.lbl_documento);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataPersonas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_documento;
        private System.Windows.Forms.Label lbl_nombres;
        private System.Windows.Forms.TextBox txt_documento;
        private System.Windows.Forms.TextBox txt_nombres;
        private System.Windows.Forms.Button btn_crearregistro;
        private System.Windows.Forms.Button btn_eliminarregistro;
        private System.Windows.Forms.DataGridView dataPersonas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombres;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblapellidos;
        private System.Windows.Forms.TextBox txt_apellidos;
        private System.Windows.Forms.Label lbltelefono;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.Label lbldireccion;
        private System.Windows.Forms.TextBox txt_direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.Button btnelimarbd;
        private System.Windows.Forms.Button btnsiguiente;
    }
}

