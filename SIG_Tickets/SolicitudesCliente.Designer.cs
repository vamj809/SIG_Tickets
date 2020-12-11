
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tk_id_ticket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tk_asunto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tk_estado_ticket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TheStatusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MyTable)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TheStatusStrip
            // 
            this.TheStatusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.TheStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ClientNameLabel,
            this.TimeStampLabel});
            this.TheStatusStrip.Location = new System.Drawing.Point(0, 391);
            this.TheStatusStrip.Name = "TheStatusStrip";
            this.TheStatusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 13, 0);
            this.TheStatusStrip.Size = new System.Drawing.Size(749, 26);
            this.TheStatusStrip.TabIndex = 9;
            this.TheStatusStrip.Text = "statusStrip1";
            // 
            // ClientNameLabel
            // 
            this.ClientNameLabel.Name = "ClientNameLabel";
            this.ClientNameLabel.Size = new System.Drawing.Size(141, 20);
            this.ClientNameLabel.Text = "¡Bienvenido Cliente!";
            this.ClientNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TimeStampLabel
            // 
            this.TimeStampLabel.Name = "TimeStampLabel";
            this.TimeStampLabel.Size = new System.Drawing.Size(18, 20);
            this.TimeStampLabel.Text = "...";
            // 
            // btnCrearSolicitud
            // 
            this.btnCrearSolicitud.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearSolicitud.Location = new System.Drawing.Point(13, 14);
            this.btnCrearSolicitud.Margin = new System.Windows.Forms.Padding(4);
            this.btnCrearSolicitud.Name = "btnCrearSolicitud";
            this.btnCrearSolicitud.Size = new System.Drawing.Size(189, 41);
            this.btnCrearSolicitud.TabIndex = 10;
            this.btnCrearSolicitud.Text = "Crear Solicitud";
            this.btnCrearSolicitud.UseVisualStyleBackColor = true;
            this.btnCrearSolicitud.Click += new System.EventHandler(this.btnCrearSolicitud_Click);
            // 
            // BtnCerrarSesion
            // 
            this.BtnCerrarSesion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCerrarSesion.Location = new System.Drawing.Point(547, 13);
            this.BtnCerrarSesion.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCerrarSesion.Name = "BtnCerrarSesion";
            this.BtnCerrarSesion.Size = new System.Drawing.Size(189, 41);
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
            this.MyTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MyTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MyTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tk_id_ticket,
            this.tk_asunto,
            this.tk_estado_ticket});
            this.MyTable.Location = new System.Drawing.Point(0, 72);
            this.MyTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MyTable.MultiSelect = false;
            this.MyTable.Name = "MyTable";
            this.MyTable.ReadOnly = true;
            this.MyTable.RowHeadersWidth = 51;
            this.MyTable.RowTemplate.Height = 24;
            this.MyTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MyTable.Size = new System.Drawing.Size(749, 319);
            this.MyTable.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.btnCrearSolicitud);
            this.panel1.Controls.Add(this.BtnCerrarSesion);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(749, 68);
            this.panel1.TabIndex = 13;
            // 
            // tk_id_ticket
            // 
            this.tk_id_ticket.HeaderText = "ID Ticket";
            this.tk_id_ticket.MinimumWidth = 6;
            this.tk_id_ticket.Name = "tk_id_ticket";
            this.tk_id_ticket.ReadOnly = true;
            this.tk_id_ticket.Visible = false;
            this.tk_id_ticket.Width = 125;
            // 
            // tk_asunto
            // 
            this.tk_asunto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tk_asunto.HeaderText = "Solicitud";
            this.tk_asunto.MinimumWidth = 6;
            this.tk_asunto.Name = "tk_asunto";
            this.tk_asunto.ReadOnly = true;
            // 
            // tk_estado_ticket
            // 
            this.tk_estado_ticket.HeaderText = "Estado";
            this.tk_estado_ticket.MinimumWidth = 6;
            this.tk_estado_ticket.Name = "tk_estado_ticket";
            this.tk_estado_ticket.ReadOnly = true;
            this.tk_estado_ticket.Width = 125;
            // 
            // SolicitudesCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 417);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MyTable);
            this.Controls.Add(this.TheStatusStrip);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SolicitudesCliente";
            this.Text = "Mis Solicitudes";
            this.TheStatusStrip.ResumeLayout(false);
            this.TheStatusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MyTable)).EndInit();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tk_id_ticket;
        private System.Windows.Forms.DataGridViewTextBoxColumn tk_asunto;
        private System.Windows.Forms.DataGridViewTextBoxColumn tk_estado_ticket;
    }
}