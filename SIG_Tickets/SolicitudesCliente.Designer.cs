
namespace SIG_Tickets
{
    partial class SolicitudesCliente
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
            this.components = new System.ComponentModel.Container();
            this.TheStatusStrip = new System.Windows.Forms.StatusStrip();
            this.ClientNameLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.TimeStampLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnCrearSolicitud = new System.Windows.Forms.Button();
            this.BtnCerrarSesion = new System.Windows.Forms.Button();
            this.TimeStamp_Timer = new System.Windows.Forms.Timer(this.components);
            this.MyTable = new System.Windows.Forms.DataGridView();
            this.TheBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.TheStatusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MyTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TheBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TheStatusStrip
            // 
            this.TheStatusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.TheStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ClientNameLabel,
            this.TimeStampLabel});
            this.TheStatusStrip.Location = new System.Drawing.Point(0, 282);
            this.TheStatusStrip.Name = "TheStatusStrip";
            this.TheStatusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.TheStatusStrip.Size = new System.Drawing.Size(628, 22);
            this.TheStatusStrip.TabIndex = 9;
            this.TheStatusStrip.Text = "statusStrip1";
            // 
            // ClientNameLabel
            // 
            this.ClientNameLabel.Name = "ClientNameLabel";
            this.ClientNameLabel.Size = new System.Drawing.Size(112, 17);
            this.ClientNameLabel.Text = "¡Bienvenido Cliente!";
            this.ClientNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TimeStampLabel
            // 
            this.TimeStampLabel.Name = "TimeStampLabel";
            this.TimeStampLabel.Size = new System.Drawing.Size(16, 17);
            this.TimeStampLabel.Text = "...";
            // 
            // btnCrearSolicitud
            // 
            this.btnCrearSolicitud.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearSolicitud.Location = new System.Drawing.Point(10, 11);
            this.btnCrearSolicitud.Name = "btnCrearSolicitud";
            this.btnCrearSolicitud.Size = new System.Drawing.Size(142, 33);
            this.btnCrearSolicitud.TabIndex = 10;
            this.btnCrearSolicitud.Text = "Crear Solicitud";
            this.btnCrearSolicitud.UseVisualStyleBackColor = true;
            this.btnCrearSolicitud.Click += new System.EventHandler(this.btnCrearSolicitud_Click);
            // 
            // BtnCerrarSesion
            // 
            this.BtnCerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCerrarSesion.Location = new System.Drawing.Point(468, 11);
            this.BtnCerrarSesion.Name = "BtnCerrarSesion";
            this.BtnCerrarSesion.Size = new System.Drawing.Size(142, 33);
            this.BtnCerrarSesion.TabIndex = 11;
            this.BtnCerrarSesion.Text = "Cerrar Sesión";
            this.BtnCerrarSesion.UseVisualStyleBackColor = true;
            this.BtnCerrarSesion.Click += new System.EventHandler(this.BtnCerrarSesion_Click);
            // 
            // TimeStamp_Timer
            // 
            this.TimeStamp_Timer.Enabled = true;
            this.TimeStamp_Timer.Interval = 1000;
            this.TimeStamp_Timer.Tick += new System.EventHandler(this.TimeStamp_Timer_Tick);
            // 
            // MyTable
            // 
            this.MyTable.AllowUserToAddRows = false;
            this.MyTable.AllowUserToDeleteRows = false;
            this.MyTable.AllowUserToOrderColumns = true;
            this.MyTable.AutoGenerateColumns = false;
            this.MyTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MyTable.DataSource = this.TheBindingSource;
            this.MyTable.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MyTable.Location = new System.Drawing.Point(0, 58);
            this.MyTable.Margin = new System.Windows.Forms.Padding(2);
            this.MyTable.Name = "MyTable";
            this.MyTable.ReadOnly = true;
            this.MyTable.RowHeadersWidth = 51;
            this.MyTable.RowTemplate.Height = 24;
            this.MyTable.Size = new System.Drawing.Size(628, 224);
            this.MyTable.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCrearSolicitud);
            this.panel1.Controls.Add(this.BtnCerrarSesion);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(628, 54);
            this.panel1.TabIndex = 13;
            // 
            // SolicitudesCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 304);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MyTable);
            this.Controls.Add(this.TheStatusStrip);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SolicitudesCliente";
            this.Text = "Mis Solicitudes";
            this.TheStatusStrip.ResumeLayout(false);
            this.TheStatusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MyTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TheBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip TheStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel ClientNameLabel;
        private System.Windows.Forms.ToolStripStatusLabel TimeStampLabel;
        private System.Windows.Forms.Button btnCrearSolicitud;
        private System.Windows.Forms.Button BtnCerrarSesion;
        private System.Windows.Forms.Timer TimeStamp_Timer;
        private System.Windows.Forms.DataGridView MyTable;
        private System.Windows.Forms.BindingSource TheBindingSource;
        private System.Windows.Forms.Panel panel1;
    }
}