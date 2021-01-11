
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
            this.btnCrearTicket.Location = new System.Drawing.Point(12, 321);
            this.btnCrearTicket.Name = "btnCrearTicket";
            this.btnCrearTicket.Size = new System.Drawing.Size(142, 33);
            this.btnCrearTicket.TabIndex = 20;
            this.btnCrearTicket.Text = "Crear Solicitud";
            this.btnCrearTicket.UseVisualStyleBackColor = true;
            this.btnCrearTicket.Click += new System.EventHandler(this.btnCrearTicket_Click);
            // 
            // BtnCancelarTicket
            // 
            this.BtnCancelarTicket.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancelarTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelarTicket.Location = new System.Drawing.Point(214, 322);
            this.BtnCancelarTicket.Name = "BtnCancelarTicket";
            this.BtnCancelarTicket.Size = new System.Drawing.Size(142, 33);
            this.BtnCancelarTicket.TabIndex = 21;
            this.BtnCancelarTicket.Text = "Cancelar";
            this.BtnCancelarTicket.UseVisualStyleBackColor = true;
            this.BtnCancelarTicket.Click += new System.EventHandler(this.BtnCancelarTicket_Click);
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(108, 77);
            this.txtTitulo.Margin = new System.Windows.Forms.Padding(2);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(235, 20);
            this.txtTitulo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Título";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Descripcion";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(108, 124);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(235, 179);
            this.txtDescripcion.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
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
            this.CB_Categoria.Location = new System.Drawing.Point(108, 32);
            this.CB_Categoria.Name = "CB_Categoria";
            this.CB_Categoria.Size = new System.Drawing.Size(235, 21);
            this.CB_Categoria.TabIndex = 1;
            // 
            // CrearSolicitudes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 366);
            this.Controls.Add(this.CB_Categoria);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.BtnCancelarTicket);
            this.Controls.Add(this.btnCrearTicket);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CrearSolicitudes";
            this.Text = "Crea tu Solicitud";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCrearTicket;
        private System.Windows.Forms.Button BtnCancelarTicket;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CB_Categoria;
    }
}