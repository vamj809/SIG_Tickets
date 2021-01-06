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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comentario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtComentario = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtSolicitante = new System.Windows.Forms.TextBox();
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
            this.CbCategoria.Location = new System.Drawing.Point(101, 16);
            this.CbCategoria.Name = "CbCategoria";
            this.CbCategoria.Size = new System.Drawing.Size(235, 21);
            this.CbCategoria.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Categoria";
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.Enabled = false;
            this.TxtDescripcion.Location = new System.Drawing.Point(101, 82);
            this.TxtDescripcion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtDescripcion.Multiline = true;
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.ReadOnly = true;
            this.TxtDescripcion.Size = new System.Drawing.Size(235, 179);
            this.TxtDescripcion.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Descripcion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Título";
            // 
            // TxtTitulo
            // 
            this.TxtTitulo.Enabled = false;
            this.TxtTitulo.Location = new System.Drawing.Point(101, 51);
            this.TxtTitulo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtTitulo.Name = "TxtTitulo";
            this.TxtTitulo.ReadOnly = true;
            this.TxtTitulo.Size = new System.Drawing.Size(235, 20);
            this.TxtTitulo.TabIndex = 27;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Location = new System.Drawing.Point(515, 330);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(142, 33);
            this.BtnCancelar.TabIndex = 30;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // btnEditarSolicitud
            // 
            this.btnEditarSolicitud.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEditarSolicitud.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarSolicitud.Location = new System.Drawing.Point(12, 330);
            this.btnEditarSolicitud.Name = "btnEditarSolicitud";
            this.btnEditarSolicitud.Size = new System.Drawing.Size(142, 33);
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
            this.CbEstado.Location = new System.Drawing.Point(422, 16);
            this.CbEstado.Name = "CbEstado";
            this.CbEstado.Size = new System.Drawing.Size(235, 21);
            this.CbEstado.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(376, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Estado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Fecha Creación";
            // 
            // TxtFechaCreacion
            // 
            this.TxtFechaCreacion.Enabled = false;
            this.TxtFechaCreacion.Location = new System.Drawing.Point(101, 297);
            this.TxtFechaCreacion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtFechaCreacion.Name = "TxtFechaCreacion";
            this.TxtFechaCreacion.ReadOnly = true;
            this.TxtFechaCreacion.Size = new System.Drawing.Size(235, 20);
            this.TxtFechaCreacion.TabIndex = 37;
            // 
            // msgDataGrid
            // 
            this.msgDataGrid.AllowUserToAddRows = false;
            this.msgDataGrid.AllowUserToDeleteRows = false;
            this.msgDataGrid.AllowUserToResizeColumns = false;
            this.msgDataGrid.AllowUserToResizeRows = false;
            this.msgDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.msgDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Usuario,
            this.Comentario});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.msgDataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.msgDataGrid.Location = new System.Drawing.Point(378, 51);
            this.msgDataGrid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.msgDataGrid.MultiSelect = false;
            this.msgDataGrid.Name = "msgDataGrid";
            this.msgDataGrid.ReadOnly = true;
            this.msgDataGrid.RowHeadersWidth = 10;
            this.msgDataGrid.RowTemplate.Height = 48;
            this.msgDataGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.msgDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.msgDataGrid.ShowCellErrors = false;
            this.msgDataGrid.ShowCellToolTips = false;
            this.msgDataGrid.ShowEditingIcon = false;
            this.msgDataGrid.ShowRowErrors = false;
            this.msgDataGrid.Size = new System.Drawing.Size(278, 141);
            this.msgDataGrid.TabIndex = 38;
            // 
            // Usuario
            // 
            this.Usuario.HeaderText = "Usuario";
            this.Usuario.MinimumWidth = 6;
            this.Usuario.Name = "Usuario";
            this.Usuario.ReadOnly = true;
            this.Usuario.Width = 75;
            // 
            // Comentario
            // 
            this.Comentario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Comentario.HeaderText = "Comentario";
            this.Comentario.MinimumWidth = 6;
            this.Comentario.Name = "Comentario";
            this.Comentario.ReadOnly = true;
            // 
            // txtComentario
            // 
            this.txtComentario.Location = new System.Drawing.Point(378, 219);
            this.txtComentario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtComentario.Multiline = true;
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(279, 97);
            this.txtComentario.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(376, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 13);
            this.label6.TabIndex = 40;
            this.label6.Text = "Nuevo Comentario: *";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 272);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 42;
            this.label7.Text = "Solicitante";
            // 
            // TxtSolicitante
            // 
            this.TxtSolicitante.Enabled = false;
            this.TxtSolicitante.Location = new System.Drawing.Point(101, 269);
            this.TxtSolicitante.Margin = new System.Windows.Forms.Padding(2);
            this.TxtSolicitante.Name = "TxtSolicitante";
            this.TxtSolicitante.ReadOnly = true;
            this.TxtSolicitante.Size = new System.Drawing.Size(235, 20);
            this.TxtSolicitante.TabIndex = 41;
            // 
            // EditarSolicitudes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 375);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtSolicitante);
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
            this.Name = "EditarSolicitudes";
            this.Text = "Editar Solicitud";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comentario;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtSolicitante;
    }
}