
namespace SIG_Tickets
{
    partial class CrearSolicitudes
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
            if (disposing && (components != null)) {
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
            this.btnCrearTicket = new System.Windows.Forms.Button();
            this.BtnCancelarTicket = new System.Windows.Forms.Button();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CB_Categoria = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnCrearTicket
            // 
            this.btnCrearTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearTicket.Location = new System.Drawing.Point(16, 395);
            this.btnCrearTicket.Margin = new System.Windows.Forms.Padding(4);
            this.btnCrearTicket.Name = "btnCrearTicket";
            this.btnCrearTicket.Size = new System.Drawing.Size(189, 41);
            this.btnCrearTicket.TabIndex = 20;
            this.btnCrearTicket.Text = "Crear Solicitud";
            this.btnCrearTicket.UseVisualStyleBackColor = true;
            this.btnCrearTicket.Click += new System.EventHandler(this.btnCrearTicket_Click);
            // 
            // BtnCancelarTicket
            // 
            this.BtnCancelarTicket.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancelarTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelarTicket.Location = new System.Drawing.Point(285, 396);
            this.BtnCancelarTicket.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCancelarTicket.Name = "BtnCancelarTicket";
            this.BtnCancelarTicket.Size = new System.Drawing.Size(189, 41);
            this.BtnCancelarTicket.TabIndex = 21;
            this.BtnCancelarTicket.Text = "Cancelar";
            this.BtnCancelarTicket.UseVisualStyleBackColor = true;
            this.BtnCancelarTicket.Click += new System.EventHandler(this.BtnCancelarTicket_Click);
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(144, 95);
            this.txtTitulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(312, 22);
            this.txtTitulo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 98);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "Título";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 156);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "Descripcion";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(144, 153);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(312, 219);
            this.txtDescripcion.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 39);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 25;
            this.label3.Text = "Categoria";
            // 
            // CB_Categoria
            // 
            this.CB_Categoria.FormattingEnabled = true;
            this.CB_Categoria.Items.AddRange(new object[] {
            "Soporte a Usuarios",
            "Compra de Equipos",
            "Instalación de Programas"});
            this.CB_Categoria.Location = new System.Drawing.Point(144, 39);
            this.CB_Categoria.Margin = new System.Windows.Forms.Padding(4);
            this.CB_Categoria.Name = "CB_Categoria";
            this.CB_Categoria.Size = new System.Drawing.Size(312, 24);
            this.CB_Categoria.TabIndex = 1;
            this.CB_Categoria.SelectedIndexChanged += new System.EventHandler(this.CB_Categoria_SelectedIndexChanged);
            // 
            // CrearSolicitudes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 450);
            this.Controls.Add(this.CB_Categoria);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.BtnCancelarTicket);
            this.Controls.Add(this.btnCrearTicket);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CrearSolicitudes";
            this.Text = "Crea tu Solicitud";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnCrearTicket;
        private System.Windows.Forms.Button BtnCancelarTicket;
        public System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox CB_Categoria;
    }
}