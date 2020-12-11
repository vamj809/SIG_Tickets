
namespace SIG_Tickets
{
    partial class GestionSolicitudes
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
            this.TimeStamp_Timer = new System.Windows.Forms.Timer(this.components);
            this.TheStatusStrip = new System.Windows.Forms.StatusStrip();
            this.AgentNameLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.TimeStampLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.BtnCerrarSesion = new System.Windows.Forms.Button();
            this.btnEditarSolicitud = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MyTable = new System.Windows.Forms.DataGridView();
            this.TheStatusStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MyTable)).BeginInit();
            this.SuspendLayout();
            // 
            // TimeStamp_Timer
            // 
            this.TimeStamp_Timer.Enabled = true;
            this.TimeStamp_Timer.Interval = 1000;
            this.TimeStamp_Timer.Tick += new System.EventHandler(this.TimeStamp_Timer_Tick);
            // 
            // TheStatusStrip
            // 
            this.TheStatusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.TheStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AgentNameLabel,
            this.TimeStampLabel});
            this.TheStatusStrip.Location = new System.Drawing.Point(0, 344);
            this.TheStatusStrip.Name = "TheStatusStrip";
            this.TheStatusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.TheStatusStrip.Size = new System.Drawing.Size(600, 22);
            this.TheStatusStrip.TabIndex = 10;
            this.TheStatusStrip.Text = "statusStrip1";
            // 
            // AgentNameLabel
            // 
            this.AgentNameLabel.Name = "AgentNameLabel";
            this.AgentNameLabel.Size = new System.Drawing.Size(115, 17);
            this.AgentNameLabel.Text = "¡Bienvenido Técnico!";
            // 
            // TimeStampLabel
            // 
            this.TimeStampLabel.Name = "TimeStampLabel";
            this.TimeStampLabel.Size = new System.Drawing.Size(16, 17);
            this.TimeStampLabel.Text = "...";
            // 
            // BtnCerrarSesion
            // 
            this.BtnCerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCerrarSesion.Location = new System.Drawing.Point(446, 11);
            this.BtnCerrarSesion.Name = "BtnCerrarSesion";
            this.BtnCerrarSesion.Size = new System.Drawing.Size(142, 33);
            this.BtnCerrarSesion.TabIndex = 11;
            this.BtnCerrarSesion.Text = "Cerrar Sesión";
            this.BtnCerrarSesion.UseVisualStyleBackColor = true;
            this.BtnCerrarSesion.Click += new System.EventHandler(this.BtnCerrarSesion_Click_1);
            // 
            // btnEditarSolicitud
            // 
            this.btnEditarSolicitud.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarSolicitud.Location = new System.Drawing.Point(10, 11);
            this.btnEditarSolicitud.Name = "btnEditarSolicitud";
            this.btnEditarSolicitud.Size = new System.Drawing.Size(142, 33);
            this.btnEditarSolicitud.TabIndex = 10;
            this.btnEditarSolicitud.Text = "Editar Solicitud";
            this.btnEditarSolicitud.UseVisualStyleBackColor = true;
            this.btnEditarSolicitud.Click += new System.EventHandler(this.btnEditarSolicitud_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnEditarSolicitud);
            this.panel1.Controls.Add(this.BtnCerrarSesion);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 54);
            this.panel1.TabIndex = 16;
            // 
            // MyTable
            // 
            this.MyTable.AllowUserToAddRows = false;
            this.MyTable.AllowUserToDeleteRows = false;
            this.MyTable.AllowUserToOrderColumns = true;
            this.MyTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MyTable.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MyTable.Location = new System.Drawing.Point(0, 56);
            this.MyTable.Margin = new System.Windows.Forms.Padding(2);
            this.MyTable.MultiSelect = false;
            this.MyTable.Name = "MyTable";
            this.MyTable.ReadOnly = true;
            this.MyTable.RowHeadersWidth = 51;
            this.MyTable.RowTemplate.Height = 24;
            this.MyTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MyTable.Size = new System.Drawing.Size(600, 288);
            this.MyTable.TabIndex = 15;
            // 
            // GestionSolicitudes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MyTable);
            this.Controls.Add(this.TheStatusStrip);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "GestionSolicitudes";
            this.Text = "Gestión de Solicitudes";
            this.TheStatusStrip.ResumeLayout(false);
            this.TheStatusStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MyTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer TimeStamp_Timer;
        private System.Windows.Forms.StatusStrip TheStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel AgentNameLabel;
        private System.Windows.Forms.ToolStripStatusLabel TimeStampLabel;
        private System.Windows.Forms.Button BtnCerrarSesion;
        private System.Windows.Forms.Button btnEditarSolicitud;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView MyTable;
    }
}