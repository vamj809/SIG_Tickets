﻿
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
            this.tk_id_ticket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Situacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.TheStatusStrip.Location = new System.Drawing.Point(0, 424);
            this.TheStatusStrip.Name = "TheStatusStrip";
            this.TheStatusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 13, 0);
            this.TheStatusStrip.Size = new System.Drawing.Size(800, 26);
            this.TheStatusStrip.TabIndex = 10;
            this.TheStatusStrip.Text = "statusStrip1";
            // 
            // AgentNameLabel
            // 
            this.AgentNameLabel.Name = "AgentNameLabel";
            this.AgentNameLabel.Size = new System.Drawing.Size(145, 20);
            this.AgentNameLabel.Text = "¡Bienvenido Técnico!";
            // 
            // TimeStampLabel
            // 
            this.TimeStampLabel.Name = "TimeStampLabel";
            this.TimeStampLabel.Size = new System.Drawing.Size(18, 20);
            this.TimeStampLabel.Text = "...";
            // 
            // BtnCerrarSesion
            // 
            this.BtnCerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCerrarSesion.Location = new System.Drawing.Point(595, 14);
            this.BtnCerrarSesion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnCerrarSesion.Name = "BtnCerrarSesion";
            this.BtnCerrarSesion.Size = new System.Drawing.Size(189, 41);
            this.BtnCerrarSesion.TabIndex = 11;
            this.BtnCerrarSesion.Text = "Cerrar Sesión";
            this.BtnCerrarSesion.UseVisualStyleBackColor = true;
            this.BtnCerrarSesion.Click += new System.EventHandler(this.BtnCerrarSesion_Click_1);
            // 
            // btnEditarSolicitud
            // 
            this.btnEditarSolicitud.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarSolicitud.Location = new System.Drawing.Point(13, 14);
            this.btnEditarSolicitud.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEditarSolicitud.Name = "btnEditarSolicitud";
            this.btnEditarSolicitud.Size = new System.Drawing.Size(189, 41);
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
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 66);
            this.panel1.TabIndex = 16;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // MyTable
            // 
            this.MyTable.AllowUserToAddRows = false;
            this.MyTable.AllowUserToDeleteRows = false;
            this.MyTable.AllowUserToOrderColumns = true;
            this.MyTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MyTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tk_id_ticket,
            this.Situacion,
            this.Estado,
            this.Usuario});
            this.MyTable.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MyTable.Location = new System.Drawing.Point(0, 70);
            this.MyTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MyTable.MultiSelect = false;
            this.MyTable.Name = "MyTable";
            this.MyTable.ReadOnly = true;
            this.MyTable.RowHeadersWidth = 51;
            this.MyTable.RowTemplate.Height = 24;
            this.MyTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MyTable.Size = new System.Drawing.Size(800, 354);
            this.MyTable.TabIndex = 15;
            this.MyTable.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MyTable_CellDoubleClick);
            this.MyTable.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MyTable_CellDoubleClick);
            this.MyTable.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MyTable_KeyDown);
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
            // Situacion
            // 
            this.Situacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Situacion.HeaderText = "Situación";
            this.Situacion.MinimumWidth = 6;
            this.Situacion.Name = "Situacion";
            this.Situacion.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.MinimumWidth = 6;
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Width = 125;
            // 
            // Usuario
            // 
            this.Usuario.HeaderText = "Técnico Asignado";
            this.Usuario.MinimumWidth = 6;
            this.Usuario.Name = "Usuario";
            this.Usuario.ReadOnly = true;
            this.Usuario.Width = 125;
            // 
            // GestionSolicitudes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MyTable);
            this.Controls.Add(this.TheStatusStrip);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn tk_id_ticket;
        private System.Windows.Forms.DataGridViewTextBoxColumn Situacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
    }
}