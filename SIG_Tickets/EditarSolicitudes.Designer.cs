namespace SIG_Tickets
{
    partial class EditarSolicitudes
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
            this.CbCategoria = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtTitulo = new System.Windows.Forms.TextBox();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.btnEditarSolicitud = new System.Windows.Forms.Button();
            this.CbEstado = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtFechaCreacion = new System.Windows.Forms.TextBox();
            this.msgDataGrid = new System.Windows.Forms.DataGridView();
            this.txtComentario = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.msgDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // CbCategoria
            // 
            this.CbCategoria.FormattingEnabled = true;
            this.CbCategoria.Items.AddRange(new object[] {
            "Soporte a Usuarios",
            "Compra de Equipos",
            "Instalación de Programas"});
            this.CbCategoria.Location = new System.Drawing.Point(135, 20);
            this.CbCategoria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CbCategoria.Name = "CbCategoria";
            this.CbCategoria.Size = new System.Drawing.Size(312, 24);
            this.CbCategoria.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 33;
            this.label3.Text = "Categoria";
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.Enabled = false;
            this.TxtDescripcion.Location = new System.Drawing.Point(135, 111);
            this.TxtDescripcion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtDescripcion.Multiline = true;
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.ReadOnly = true;
            this.TxtDescripcion.Size = new System.Drawing.Size(312, 219);
            this.TxtDescripcion.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 115);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 32;
            this.label2.Text = "Descripcion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 31;
            this.label1.Text = "Título";
            // 
            // TxtTitulo
            // 
            this.TxtTitulo.Enabled = false;
            this.TxtTitulo.Location = new System.Drawing.Point(135, 63);
            this.TxtTitulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtTitulo.Name = "TxtTitulo";
            this.TxtTitulo.ReadOnly = true;
            this.TxtTitulo.Size = new System.Drawing.Size(312, 22);
            this.TxtTitulo.TabIndex = 27;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Location = new System.Drawing.Point(687, 406);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(189, 41);
            this.BtnCancelar.TabIndex = 30;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // btnEditarSolicitud
            // 
            this.btnEditarSolicitud.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEditarSolicitud.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarSolicitud.Location = new System.Drawing.Point(16, 406);
            this.btnEditarSolicitud.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEditarSolicitud.Name = "btnEditarSolicitud";
            this.btnEditarSolicitud.Size = new System.Drawing.Size(189, 41);
            this.btnEditarSolicitud.TabIndex = 29;
            this.btnEditarSolicitud.Text = "Enviar Comentario";
            this.btnEditarSolicitud.UseVisualStyleBackColor = true;
            this.btnEditarSolicitud.Click += new System.EventHandler(this.btnEditarSolicitud_Click);
            // 
            // CbEstado
            // 
            this.CbEstado.FormattingEnabled = true;
            this.CbEstado.Items.AddRange(new object[] {
            "Abierto",
            "Cerrado",
            "Inactivo"});
            this.CbEstado.Location = new System.Drawing.Point(563, 20);
            this.CbEstado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CbEstado.Name = "CbEstado";
            this.CbEstado.Size = new System.Drawing.Size(312, 24);
            this.CbEstado.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(501, 23);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 35;
            this.label4.Text = "Estado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 366);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 17);
            this.label5.TabIndex = 36;
            this.label5.Text = "Fecha Creación";
            // 
            // TxtFechaCreacion
            // 
            this.TxtFechaCreacion.Enabled = false;
            this.TxtFechaCreacion.Location = new System.Drawing.Point(135, 366);
            this.TxtFechaCreacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtFechaCreacion.Name = "TxtFechaCreacion";
            this.TxtFechaCreacion.ReadOnly = true;
            this.TxtFechaCreacion.Size = new System.Drawing.Size(312, 22);
            this.TxtFechaCreacion.TabIndex = 37;
            // 
            // msgDataGrid
            // 
            this.msgDataGrid.AllowUserToDeleteRows = false;
            this.msgDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.msgDataGrid.Location = new System.Drawing.Point(504, 63);
            this.msgDataGrid.Name = "msgDataGrid";
            this.msgDataGrid.ReadOnly = true;
            this.msgDataGrid.RowHeadersWidth = 51;
            this.msgDataGrid.RowTemplate.Height = 24;
            this.msgDataGrid.Size = new System.Drawing.Size(371, 174);
            this.msgDataGrid.TabIndex = 38;
            // 
            // txtComentario
            // 
            this.txtComentario.Enabled = false;
            this.txtComentario.Location = new System.Drawing.Point(504, 270);
            this.txtComentario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtComentario.Multiline = true;
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(371, 118);
            this.txtComentario.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(501, 251);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 17);
            this.label6.TabIndex = 40;
            this.label6.Text = "Nuevo Comentario: *";
            // 
            // EditarSolicitudes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 462);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtComentario);
            this.Controls.Add(this.msgDataGrid);
            this.Controls.Add(this.TxtFechaCreacion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CbEstado);
            this.Controls.Add(this.CbCategoria);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtDescripcion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtTitulo);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.btnEditarSolicitud);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "EditarSolicitudes";
            this.Text = "EditarSolicitudes";
            ((System.ComponentModel.ISupportInitialize)(this.msgDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CbCategoria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtTitulo;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button btnEditarSolicitud;
        private System.Windows.Forms.ComboBox CbEstado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtFechaCreacion;
        private System.Windows.Forms.DataGridView msgDataGrid;
        private System.Windows.Forms.TextBox txtComentario;
        private System.Windows.Forms.Label label6;
    }
}