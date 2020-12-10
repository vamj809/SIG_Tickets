
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
            this.btnCrearSolicitud = new System.Windows.Forms.Button();
            this.BtnCerrarSesion = new System.Windows.Forms.Button();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.TimeStampLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.TimeStamp_Timer = new System.Windows.Forms.Timer(this.components);
            this.MyTable = new System.Windows.Forms.DataGridView();
            this.TheStatusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MyTable)).BeginInit();
            this.SuspendLayout();
            // 
            // TheStatusStrip
            // 
            this.TheStatusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.TheStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ClientNameLabel,
            this.toolStripStatusLabel1,
            this.TimeStampLabel});
            this.TheStatusStrip.Location = new System.Drawing.Point(0, 375);
            this.TheStatusStrip.Name = "TheStatusStrip";
            this.TheStatusStrip.Size = new System.Drawing.Size(827, 26);
            this.TheStatusStrip.TabIndex = 9;
            this.TheStatusStrip.Text = "statusStrip1";
            // 
            // ClientNameLabel
            // 
            this.ClientNameLabel.Name = "ClientNameLabel";
            this.ClientNameLabel.Size = new System.Drawing.Size(141, 20);
            this.ClientNameLabel.Text = "¡Bienvenido Cliente!";
            // 
            // btnCrearSolicitud
            // 
            this.btnCrearSolicitud.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearSolicitud.Location = new System.Drawing.Point(13, 13);
            this.btnCrearSolicitud.Margin = new System.Windows.Forms.Padding(4);
            this.btnCrearSolicitud.Name = "btnCrearSolicitud";
            this.btnCrearSolicitud.Size = new System.Drawing.Size(190, 41);
            this.btnCrearSolicitud.TabIndex = 10;
            this.btnCrearSolicitud.Text = "Crear Solicitud";
            this.btnCrearSolicitud.UseVisualStyleBackColor = true;
            // 
            // BtnCerrarSesion
            // 
            this.BtnCerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCerrarSesion.Location = new System.Drawing.Point(624, 13);
            this.BtnCerrarSesion.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCerrarSesion.Name = "BtnCerrarSesion";
            this.BtnCerrarSesion.Size = new System.Drawing.Size(190, 41);
            this.BtnCerrarSesion.TabIndex = 11;
            this.BtnCerrarSesion.Text = "Cerrar Sesión";
            this.BtnCerrarSesion.UseVisualStyleBackColor = true;
            this.BtnCerrarSesion.Click += new System.EventHandler(this.BtnCerrarSesion_Click);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(516, 20);
            this.toolStripStatusLabel1.Spring = true;
            this.toolStripStatusLabel1.Text = " ";
            // 
            // TimeStampLabel
            // 
            this.TimeStampLabel.Name = "TimeStampLabel";
            this.TimeStampLabel.Size = new System.Drawing.Size(155, 20);
            this.TimeStampLabel.Text = "10/12/2020 12:51 a.m.";
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
            this.MyTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MyTable.Location = new System.Drawing.Point(13, 77);
            this.MyTable.Name = "MyTable";
            this.MyTable.ReadOnly = true;
            this.MyTable.RowHeadersWidth = 51;
            this.MyTable.RowTemplate.Height = 24;
            this.MyTable.Size = new System.Drawing.Size(801, 283);
            this.MyTable.TabIndex = 12;
            // 
            // SolicitudesCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 401);
            this.Controls.Add(this.MyTable);
            this.Controls.Add(this.BtnCerrarSesion);
            this.Controls.Add(this.btnCrearSolicitud);
            this.Controls.Add(this.TheStatusStrip);
            this.Name = "SolicitudesCliente";
            this.Text = "Mis Solicitudes";
            this.TheStatusStrip.ResumeLayout(false);
            this.TheStatusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MyTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip TheStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel ClientNameLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel TimeStampLabel;
        private System.Windows.Forms.Button btnCrearSolicitud;
        private System.Windows.Forms.Button BtnCerrarSesion;
        private System.Windows.Forms.Timer TimeStamp_Timer;
        private System.Windows.Forms.DataGridView MyTable;
    }
}